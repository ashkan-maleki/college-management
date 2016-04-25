using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.SubjectCategory
{
    public partial class AddingSubject : TaaliTimeManagement.MasterEntryForm
    {
        public AddingSubject()
        {
            InitializeComponent();

            boxIDMask.ValidatingType = typeof(int);
            string str = "شما نمی توانید هیچ کاراکتری را به این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را حذف کنید.";
            this.boxIDMask.MaskFulErrorText = str;
            this.boxUnitsNumberMask.EmptinessErrorText = "لطفا اطلاعات مربوط به کد درس را وارد کنید";
            str = "شما نمی توانید هیچ کاراکتری را به آخر این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را از آخر حذف کنید.";
            this.boxUnitsNumberMask.EndOfFieldErrorText = str;
            this.boxIDMask.InputCharacterErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";
            this.boxIDMask.MaskCompletedErrorText = "شما باید این فیلد را تکمیل کنید";
            this.boxIDMask.TypeInvalidErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";

            boxUnitsNumberMask.ValidatingType = typeof(int);
            this.boxUnitsNumberMask.EmptinessErrorText = "لطفا اطلاعات مربوط به تعداد واحد را وارد کنید";
            str = "شما نمی توانید هیچ کاراکتری را به آخر این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را از آخر حذف کنید.";
            this.boxUnitsNumberMask.EndOfFieldErrorText = str;
            str = "شما نمی توانید هیچ کاراکتری را به این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را حذف کنید.";
            this.boxUnitsNumberMask.MaskFulErrorText = str;
            this.boxUnitsNumberMask.InputCharacterErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";
            this.boxUnitsNumberMask.MaskCompletedErrorText = "شما باید این فیلد را تکمیل کنید";
            this.boxUnitsNumberMask.TypeInvalidErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";

            this.taali = new TaaliDataDataContext();

            this.boxType.Enabled = false;
            
        }
        protected TaaliDataDataContext taali;
        public Subject TheSubject { get; set; }
        protected List<Subject> prerequisites { get; set; }
        protected List<Major> majors { get; set; }
        protected SubjectType subjectType { get; set; }

       

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            if (!this.ValidateIDs())
                return;
            this.TheSubject = new Subject();
            if (this.taali == null && this.TheSubject == null)
            {
                MessageBox.Show("لطفا یک درس انتخاب کنید.", "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
                return;
            }
            this.setData();
            try
            {
                taali.Subjects.InsertOnSubmit(this.TheSubject);
                taali.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("لطفا درس با مشخصات تکراری وارد نکنید.", "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.TargetSite + "\n" + ex.Message);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        protected void setData()
        {
            if (this.boxIDMask.ValidAll)
                this.TheSubject.SubjectID = (int)this.boxIDMask.GetNumeric();
            if (this.boxUnitsNumberMask.ValidAll)
                this.TheSubject.Units = (byte)this.boxUnitsNumberMask.GetNumeric();
            if (!this.boxTitle.IsEmptyOrDefault)
                this.TheSubject.Title = this.boxTitle.Text;
            if (this.majors != null)
            {
                foreach (var m in this.majors)
                {
                    if (this.TheSubject.MajorSubjects.Where(ms => ms.MajorID == m.MajorID).Count() == 0)
                    {
                        MajorSubject ms = new MajorSubject();
                        ms.Subject = this.TheSubject;
                        ms.Major = this.taali.Majors.Where(maj => maj.MajorID == m.MajorID).Single();
                        this.TheSubject.MajorSubjects.Add(ms);
                    }
                }
            }
            if (this.prerequisites != null)
            {
                foreach (var p in this.prerequisites)
                {
                    if (this.TheSubject.Prerequisites.Where(pre => pre.PrerequisiteSubjectID == p.SubjectID)
                        .Count() == 0)
                    {
                        Prerequisite pr = new Prerequisite();
                        pr.Subject = this.TheSubject;
                        pr.Subject1 = this.taali.Subjects.Where(s => s.SubjectID == p.SubjectID).Single();
                        this.TheSubject.Prerequisites.Add(pr);
                    }
                }
            }
            if (this.subjectType != null)
                this.TheSubject.SubjectType = taali.SubjectTypes.Where(st => st.SubjectTypeID
                == this.subjectType.SubjectTypeID).Single();
        }

        protected bool boxValidation()
        {
            return !this.boxTitle.CheckEmptinessOrDefault() && !this.boxType.CheckEmptinessOrDefault()
                && this.boxIDMask.ValidateAll() && this.boxUnitsNumberMask.ValidateAll()
                && this.checkMajor();
        }

        protected void setAutoComplete()
        {
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var title = from s in data.SubjectList()
                        where s.Title != null
                        select s.Title.ToString();
            if (title != null && title.Count() > 0)
                boxTitle.AutoCompleteCustomSource.AddRange(title.ToArray());
        }

        protected void btnAddMajor_Click(object sender, EventArgs e)
        {
            MajorCategory.BaseMajorForm bmf = new MajorCategory.BaseMajorForm();
            bmf.MultiSelect = true;
            DialogResult dr = bmf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (bmf.SelectedMajors.SelectedItems == null || bmf.SelectedMajors.SelectedItems.Count == 0)
                    return;
                if (this.majors == null || this.majors.Count() == 0)
                    this.majors = bmf.SelectedMajors.SelectedItems;
                else
                {
                    this.majors.AddRange(from p in bmf.SelectedMajors.SelectedItems
                                         where this.majors.Where(pr =>
                                                    pr.MajorID == p.MajorID).Count() == 0
                                         select p);
                }
                this.majors = this.majors.OrderBy(m => m.ToString()).ToList();
                this.boxMajorCombo.Items.Clear();
                this.boxMajorCombo.Items.AddRange(majors.Select(m => m.ToString()).ToArray());
                this.boxMajorCombo.SelectedIndex = 0;
                if (boxMajorCombo.Items.Count > 1)
                    this.btnDeleteMajor.Enabled = true;
                this.checkMajor();
            }
        }

        protected void btnDeleteMajor_Click(object sender, EventArgs e)
        {
            this.majors.RemoveAt(this.boxMajorCombo.SelectedIndex);
            this.boxMajorCombo.Items.RemoveAt(this.boxMajorCombo.SelectedIndex);
            if (boxMajorCombo.Items.Count == 1)
                this.btnDeleteMajor.Enabled = false;
            if (boxMajorCombo.Items.Count > 0)
                this.boxMajorCombo.SelectedIndex = 0;
        }

        protected bool checkMajor()
        {
            string text = "لطفا حداقل یک رشته انتخاب کنید.";
            if (this.majors == null)
            {
                this.comboStyling(!(this.majors == null), text, this.boxMajorCombo);
                return !(this.majors == null);
            }
            if (this.boxMajorCombo.Items.Count == this.majors.Count)
            {
                this.comboStyling(!(this.boxMajorCombo.Items.Count <= 0), text, this.boxMajorCombo);
                return !(this.boxMajorCombo.Items.Count <= 0);
            }
            else
            {
                this.comboStyling(this.boxMajorCombo.Items.Count <= 0, text, this.boxMajorCombo);
                return false;
            }
        }


        protected void comboStyling(bool valid, string toolTipText, IWin32Window window)
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 50;
            if (valid)
            {
                this.boxMajorCombo.BackColor = Color.FromKnownColor(KnownColor.Window);
                tt.Hide(window);
            }
            else
            {
                this.boxMajorCombo.BackColor = Color.LightPink;
                tt.Show(toolTipText, this.boxMajorCombo, 5000);
            }
        }

        protected void btnAddPrerequisites_Click(object sender, EventArgs e)
        {
            SubjectCategory.BaseSubjectForm bsf = new SubjectCategory.BaseSubjectForm();
            bsf.MultiSelect = true;
            DialogResult dr = bsf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (bsf.SelectedItems.SelectedItems == null || bsf.SelectedItems.SelectedItems.Count == 0)
                    return;
                if (this.prerequisites == null || this.prerequisites.Count() == 0)
                    this.prerequisites = bsf.SelectedItems.SelectedItems;
                else
                {
                    this.prerequisites.AddRange(from p in bsf.SelectedItems.SelectedItems
                                                where this.prerequisites.Where(pr =>
                                                    pr.SubjectID == p.SubjectID).Count() == 0
                                                select p);
                }
                this.prerequisites = this.prerequisites.OrderBy(p => p.Title).ToList();
                this.boxPrerequisitesCombo.Items.Clear();
                this.boxPrerequisitesCombo.Items.AddRange(this.prerequisites.Select(p => p.ToString()).ToArray());
                this.boxPrerequisitesCombo.SelectedIndex = 0;
                this.btnDeletePrerequisites.Enabled = true;
            }
        }

        protected void btnDeletePrerequisites_Click(object sender, EventArgs e)
        {
            this.prerequisites.RemoveAt(this.boxPrerequisitesCombo.SelectedIndex);
            this.boxPrerequisitesCombo.Items.RemoveAt(this.boxPrerequisitesCombo.SelectedIndex);
            boxPrerequisitesCombo.Text = string.Empty;
            if (boxPrerequisitesCombo.Items.Count == 0)
                this.btnDeletePrerequisites.Enabled = false;
            else
                this.boxPrerequisitesCombo.SelectedIndex = 0;
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            TypeCategory.BaseTypeForm btf = new TypeCategory.BaseTypeForm();
            btf.MultiSelect = false;
            DialogResult dr = btf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.subjectType = taali.SubjectTypes.Where(st => st.SubjectTypeID == btf.SelectedTypes
                    .SelectedItems[0].SubjectTypeID).Single();
                this.boxType.Text = this.subjectType.ToString();
                this.btnAddType.Enabled = false;
                this.btnDeleteType.Enabled = true;
                this.boxType.CheckEmptinessOrDefault();
            }
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            this.subjectType = null;
            this.boxType.Text = string.Empty;
            this.btnDeleteType.Enabled = false;
            this.btnAddType.Enabled = true;
        }

        protected virtual void boxIDMask_Validated(object sender, EventArgs e)
        {
            this.ValidateIDs();
        }

        protected bool ValidateIDs()
        {
            if (this.boxIDMask.Text.Length != 5)
                return false;
            bool isThere = (from s in this.taali.Subjects
                            where s.SubjectID == this.boxIDMask.GetNumeric()
                            select s.SubjectID).Count() > 0;
            this.boxIDMask.SetValidationStyle(!isThere, "", "شما نمی توانید از این کد درس استفاده کنید. " +
            "درسی با این کد درس قبلا ثبت شده است.", 5000);
            return !isThere;
        }

        protected virtual void boxMajorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
