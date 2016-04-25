using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.TeacherCategory
{
    public partial class BaseTeacherForm : TaaliTimeManagement.MasterForm
    {
        public BaseTeacherForm()
        {
            InitializeComponent();
            this.Teachers = new TaaliClasses.DataList().TeacherList();
            this.bindDataControls(this.teacherDataGridView, this.Teachers);
            this.SelectedItems = new TaaliClasses.SelectionBinding<Teacher>(this.teacherDataGridView, this.Teachers);
            this.teacherDataGridView.MultiSelect = false;
            this.SelectedTeachers = new List<Teacher>();
        }

        protected TaaliDataDataContext taali = new TaaliDataDataContext();
        public List<Teacher> Teachers;
        public TaaliClasses.SelectionBinding<Teacher> SelectedItems;
        protected List<Teacher> SelectedTeachers;

        public bool MultiSelect
        {
            get
            {
                return this.teacherDataGridView.MultiSelect;
            }
            set
            {
                this.teacherDataGridView.MultiSelect = value;
            }
        }

        protected void selectData()
        {
            this.teacherDataGridView.ClearSelection();
            if (this.SelectedTeachers == null || this.SelectedTeachers.Count == 0)
            {
                if (this.teacherDataGridView.RowCount > 0)
                    this.teacherDataGridView.Rows[0].Selected = true;
                return;
            }
            foreach (Teacher s in this.SelectedTeachers)
            {
                int j = -1;
                if (this.Teachers.Where(ts => ts.TeacherID == s.TeacherID).Count() > 0)
                    j = this.Teachers.IndexOf(this.Teachers.Where(ts => ts.TeacherID == s.TeacherID).Single());
                if (j > -1)
                    this.teacherDataGridView.Rows[j].Selected = true;
            }
        }

        private void refreshSelectedBinding()
        {
            this.Teachers = new TaaliClasses.DataList().TeacherList();
            this.bindDataControls(this.teacherDataGridView, this.Teachers);
            this.SelectedItems.Refresh(this.teacherDataGridView, this.Teachers);
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
            TeacherCategory.AddingTeacher ag = new TeacherCategory.AddingTeacher();
            if (ag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectedTeachers = new List<Teacher>();
                this.SelectedTeachers.Add(ag.TheTeacher);
                refreshSelectedBinding();
                this.selectData();
            }
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (teacherDataGridView.RowCount > 1 && teacherDataGridView.SelectedRows.Count != 1)
                    throw new Exception("لطفا فقط یک استاد انتخاب کنید.");
                if (!(teacherDataGridView.SelectedRows[0].Index <= teacherDataGridView.RowCount - 1))
                    throw new Exception("لطفا یک استاد از استاد های موجود را انتخاب کنید.");
                if (this.SelectedItems.SelectedItems != null && this.SelectedItems.SelectedItems.Count() != 1)
                    throw new Exception();
                TeacherCategory.EditingTeacher et = new TeacherCategory.EditingTeacher();
                et.TheTeacher = this.SelectedItems.SelectedItems.First();
                if (et.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.SelectedTeachers = new List<Teacher>();
                    this.SelectedTeachers.Add(et.TheTeacher);
                    refreshSelectedBinding();
                    this.selectData();
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا",
            //           MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
            //           MessageBoxOptions.RtlReading);
            //}
        }

        protected override void btnSearch_Click(object sender, EventArgs e)
        {
            TeacherCategory.SearchingTeacher st = new TeacherCategory.SearchingTeacher();
            if (st.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.SelectedTeachers = st.Teachers;
                refreshSelectedBinding();
                this.selectData();
            }
        }

        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this, "آیا مایل به حذف این استاد هستید؟", "", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
                if (dr == System.Windows.Forms.DialogResult.No)
                    return;
                if (teacherDataGridView.RowCount > 1 && teacherDataGridView.SelectedRows.Count <= 0)
                    throw new Exception("لطفا حداقل یک استاد انتخاب کنید.");
                if (this.SelectedItems.SelectedItems != null && this.SelectedItems.SelectedItems.Count() <= 0)
                    throw new Exception();
                for (int j = 0; j < teacherDataGridView.RowCount; j++)
                    if (!(teacherDataGridView.SelectedRows[0].Index <= teacherDataGridView.RowCount - 1))
                        throw new Exception("لطفا حداقل یک استاد از استاد های موجود را انتخاب کنید.");
                List<Teacher> ts = new List<Teacher>();
                foreach (Teacher t in this.SelectedItems.SelectedItems)
                {
                    ts.AddRange(from v in taali.Teachers
                                where v.TeacherID == t.TeacherID
                                select v);
                    foreach (var time in t.TimeTeachers)
                    {
                        this.taali.TimeTables.DeleteAllOnSubmit(this.taali.TimeTables
                            .Where(tt => tt.TimeTeacherID == time.TimeTeacherID));
                        var delete = this.taali.TimeTeachers.Where(tt => tt.TimeTeacherID == 
                            time.TimeTeacherID);
                        if (delete != null && delete.Count() > 0)
                            this.taali.TimeTeachers.DeleteAllOnSubmit(delete);
                    }
                    foreach (var sub in t.SubjectTeachers)
                    {
                        var delete = this.taali.SubjectTeachers.Where(s => s.ID == sub.ID);
                        if (delete != null && delete.Count() > 0)
                            this.taali.SubjectTeachers.DeleteAllOnSubmit(delete);
                    }
                }
                taali.Teachers.DeleteAllOnSubmit(ts);
                taali.SubmitChanges();
                this.refreshSelectedBinding();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string message = "شما نمی توانید این استاد را حذف کنید. ";
                message += "بدین دلیل که از این استاد در جدول های دیگر استفاده شده.";
                MessageBox.Show(message, "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
            }
        }

        

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        protected override void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void BaseTeacherForm_Load(object sender, EventArgs e)
        {
            this.bindDataControls(this.teacherDataGridView, this.Teachers);
            this.SelectedItems = new TaaliClasses.SelectionBinding<Teacher>(this.teacherDataGridView, this.Teachers);
        }
    }
}
