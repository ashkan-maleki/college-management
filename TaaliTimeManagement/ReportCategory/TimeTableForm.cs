using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace TaaliTimeManagement.ReportCategory
{
    public partial class TimeTableForm : Form
    {
        public TimeTableForm()
        {
            InitializeComponent();
            this.timeTableViewer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            TaaliDataDataContext taali = new TaaliDataDataContext();
            if (taali.TimeTables != null && taali.TimeTables.Count() != 0)
            {
                this.boxYearCombo.Items.AddRange(taali.TimeTables.Select(tt => tt.GroupSubject)
                    .OrderByDescending(gs => gs.TermYear).Select(tt => tt.TermYear.ToString())
                    .Distinct().ToArray());
                this.boxYearCombo.SelectedIndex = this.boxYearCombo.Items.Count - 1;
                boxSemesterCombo.SelectedIndex = taali.TimeTables.Select(tt => tt.GroupSubject)
                    .Where(gs => gs.TermYear == taali.GroupSubjects.Max(g => g.TermYear))
                    .Distinct().Max(gs => gs.Semester) - 1;
                this.yearIndexCombo = this.boxYearCombo.SelectedIndex;
                this.semesterIndexCombo = this.boxSemesterCombo.SelectedIndex;
            }
        }

        private int yearIndexCombo = 0;
        private int semesterIndexCombo = 0;

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            byte year = 0;
            byte semester = 0;
            if (this.boxYearCombo.SelectedIndex >= 0)
                year = Convert.ToByte(this.boxYearCombo.SelectedItem);
            if (this.boxSemesterCombo.SelectedIndex >= 0)
                semester = (byte)(this.boxSemesterCombo.SelectedIndex + 1);
            if (year == 0)
            {
                MessageBox.Show("لطفا ابتدا مشخص کنید برای چه سالی قسد گزارش گیری دارید."
                    , "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }
            if (semester == 0)
            {
                MessageBox.Show("لطفا ابتدا مشخص کنید برای چه ترمی قسد گزارش گیری دارید."
                    , "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }
            ReportDocument rd = new ReportDocument();
            TaaliDataDataContext taali = new TaaliDataDataContext();
            var groups = (from tt in taali.TimeTables.Distinct()
                          where tt.GroupSubject.TermYear == year
                          && tt.GroupSubject.Semester == semester
                          group tt by tt.GroupSubject.GroupID);
            if (groups == null && groups.Count() > 0)
            {
                MessageBox.Show("برای سال و ترمی که شما انتخاب کردید هیچ برنامه هفتگی وجود ندارد."
                   , "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }
            List<TimeTableView> tablesView = new List<TimeTableView>();
            foreach (var table in groups)
            {
                List<TimeCategory.TimeTableClass<TimeTable>> tables =
                    new List<TimeCategory.TimeTableClass<TimeTable>>();
                var periods = from uht in taali.UniversityHoldingTimes
                              where uht.Possible
                              select new
                              {
                                  StartTime = uht.StartTime,
                                  EndTime = uht.EndTime
                              };
                periods = periods.Distinct();
                foreach (var period in periods)
                {
                    TimeCategory.TimeTableClass<TimeTable> row =
                        new TimeCategory.TimeTableClass<TimeTable>(period.StartTime,
                            period.EndTime);
                    var days = from uht in taali.UniversityHoldingTimes
                               where uht.Possible
                               select uht.HoldingDay;
                    foreach (var day in days)
                    {
                        if (table.Where(t => t.GroupSubject.GroupID == table.Key
                            && t.TimeTeacher.UniversityHoldingTime.StartTime == period.StartTime
                            && t.TimeTeacher.UniversityHoldingTime.EndTime == period.EndTime
                            && t.TimeTeacher.UniversityHoldingTime.HoldingDay == day)
                            .Count() == 1)
                        {
                            row.Fill(table.Where(t => t.GroupSubject.GroupID == table.Key
                            && t.TimeTeacher.UniversityHoldingTime.StartTime == period.StartTime
                            && t.TimeTeacher.UniversityHoldingTime.EndTime == period.EndTime
                            && t.TimeTeacher.UniversityHoldingTime.HoldingDay == day).Single(),
                            day);
                        }
                    }
                    tables.Add(row);
                }
                foreach (var row in tables)
                {
                    TimeTableView records = new TimeTableView();
                    if (!row.IsEmpty)
                    {
                        records.Fill(taali.Groups.Where(g => g.GroupID == table.Key).Single(), row);
                        tablesView.Add(records);
                    }
                }
            }
            
            if (tablesView.Count == 0)
            {
                MessageBox.Show("برای سال و ترمی که شما انتخاب کردید هیچ برنامه هفتگی وجود ندارد."
                      , "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error,
                      MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                this.boxYearCombo.SelectedIndex = this.yearIndexCombo;
                this.boxSemesterCombo.SelectedIndex = this.semesterIndexCombo;
                return;
            }
            this.yearIndexCombo = this.boxYearCombo.SelectedIndex;
            this.semesterIndexCombo = this.boxSemesterCombo.SelectedIndex;
            rd.Load("TimeTableReport.rpt");
            rd.VerifyDatabase();
            rd.SetDataSource(tablesView);
            timeTableViewer.ReportSource = rd;
        }
    }
}
