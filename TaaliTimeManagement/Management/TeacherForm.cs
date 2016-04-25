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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        public List<Teacher> Teachers { get; set; }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            if (this.Teachers == null)
                this.Teachers = new List<Teacher>();
            this.dataSource.DataSource = this.Teachers;
            this.teacherDataGridView.DataSource = this.dataSource;
            this.bindingTeacherNavigator.BindingSource = this.dataSource;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            TeacherCategory.BaseTeacherForm btf = new TeacherCategory.BaseTeacherForm();
            TaaliDataDataContext taali = new TaaliDataDataContext();
            btf.Teachers = taali.TimeTeachers.Select(tt => tt.Teacher).Distinct()
                .OrderBy(t => t.FirstName).OrderBy(t=> t.LastName).ToList();
            btf.SetDontShowControls();
            btf.MultiSelect = true;
            DialogResult dr = btf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                int id = 0;
                if (btf.SelectedItems.SelectedItems == null || btf.SelectedItems.SelectedItems.Count == 0)
                    return;
                if (this.Teachers == null || this.Teachers.Count() == 0)
                    this.Teachers = btf.SelectedItems.SelectedItems.ToList();
                else
                {
                    this.Teachers.AddRange(from g in btf.SelectedItems.SelectedItems
                                           where this.Teachers.Where(gr =>
                                                      gr.TeacherID == g.TeacherID).Count() == 0
                                           select g);
                }
                this.Teachers = (from t in this.Teachers
                                 orderby t.LastName, t.FirstName
                                 select t).ToList();
                this.dataSource.DataSource = this.Teachers;
                foreach (var s in btf.SelectedItems.SelectedItems)
                {
                    int i = this.Teachers.IndexOf(this.Teachers.Where
                        (t => t.TeacherID == s.TeacherID).Single());
                    this.teacherDataGridView.Rows[i].Selected = true;
                }
                if (this.teacherDataGridView.RowCount > 0)
                    this.btnDeleteTeacher.Enabled = true;
            }
        }


        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < this.teacherDataGridView.SelectedRows.Count; j++)
            {
                int i = this.teacherDataGridView.SelectedRows[j].Index;
                this.Teachers = (from t in this.Teachers
                                 where t.TeacherID != this.Teachers[i].TeacherID
                                 orderby t.LastName, t.FirstName
                                 select t).ToList();
            }
            this.dataSource.DataSource = this.Teachers;
            if (this.teacherDataGridView.RowCount == 0)
                this.btnDeleteTeacher.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.Teachers.Count == 0 || this.teacherDataGridView.RowCount == 0)
            {
                MessageBox.Show("لطفا حداقل یک استاد انتخاب کنید.", "خطا",
                         MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                         MessageBoxOptions.RtlReading);
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Retry;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
