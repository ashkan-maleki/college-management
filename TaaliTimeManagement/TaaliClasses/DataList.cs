using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaaliTimeManagement.TaaliClasses
{
    class DataList
    {
        public DataList()
        {
            taalidata = new TaaliDataDataContext();
        }

        TaaliDataDataContext taalidata;

        public List<Major> MajorList()
        {
            List<Major> majors = (from m in taalidata.Majors
                                  orderby m.MajorLevel, m.Title, m.Branch
                                  select m).ToList();
            return majors;
        }

        public List<Major> FindMajor(string level, string title, string branch)
        {
            return (from m in this.MajorList()
                    where (string.IsNullOrWhiteSpace(level) || m.MajorLevel.Equals(level))
                    && (string.IsNullOrWhiteSpace(title) || m.Title.Equals(title)) &&
                    (string.IsNullOrWhiteSpace(branch) || string.Equals(m.Branch, branch))
                    select m).ToList();
        }

        public List<Class> ClassList()
        {
            return (from c in this.taalidata.Classes
                    orderby c.ClassID
                    select c).ToList();
        }

        public List<Class> FindClass(int id, string department, int? floor, int capacity)
        {
            return (from c in this.ClassList()
                    where (id == 0 || c.ClassID == id) &&
                    (string.IsNullOrWhiteSpace(department) || string.Equals(c.Department,department))
                    && (floor == null || c.BuildingFloor == floor) &&
                    (capacity == 0 || c.Capacity == capacity)
                    select c).ToList();
        }

        public List<SubjectType> TypeList()
        {
            return (from t in taalidata.SubjectTypes
                    orderby t.TypeTitle, t.Theory descending,
                    t.SubjectTypeID
                    select t).ToList();
        }

        public List<SubjectType> FindType(string typeTitle, bool theory)
        {
            return (from t in this.TypeList()
                    where (string.IsNullOrWhiteSpace(typeTitle) || t.TypeTitle.Equals(typeTitle))
                    &&  t.Theory == theory
                    select t).ToList();
        }

        public List<Group> GroupList()
        {
            return (from g in taalidata.Groups
                    orderby g.EnterYear descending,
                    g.EnterSemester, g.Major.MajorLevel,
                    g.Major.Title, g.Major.Branch
                    select g).ToList();
        }

        public List<Group> FindGroup(Major major, string groupTitle, int entryYear,
            byte entrySemester, byte? numberOfStudent)
        {
            return (from g in this.GroupList()
                    where (major == null || g.MajorID == major.MajorID) &&
                    (string.IsNullOrWhiteSpace(groupTitle) || g.Title.Equals(groupTitle))
                    && (entryYear == 0 || g.EnterYear == entryYear)
                    && (entrySemester == 0 || g.EnterSemester.Equals(entrySemester))
                    && g.NumberOfStudent == numberOfStudent
                    select g).ToList();
        }

        public List<Subject> SubjectList()
        {
            return (from s in this.taalidata.Subjects
                    orderby s.SubjectID
                    select s).ToList();
        }

        public List<Subject> FindSubject(string title, SubjectType type)
        {
            return (from s in this.SubjectList()
                    where (type == null || s.SubjectType.SubjectTypeID == type.SubjectTypeID)
                    && (string.IsNullOrWhiteSpace(title) || s.Title.Equals(title))
                    select s).ToList();
        }

        public List<UniversityHoldingTime> HoldingTimeList()
        {
            return (from ht in this.taalidata.UniversityHoldingTimes
                    orderby ht.HoldingDay, ht.StartTime, ht.EndTime
                    select ht).ToList();
        }

        public List<Teacher> TeacherList()
        {
            return (from t in taalidata.Teachers
                    orderby t.LastName, t.FirstName
                    select t).ToList();
        }

        public List<Teacher> FindTeacher(string firstName, string lastName)
        {
            return (from t in this.TeacherList()
                    where (string.IsNullOrWhiteSpace(firstName)
                    || t.FirstName.Equals(firstName))
                    && (string.IsNullOrWhiteSpace(lastName)
                    || t.LastName.Equals(lastName))
                    select t).ToList();
        }
        
    }
}
