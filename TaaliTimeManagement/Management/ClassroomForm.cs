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
    public partial class ClassroomForm : Form
    {
        public ClassroomForm()
        {
            InitializeComponent();
        }

        public List<Class> Classes { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.Classes == null)
                this.Classes = new List<Class>();
            if (this.Classes.Count == 0)
            {
                TaaliDataDataContext taali = new TaaliDataDataContext();
                this.Classes = taali.Classes.ToList();
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

        private void ClassroomForm_Load(object sender, EventArgs e)
        {
            if (this.Classes == null)
                this.Classes = new List<Class>();
            this.dataSource.DataSource = this.Classes;
            this.classDataGridView.DataSource = this.dataSource;
            this.bindingClassNavigator.BindingSource = this.dataSource;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            ClassCategory.BaseClassForm bcf = new ClassCategory.BaseClassForm();
            TaaliDataDataContext taali = new TaaliDataDataContext();
            bcf.SetDontShowControls();
            DialogResult dr = bcf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (bcf.SelectedClasses.SelectedItems == null || bcf.SelectedClasses.SelectedItems.Count == 0)
                    return;
                if (this.Classes == null || this.Classes.Count() == 0)
                    this.Classes = bcf.SelectedClasses.SelectedItems.ToList();
                else
                {
                    this.Classes.AddRange(from c in bcf.SelectedClasses.SelectedItems
                                          where this.Classes.Where(gr =>
                                                     gr.ClassID == c.ClassID).Count() == 0
                                          select c);
                }
                this.Classes = (from t in this.Classes
                                orderby t.ClassID
                                select t).ToList();
                this.dataSource.DataSource = this.Classes;
                foreach (var s in bcf.SelectedClasses.SelectedItems)
                {
                    int i = this.Classes.IndexOf(this.Classes.Where
                        (t => t.ClassID == s.ClassID).Single());
                    this.classDataGridView.Rows[i].Selected = true;
                }
                if (this.classDataGridView.RowCount > 0)
                    this.btnDeleteClass.Enabled = true;
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < this.classDataGridView.SelectedRows.Count; j++)
            {
                int i = this.classDataGridView.SelectedRows[j].Index;
                this.Classes = (from c in this.Classes
                                where c.ClassID != this.Classes[i].ClassID
                                orderby c.ClassID
                                select c).ToList();
            }
            this.dataSource.DataSource = this.Classes;
            if (this.classDataGridView.RowCount == 0)
                this.btnDeleteClass.Enabled = false;
        }

    }
}
