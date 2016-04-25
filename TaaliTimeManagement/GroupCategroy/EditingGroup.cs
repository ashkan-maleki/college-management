using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.GroupCategroy
{
    public partial class EditingGroup : TaaliTimeManagement.GroupCategroy.AddingGroup
    {
        public EditingGroup()
        {
            InitializeComponent();
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            if (!this.validateTitle())
                return;
            this.TheGroup = taali.Groups.Where(gs => gs.GroupID == this.TheGroup.GroupID).First();
            this.setData();
            if (this.taali == null && this.TheGroup == null)
                return;
            try
            {
                taali.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("این گروه قبلا وجود داشت. لطفا از تغییر به گروه های تکراری خود داری نمایید."
                    , "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.TargetSite + "\n" + ex.Message);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


        protected override void MasterEntryForm_Load(object sender, EventArgs e)
        {
            if (this.TheGroup == null)
                return;
            this.boxMajor.Text = this.TheGroup.Major.ToString();
            this.boxYear.Text = this.TheGroup.EnterYear.ToString();
            this.boxSemester.Text = this.TheGroup.EnterSemester.ToString();
            this.boxGroupTitle.Text = this.TheGroup.Title;
            this.boxNumberOFStudent.Text = this.TheGroup.NumberOfStudent.ToString();
        }

        protected override bool validateTitle()
        {
            ToolTip tt = new ToolTip();
            tt.InitialDelay = 50;
            if (taali.Groups.Where(g => g.Title.Equals(this.boxGroupTitle.Text) &&
                g.GroupID != this.TheGroup.GroupID).Count() != 0)
            {
                this.boxGroupTitle.BackColor = Color.LightPink;
                tt.Show("عنوان مورد نظر شما قبلا برای گروه دیگر ثبت شده.", this.boxGroupTitle, 3000);
                return false;
            }
            else
            {
                tt.RemoveAll();
                this.boxGroupTitle.BackColor = Color.FromKnownColor(KnownColor.Window);
                return true;
            }
        }

        protected override void boxGroupTitle_TextChanged(object sender, EventArgs e)
        {
            this.validateTitle();
        }

        
    }
}
