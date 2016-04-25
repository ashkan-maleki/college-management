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
    class Programming
    {
        public Programming()
        {
            this.Continue = false;
            this.timeTable = new List<TimeTable>();
        }

        public void StartAlgorithm()
        {
            this.setTerm();
        }

        public void StartAlgorithm(byte year, byte semester)
        {
            this.year = year;
            this.semester = semester;
            this.setSubjects();
        }

        private byte year;
        private byte semester;
        private List<GroupSubject> groupSubjects;
        private List<Teacher> teachers;
        private List<TimeTable> timeTable;
        private List<Class> classes;
        public MainForm ParentForm { get; set; }
        public bool Continue;
        public TimeTableForm TableForm { get; set; }

        private void setTerm()
        {
            Management.TermForm tf = new Management.TermForm();
            if (tf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            this.year = tf.Year;
            this.semester = tf.Semester;
            this.setSubjects();
        }

        private void setSubjects()
        {
            Management.SubjectForm sf = new Management.SubjectForm();
            TaaliDataDataContext taali = new TaaliDataDataContext();
            sf.GroupSubjects = taali.GroupSubjects.Where(gs => gs.TermYear == this.year
                && gs.Semester == this.semester).ToList();
            if (this.Continue)
            {
                this.timeTable = (from tt in taali.TimeTables
                                  join gs in taali.GroupSubjects
                                      on tt.GroupSubjectID equals gs.GroupSubjectID
                                  where gs.Semester == this.semester &&
                                  gs.TermYear == this.year
                                  select tt).ToList();
            }
            DialogResult dr = sf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (var gsub in taali.GroupSubjects.Where(gs => gs.TermYear == this.year
                    && gs.Semester == this.semester))
                {
                    if (sf.GroupSubjects.Where(gs => gs.GroupID == gsub.GroupID &&
                        gs.SubjectID == gsub.SubjectID && gsub.TermYear == this.year
                        && gsub.Semester == this.semester).Count() == 0)
                    {
                        string command = string.Format("{0} {1}",
                                 "DELETE FROM GroupSubject WHERE GroupSubjectID =",
                                 gsub.GroupSubjectID);
                        taali.ExecuteCommand(command);
                    }
                }
                foreach (var gsub in sf.GroupSubjects)
                {
                    if (gsub.Group != null && gsub.Subject != null)
                    {
                        int count = taali.GroupSubjects.Where(gs => gs.GroupID == gsub.GroupID
                           && gs.SubjectID == gsub.SubjectID && gs.Semester == this.semester
                           && gs.TermYear == this.year).Count();
                        if (sf.GroupSubjects.Where(gs => gs.GroupID == gsub.GroupID
                           && gs.SubjectID == gsub.SubjectID).Count() != count)
                        {
                            string command = string.Format("{0} {1} {2} ({3}, {4}, {5}, {6})",
                                "INSERT INTO GroupSubject", "(GroupID, SubjectID, TermYear, Semester)",
                                "VALUES", gsub.GroupID, gsub.SubjectID, this.year, this.semester);
                            taali.ExecuteCommand(command);
                        }
                    }
                }
                this.groupSubjects = taali.GroupSubjects.Where(gs => gs.TermYear == this.year
                && gs.Semester == this.semester).ToList();
                this.setTeacher();
                //try
                //{

                //}
                //catch (Exception)
                //{

                //    throw;
                //}
            }
            else if (dr != DialogResult.Cancel)
            {
                this.setTerm();
            }
        }

        private void setTeacher()
        {
            TeacherForm tf = new TeacherForm();
            TaaliDataDataContext taali = new TaaliDataDataContext();
            tf.Teachers = (from tt in this.timeTable
                           select tt.TimeTeacher.Teacher).Distinct().ToList();
            DialogResult dr = tf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.teachers = tf.Teachers;
                this.setClass();
            }
            else if (dr != DialogResult.Cancel)
            {
                this.setSubjects();
            }
        }

        private void setClass()
        {
            ClassroomForm cf = new ClassroomForm();
            TaaliDataDataContext taali = new TaaliDataDataContext();
            cf.Classes = (from tt in this.timeTable
                          select tt.Class).Distinct().ToList();
            DialogResult dr = cf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                this.classes = cf.Classes;
                this.program();
            }
            else if (dr != DialogResult.Cancel)
            {
                setTeacher();
            }
        }

        private void program()
        {
            TaaliDataDataContext taali = new TaaliDataDataContext();
            foreach (var titab in this.timeTable.Where(tita =>
                tita.GroupSubject.TermYear == this.year &&
                tita.GroupSubject.Semester == this.semester))
            {
                if (this.teachers.Where(t => t.TeacherID == titab.TimeTeacher.TeacherID)
                    .Count() == 0)
                    this.timeTable = this.timeTable.Where(tt => tt.TimeTeacher.TeacherID !=
                        titab.TimeTeacher.TeacherID).ToList();
            }
            foreach (var titab in this.timeTable.Where(tita =>
                tita.GroupSubject.TermYear == this.year &&
                tita.GroupSubject.Semester == this.semester))
            {
                if (this.classes.Where(c => c.ClassID == titab.ClassID)
                    .Count() == 0)
                    this.timeTable = this.timeTable.Where(tt => tt.ClassID != titab.ClassID)
                        .ToList();
            }

            var grps = (from g in this.groupSubjects
                        group g by g.Group).ToList();
            grps = grps.OrderBy(g => g.Count()).ToList();

            //foreach (var grop in grps)
            //{
            //    System.Diagnostics.Debug.WriteLine(string.Format("-----\n{0} : {1}\n\n",
            //            "Group", grop.Key.Title));
            //    foreach (var sub in grop)
            //        System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
            //            " Subject", sub.Subject.Title));
            //}



            System.Diagnostics.Debug.WriteLine("\n---StartProgramming---\n");

            // 1st step
            foreach (var grop in grps)
            {

                System.Diagnostics.Debug.WriteLine(string.Format("-----\n{0} : {1}\n\n",
                        "Group", grop.Key.Title));

                var teachs = from gp in grop
                             join st in taali.SubjectTeachers.ToList()
                             on gp.SubjectID equals st.SubjectID
                             where st.Active
                             select st.Teacher;

                foreach (var tea in teachs.Distinct())
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                        " Teacher", tea.ToString()));

                var times = from t in teachs.Distinct()
                            join tt in taali.TimeTeachers.ToList()
                            on t.TeacherID equals tt.TeacherID
                            where tt.Active
                            group tt.UniversityHoldingTime by
                            tt.UniversityHoldingTime.HoldingDay;
                times = times.OrderBy(t => Shamsi.ShamsiDay.FindShamsiDay(t.Key).DayNumber)
                    .OrderByDescending(t => (double)(double)(t.Count() / (double)t.Distinct()
                        .Count()));
                foreach (var ti in times)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                        " Day", ti.Key));
                    var timteach = from tt in taali.TimeTeachers.ToList()
                                   join uht in taali.UniversityHoldingTimes.ToList()
                                   on tt.TimeID equals uht.HoldingTimeID
                                   where tt.Active && uht.Enabled &&
                                   uht.HoldingDay.Equals(ti.Key)
                                   select tt;
                    var subteach = from tt in timteach.Distinct()
                                   join st in taali.SubjectTeachers.ToList()
                                   on tt.TeacherID equals st.TeacherID
                                   where st.Active
                                   select st;
                    var subs = from gp in grop
                               join st in subteach.Distinct()
                               on gp.SubjectID equals st.SubjectID
                               group st.Teacher by gp.Subject;
                    subs = subs.OrderBy(sub => sub.Distinct().Count());
                    foreach (var sub in subs)
                    {
                        System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                           "  Subject", sub.Key.Title));
                        var theSub = sub.Distinct().OrderBy(t => (from gp in this.groupSubjects
                                                                  join st in taali.SubjectTeachers.ToList()
                                                                      on gp.SubjectID equals st.SubjectID
                                                                  where st.TeacherID == t.TeacherID
                                                                  select gp.Subject).Distinct().Count());
                        foreach (var teach in theSub)
                        {
                            System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                              "   Teacher", teach.ToString()));
                            var teachTodayTimes = (from t in timteach
                                                   where t.TeacherID == teach.TeacherID
                                                    && t.Active && t.UniversityHoldingTime.Enabled
                                                   select t.UniversityHoldingTime).ToList();

                            foreach (var teacher in teachTodayTimes)
                                System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                              "    Time", teacher.ToString()));
                            for (int i = 0; i + sub.Key.HoursPerWeak <= teachTodayTimes.Count; i++)
                            {
                                System.Diagnostics.Debug.WriteLine(string.Format("{0}{1}{2}{3}{4}{5}\n",
                              "    TimeCount : ", teachTodayTimes.Count, "\n    HoursPerWeak : ",
                              sub.Key.HoursPerWeak, "\n    i : ", i));
                                foreach (var classroom in this.classes)
                                    this.saveToTimeTable(grop.Key, sub.Key, teach, classroom,
                                        teachTodayTimes.ToList().GetRange(i, sub.Key.HoursPerWeak));
                            }
                        }
                    }
                }
            }

            // 2nd step
            grps = (from g in this.groupSubjects
                    where this.timeTable.Where(tt =>
                        g.GroupSubjectID ==
                        tt.GroupSubjectID).Count() == 0
                    group g by g.Group)
                     .OrderBy(g => g.Count()).ToList();
            foreach (var grop in grps)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("-----\n{0} : {1}\n\n",
                        "Group", grop.Key.Title));

                var teachs = from gp in grop
                             join st in taali.SubjectTeachers.ToList()
                             on gp.SubjectID equals st.SubjectID
                             where st.Active
                             select st.Teacher;

                //foreach (var tea in teachs.Distinct())
                //    System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                //        " Teacher", tea.ToString()));

                var times = from t in teachs.Distinct()
                            join tt in taali.TimeTeachers.ToList()
                            on t.TeacherID equals tt.TeacherID
                            where tt.Active
                            group tt.UniversityHoldingTime by
                            tt.UniversityHoldingTime.HoldingDay;
                times = times.OrderBy(t => Shamsi.ShamsiDay.FindShamsiDay(t.Key).DayNumber)
                    .OrderByDescending(t => (double)(double)(t.Count() / (double)t.Distinct()
                        .Count()));
                foreach (var ti in times)
                {
                    System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                        " Day", ti.Key));
                    var timteach = from tt in taali.TimeTeachers.ToList()
                                   join uht in taali.UniversityHoldingTimes.ToList()
                                   on tt.TimeID equals uht.HoldingTimeID
                                   where tt.Active && uht.Enabled &&
                                   uht.HoldingDay.Equals(ti.Key)
                                   select tt;
                    var subteach = from tt in timteach.Distinct()
                                   join st in taali.SubjectTeachers.ToList()
                                   on tt.TeacherID equals st.TeacherID
                                   where st.Active
                                   select st;
                    var subs = from gp in grop
                               join st in subteach.Distinct()
                               on gp.SubjectID equals st.SubjectID
                               group st.Teacher by gp.Subject;
                    subs = subs.OrderBy(sub => sub.Distinct().Count());
                    foreach (var sub in subs)
                    {
                        System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                           "  Subject", sub.Key.Title));
                        var theSub = sub.Distinct().OrderBy(t => (from gp in this.groupSubjects
                                                                  join st in taali.SubjectTeachers.ToList()
                                                                      on gp.SubjectID equals st.SubjectID
                                                                  where st.TeacherID == t.TeacherID
                                                                  select gp.Subject).Distinct().Count());
                        foreach (var teach in theSub)
                        {
                            System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                              "   Teacher", teach.ToString()));
                            var teachTodayTimes = (from t in timteach
                                                   where t.TeacherID == teach.TeacherID
                                                    && t.Active && t.UniversityHoldingTime.Enabled
                                                   select t.UniversityHoldingTime).ToList();

                            //foreach (var teacher in teachTodayTimes)
                            //    System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                            //  "    Time", teacher.ToString()));
                            var cells = (from toti in teachTodayTimes
                                         where this.timeTable.Where(tt => tt.GroupSubject.TermYear == this.year
                                         && tt.GroupSubject.Semester == this.semester
                                         && tt.TimeTeacher.UniversityHoldingTime.HoldingDay
                                         == ti.Key && tt.TimeTeacher.TeacherID ==
                                         teach.TeacherID && toti.HoldingTimeID ==
                                         tt.TimeTeacher.TimeID).Count() == 0
                                         select toti).Distinct();
                            if (cells.Count() >= sub.Key.HoursPerWeak)
                            {
                                foreach (var classroom in this.classes)
                                    this.saveToTimeTable(grop.Key, sub.Key, teach, classroom,
                                        cells.OrderBy(uht => uht.StartTime)
                                        .Take(sub.Key.HoursPerWeak));
                            }
                        }
                    }
                }
            }
            // 3rd
            grps = (from g in this.groupSubjects
                    where this.timeTable.Where(tt =>
                        g.GroupSubjectID ==
                        tt.GroupSubjectID).Count() == 0
                    group g by g.Group)
                 .OrderBy(g => g.Count()).ToList();
            foreach (var grop in grps)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("-----\n{0} : {1}\n\n",
                        "Group", grop.Key.Title));

                foreach (var sub in grop)
                {
                    var teachs = from t in this.teachers
                                 join st in taali.SubjectTeachers.ToList()
                                 on t.TeacherID equals st.TeacherID
                                 where st.Active &&
                                 st.SubjectID == sub.SubjectID
                                 select st.Teacher;
                    foreach (var teach in teachs)
                    {
                        var times = from tt in teach.TimeTeachers
                                    where tt.Active && tt.UniversityHoldingTime.Enabled
                                    && this.timeTable.Where(ttab => ttab.GroupSubject.TermYear
                                        == this.year && this.semester ==
                                        ttab.GroupSubject.Semester
                                         && ttab.TimeTeacher.TeacherID ==
                                         teach.TeacherID && tt.TimeTeacherID
                                         == ttab.TimeTeacherID).Count() == 0
                                    && this.timeTable.Where(ttab => ttab.GroupSubject
                                        .GroupID == sub.GroupID && ttab.TimeTeacher.TimeID
                                        == tt.TimeID &&
                                        ttab.GroupSubject.TermYear
                                        == this.year && this.semester ==
                                        ttab.GroupSubject.Semester
                                        ).Count() == 0
                                    group tt.UniversityHoldingTime by
                                        tt.UniversityHoldingTime.HoldingDay;
                        times = times.OrderBy(t => Shamsi.ShamsiDay.FindShamsiDay(t.Key).DayNumber)
                    .OrderByDescending(t => (double)(double)(t.Count() / (double)t.Distinct()
                        .Count()));
                        List<UniversityHoldingTime> uhts = new List<UniversityHoldingTime>();
                        foreach (var ti in times)
                        {
                            foreach (var uht in ti.OrderBy(t => t.StartTime))
                            {
                                uhts.Add(uht);
                            }
                        }
                        if (uhts.Count() >= sub.Subject.HoursPerWeak)
                        {
                            foreach (var classroom in this.classes)
                                this.saveToTimeTable(grop.Key, sub.Subject, teach, classroom,
                                    uhts.Take(sub.Subject.HoursPerWeak));
                        }
                    }
                }
            }
            // delete not completed subjects
            System.Diagnostics.Debug.WriteLine("\n---EndProgramming---\n");
            this.result();

        }

        private void saveToTimeTable(Group group, Subject subject, Teacher teacher, Class classroom,
            IEnumerable<UniversityHoldingTime> times)
        {
            GroupSubject gropsub = this.groupSubjects.Where(gs => gs.GroupID == group.GroupID
                && gs.SubjectID == subject.SubjectID).Single();
            if (this.timeTable.Where(tt => tt.GroupSubjectID == gropsub.GroupSubjectID).Count() != 0)
                return;
            foreach (var time in times)
            {
                if (this.timeTable.Where(tt => tt.TimeTeacher.TimeID == time.HoldingTimeID &&
                    tt.GroupSubject.TermYear == this.year && tt.GroupSubject.Semester == this.semester
                    && tt.GroupSubject.GroupID == group.GroupID).Count() != 0)
                    return;
                if (this.timeTable.Where(tt => tt.TimeTeacher.TeacherID == teacher.TeacherID &&
                    tt.TimeTeacher.TimeID == time.HoldingTimeID && tt.GroupSubject.TermYear ==
                    this.year && tt.GroupSubject.Semester == this.semester).Count() != 0)
                    return;
                if (this.timeTable.Where(tt => tt.ClassID == classroom.ClassID &&
                    tt.TimeTeacher.TimeID == time.HoldingTimeID && tt.GroupSubject.TermYear ==
                    this.year && tt.GroupSubject.Semester == this.semester).Count() != 0)
                    return;
            }
            foreach (var time in times)
            {
                TaaliDataDataContext taali = new TaaliDataDataContext();
                TimeTeacher timeteach = taali.TimeTeachers.Where(tt => tt.TeacherID == teacher.TeacherID
                    && tt.TimeID == time.HoldingTimeID).Single();
                TimeTable table = new TimeTable();
                if (classroom.ClassID != 0 && gropsub.GroupSubjectID != 0
                    && timeteach.TimeTeacherID != 0)
                {
                    table.Class = classroom;
                    table.GroupSubject = gropsub;
                    table.TimeTeacher = timeteach;
                    this.timeTable.Add(table);
                }
            }
        }

       


        private void result()
        {
            if (this.TableForm == null)
            {
                TimeTableForm ttf = new TimeTableForm();
                ttf.MdiParent = this.ParentForm;
                ttf.UniTimeTable = this.timeTable;
                ttf.SetTerm(year, semester);
                ttf.Save();
                ttf.Show();
            }
            else
            {
                this.TableForm.UniTimeTable = this.timeTable;
                this.TableForm.FillGroupComboBox();
                this.TableForm.SetTerm(year, semester);
                this.TableForm.Save();
                this.TableForm.ShowData();
            }
        }
    }
}
