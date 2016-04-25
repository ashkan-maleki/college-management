using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.ClassCategory
{
    public partial class EditingClass : TaaliTimeManagement.ClassCategory.AddingClass
    {
        public EditingClass()
        {
            InitializeComponent();
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            this.setData(taali.Classes.Where(cs => cs.ClassID == this.TheClass.ClassID).First());
            if (this.taali == null && this.TheClass == null)
                return;
            try
            {
                taali.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        
        protected override void MasterEntryForm_Load(object sender, EventArgs e)
        {
            this.boxID.Enabled = false;
            if (this.TheClass == null)
                return;
            this.boxID.Text = this.TheClass.ClassID.ToString();
            this.boxDepartment.Text = this.TheClass.Department;
            this.boxFloor.Text = this.TheClass.BuildingFloor.ToString();
            this.boxCapacity.Text = this.TheClass.Capacity.ToString();
        }
    }
}
