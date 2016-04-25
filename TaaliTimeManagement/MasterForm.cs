using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();

            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        protected virtual void btnAdd_Click(object sender, EventArgs e)
        {
        }

        protected virtual void btnFirst_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnNext_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnLast_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnOK_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        protected void setShowControls()
        {
            this.btnOK.Enabled = false;
            this.btnOK.Visible = false;
            this.btnCancel.Enabled = false;
            this.btnCancel.Visible = false;
            this.toolStripSeparator1.Visible = false;
        }

        protected void showForm(Form frmNew)
        {
            frmNew.MdiParent = this.MdiParent;
            if (!frmNew.Equals(null) && !frmNew.IsDisposed)
            frmNew.Show();
        }

        protected void bindDataControls<TItem>(DataGridView dgv, List<TItem> items)
        {
            this.masterSource.DataSource = items;
            dgv.DataSource = masterSource;
            masterBindingNavigator.BindingSource = masterSource;
        }

        protected virtual void MasterForm_Activated(object sender, EventArgs e)
        {

        }

        public void SetDontShowControls()
        {
            this.btnAdd.Visible = false;
            this.btnDelete.Visible = false;
            this.btnEdit.Visible = false;
            this.btnSearch.Visible = false;
            this.btnRefresh.Visible = false;
            this.toolStripSeparator2.Visible = false;
            this.toolStripSeparator3.Visible = false;
        }
        

        
    }
}
