using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.TimeCategory
{
    public partial class AutoTimeForm : TaaliTimeManagement.TimeCategory.BaseAutoTimeForm
    {
        public AutoTimeForm()
        {
            InitializeComponent();
            this.disableControls();
            this.inactiveCells = this.findDisableCells();
            this.initializeGridView();
        }

        public List<UniversityHoldingTime> TeachersTimes { get; set; }
        private List<UniversityHoldingTime> defaultTeacherTimes { get; set; }
        private Dictionary<int, List<int>> inactiveCells { get; set; }
        private List<TimeTableClass<bool>> holdingTable {get; set;}

        private void initializeGridView()
        {
            if (this.holdingTimes == null || this.holdingTimes.Count <= 0)
                return;
            this.holdingTable = new List<TimeTableClass<bool>>();
            var times = from t in this.holdingTimes
                        where t.Possible
                        group t by new
                        {
                            t.StartTime,
                            t.EndTime
                        };
            foreach (var time in times)
            {
                TimeTableClass<bool> ttc = new TimeTableClass<bool>(time.Key.StartTime, time.Key.EndTime);
                foreach (var ht in time)
                    ttc.Fill(false, ht.HoldingDay);
                this.holdingTable.Add(ttc);
            }
            this.timeDataGridView.DataSource = this.holdingTable;
        }

        private void setGridView()
        {
            this.defaultTeacherTimes = this.TeachersTimes;
            if (this.holdingTimes == null || this.holdingTimes.Count <= 0)
                return;
            if (this.TeachersTimes == null || this.TeachersTimes.Count <= 0)
                return;
            var times = from t in this.TeachersTimes
                        group t by new
                        {
                            t.StartTime,
                            t.EndTime
                        };
            foreach (var time in times)
            {
                foreach (var ht in time)
                {
                    var row = holdingTable.Where(ttc => ttc.StartTime == time.Key.StartTime
                        && ttc.EndTime == time.Key.EndTime);
                    if (row.Count() == 1)
                    {
                        row.Single().Fill(true, ht.HoldingDay);
                    }
                }
            }
        }

        private void styleDisableCells()
        {
            foreach (var col in this.inactiveCells)
            {
                foreach (var row in col.Value)
                {
                    this.timeDataGridView[col.Key, row].Style.BackColor =
                        Color.FromKnownColor(KnownColor.InactiveCaption);
                    this.timeDataGridView[col.Key, row].ReadOnly = true;
                    this.timeDataGridView[col.Key, row].ToolTipText = "این بازه زمانی غیر قابل دسترسی می باشد.";
                }
            }
        }

        private void AutoTimeForm_Load(object sender, EventArgs e)
        {

            this.styleDisableCells();
            this.setGridView();
        }

        protected override void btnOk_Click(object sender, EventArgs e)
        {
            if (this.holdingTable == null)
            {
                MessageBox.Show("قبل از تایید جدول زمان بندی باید ایجاد شود.", "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
                return;
            }
            this.TeachersTimes = new List<UniversityHoldingTime>();
            foreach (var ttc in this.holdingTable)
            {
                foreach (var dic in ttc.Read())
                {
                    if (dic.Value)
                        this.TeachersTimes.AddRange(this.taali.UniversityHoldingTimes.Where(uht =>
                            uht.HoldingDay == dic.Key.HoldingDay && uht.StartTime == dic.Key.StartTime
                            && uht.EndTime == dic.Key.EndTime));
                }
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            this.TeachersTimes = this.defaultTeacherTimes;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        
    }
}
