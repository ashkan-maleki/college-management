using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaaliTimeManagement.TimeCategory
{
    public class TimeTableClass<TItem>
    {
        public TimeTableClass(TimeSpan start, TimeSpan end)
        {
            this.StartTime = start;
            this.EndTime = end;
        }

        public TItem Saturday { get; set; }
        public TItem Sunday { get; set; }
        public TItem Monday { get; set; }
        public TItem Tuesday { get; set; }
        public TItem Wednesday { get; set; }
        public TItem Thursday { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Period
        {
            get
            {
                return string.Format("{0} - {1}", this.StartTime, EndTime);
            }
        }

        private TItem empty;

        public bool IsEmpty
        {
            get
            {
                return this.Saturday == null
                    && this.Sunday == null
                    && this.Monday == null
                    && this.Tuesday == null
                    && this.Wednesday == null
                    && this.Thursday == null;
            }
        }

        public void Fill(TItem value, string day)
        {
            System.Diagnostics.Debug.WriteLine(day + " : " + value);
            if (day == Shamsi.ShamsiDay.Shanbeh.ToString())
                this.Saturday = value;
            else if (day == Shamsi.ShamsiDay.YekShanbeh.ToString())
                this.Sunday = value;
            else if (day == Shamsi.ShamsiDay.DoShanbeh.ToString())
                this.Monday = value;
            else if (day == Shamsi.ShamsiDay.SeShanbeh.ToString())
                this.Tuesday = value;
            else if (day == Shamsi.ShamsiDay.ChaharShanbeh.ToString())
                this.Wednesday = value;
            else if (day == Shamsi.ShamsiDay.PanjShanbeh.ToString())
                this.Thursday = value;
            else throw new Exception("چنین روزی در روز های هفته موجود نیست.");
        }

        public void Fill(TItem value, params string[] days)
        {
            foreach (string day in days)
                this.Fill(value, day);
        }

        public void FillAll(TItem value)
        {
            this.Fill(value, Shamsi.ShamsiDay.Shanbeh.ToString(),
                Shamsi.ShamsiDay.YekShanbeh.ToString(),
                Shamsi.ShamsiDay.DoShanbeh.ToString(),
                Shamsi.ShamsiDay.SeShanbeh.ToString(),
                Shamsi.ShamsiDay.ChaharShanbeh.ToString(),
                Shamsi.ShamsiDay.PanjShanbeh.ToString());
        }

        public Dictionary<UniversityHoldingTime, TItem> Read()
        {
            Dictionary<UniversityHoldingTime, TItem> data = new Dictionary<UniversityHoldingTime, TItem>();
            data.Add(new UniversityHoldingTime()
            {
                HoldingDay = Shamsi.ShamsiDay.Shanbeh.ToString(),
                StartTime = this.StartTime,
                EndTime = this.EndTime
            }, this.Saturday);
            data.Add(new UniversityHoldingTime()
            {
                HoldingDay = Shamsi.ShamsiDay.YekShanbeh.ToString(),
                StartTime = this.StartTime,
                EndTime = this.EndTime
            }, this.Sunday);
            data.Add(new UniversityHoldingTime()
            {
                HoldingDay = Shamsi.ShamsiDay.DoShanbeh.ToString(),
                StartTime = this.StartTime,
                EndTime = this.EndTime
            }, this.Monday);
            data.Add(new UniversityHoldingTime()
            {
                HoldingDay = Shamsi.ShamsiDay.SeShanbeh.ToString(),
                StartTime = this.StartTime,
                EndTime = this.EndTime
            }, this.Tuesday);
            data.Add(new UniversityHoldingTime()
            {
                HoldingDay = Shamsi.ShamsiDay.ChaharShanbeh.ToString(),
                StartTime = this.StartTime,
                EndTime = this.EndTime
            }, this.Wednesday);
            data.Add(new UniversityHoldingTime()
            {
                HoldingDay = Shamsi.ShamsiDay.PanjShanbeh.ToString(),
                StartTime = this.StartTime,
                EndTime = this.EndTime
            }, this.Thursday);
            return data;
        }

        public void RemoveAt(string day)
        {
            if (day == Shamsi.ShamsiDay.Shanbeh.ToString())
                this.Saturday = empty;
            else if (day == Shamsi.ShamsiDay.YekShanbeh.ToString())
                this.Sunday = empty;
            else if (day == Shamsi.ShamsiDay.DoShanbeh.ToString())
                this.Monday = empty;
            else if (day == Shamsi.ShamsiDay.SeShanbeh.ToString())
                this.Tuesday = empty;
            else if (day == Shamsi.ShamsiDay.ChaharShanbeh.ToString())
                this.Wednesday = empty;
            else if (day == Shamsi.ShamsiDay.PanjShanbeh.ToString())
                this.Thursday = empty;
            else throw new Exception("چنین روزی در روز های هفته موجود نیست.");
        }

        public void RemoveAt( params string[] days)
        {
            foreach (string day in days)
                this.RemoveAt(day);
        }

        public void RemoveAll()
        {
            this.RemoveAt(Shamsi.ShamsiDay.Shanbeh.ToString(),
                    Shamsi.ShamsiDay.YekShanbeh.ToString(),
                    Shamsi.ShamsiDay.DoShanbeh.ToString(),
                    Shamsi.ShamsiDay.SeShanbeh.ToString(),
                    Shamsi.ShamsiDay.ChaharShanbeh.ToString(),
                    Shamsi.ShamsiDay.PanjShanbeh.ToString());
        }
    }
}
