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
    public partial class BaseAutoTimeForm : Form
    {
        public BaseAutoTimeForm()
        {
            InitializeComponent();

            string str = "شما نمی توانید هیچ کاراکتری را به این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را حذف کنید.";
            this.boxStartUniversityMasked.MaskFulErrorText = str;
            this.boxStartUniversityMasked.EmptinessErrorText = "لطفا اطلاعات مربوط به زمان شروع دانشگاه را وارد کنید";
            str = "شما نمی توانید هیچ کاراکتری را به آخر این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را از آخر حذف کنید.";
            this.boxStartUniversityMasked.EndOfFieldErrorText = str;
            this.boxStartUniversityMasked.InputCharacterErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";
            this.boxStartUniversityMasked.MaskCompletedErrorText = "شما باید این فیلد را تکمیل کنید";
            this.boxStartUniversityMasked.TypeInvalidErrorText = "این ورودی برای ساعت مجاز نمی باشد.";

            str = "شما نمی توانید هیچ کاراکتری را به این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را حذف کنید.";
            this.boxEndUniversityMasked.MaskFulErrorText = str;
            this.boxEndUniversityMasked.EmptinessErrorText = "لطفا اطلاعات مربوط به زمان پایان فعالیت دانشگاه را وارد کنید";
            str = "شما نمی توانید هیچ کاراکتری را به آخر این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را از آخر حذف کنید.";
            this.boxEndUniversityMasked.EndOfFieldErrorText = str;
            this.boxEndUniversityMasked.InputCharacterErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";
            this.boxEndUniversityMasked.MaskCompletedErrorText = "شما باید این فیلد را تکمیل کنید";
            this.boxEndUniversityMasked.TypeInvalidErrorText = "این ورودی برای ساعت مجاز نمی باشد.";

            str = "شما نمی توانید هیچ کاراکتری را به این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را حذف کنید.";
            this.boxClassPeriodMasked.MaskFulErrorText = str;
            this.boxClassPeriodMasked.EmptinessErrorText = "لطفا اطلاعات مربوط به مدت زمان هر کلاس را وارد کنید";
            str = "شما نمی توانید هیچ کاراکتری را به آخر این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را از آخر حذف کنید.";
            this.boxClassPeriodMasked.EndOfFieldErrorText = str;
            this.boxClassPeriodMasked.InputCharacterErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";
            this.boxClassPeriodMasked.MaskCompletedErrorText = "شما باید این فیلد را تکمیل کنید";
            this.boxClassPeriodMasked.TypeInvalidErrorText = "این ورودی برای ساعت مجاز نمی باشد.";

            str = "شما نمی توانید هیچ کاراکتری را به این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را حذف کنید.";
            this.boxRestTimeMasked.MaskFulErrorText = str;
            this.boxRestTimeMasked.EmptinessErrorText = "لطفا اطلاعات مربوط به مدت زمان استراحت بین دو کلاس را وارد کنید";
            str = "شما نمی توانید هیچ کاراکتری را به آخر این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را از آخر حذف کنید.";
            this.boxRestTimeMasked.EndOfFieldErrorText = str;
            this.boxRestTimeMasked.InputCharacterErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";
            this.boxRestTimeMasked.MaskCompletedErrorText = "شما باید این فیلد را تکمیل کنید";
            this.boxRestTimeMasked.TypeInvalidErrorText = "این ورودی برای ساعت مجاز نمی باشد.";

            this.taali = new TaaliDataDataContext();
            this.holdingTimes = this.taali.UniversityHoldingTimes.
                OrderBy(uht => uht.StartTime).ToList();
            this.readFromDb();
            if (this.holdingTable != null && this.holdingTable.Count > 0)
                this.timeDataGridView.DataSource = this.holdingTable;
            
        }


        protected TaaliDataDataContext taali;
        private List<TimeTableClass<bool>> holdingTable { get; set; }
        protected List<UniversityHoldingTime> holdingTimes { get; set; }

        private TimeSpan uniBeginning { get; set; }
        private TimeSpan uniEnd { get; set; }
        private TimeSpan periodTime { get; set; }
        private TimeSpan halfPeriod { get; set; }
        private TimeSpan restPeriod { get; set; }
        private TimeSpan delayBeginning { get; set; }
        private TimeSpan delayEnd { get; set; }

        private void btnMake_Click(object sender, EventArgs e)
        {
            if (!this.boxStartUniversityMasked.ValidateAll())
                return;
            if (!this.boxEndUniversityMasked.ValidateAll())
                return;
            if (!this.boxClassPeriodMasked.ValidateAll())
                return;
            if (!this.boxRestTimeMasked.ValidateAll())
                return;
            this.uniBeginning = this.boxStartUniversityMasked.GetTime();
            this.uniEnd = this.boxEndUniversityMasked.GetTime();
            this.periodTime = this.boxClassPeriodMasked.GetTime();
            int minutes = (int)(this.periodTime.TotalMinutes / 2);
            int hours = (minutes / 60);
            minutes -= hours * 60;
            this.halfPeriod = new TimeSpan(hours, minutes, 0);
            this.restPeriod = this.boxRestTimeMasked.GetTime();
            this.holdingTable = new List<TimeTableClass<bool>>();
            TimeSpan previousStart = this.uniBeginning;
            for (TimeSpan start = this.uniBeginning; start.Add(this.halfPeriod) <= this.uniEnd; )
            {
                TimeSpan end = start.Add(this.halfPeriod);
                TimeTableClass<bool> ttc = new TimeTableClass<bool>(start, end);
                ttc.Fill(true,
                    new Shamsi.ShamsiDay(0).Name,
                    new Shamsi.ShamsiDay(1).Name,
                    new Shamsi.ShamsiDay(2).Name,
                    new Shamsi.ShamsiDay(3).Name,
                    new Shamsi.ShamsiDay(4).Name,
                    new Shamsi.ShamsiDay(5).Name);
                this.holdingTable.Add(ttc);
                start = end;
                if (end - previousStart == this.periodTime)
                {
                    start = start.Add(this.restPeriod);
                    previousStart = start;
                }
            }

            this.holdingTable = this.holdingTable.OrderBy(ht => ht.StartTime).ToList();
            this.timeDataGridView.DataSource = this.holdingTable;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!this.boxStartDelayMasked.ValidateAll())
                return;
            if (!this.boxEndDelayMasked.ValidateAll())
                return;
            this.delayBeginning = this.boxStartDelayMasked.GetTime();
            this.delayEnd = this.boxEndDelayMasked.GetTime();
            var change = from ht in this.holdingTable
                         where ht.StartTime >= this.delayBeginning
                         && ht.StartTime < this.delayEnd
                         orderby ht.StartTime
                         select ht;
            if (change == null || change.Count() <= 0)
            {
                MessageBox.Show("ایجاد وقفه در این بازه زمانی غیر ممکن هست به این دلیل که کلاسی وجود ندارد.",
                    "خطا",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
                return;
            }
            TimeSpan span = this.delayEnd - change.First().StartTime;
            var rows = (from ht in this.holdingTable
                        where ht.StartTime >= this.delayBeginning
                        select ht).ToList();
            for (int i = 0; i < rows.Count(); i++)
            {
                this.holdingTable.Where(ttc => ttc.StartTime == rows[i].StartTime).First().StartTime
                    = rows[i].StartTime.Add(span);
                this.holdingTable.Where(ttc => ttc.EndTime == rows[i].EndTime).First().EndTime
                    = rows[i].EndTime.Add(span);
            }
            this.holdingTable = (from ttc in this.holdingTable
                                 where ttc.EndTime <= this.uniEnd
                                 orderby ttc.StartTime
                                 select ttc).ToList();
            this.timeDataGridView.DataSource = this.holdingTable;
        }

        //private void btndefault_Click(object sender, EventArgs e)
        //{
        //    this.boxStartUniversityMasked.Text = "0800";
        //    this.boxEndUniversityMasked.Text = "1500";
        //    this.boxClassPeriodMasked.Text = "0130";
        //    this.boxRestTimeMasked.Text = "0015";
        //    this.boxStartDelayMasked.Text = "1300";
        //    this.boxEndDelayMasked.Text = "1345";
        //}

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            this.holdingTimes = this.taali.UniversityHoldingTimes.ToList();
            this.readFromDb();
            this.timeDataGridView.DataSource = this.holdingTable;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        protected virtual void btnOk_Click(object sender, EventArgs e)
        {
            if (this.holdingTable == null)
            {
                MessageBox.Show("قبل از تایید جدول زمان بندی باید ایجاد شود.",
                    "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
                return;
            }
            foreach (var uht in this.taali.UniversityHoldingTimes.Where(t => t.Possible))
            {
                uht.Possible = false;
                taali.SubmitChanges();
            }
            foreach (var ttc in this.holdingTable)
            {
                foreach (var dic in ttc.Read())
                {
                    var times = (from t in this.taali.UniversityHoldingTimes
                                 where t.HoldingDay == dic.Key.HoldingDay &&
                                 (t.StartTime == dic.Key.StartTime && t.EndTime == dic.Key.EndTime)
                                 select t).ToList();
                    if (times.Count() > 0)
                    {
                        for (int i = 0; i < times.Count(); i++)
                        {
                            times[i].Possible = true;
                            times[i].Enabled = dic.Value;
                        }
                        try
                        {
                            taali.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                    else
                    {
                        dic.Key.Possible = true;
                        dic.Key.Enabled = dic.Value;
                        try
                        {
                            taali.UniversityHoldingTimes.InsertOnSubmit(dic.Key);
                            taali.SubmitChanges();
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                    }
                }
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void readFromDb()
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
                    ttc.Fill(ht.Enabled, ht.HoldingDay);
                this.holdingTable.Add(ttc);
            }
            this.uniBeginning = times.Min(t => t.Key.StartTime);
            this.boxStartUniversityMasked.Text = this.uniBeginning.ToString().Remove(5);
            this.uniEnd = times.Max(t => t.Key.EndTime);
            this.boxEndUniversityMasked.Text = this.uniEnd.ToString().Remove(5);
            var h = times.OrderBy(t => t.Key.StartTime).Take(2);
            this.periodTime = h.Last().Key.EndTime - h.First().Key.StartTime;
            this.boxClassPeriodMasked.Text = this.periodTime.ToString().Remove(5);
            this.restPeriod = times.OrderBy(t => t.Key.StartTime).Take(3).Last().Key.StartTime
                - h.Last().Key.EndTime;
            this.boxRestTimeMasked.Text = this.restPeriod.ToString().Remove(5);
        }

        //
        // Children Codes
        //
        

        protected void disableControls()
        {
            this.groupBox1.Enabled = false;
            this.groupBox1.Visible = false;
            this.groupBox2.Enabled = false;
            this.groupBox2.Visible = false;
        }

        

        protected Dictionary<int, List<int>> findDisableCells()
        {
            Dictionary<int, List<int>> disables = new Dictionary<int, List<int>>();
            if (this.holdingTable == null || this.holdingTable.Count <= 0)
                return null;
            if (this.timeDataGridView.RowCount <= 0)
                return null;
            for (int i = 0; i < this.timeDataGridView.ColumnCount - 3; i++)
            {
                List<int> indeces = new List<int>();
                for (int j = 0; j < this.timeDataGridView.RowCount; j++)
                {
                    if (this.timeDataGridView[i, j].ValueType == typeof(bool)
                        && !(bool)this.timeDataGridView[i, j].Value)
                        indeces.Add(j);
                }
                disables.Add(i, indeces);
            }
            return disables;
        }


    }

    

}
