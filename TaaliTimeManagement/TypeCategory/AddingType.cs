using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.TypeCategory
{
    public partial class AddingType : TaaliTimeManagement.MasterEntryForm
    {
        public AddingType()
        {
            InitializeComponent();
            this.taali = new TaaliDataDataContext();
            this.setAutoComplete();
        }

        protected TaaliDataDataContext taali;
        public SubjectType TheType { get; set; }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            this.setData(new SubjectType());
            if (this.taali == null && this.TheType == null)
                return;
            try
            {
                taali.SubjectTypes.InsertOnSubmit(this.TheType);
                taali.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("لطفا نوع درس با مشخصات تکراری وارد نکنید.", "خطا",
                      MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                      MessageBoxOptions.RtlReading);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        protected void setData(SubjectType st)
        {
            this.TheType = st;
            if (!this.boxType.IsEmptyOrWhiteSpace )
                this.TheType.TypeTitle = this.boxType.Text;
            if (!this.boxHours.IsEmptyOrWhiteSpace && this.boxHours.IsNumeric())
                this.TheType.HoursPerUnit = Convert.ToByte(this.boxHours.NumericText);
            if (!this.boxSalary.IsEmptyOrWhiteSpace && this.boxSalary.IsNumeric())
                this.TheType.SalaryPerUnit = Convert.ToInt32(this.boxSalary.NumericText);
            if (!this.boxPrice.IsEmptyOrWhiteSpace && this.boxPrice.IsNumeric())
                this.TheType.PricePerUnit = Convert.ToInt32(this.boxPrice.NumericText);
            this.TheType.Theory = this.boxTheoryCheck.Checked;
        }

        protected bool boxValidation()
        {
            if (this.boxType.CheckEmptinessOrDefault() || this.boxHours.CheckEmptinessOrDefault() ||
                this.boxPrice.CheckEmptinessOrDefault() || this.boxSalary.CheckEmptinessOrDefault())
                return false;
            if (!this.boxHours.CheckNumeric() && !this.boxSalary.CheckNumeric() && !this.boxPrice.CheckNumeric())
                return false;
            return true;
        }

        protected void setAutoComplete()
        {
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var typeTitle = from t in data.TypeList()
                     select t.TypeTitle;
            if (typeTitle != null && typeTitle.Count() > 0)
                boxType.AutoCompleteCustomSource.AddRange(typeTitle.ToArray());
            var hours = from t in data.TypeList()
                             select t.HoursPerUnit.ToString();
            if (hours != null && hours.Count() > 0)
                boxHours.AutoCompleteCustomSource.AddRange(hours.ToArray());
            var salary = from t in data.TypeList()
                        select t.SalaryPerUnit.ToString();
            if (salary != null && salary.Count() > 0)
                boxSalary.AutoCompleteCustomSource.AddRange(salary.ToArray());
            var price = from t in data.TypeList()
                           select t.PricePerUnit.ToString();
            if (price != null && price.Count() > 0)
                boxPrice.AutoCompleteCustomSource.AddRange(price.ToArray());
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
