using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaaliTimeManagement
{
    public partial class Subject
    {

        public string MajorsName
        {
            get
            {
                string names = string.Empty;
                if (this.MajorSubjects.Count > 0)
                    names = this.MajorSubjects[0].Major.ToString();
                for (int i = 1; i < this.MajorSubjects.Count; i++)
                {
                    names = string.Format("{0}\n{1}", names, this.MajorSubjects[i].Major);
                }
                return names;
            }
        }
        public string PrerequisitesName
        {
            get
            {
                string names = string.Empty;
                if (this.Prerequisites.Count > 0)
                    names = this.Prerequisites[0].Subject1.ToString();
                for (int i = 1; i < this.Prerequisites.Count; i++)
                {
                    names = string.Format("{0} - {1}", names, this.Prerequisites[i].Subject1);
                }
                return names;
            }
        }

        public int HoursPerWeak
        {
            get
            {
                return this.SubjectType.HoursPerUnit * this.Units / 16;
            }
        }

        public override string ToString()
        {
            return this.Title;
        }
    }

    public partial class Major
    {
        public override string ToString()
        {
            string text = string.Format("{0} - {1}", this.MajorLevel, this.Title);
            if (!string.IsNullOrWhiteSpace(this.Branch))
                text = string.Format("{0} - {1}", text, this.Branch);
            return text;
        }
    }

    public partial class SubjectType
    {
        public override string ToString()
        {
            string text = this.TypeTitle;
            if (this.Theory)
                text = string.Format("{0} - {1}", text, "نظری");
            else text = string.Format("{0} - {1}", text, "عملی");
            return text;
        }
    }

    public partial class UniversityHoldingTime
    {
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this.HoldingDay, this.StartTime, this.EndTime);
        }
    }

    public partial class Group
    {
        public override string ToString()
        {
            return this.Title;
        }
        private List<Subject> _Subjects;
        public List<Subject> Subjects 
        {
            get
            {
                if (this._Subjects != null && this._Subjects.Count > 0)
                    return this._Subjects.OrderBy(s => s.SubjectID).ToList();
                return this._Subjects;
            }
            set
            {
                this._Subjects = value;
            }
        }
    }

    public partial class Teacher
    {
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    public partial class TimeTable
    {
        public override string ToString()
        {
            if (this.TimeTeacher == null || this.Class == null || this.GroupSubject == null)
                return string.Empty;
            return string.Format("{0} - {1} - {2}", this.TimeTeacher.Teacher.ToString(),
                this.GroupSubject.Subject.Title, this.Class.ClassID);
        }

    }

    public partial class TimeTableView
    {
        public void Fill(Group group, TimeCategory.TimeTableClass<TimeTable> row)
        {
            this.Period = row.Period;
            if(row.Saturday != null)
                this.Saturday = row.Saturday.ToString();
            if (row.Sunday != null)
                this.Sunday = row.Sunday.ToString();
            if (row.Monday != null)
                this.Monday = row.Monday.ToString();
            if (row.Tuesday != null)
                this.Tuesday = row.Tuesday.ToString();
            if (row.Wednesday != null)
                this.Wednesday = row.Wednesday.ToString();
            if (row.Thursday != null)
                this.Thursday = row.Thursday.ToString();
            this.Group = group.Title;
        }
    }

    public partial class DailyTableView
    {
        public void SetDailyView(string day, TimeSpan startTime, TimeSpan endTime, TimeTable coarse)
        {
            this.Group = coarse.GroupSubject.Group.Title;
            this.Subject = coarse.GroupSubject.Subject.Title;
            this.Teacher = coarse.TimeTeacher.Teacher.ToString();
            this.Class = coarse.ClassID.ToString();
            this.StartTime = startTime.ToString();
            this.EndTime = endTime.ToString();
            this.HoldingDay = day;
        }
    }

    
}