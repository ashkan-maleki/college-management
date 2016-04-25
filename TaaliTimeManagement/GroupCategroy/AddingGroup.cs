using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.GroupCategroy
{
    public partial class AddingGroup : TaaliTimeManagement.MasterEntryForm
    {
        public AddingGroup()
        {
            InitializeComponent();
            boxYear.ValidatingType = typeof(int);
            string str = "شما نمی توانید هیچ کاراکتری را به این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را حذف کنید.";
            this.boxYear.MaskFulErrorText = str;
            this.boxYear.InputCharacterErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";
            this.boxYear.MaskCompletedErrorText = "شما باید این فیلد را تکمیل کنید";
            this.boxYear.TypeInvalidErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";

            boxSemester.ValidatingType = typeof(int);
            this.boxSemester.EmptinessErrorText = "لطفا اطلاعات مربوط به ترم ورود را وارد کنید";
            str = "شما نمی توانید هیچ کاراکتری را به آخر این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را از آخر حذف کنید.";
            this.boxSemester.EndOfFieldErrorText = str;
            str = "شما نمی توانید هیچ کاراکتری را به این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را حذف کنید.";
            this.boxSemester.MaskFulErrorText = str;
            this.boxSemester.InputCharacterErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";
            this.boxSemester.MaskCompletedErrorText = "شما باید این فیلد را تکمیل کنید";
            this.boxSemester.TypeInvalidErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";

            this.taali = new TaaliDataDataContext();
            this.boxMajor.Enabled = false;
        }

        protected TaaliDataDataContext taali;
        public Group TheGroup { get; set; }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            if (!this.validateTitle())
                return;
            if (this.taali == null && this.TheGroup == null)
            {
                MessageBox.Show("لطفا یک گروه انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                return;
            }
            this.setData();
            try
            {
                taali.Groups.InsertOnSubmit(this.TheGroup);
                taali.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("لطفا گروه با مشخصات تکراری وارد نکنید.", "خطا",
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
            if (this.boxYear.ValidAll)
                this.TheGroup.EnterYear = (int)this.boxYear.GetNumeric();
            if (this.boxSemester.ValidAll)
            this.TheGroup.EnterSemester = (byte)this.boxSemester.GetNumeric();
            if (!this.boxGroupTitle.IsEmptyOrDefault)
                this.TheGroup.Title = this.boxGroupTitle.Text;
            decimal noStudent = 0;
            if (this.boxNumberOFStudent.IsNumeric(out noStudent))
                this.TheGroup.NumberOfStudent = (byte?)noStudent;
        }

        protected bool boxValidation()
        {
            if (this.boxMajor.CheckEmptinessOrDefault() && this.boxGroupTitle.CheckEmptinessOrDefault()
                && !this.boxYear.ValidateAll() && !this.boxSemester.ValidateAll())
                return false;
            return this.ValidateSemester();
        }

        protected void setAutoComplete()
        {
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var title = from g in data.GroupList()
                        where g.Title != null && !g.Title.Equals("")
                        select g.Title;
            if (title != null && title.Count() > 0)
                boxGroupTitle.AutoCompleteCustomSource.AddRange(title.ToArray());
            var numberOfStudent = from g in data.GroupList()
                                  where g.NumberOfStudent != null
                                  select g.NumberOfStudent.ToString();
            if (numberOfStudent != null && numberOfStudent.Count() > 0)
                boxNumberOFStudent.AutoCompleteCustomSource.AddRange(numberOfStudent.ToArray());
        }

        protected void btnAddMajor_Click(object sender, EventArgs e)
        {
            MajorCategory.BaseMajorForm bmf = new MajorCategory.BaseMajorForm();
            bmf.MultiSelect = false;
            DialogResult dr = bmf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.TheGroup = new Group();
                this.TheGroup.Major = taali.Majors.Where(m => m.MajorID == bmf.SelectedMajors
                    .SelectedItems[0].MajorID).Single();
                this.boxMajor.Text = this.TheGroup.Major.ToString();
                this.makeTitle();
                this.btnDeleteMajor.Enabled = true;
                this.btnAddMajor.Enabled = false;
                this.boxMajor.CheckEmptinessOrDefault();
                this.boxGroupTitle.CheckEmptinessOrDefault();
            }
        }

        protected void boxDeleteMajor_Click(object sender, EventArgs e)
        {
            this.TheGroup.Major = null;
            this.boxMajor.Text = string.Empty;
            this.btnDeleteMajor.Enabled = false;
            this.btnAddMajor.Enabled = true;
        }

        private bool ValidateSemester()
        {
            ToolTip tt = new ToolTip();
            tt.Hide(this.boxSemester);
            this.boxSemester.BackColor = Color.FromKnownColor(KnownColor.Window);
            if (this.boxSemester.GetNumeric() > 3 || this.boxSemester.GetNumeric() < 1)
            {
                tt.Show("شما فقط می توانید از اعداد 1 و 2 و 3 استفاده کنید.", this.boxSemester, 5000);
                this.boxSemester.BackColor = Color.LightPink;
                return false;
            }
            return true;
        }

        private void boxSemester_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3'))
            {
                if (e.KeyChar != (int)Keys.Back)
                {
                    ToolTip ttp = new ToolTip();
                    ttp.InitialDelay = 50;
                    ttp.Show("شما فقط می توانید از اعداد 1 و 2 و 3 استفاده کنید.",
                        (WiseTextBox.WiseMaskedTextBox)sender, 2500);
                    e.Handled = true;
                }
            }
        }

        protected virtual bool validateTitle()
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 50;
            if (taali.Groups.Where(g => g.Title.Equals(this.boxGroupTitle.Text)).Count() != 0)
            {
                this.boxGroupTitle.BackColor = Color.LightPink;
                tt.Show("عنوان مورد نظر شما قبلا برای گروه دیگر ثبت شده.", this.boxGroupTitle, 3000);
                return false;
            }
            else
            {
                tt.RemoveAll();
                this.boxGroupTitle.BackColor = Color.FromKnownColor(KnownColor.Window);
                return true;
            }
        }

        protected virtual void boxGroupTitle_TextChanged(object sender, EventArgs e)
        {
            this.validateTitle();
        }

        private void box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (int)Keys.Back)
                {
                    ToolTip ttp = new ToolTip();
                    ttp.InitialDelay = 50;
                    ttp.Show("شما فقط می توانید از اعداد 0 تا 9 استفاده کنید.",
                        (WiseTextBox.WiseTextBox)sender, 2500);
                    e.Handled = true;
                }
            }
        }

        private void makeTitle()
        {
            if (!this.boxYear.IsEmptyOrWhiteSpace && !this.boxMajor.IsEmptyOrWhiteSpace)
               this.boxGroupTitle.Text = string.Format("{0} - {1}", this.boxMajor.Text, 
                   this.boxYear.Text);
        }

        private void boxYear_Leave(object sender, EventArgs e)
        {
            this.makeTitle();
        }

    }
}
