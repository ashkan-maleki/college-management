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
    public partial class EditingType : TaaliTimeManagement.TypeCategory.AddingType
    {
        public EditingType()
        {
            InitializeComponent();
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            this.setData(taali.SubjectTypes.Where(sts => sts.SubjectTypeID == this.TheType.SubjectTypeID).First());
            if (this.taali == null && this.TheType == null)
                return;
            try
            {
                taali.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("این نوع درس قبلا وجود داشت. لطفا از تغییر به نوع درس تکراری خود داری نمایید.",
                    "خطا",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        protected override void MasterEntryForm_Load(object sender, EventArgs e)
        {
            if (this.TheType == null)
                return;
            this.boxType.Text = this.TheType.TypeTitle.ToString();
            this.boxHours.Text = this.TheType.HoursPerUnit.ToString();
            this.boxPrice.Text = this.TheType.PricePerUnit.ToString();
            this.boxSalary.Text = this.TheType.SalaryPerUnit.ToString();
            this.boxTheoryCheck.Checked = this.TheType.Theory;
        }
    }
}
