using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.TeacherCategory
{
    public partial class AddingTeacher : TaaliTimeManagement.MasterEntryForm
    {
        public AddingTeacher()
        {
            InitializeComponent();

            this.taali = new TaaliDataDataContext();
            this.TheTeacher = new Teacher();
        }


        protected TaaliDataDataContext taali;
        public Teacher TheTeacher { get; set; }
        protected List<UniversityHoldingTime> times { get; set; }
        protected List<Subject> subjects { get; set; }



        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            if (this.taali == null && this.TheTeacher == null)
            {
                throw new Exception();
            }
            this.TheTeacher = new Teacher();
            this.setData();
            try
            {
                taali.Teachers.InsertOnSubmit(this.TheTeacher);
                taali.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("لطفااسناد با مشخصات تکراری وارد نکنید.", "خطا",
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
            if (!this.boxFirstName.IsEmptyOrWhiteSpace)
                this.TheTeacher.FirstName = this.boxFirstName.Text;
            if (!this.boxLastName.IsEmptyOrWhiteSpace)
                this.TheTeacher.LastName = this.boxLastName.Text;
            if (this.times != null)
            {
                for (int i = 0; i < this.TheTeacher.TimeTeachers.Count; i++)
                    this.TheTeacher.TimeTeachers[i].Active = false;
                foreach (UniversityHoldingTime uht in this.times)
                {
                    if (this.TheTeacher.TimeTeachers.Where(t => t.UniversityHoldingTime.HoldingTimeID ==
                        uht.HoldingTimeID).Count() == 0)
                    {
                        TimeTeacher tt = new TimeTeacher();
                        tt.Teacher = this.TheTeacher;
                        tt.UniversityHoldingTime = taali.UniversityHoldingTimes.Where(t =>
                            t.HoldingTimeID == uht.HoldingTimeID).Single();
                        tt.Active = true;
                        this.TheTeacher.TimeTeachers.Add(tt);
                    }
                    else
                    {
                        this.TheTeacher.TimeTeachers.Where(t => t.UniversityHoldingTime.HoldingTimeID ==
                                                                        uht.HoldingTimeID).First().Active = true;
                    }
                }
            }
            if (this.times != null)
            {
                for (int i = 0; i < this.TheTeacher.SubjectTeachers.Count; i++)
                    this.TheTeacher.SubjectTeachers[i].Active = false;
                foreach (Subject s in this.subjects)
                {
                    if (this.TheTeacher.SubjectTeachers.Where(ss => ss.Subject.SubjectID ==
                        s.SubjectID).Count() == 0)
                    {
                        SubjectTeacher st = new SubjectTeacher();
                        st.Teacher = this.TheTeacher;
                        st.Subject = taali.Subjects.Where(ss => ss.SubjectID == s.SubjectID).Single();
                        st.Active = true;
                        this.TheTeacher.SubjectTeachers.Add(st);
                    }
                    else
                    {
                        this.TheTeacher.SubjectTeachers.Where(ss => ss.Subject.SubjectID ==
                        s.SubjectID).First().Active = true;
                    }
                }
            }
        }

        protected bool boxValidation()
        {
            return !this.boxFirstName.CheckEmptinessOrDefault() && !this.boxLastName.CheckEmptinessOrDefault()
                && this.checkSubject() && this.checkTime();
        }

        protected void setAutoComplete()
        {
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var first = from s in data.TeacherList()
                        where s.FirstName != null
                        select s.FirstName;
            if (first != null && first.Count() > 0)
                boxFirstName.AutoCompleteCustomSource.AddRange(first.ToArray());
            var last = from s in data.TeacherList()
                       where s.LastName != null
                       select s.LastName;
            if (last != null && last.Count() > 0)
                boxLastName.AutoCompleteCustomSource.AddRange(last.ToArray());
        }

        protected void btnAddTimes_Click(object sender, EventArgs e)
        {
            TimeCategory.AutoTimeForm art = new TimeCategory.AutoTimeForm();
            if (this.times == null)
                this.times = new List<UniversityHoldingTime>();
            art.TeachersTimes = this.times.Where(t => t.Enabled).ToList();
            DialogResult dr = art.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (art.TeachersTimes == null || art.TeachersTimes.Count == 0)
                    return;
                //if (this.times == null || this.times.Count() == 0)
                //    this.times = art.TeachersTimes;
                //else
                //{
                //    this.times.AddRange(from t in art.TeachersTimes
                //                        where this.times.Where(pr =>
                //                                    pr.HoldingTimeID == t.HoldingTimeID).Count() == 0
                //                        select t);
                //}
                this.times = art.TeachersTimes.OrderBy(t => t.ToString()).ToList();
                //this.times = this.times.OrderBy(t => t.ToString()).ToList();
                this.boxTimesCombo.Items.Clear();
                this.boxTimesCombo.Items.AddRange(times.Select(t => t.ToString()).ToArray());
                this.boxTimesCombo.SelectedIndex = 0;
            }
        }

        protected void comboStyling(ComboBox cb, bool valid, string toolTipText)
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 50;
            if (valid)
            {
                cb.BackColor = Color.FromKnownColor(KnownColor.Window);
                tt.Hide(cb);
            }
            else
            {
                cb.BackColor = Color.LightPink;
                tt.Show(toolTipText, cb, 5000);
            }
        }

        protected bool checkTime()
        {
            string text = "لطفا زمان حضور استاد را مشخص کنید.";
            if (this.times == null)
            {
                this.comboStyling(this.boxTimesCombo, !(this.times == null), text);
                return !(this.times == null);
            }
            if (this.boxTimesCombo.Items.Count == this.times.Count)
            {
                this.comboStyling(this.boxTimesCombo, !(this.boxTimesCombo.Items.Count <= 0), text);
                return !(this.boxTimesCombo.Items.Count <= 0);
            }
            else
            {
                this.comboStyling(this.boxTimesCombo, this.boxTimesCombo.Items.Count <= 0, text);
                return false;
            }
        }

        protected void btnAddSubjects_Click(object sender, EventArgs e)
        {
            SubjectCategory.BaseSubjectForm bsf = new SubjectCategory.BaseSubjectForm();
            bsf.MultiSelect = true;
            DialogResult dr = bsf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                if (bsf.SelectedItems.SelectedItems == null || bsf.SelectedItems.SelectedItems.Count == 0)
                    return;
                if (this.subjects == null || this.subjects.Count() == 0)
                    this.subjects = bsf.SelectedItems.SelectedItems;
                else
                {
                    this.subjects.AddRange(from s in bsf.SelectedItems.SelectedItems
                                           where this.subjects.Where(sub =>
                                                    sub.SubjectID == s.SubjectID).Count() == 0
                                                select s);
                }
                this.subjects = this.subjects.OrderBy(s => s.Title).ToList();
                this.boxSubjectsCombo.Items.Clear();
                this.boxSubjectsCombo.Items.AddRange(this.subjects.Select(s => s.ToString()).ToArray());
                this.boxSubjectsCombo.SelectedIndex = 0;
                if (boxSubjectsCombo.Items.Count > 1)
                    this.btnDeleteSubjects.Enabled = true;
            }
        }

        protected void btnDeleteSubjects_Click(object sender, EventArgs e)
        {
            this.subjects.RemoveAt(this.boxSubjectsCombo.SelectedIndex);
            this.boxSubjectsCombo.Items.RemoveAt(this.boxSubjectsCombo.SelectedIndex);
            this.boxSubjectsCombo.Text = string.Empty;
            if (boxSubjectsCombo.Items.Count == 1)
                this.btnDeleteSubjects.Enabled = false;
            this.boxSubjectsCombo.SelectedIndex = 0;
        }

        protected bool checkSubject()
        {
            string text = "لطفا دروسی که استاد می تواند تدریس کند را مشخص کنید.";
            if (this.subjects == null)
            {
                this.comboStyling(this.boxSubjectsCombo, !(this.subjects == null), text);
                return !(this.subjects == null);
            }
            if (this.boxSubjectsCombo.Items.Count == this.subjects.Count)
            {
                this.comboStyling(this.boxSubjectsCombo, !(this.boxSubjectsCombo.Items.Count <= 0), text);
                return !(this.boxSubjectsCombo.Items.Count <= 0);
            }
            else
            {
                this.comboStyling(this.boxSubjectsCombo, this.boxSubjectsCombo.Items.Count <= 0, text);
                return false;
            }
        }
    }
}
