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
    public partial class TodayForm : TaaliTimeManagement.ReportCategory.TimeTableForm
    {
        public TodayForm()
        {
            InitializeComponent();
            this.toolStrip1.Visible = false;
        }

        public List<IGrouping<GroupSubject, TimeTable>> Subjects;

        private void TodayForm_Load(object sender, EventArgs e)
        {
            if (this.Subjects == null || this.Subjects.Count() == 0)
                return;
            List<DailyTableView> todayTable = new List<DailyTableView>();
            foreach (var subject in this.Subjects)
            {

                foreach (var t1 in subject)
                {
                    DailyTableView row = new DailyTableView();
                    foreach (var t2 in subject)
                    {
                        if (t1.TimeTeacher.UniversityHoldingTime.EndTime ==
                            t2.TimeTeacher.UniversityHoldingTime.StartTime)
                        {
                            row.SetDailyView(t1.TimeTeacher.UniversityHoldingTime.HoldingDay,
                                t1.TimeTeacher.UniversityHoldingTime.StartTime,
                                t2.TimeTeacher.UniversityHoldingTime.EndTime, t1);
                            break;
                        }
                        else if (t1.TimeTeacher.UniversityHoldingTime.StartTime ==
                            t2.TimeTeacher.UniversityHoldingTime.EndTime)
                        {
                            row = new DailyTableView();
                            break;
                        }
                        else
                        {
                            row.SetDailyView(t1.TimeTeacher.UniversityHoldingTime.HoldingDay,
                                t1.TimeTeacher.UniversityHoldingTime.StartTime,
                                   t1.TimeTeacher.UniversityHoldingTime.EndTime, t1);
                        }
                    }
                    if (!string.IsNullOrEmpty(row.Teacher) && !string.IsNullOrEmpty(row.Subject))
                        todayTable.Add(row);
                }
            }
            ReportDocument rd = new ReportDocument();
            rd.Load("TodayReport.rpt");
            rd.VerifyDatabase();
            rd.SetDataSource(todayTable);
            timeTableViewer.ReportSource = rd;
        }
    }
}
