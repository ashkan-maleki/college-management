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
    public partial class AddingClass : TaaliTimeManagement.MasterEntryForm
    {
        public AddingClass()
        {
            InitializeComponent();
            this.taali = new TaaliDataDataContext();
        }

        protected TaaliDataDataContext taali;
        public Class TheClass { get; set; }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            this.setData(new Class());
            if (this.taali == null && this.TheClass == null)
                return;
            try
            {
            taali.Classes.InsertOnSubmit(this.TheClass);
            taali.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("لطفا کلاس با شماره تکراری وارد نکنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        protected void setData(Class c)
        {
            this.TheClass = c;
            if (!this.boxID.IsEmptyOrWhiteSpace && this.boxID.IsNumeric())
                this.TheClass.ClassID = Convert.ToInt32(this.boxID.NumericText);
            this.TheClass.Department = this.boxDepartment.Text;
            if (!this.boxCapacity.IsEmptyOrWhiteSpace && this.boxCapacity.IsNumeric())
                this.TheClass.Capacity = Convert.ToInt32(this.boxCapacity.NumericText);
            if (!string.IsNullOrWhiteSpace(boxFloor.NumericText))
                this.TheClass.BuildingFloor = Convert.ToInt32(boxFloor.NumericText);
        }

        protected bool boxValidation()
        {
            if (this.boxID.CheckEmptinessOrDefault() || this.boxCapacity.CheckEmptinessOrDefault())
                return false;
            if (!this.boxCapacity.CheckNumeric() && !this.boxID.CheckNumeric() && !this.boxFloor.CheckNumeric())
                return false;
            return true;
        }

        protected void setAutoComplete()
        {
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var id = from c in data.ClassList()
                     select c.ClassID.ToString();
            if (id != null && id.Count() > 0)
                boxID.AutoCompleteCustomSource.AddRange(id.ToArray());
            var department = from c in data.ClassList()
                             where c.Department != null && !c.Department.Equals("")
                             select c.Department;
            if (department != null && department.Count() > 0)
                boxDepartment.AutoCompleteCustomSource.AddRange(department.ToArray());
            var floor = from c in data.ClassList()
                         where c.BuildingFloor != null
                        select c.BuildingFloor.ToString();
            if (floor != null && floor.Count() > 0)
                boxFloor.AutoCompleteCustomSource.AddRange(floor.ToArray());
            var capacity = from c in data.ClassList()
                           select c.Capacity.ToString();
            if (capacity != null && capacity.Count() > 0)
                boxCapacity.AutoCompleteCustomSource.AddRange(capacity.ToArray());
        }

        private void box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (int)Keys.Back)
                {
                    ToolTip ttp = new ToolTip();
                    ttp.InitialDelay = 50;
                    ttp.Show("شما فقط می توانید از اعداد 0 تا 9 استفاده کنید.",
                        (WiseTextBox.WiseTextBox)sender, 2500);
                    e.Handled = true;
                }
            }
        }

        
         
    }
}
