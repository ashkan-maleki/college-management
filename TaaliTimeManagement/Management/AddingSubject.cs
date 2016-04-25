using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.Management
{
    public partial class AddingSubject : TaaliTimeManagement.MasterEntryForm
    {
        public AddingSubject()
        {
            InitializeComponent();
            this.taali = new TaaliDataDataContext();

        }

        protected TaaliDataDataContext taali;
        public List<UniversityHoldingTime> Times { get; set; }
        public Group TheGroup { get; set; }
        public Subject TheSubject { get; set; }
        public Teacher TheTeacher { get; set; }
        public Class TheClass { get; set; }
        public byte Year { get; set; }
        public byte Semester { get; set; }
        public List<TimeTable> TimeTableCells { get; set; }

        private void saveToTimeTable( )
        {
           
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            bool done = false;
            GroupSubject gropsub = new GroupSubject();
            try
            {
                if (this.taali.GroupSubjects.Where(gs => gs.GroupID ==
                    TheGroup.GroupID && gs.SubjectID == TheSubject.SubjectID && gs.TermYear == this.Year
                    && gs.Semester == this.Semester).Count() == 1)
                {
                    gropsub = this.taali.GroupSubjects.Where(gs => gs.GroupID ==
                         TheGroup.GroupID && gs.SubjectID == TheSubject.SubjectID && gs.TermYear == this.Year
                         && gs.Semester == this.Semester).Single();
                }
                else
                {
                    gropsub = new GroupSubject();
                    gropsub.Semester = this.Semester;
                    gropsub.TermYear = this.Year;
                    gropsub.Group = this.taali.Groups.Where(g => g.GroupID == this.TheGroup.GroupID)
                        .Single();
                    gropsub.Subject = this.taali.Subjects.Where(s => s.SubjectID ==
                        this.TheSubject.SubjectID).Single();
                    this.taali.GroupSubjects.InsertOnSubmit(gropsub);
                    this.taali.SubmitChanges();
                    done = true;
                    gropsub = this.taali.GroupSubjects.Where(gs => gs.GroupID ==
                         TheGroup.GroupID && gs.SubjectID == TheSubject.SubjectID && gs.TermYear == this.Year
                         && gs.Semester == this.Semester).Single();
                }
                if (this.TimeTableCells.Where(tt => tt.GroupSubjectID == gropsub.GroupSubjectID)
                    .Count() != 0)
                    throw new Exception("این درس در این ترم برای این گروه ارایه شده است.");
                foreach (var time in Times)
                {
                    if (this.TimeTableCells.Where(tt => tt.TimeTeacher.TimeID == time.HoldingTimeID &&
                        tt.GroupSubject.TermYear == this.Year && tt.GroupSubject.Semester == this.Semester
                        && tt.GroupSubject.GroupID == TheGroup.GroupID).Count() != 0)
                    {
                        throw new Exception(string.Format(@"{0}'{1}'{2}",
                            "برای گروه مورد نظر شما در این ساعت ", time.ToString(),
                            "یک در ارایه شده است."));
                    }
                    if (this.TimeTableCells.Where(tt => tt.TimeTeacher.TeacherID == TheTeacher.TeacherID &&
                        tt.TimeTeacher.TimeID == time.HoldingTimeID && tt.GroupSubject.TermYear ==
                        this.Year && tt.GroupSubject.Semester == this.Semester).Count() != 0)
                    {
                        throw new Exception(string.Format(@"{0}'{1}'{2}",
                               "استاد مورد نظر شما در این ساعت ", time.ToString(),
                               "تدریس می کند."));
                    }
                    if (this.TimeTableCells.Where(tt => tt.ClassID == TheClass.ClassID &&
                        tt.TimeTeacher.TimeID == time.HoldingTimeID && tt.GroupSubject.TermYear ==
                        this.Year && tt.GroupSubject.Semester == this.Semester).Count() != 0)
                    {
                        throw new Exception(string.Format(@"{0}'{1}'{2}",
                               "کلاس مورد نظر شما در این ساعت ", time.ToString(),
                               "پر می باشد."));
                    }
                }
                foreach (var time in Times)
                {
                    TaaliDataDataContext taali = new TaaliDataDataContext();
                    var timteas = taali.TimeTeachers.Where(tt => tt.TeacherID == TheTeacher.TeacherID
                        && tt.TimeID == time.HoldingTimeID);
                    if (timteas.Count() != 1)
                    {
                        string error = "استاد مورد نظر شما دراین ساعت نمی تواند تدریس کند.";
                        throw new Exception(error);
                    }
                    TimeTeacher timeteach = timteas.Single();
                    TimeTable table = new TimeTable();
                    if (TheClass.ClassID != 0 && gropsub.GroupSubjectID != 0
                        && timeteach.TimeTeacherID != 0)
                    {
                        table.Class = this.taali.Classes.Where(c => c.ClassID ==
                            this.TheClass.ClassID).Single();
                        table.GroupSubject = this.taali.GroupSubjects.Where(gs => gs.GroupSubjectID
                            == gropsub.GroupSubjectID).Single();
                        table.TimeTeacher = this.taali.TimeTeachers.Where(tt => tt.TimeTeacherID 
                            == timeteach.TimeTeacherID).Single();
                        this.TimeTableCells.Add(table);
                    }
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                if (done)
                {
                    this.taali.GroupSubjects.DeleteAllOnSubmit(this.taali.GroupSubjects
                        .Where(gs => gs.GroupSubjectID == gropsub.GroupSubjectID));
                    this.taali.SubmitChanges();
                }
                MessageBox.Show(ex.Message, "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
        

        protected bool boxValidation()
        {
                return this.checkGroup() && this.checkSubject() && this.checkTeacher()
                && this.checkClass();
        }
        protected void comboStyling(bool valid, string toolTipText, TextBox box, Button btn)
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 50;
            if (valid)
            {
                box.BackColor = Color.FromKnownColor(KnownColor.Window);
                tt.Hide(btn);
            }
            else
            {
                box.BackColor = Color.LightPink;
                tt.Show(toolTipText, btn, 5000);
            }
        }

        protected bool checkGroup()
        {
            string text = "لطفا یک گروه انتخاب کنید.";
            this.comboStyling(!(this.TheGroup == null), text, this.boxGroup, this.btnAddGroup);
            return !(this.TheGroup == null);
        }

        protected bool checkSubject()
        {
            string text = "لطفا یک درس انتخاب کنید.";
            this.comboStyling(!(this.TheSubject == null), text, this.boxSubject, this.btnAddSubject);
            return !(this.TheSubject == null);
        }

        protected bool checkTeacher()
        {
            string text = "لطفا یک استاد انتخاب کنید.";
            this.comboStyling(!(this.TheTeacher == null), text, this.boxTeacher, this.btnAddTeacher);
            return !(this.TheTeacher == null);
        }

        protected bool checkClass()
        {
            string text = "لطفا یک کلاس انتخاب کنید.";
            this.comboStyling(!(this.TheClass == null), text, this.boxClass, this.btnAddClass);
            return !(this.TheClass == null);
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            GroupCategroy.BaseGroupForm bgf = new GroupCategroy.BaseGroupForm();
            bgf.SetDontShowControls();
            bgf.MultiSelect = false;
            DialogResult dr = bgf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.TheGroup = taali.Groups.Where(g => g.GroupID == bgf.SelectedItems
                    .SelectedItems[0].GroupID).Single();
                this.boxGroup.Text = this.TheGroup.Title;
                this.btnAddGroup.Enabled = false;
                this.btnDeleteGroup.Enabled = true;
                this.btnAddSubject.Enabled = true;
            }
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            this.TheGroup = null;
            this.boxGroup.Text = string.Empty;
            this.btnDeleteGroup.Enabled = false;
            this.btnAddGroup.Enabled = true;
            this.btnDeleteSubject_Click(null, null);
            this.btnAddSubject.Enabled = false;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            SubjectCategory.BaseSubjectForm bsf = new SubjectCategory.BaseSubjectForm();
            bsf.MultiSelect = false;
            bsf.SetDontShowControls();
            bsf.Subjects = taali.Subjects.ToList().Where(s => s.MajorSubjects.Where(ms => ms.MajorID
                == this.TheGroup.MajorID).Count() > 0 && s.HoursPerWeak == this.Times.Count && 
                (from gs in this.TheGroup.GroupSubjects
                     join tt in this.TimeTableCells
                         on gs.GroupSubjectID equals tt.GroupSubjectID
                     where gs.SubjectID == s.SubjectID
                     select gs.Subject).Count() == 0).ToList();
            DialogResult dr = bsf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.TheSubject = taali.Subjects.Where(s => s.SubjectID == bsf.SelectedItems
                        .SelectedItems[0].SubjectID &&
                        (from gs in this.TheGroup.GroupSubjects
                         join tt in this.TimeTableCells
                             on gs.GroupSubjectID equals tt.GroupSubjectID
                         where gs.GroupID == this.TheGroup.GroupID &&
                         gs.SubjectID == bsf.SelectedItems.SelectedItems[0].SubjectID
                         select gs.Subject).Count() == 0).Single();
                    this.boxSubject.Text = this.TheSubject.Title;
                    if (this.TheSubject.HoursPerWeak != this.Times.Count)
                        throw new Exception(string.Format("{0}{1}{2}{3}",
                            "مدت زمانی که شما در نظر گرفتید برای ارایه این درس مناسب نمی باشد. ",
                            "برای ارایه این درس نیاز به ", this.TheSubject.HoursPerWeak,
                            " ساعت می باشد."));
                    this.btnAddSubject.Enabled = false;
                    this.btnDeleteSubject.Enabled = true;
                    this.btnAddTeacher.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.TargetSite + "\n" + ex.Message);
                }
            }
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            this.TheSubject = null;
            this.boxSubject.Text = string.Empty;
            this.btnAddSubject.Enabled = true;
            this.btnDeleteSubject.Enabled = false;
            this.btnDeleteTeacher_Click(null, null);
            this.btnAddTeacher.Enabled = false;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherCategory.BaseTeacherForm btf = new TeacherCategory.BaseTeacherForm();
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            btf.Teachers = data.TeacherList().Where(t => t.SubjectTeachers.Where(st =>
                st.SubjectID == this.TheSubject.SubjectID && st.Active).Count() > 0 &&
                (from tt in t.TimeTeachers
                 join uht in this.Times
                     on tt.TimeID equals uht.HoldingTimeID
                 where uht.Enabled && tt.Active
                 select tt.Teacher).Count() > 0 &&
                (from ti in this.Times
                 join tt in this.TimeTableCells
                     on ti.HoldingTimeID equals tt.TimeTeacher.TimeID
                 where tt.TimeTeacher.TeacherID == t.TeacherID
                 select ti).Count() == 0).ToList();
            btf.SetDontShowControls();
            btf.MultiSelect = false;
            DialogResult dr = btf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    this.TheTeacher = taali.Teachers.ToList().Where(t => t.TeacherID == btf.SelectedItems
                                .SelectedItems[0].TeacherID && t.SubjectTeachers.Where(st => st.Active
                                && st.SubjectID == this.TheSubject.SubjectID).Count() > 0
                                && (from tt in t.TimeTeachers
                                    join ti in this.Times
                                        on tt.TimeID equals ti.HoldingTimeID
                                    where ti.Enabled
                                    select tt.Teacher).Count() > 0).Single();
                    this.boxTeacher.Text = this.TheTeacher.ToString();
                    this.btnAddTeacher.Enabled = false;
                    this.btnDeleteTeacher.Enabled = true;
                    this.btnAddClass.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطا",
                          MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                          MessageBoxOptions.RtlReading);
                }
            }
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            this.TheTeacher = null;
            this.boxTeacher.Text = string.Empty;
            this.btnAddTeacher.Enabled = true;
            this.btnDeleteTeacher.Enabled = false;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ClassCategory.BaseClassForm bcf = new ClassCategory.BaseClassForm();
            bcf.MultiSelect = false;
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            bcf.Classes = data.ClassList()
                .Where(c => (from ti in this.Times
                             join tt in this.TimeTableCells
                                 on ti.HoldingTimeID equals tt.TimeTeacher.TimeID
                             where tt.ClassID == c.ClassID
                             select ti).Count() == 0).ToList();
            bcf.SetDontShowControls();
            DialogResult dr = bcf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.TheClass = taali.Classes.Where(c => c.ClassID == bcf.SelectedClasses
                    .SelectedItems[0].ClassID).Single();
                this.boxClass.Text = this.TheClass.ClassID.ToString();
                this.btnAddClass.Enabled = false;
                this.btnDeleteClass.Enabled = true;
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            this.TheClass = null;
            this.boxClass.Text = string.Empty;
            this.btnDeleteClass.Enabled = false;
            this.btnAddClass.Enabled = true;
        }

        public void GetGroup(Group group)
        {
            this.TheGroup = group;
            this.boxGroup.Text = this.TheGroup.Title;
            this.btnAddGroup.Enabled = false;
            this.btnDeleteGroup.Enabled = true;
            this.btnAddSubject.Enabled = true;
        }

    }
}
