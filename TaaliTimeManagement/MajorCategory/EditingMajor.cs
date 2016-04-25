using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.MajorCategory
{
    public partial class EditingMajor : TaaliTimeManagement.MajorCategory.AddingMajor
    {
        public EditingMajor()
        {
            InitializeComponent();
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            this.setData(taali.Majors.Where(cs => cs.MajorID == this.TheMajor.MajorID).First());
            if (this.taali == null && this.TheMajor == null)
                return;
            try
            {
                taali.SubmitChanges();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("این رشته قبلا وجود داشت. لطفا از تغییر به رشته های تکراری خود داری نمایید."
                    , "خطا",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا",
                           MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                           MessageBoxOptions.RtlReading);
            }
            this.setExchangeData();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        protected override void MasterEntryForm_Load(object sender, EventArgs e)
        {
            if (this.TheMajor == null)
                return;
            this.boxMajorLevel.Text = this.TheMajor.MajorLevel;
            this.boxTitle.Text = this.TheMajor.Title;
            this.boxBranch.Text = this.TheMajor.Branch;
        }
    }
}
