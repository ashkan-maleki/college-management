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
    public partial class TimeTableForm : Form
    {
        public TimeTableForm()
        {
            InitializeComponent();
            this.taali = new TaaliDataDataContext();
            this.table = new List<TimeCategory.TimeTableClass<TimeTable>>();
            var times = this.taali.UniversityHoldingTimes.Where(uht => uht.Possible)
                .OrderBy(uht => uht.StartTime).Select(uht => new
                {
                    Start = uht.StartTime,
                    End = uht.EndTime
                }).Distinct();
            foreach (var time in times)
            {
                TimeCategory.TimeTableClass<TimeTable> row =
                    new TimeCategory.TimeTableClass<TimeTable>(time.Start, time.End);
                this.table.Add(row);
            }
            this.timeTableGridView.DataSource = this.table;
            this.findDisableCells();
            this.styleDisableCells();
            if (this.taali.GroupSubjects != null && this.taali.GroupSubjects.Count() != 0)
            {
                this.boxYearCombo.Items.AddRange(this.taali.GroupSubjects
                    .OrderByDescending(gs => gs.TermYear).Select(tt => tt.TermYear.ToString())
                    .Distinct().ToArray());
                this.boxYearCombo.SelectedIndex = this.boxYearCombo.Items.Count - 1;
                if (this.boxYearCombo.SelectedItem != null)
                    this.year = Convert.ToByte(this.boxYearCombo.SelectedItem);
                this.semester = this.taali.GroupSubjects
                    .Where(gs => gs.TermYear == this.taali.GroupSubjects.Max(g => g.TermYear))
                    .Distinct().Max(gs => gs.Semester);
                this.boxSemesterCombo.SelectedIndex = this.semester - 1;
                this.isFilled = true;
            }
            this.readData();
            this.FillGroupComboBox();
            this.ShowData();
        }

        private bool isFilled = false;
        private bool grupFilled = false;
        public List<TimeTable> UniTimeTable { get; set; }
        private TaaliDataDataContext taali;
        private byte year;
        private byte semester;
        private List<TimeCategory.TimeTableClass<TimeTable>> table;
        private List<List<int>> inactiveCells;

        public void FillGroupComboBox()
        {
            if (this.UniTimeTable == null || this.UniTimeTable.Count == 0)
            {
                return;
            }
            this.boxGroupCombo.Items.Clear();
            string[] items = (from gs in this.taali.GroupSubjects.ToList()
                              join tt in this.UniTimeTable
                                  on gs.GroupSubjectID equals tt.GroupSubjectID
                              where gs.Semester == this.semester &&
                              gs.TermYear == this.year
                              orderby gs.Group.Title
                              select gs.Group.Title).Distinct().ToArray();
            int count = this.boxGroupCombo.Items.Count;
            int index = this.boxGroupCombo.SelectedIndex;
            this.boxGroupCombo.Items.AddRange(items);
            for (int i = 0; i < count; i++)
                this.boxGroupCombo.Items.RemoveAt(0);
            if (this.boxGroupCombo.Items.Count > 0 && this.boxGroupCombo.SelectedIndex == -1)
            {
                if (index > 0 && this.boxGroupCombo.Items.Count > index)
                    this.boxGroupCombo.SelectedIndex = index;
                else
                    this.boxGroupCombo.SelectedIndex = 0;
            }
            this.grupFilled = true;
        }

        private void readData()
        {
            if (this.year == 0 || this.semester == 0)
            {
                return;
            }
            this.UniTimeTable = this.taali.TimeTables.Where(tt => tt.GroupSubject.TermYear
                == this.year && tt.GroupSubject.Semester == this.semester).ToList();
        }

        public void ShowData()
        {
            foreach (var row in table)
                row.RemoveAll();
            this.timeTableGridView.Refresh();
            if (this.UniTimeTable == null || this.UniTimeTable.Count == 0)
            {
                return;
            }
            var tables = (from tt in this.UniTimeTable.Distinct()
                          group tt by tt.GroupSubject.GroupID);
            System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                "GroupCount", tables.Count()));
            if (this.boxGroupCombo.Items.Count == 0)
                return;
            var theGroup = tables.Where(t => this.taali.Groups.ToList().Where(g => g.GroupID == t.Key)
                .Single().Title.Equals(this.boxGroupCombo.SelectedItem.ToString()))
                .Select(t => t).Single();
            System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                "GroupTitle", this.boxGroupCombo.SelectedItem.ToString()));
            System.Diagnostics.Debug.WriteLine("TableFilling..\n");
            foreach (var cell in theGroup)
            {
                if (this.table.Where(t => t.StartTime == cell.TimeTeacher.UniversityHoldingTime.StartTime
                    && t.EndTime == cell.TimeTeacher.UniversityHoldingTime.EndTime).Distinct()
                    .Count() == 1)
                {
                    this.table.Where(t => t.StartTime == cell.TimeTeacher.UniversityHoldingTime.StartTime
                        && t.EndTime == cell.TimeTeacher.UniversityHoldingTime.EndTime).Single()
                        .Fill(cell, cell.TimeTeacher.UniversityHoldingTime.HoldingDay);
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1} - {2}\n{3}\n",
                        cell.TimeTeacher.UniversityHoldingTime.HoldingDay,
                        cell.TimeTeacher.UniversityHoldingTime.StartTime,
                        cell.TimeTeacher.UniversityHoldingTime.EndTime, cell));
                }
            }
            this.timeTableGridView.Refresh();
            this.styleDisableCells();
        }

        private void findDisableCells()
        {
            this.inactiveCells = new List<List<int>>();
            List<UniversityHoldingTime> times = taali.UniversityHoldingTimes
                .Where(uht => uht.Possible && !uht.Enabled).ToList();
            if (times == null || times.Count <= 0)
                return;
            if (this.timeTableGridView.RowCount <= 0)
                return;
            var periods = this.taali.UniversityHoldingTimes.Where(uht => uht.Possible)
                .OrderBy(uht => uht.StartTime).Select(uht => new
                {
                    Start = uht.StartTime,
                    End = uht.EndTime
                }).Distinct().ToList();
            foreach (var time in times)
            {
                int row = periods.IndexOf(periods.Where(p => p.Start == time.StartTime
                    && p.End == time.EndTime).Single());
                foreach (DataGridViewColumn col in this.timeTableGridView.Columns)
                {
                    if (col.HeaderText == time.HoldingDay)
                    {
                        List<int> coordinate = new List<int>();
                        coordinate.Add(row);
                        coordinate.Add(col.Index);
                        this.inactiveCells.Add(coordinate);
                    }
                }
            }
        }

        private void styleDisableCells()
        {
            foreach (var cell in this.inactiveCells)
            {
                this.timeTableGridView[cell.Last(), cell.First()].Style.BackColor =
                    Color.FromKnownColor(KnownColor.InactiveCaption);
                this.timeTableGridView[cell.Last(), cell.First()].ReadOnly = true;
                this.timeTableGridView[cell.Last(), cell.First()].ToolTipText =
                    "این بازه زمانی غیر قابل دسترسی می باشد.";
            }
        }

        public void SetTerm(byte year, byte semester)
        {
            this.semester = semester;
            this.year = year;
        }

        private void TimeTableForm_Load(object sender, EventArgs e)
        {
            this.boxSemesterCombo.SelectedIndex = this.semester - 1;
            for (int i = 0; i < this.boxYearCombo.Items.Count; i++)
            {
                if (this.boxYearCombo.Items[i].ToString() == year.ToString())
                    this.boxYearCombo.SelectedIndex = i;
            }
            this.readData();
            this.FillGroupComboBox();
            this.ShowData();
        }

        private void boxYearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.isFilled)
                return;
            this.year = Convert.ToByte(this.boxYearCombo.SelectedItem);
            this.readData();
            this.FillGroupComboBox();
            this.ShowData();
        }

        private void boxSemesterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.isFilled)
                return;
            this.semester = (byte)(this.boxSemesterCombo.SelectedIndex + 1);
            this.readData();
            this.FillGroupComboBox();
            this.ShowData();
        }

        private void boxGroupCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.grupFilled)
                return;
            System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                "BoxID", this.boxGroupCombo.SelectedIndex));
            this.ShowData();
        }

        public void Save()
        {
            try
            {
                var times = from tt in this.taali.TimeTables
                            join gs in this.taali.GroupSubjects
                            on tt.GroupSubjectID equals gs.GroupSubjectID
                            where gs.TermYear == this.year &&
                            gs.Semester == this.semester
                            select tt;
                if (this.UniTimeTable == null || this.UniTimeTable.Count == 0)
                    return;
                List<GroupSubject> gps = new List<GroupSubject>();
                foreach (var time in times)
                {
                    if (this.UniTimeTable.Where(utt => utt.GroupSubjectID == time.GroupSubjectID
                        && utt.ClassID == time.ClassID && utt.TimeTeacherID == time.TimeTeacherID)
                        .Count() == 0)
                    {
                        gps.Add(this.taali.TimeTables.Where(tt => tt.ID == time.ID)
                            .Select(tt => tt.GroupSubject).Single());
                        this.taali.TimeTables.DeleteAllOnSubmit(this.taali.TimeTables
                            .Where(tt => tt.ID == time.ID));
                        this.taali.SubmitChanges();
                    }
                }
                foreach (var time in this.UniTimeTable)
                {
                    if (this.taali.TimeTables.Where(tt => tt.GroupSubjectID == time.GroupSubjectID
                        && tt.ClassID == time.ClassID && tt.TimeTeacherID == time.TimeTeacherID)
                        .Count() == 0)
                    {
                        TimeTable cell = new TimeTable();
                        cell.GroupSubject = this.taali.GroupSubjects.Where(gs => gs.GroupSubjectID
                            == time.GroupSubjectID).Single();
                        cell.TimeTeacher = this.taali.TimeTeachers.Where(tt => tt.TimeTeacherID
                            == time.TimeTeacherID).Single();
                        cell.Class = this.taali.Classes.Where(c => c.ClassID == time.ClassID).Single();
                        gps = gps.Where(gp => gp.GroupSubjectID != cell.GroupSubjectID).ToList();
                        this.taali.TimeTables.InsertAllOnSubmit(this.taali.TimeTables
                            .Where(tt => tt.ID == time.ID));
                        this.taali.SubmitChanges();
                    }
                }
                foreach (var gp in gps.Distinct())
                {
                    if (this.taali.TimeTables.Where(utt => utt.GroupSubjectID == gp.GroupSubjectID)
                        .Count() == 0)
                    {
                        this.taali.GroupSubjects.DeleteAllOnSubmit(this.taali.GroupSubjects
                            .Where(gs => gs.GroupSubjectID == gp.GroupSubjectID));
                        this.taali.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.TargetSite + "\n" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (this.year == 0 || this.semester == 0)
            {
                return;
            }
            this.UniTimeTable = this.taali.TimeTables.Where(tt => tt.GroupSubject.TermYear
                == this.year && tt.GroupSubject.Semester == this.semester).ToList();
            this.FillGroupComboBox();
            this.ShowData();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                Programming pro = new Programming();
                pro.TableForm = this;
                pro.Continue = true;
                pro.StartAlgorithm(this.year, this.semester);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.TargetSite + "\n" + ex.Message);
            }
        }

        private void btnReprogram_Click(object sender, EventArgs e)
        {
            try
            {
                Programming pro = new Programming();
                pro.TableForm = this;
                pro.StartAlgorithm(this.year, this.semester);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.TargetSite + "\n" + ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SubjectForm subForm = new SubjectForm();
            subForm.SetButtons();
            subForm.GroupSubjects = this.taali.GroupSubjects.Where(gs =>
                gs.TermYear == this.year && gs.Semester == this.semester).ToList();
            subForm.ShowDialog();
        }

        private void btnAddCoarse_Click(object sender, EventArgs e)
        {
            if (this.timeTableGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("لطفا حداقل یک بازه زمانی انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                return;
            }
            bool flag = false;
            foreach (DataGridViewCell cell in this.timeTableGridView.SelectedCells)
            {
                flag = false;
                for (int i = 0; i < 6; i++)
                {
                    if (new Shamsi.ShamsiDay(i).Name == cell.OwningColumn.HeaderText)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show(this, "خانه ای که شما از جدول انتخاب کردید غیر مجاز می باشد."
                        + " لطفا فقط از خانه های سفید رنگ انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                    return;
                }
            }
            List<UniversityHoldingTime> times = new List<UniversityHoldingTime>();
            foreach (DataGridViewCell cell in this.timeTableGridView.SelectedCells)
            {
                times.AddRange(this.taali.UniversityHoldingTimes.Where(uht => uht.HoldingDay
                    == cell.OwningColumn.HeaderText && uht.StartTime == (TimeSpan)cell.OwningRow
                    .Cells["colStartTime"].Value && uht.EndTime == (TimeSpan)cell.OwningRow
                    .Cells["colEndTime"].Value));
            }
            AddingSubject asForm = new AddingSubject();
            asForm.Year = this.year;
            asForm.Semester = this.semester;
            asForm.Times = times;
            asForm.TimeTableCells = this.UniTimeTable;
            if (this.boxGroupCombo.SelectedItem != null)
            {
                var theGroup = this.taali.Groups.Where(g => g.Title.
                Equals(boxGroupCombo.SelectedItem.ToString()));
                if (theGroup != null && theGroup.Count() == 1)
                    asForm.GetGroup(theGroup.Single());
            }
            if (asForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.UniTimeTable = asForm.TimeTableCells;
                this.Save();
            }
            this.FillGroupComboBox();
            this.ShowData();
        }

        private void btnDeleteCoarse_Click(object sender, EventArgs e)
        {
            if (this.timeTableGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("لطفا حداقل یک بازه زمانی انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                return;
            }
            bool flag = false;
            foreach (DataGridViewCell cell in this.timeTableGridView.SelectedCells)
            {
                flag = false;
                for (int i = 0; i < 6; i++)
                {
                    if (new Shamsi.ShamsiDay(i).Name == cell.OwningColumn.HeaderText)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show(this, "خانه ای که شما از جدول انتخاب کردید غیر مجاز می باشد."
                        + " لطفا فقط از خانه های سفید رنگ انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                    return;
                }
            }
            List<UniversityHoldingTime> times = new List<UniversityHoldingTime>();
            foreach (DataGridViewCell cell in this.timeTableGridView.SelectedCells)
            {
                times.AddRange(this.taali.UniversityHoldingTimes.Where(uht => uht.HoldingDay
                    == cell.OwningColumn.HeaderText && uht.StartTime == (TimeSpan)cell.OwningRow
                    .Cells["colStartTime"].Value && uht.EndTime == (TimeSpan)cell.OwningRow
                    .Cells["colEndTime"].Value));
            }
            foreach (var time in times)
            {
                if (this.UniTimeTable.Where(tt => tt.TimeTeacher.TimeID == time.HoldingTimeID
                    && tt.GroupSubject.Group.Title == this.boxGroupCombo.SelectedItem.ToString()
                    && tt.GroupSubject.TermYear == this.year && tt.GroupSubject.Semester
                    == this.semester).Count() == 0)
                {
                    MessageBox.Show(this, "خانه ای که شما از جدول انتخاب کردید غیر مجاز می باشد."
                        + " لطفا فقط از خانه های حاوی اطلاعات انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                    return;
                }
            }
            DialogResult dr = MessageBox.Show(this, "آیا مایل به حذف این خانه های جدول می باشید؟"
                        , "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
            if (dr == System.Windows.Forms.DialogResult.No)
                return;
            try
            {
                foreach (var time in times)
                {
                    var teachs = this.UniTimeTable.Where(tt => tt.TimeTeacher.TimeID == time.HoldingTimeID
                        && tt.GroupSubject.Group.Title == this.boxGroupCombo.SelectedItem.ToString()
                        && tt.GroupSubject.TermYear == this.year && tt.GroupSubject.Semester
                        == this.semester).Select(tt => tt.TimeTeacher.Teacher);
                    var subs = this.UniTimeTable.Where(tt => tt.TimeTeacher.TimeID == time.HoldingTimeID
                        && tt.GroupSubject.Group.Title == this.boxGroupCombo.SelectedItem.ToString()
                        && tt.GroupSubject.TermYear == this.year && tt.GroupSubject.Semester
                        == this.semester).Select(tt => tt.GroupSubject.Subject);
                    if (subs != null && teachs != null && subs.Count() == 1
                        && teachs.Count() == 1)
                    {
                        Teacher teacher = teachs.Single();
                        Subject subject = subs.Single();
                        this.UniTimeTable = this.UniTimeTable.Where(tt => !(tt.TimeTeacher.TeacherID ==
                            teacher.TeacherID && tt.GroupSubject.Group.Title == this.boxGroupCombo
                            .SelectedItem.ToString() && tt.GroupSubject.TermYear == this.year &&
                            tt.GroupSubject.Semester == this.semester && tt.GroupSubject.SubjectID
                            == subject.SubjectID)).ToList();
                    }

                }
                this.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.TargetSite + "\n" + ex.Message + "\n" + ex);
            }
            this.FillGroupComboBox();
            this.ShowData();
        }

        private void btnEditCoarse_Click(object sender, EventArgs e)
        {
            if (this.timeTableGridView.SelectedCells.Count == 0)
            {
                MessageBox.Show("لطفا حداقل یک بازه زمانی انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                return;
            }
            bool flag = false;
            foreach (DataGridViewCell cell in this.timeTableGridView.SelectedCells)
            {
                flag = false;
                for (int i = 0; i < 6; i++)
                {
                    if (new Shamsi.ShamsiDay(i).Name == cell.OwningColumn.HeaderText)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show(this, "خانه ای که شما از جدول انتخاب کردید غیر مجاز می باشد."
                        + " لطفا فقط از خانه های سفید رنگ انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                    return;
                }
            }
            List<UniversityHoldingTime> times = new List<UniversityHoldingTime>();
            foreach (DataGridViewCell cell in this.timeTableGridView.SelectedCells)
            {
                times.AddRange(this.taali.UniversityHoldingTimes.Where(uht => uht.HoldingDay
                    == cell.OwningColumn.HeaderText && uht.StartTime == (TimeSpan)cell.OwningRow
                    .Cells["colStartTime"].Value && uht.EndTime == (TimeSpan)cell.OwningRow
                    .Cells["colEndTime"].Value));
            }
            foreach (var time in times)
            {
                if (this.UniTimeTable.Where(tt => tt.TimeTeacher.TimeID == time.HoldingTimeID
                    && tt.GroupSubject.Group.Title == this.boxGroupCombo.SelectedItem.ToString()
                    && tt.GroupSubject.TermYear == this.year && tt.GroupSubject.Semester
                    == this.semester).Count() == 0)
                {
                    MessageBox.Show(this, "خانه ای که شما از جدول انتخاب کردید غیر مجاز می باشد."
                        + " لطفا فقط از خانه های حاوی اطلاعات انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                    return;
                }
            }
            List<Teacher> teachers = new List<Teacher>();
            List<Subject> subjects = new List<Subject>();
            foreach (var time in times)
            {
                teachers.AddRange(this.UniTimeTable.Where(tt => tt.TimeTeacher.TimeID == time.HoldingTimeID
                    && tt.GroupSubject.Group.Title == this.boxGroupCombo.SelectedItem.ToString()
                    && tt.GroupSubject.TermYear == this.year && tt.GroupSubject.Semester
                    == this.semester).Select(tt => tt.TimeTeacher.Teacher));
                subjects.AddRange(this.UniTimeTable.Where(tt => tt.TimeTeacher.TimeID == time.HoldingTimeID
                    && tt.GroupSubject.Group.Title == this.boxGroupCombo.SelectedItem.ToString()
                    && tt.GroupSubject.TermYear == this.year && tt.GroupSubject.Semester
                    == this.semester).Select(tt => tt.GroupSubject.Subject));
            }
            try
            {
                teachers = teachers.Distinct().ToList();
                subjects = subjects.Distinct().ToList();
                Teacher teacher = teachers.Single();
                Subject subject = subjects.Single();
                if (subject.HoursPerWeak != times.Count)
                    throw new Exception();
                EditingSubject es = new EditingSubject();
                es.TheGroup = this.taali.Groups.Where(g => g.Title == this.boxGroupCombo
                    .SelectedItem.ToString()).Single();
                es.TheSubject = subject;
                es.TheTeacher = teacher;
                es.TheClass = this.UniTimeTable.Where(tt => tt.TimeTeacher.TeacherID ==
                        teacher.TeacherID && tt.GroupSubject.Group.Title == this.boxGroupCombo
                        .SelectedItem.ToString() && tt.GroupSubject.TermYear == this.year &&
                        tt.GroupSubject.Semester == this.semester && tt.GroupSubject.SubjectID
                        == subject.SubjectID).Select(tt => tt.Class).Distinct().Single();
                es.Year = this.year;
                es.Semester = this.semester;
                es.Times = times;
                es.TimeTableCells = this.UniTimeTable;
                if (es.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.UniTimeTable = es.TimeTableCells;
                    this.Save();
                }
                this.FillGroupComboBox();
                this.ShowData();
            }
            catch (Exception)
            {
                MessageBox.Show(this, "شما فقط می توانید یک درس انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
            }
        }
    }
}
