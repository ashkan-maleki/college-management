using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool showTodayReport()
        {
            byte year = 0;
            byte semester = 0;
            int todayYear = Shamsi.ShamsiDate.Today.Year;
            if (Shamsi.ShamsiDate.Today.Month > 3)
                year = (byte)(todayYear - (todayYear / 100) * 100);
            else year = (byte)(todayYear - 1 - (todayYear / 100) * 100);
            if (Shamsi.ShamsiDate.Today.Month < 4 || Shamsi.ShamsiDate.Today.Month > 9)
                semester = 2;
            else if (Shamsi.ShamsiDate.Today.Month > 3 && Shamsi.ShamsiDate.Today.Month < 7)
                semester = 3;
            else semester = 1;
            TaaliDataDataContext taali = new TaaliDataDataContext();
            var subjects = from tt in taali.TimeTables
                           where tt.GroupSubject.Semester
                           == semester && year == tt
                           .GroupSubject.TermYear &&
                           tt.TimeTeacher.UniversityHoldingTime
                           .HoldingDay == Shamsi.ShamsiDate
                           .Today.DayOfWeek.Name
                           group tt by tt.GroupSubject;
            if (subjects != null && subjects.Count() > 0)
            {
                ReportCategory.TodayForm today = new ReportCategory.TodayForm();
                today.Text = Shamsi.ShamsiDate.Today.DayOfWeek.Name;
                today.Subjects = subjects.ToList();
                this.showForm(today);
                return true;
            }
            else return false;
        }

        private void showDailyReport()
        {
            byte year = 0;
            byte semester = 0;
            int todayYear = Shamsi.ShamsiDate.Today.Year;
            if (Shamsi.ShamsiDate.Today.Month > 3)
                year = (byte)(todayYear - (todayYear / 100) * 100);
            else year = (byte)(todayYear - 1 - (todayYear / 100) * 100);
            if (Shamsi.ShamsiDate.Today.Month < 4 || Shamsi.ShamsiDate.Today.Month > 9)
                semester = 2;
            else if (Shamsi.ShamsiDate.Today.Month > 3 && Shamsi.ShamsiDate.Today.Month < 7)
                semester = 3;
            else semester = 1;
            TaaliDataDataContext taali = new TaaliDataDataContext();
            var subjects = from tt in taali.TimeTables
                           where tt.GroupSubject.Semester
                           == semester && year == tt
                           .GroupSubject.TermYear 
                           group tt by tt.GroupSubject;
            if (subjects != null && subjects.Count() > 0)
            {
                ReportCategory.DailyForm daily = new ReportCategory.DailyForm();
                daily.Subjects = subjects.ToList();
                this.showForm(daily);
            }
            else MessageBox.Show("برای این ترم هیچ برنامه ای ندارد");
        }

        protected void showForm(Form frmNew)
        {
            frmNew.MdiParent = this;
            if (!frmNew.Equals(null) && !frmNew.IsDisposed)
                frmNew.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(
                new System.Globalization.CultureInfo("fa-IR"));
            this.showTodayReport();
        }

        



        private void subjectTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.showForm(new TypeCategory.TypeForm());
        }

        private void classToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.showForm(new ClassCategory.ClassroomForm());
        }

        private void majorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.showForm(new MajorCategory.MajorForm());
        }

        private void groupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.showForm(new GroupCategroy.GroupForm());
        }

        private void t1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Size = new Size(200, 200);
            f.ShowDialog();
        }

        //private void autoTimingToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void teacherManagementToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.showForm(new Management.TermForm());
        }

        private void programmingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Management.Programming pro = new Management.Programming();
            pro.ParentForm = this;
            pro.StartAlgorithm();
        }

        private void timeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showForm(new Management.TimeTableForm());
        }

        private void timeTableReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showForm(new ReportCategory.TimeTableForm());
        }

        private void todayReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.showTodayReport())
                MessageBox.Show("امروز هیچ برنامه ای ندارد");
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showDailyReport();
        }

        private void subjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.showForm(new SubjectCategory.SubjectForm());
        }

        private void timeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.showForm(new TimeCategory.BaseAutoTimeForm());
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.showForm(new TeacherCategory.TeacherForm());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
