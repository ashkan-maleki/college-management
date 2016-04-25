 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.SubjectCategory
{
    public partial class BaseSubjectForm : TaaliTimeManagement.MasterForm
    {
        public BaseSubjectForm()
        {
            InitializeComponent();
            this.subjectDataGridView.AutoGenerateColumns = true;
            this.bindDataControls(this.subjectDataGridView, this.Subjects);
            this.SelectedItems = new TaaliClasses.SelectionBinding<Subject>(this.subjectDataGridView, this.Subjects);
            this.subjectDataGridView.MultiSelect = false;
            this.SelectedSubjects = new List<Subject>();
            this.cellStyling();
        }

        protected TaaliDataDataContext taali = new TaaliDataDataContext();
        public List<Subject> Subjects = new TaaliClasses.DataList().SubjectList();
        public TaaliClasses.SelectionBinding<Subject> SelectedItems;
        protected List<Subject> SelectedSubjects;

         public bool MultiSelect
        {
            get
            {
                return this.subjectDataGridView.MultiSelect;
            }
            set
            {
                this.subjectDataGridView.MultiSelect = value;
            }
        }

        protected void selectData()
        {
            this.subjectDataGridView.ClearSelection();
            if (this.SelectedSubjects == null || this.SelectedSubjects.Count == 0)
            {
                if (this.subjectDataGridView.RowCount > 0)
                    this.subjectDataGridView.Rows[0].Selected = true;
                return;
            }
            foreach (Subject s in this.SelectedSubjects)
            {
                int j = -1;
                if (this.Subjects.Where(ss => ss.SubjectID == s.SubjectID).Count() > 0)
                    j = this.Subjects.IndexOf(this.Subjects.Where(ss => ss.SubjectID == s.SubjectID).Single());
                if (j > -1)
                    this.subjectDataGridView.Rows[j].Selected = true;
            }
        }

        private void refreshSelectedBinding()
        {
            this.Subjects = new TaaliClasses.DataList().SubjectList();
            this.bindDataControls(this.subjectDataGridView, this.Subjects);
            this.SelectedItems.Refresh(this.subjectDataGridView, this.Subjects);
            this.cellStyling();
        }

        protected override void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshSelectedBinding();
        }

        protected override void MasterForm_Activated(object sender, EventArgs e)
        {
            //this.refreshSelectedBinding();
            //this.selectData();
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            AddingSubject ag = new AddingSubject();
            if (ag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectedSubjects = new List<Subject>();
                this.SelectedSubjects.Add(ag.TheSubject);
                this.refreshSelectedBinding();
                this.selectData();
            }
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (subjectDataGridView.RowCount > 1 && subjectDataGridView.SelectedRows.Count != 1)
                    throw new Exception("لطفا فقط یک درس انتخاب کنید.");
                if (!(subjectDataGridView.SelectedRows[0].Index <= subjectDataGridView.RowCount - 1))
                    throw new Exception("لطفا یک درس از درس های موجود را انتخاب کنید.");
                if (this.SelectedItems.SelectedItems != null && this.SelectedItems.SelectedItems.Count() != 1)
                    throw new Exception();
                EditingSubject es = new EditingSubject();
                es.TheSubject = this.SelectedItems.SelectedItems.First();
                if (es.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.SelectedSubjects = new List<Subject>();
                    this.SelectedSubjects.Add(es.TheSubject);
                    this.refreshSelectedBinding();
                    this.selectData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
            }
        }

        protected override void btnSearch_Click(object sender, EventArgs e)
        {
            SearchingSubject ss = new SearchingSubject();
            if (ss.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectedSubjects = ss.Subjects;
                this.refreshSelectedBinding();
                this.selectData();
            }
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
                DialogResult dr = MessageBox.Show(this, "آیا مایل به حذف این درس هستید؟", "", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
                if (dr == System.Windows.Forms.DialogResult.No)
                    return;
                if (subjectDataGridView.RowCount > 1 && subjectDataGridView.SelectedRows.Count <= 0)
                    throw new Exception("لطفا حداقل یک درس انتخاب کنید.");
                if (this.SelectedItems.SelectedItems != null && this.SelectedItems.SelectedItems.Count() <= 0)
                    throw new Exception();
                for (int j = 0; j < subjectDataGridView.RowCount; j++)
                    if (!(subjectDataGridView.SelectedRows[0].Index <= subjectDataGridView.RowCount - 1))
                        throw new Exception("لطفا حداقل یک درس از درس های موجود را انتخاب کنید.");
                List<Subject> ss = new List<Subject>();
                foreach (Subject s in this.SelectedItems.SelectedItems)
                {
                    foreach (var m in s.MajorSubjects)
                    {
                        var delete = this.taali.MajorSubjects.Where(ms => ms.ID == m.ID);
                        if (delete != null && delete.Count() > 0)
                            this.taali.MajorSubjects.DeleteAllOnSubmit(delete);
                    }
                    foreach (var p in s.Prerequisites)
                    {
                        var delete = this.taali.Prerequisites.Where(ps =>
                            ps.PrerequisiteSubjectID == p.PrerequisiteSubjectID);
                        if (delete != null && delete.Count() > 0)
                            this.taali.Prerequisites.DeleteAllOnSubmit(delete);
                    }
                    foreach (var p in s.Prerequisites1)
                    {
                        var delete = this.taali.Prerequisites.Where(ps =>
                            ps.PrerequisiteSubjectID == p.PrerequisiteSubjectID);
                        if (delete != null && delete.Count() > 0)
                            this.taali.Prerequisites.DeleteAllOnSubmit(delete);
                    }
                    foreach (var st in s.SubjectTeachers)
                    {
                        var delete = this.taali.SubjectTeachers.Where(sts => sts.ID == st.ID);
                        if (delete != null && delete.Count() > 0)
                            this.taali.SubjectTeachers.DeleteAllOnSubmit(delete);
                    }
                    foreach (var gs in s.GroupSubjects)
                    {
                        foreach (var tt in gs.TimeTables)
                        {
                            var deleteCell = this.taali.TimeTables.Where(tts => tts.ID == tt.ID);
                            if (deleteCell != null && deleteCell.Count() > 0)
                                this.taali.TimeTables.DeleteAllOnSubmit(deleteCell);
                        }
                        var delete = this.taali.GroupSubjects.Where(gss => gss.GroupSubjectID
                            == gs.GroupSubjectID);
                        if (delete != null && delete.Count() > 0)
                            this.taali.GroupSubjects.DeleteAllOnSubmit(delete);
                    }
                }
                foreach (Subject s in this.SelectedItems.SelectedItems)
                {
                    ss.AddRange(from v in taali.Subjects
                                where v.SubjectID == s.SubjectID
                                select v);
                }
                taali.Subjects.DeleteAllOnSubmit(ss);
                taali.SubmitChanges();
                this.refreshSelectedBinding();
            //}
            //catch (System.Data.SqlClient.SqlException ex)
            //{
            //    string message = "شما نمی توانید این درس را حذف کنید. ";
            //    message += "بدین دلیل که از این درس در جدول های دیگر استفاده شده.";
            //    MessageBox.Show(message, "خطا",
            //           MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
            //           MessageBoxOptions.RtlReading);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا",
            //           MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
            //           MessageBoxOptions.RtlReading);
            //}
        }

        protected void cellStyling()
        {
            string str = "این درس برای رشته های زیر می باشد:";
            str = str + "\n";
            for (int i = 0; i < this.subjectDataGridView.RowCount; i++)
                for (int j = 0; j < this.subjectDataGridView.ColumnCount; j++)
                    this.subjectDataGridView[j, i].ToolTipText = str + this.Subjects[i].MajorsName;
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void BaseSubjectForm_Load(object sender, EventArgs e)
        {
            this.bindDataControls(this.subjectDataGridView, this.Subjects);
            this.SelectedItems.Refresh(this.subjectDataGridView, this.Subjects);
            this.cellStyling();
        }
    }
}
