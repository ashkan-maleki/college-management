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
    public partial class TermForm : Form
    {
        public TermForm()
        {
            InitializeComponent();
            //this.taali = new TaaliDataDataContext();
            //if (this.taali.GroupSubjects == null || this.taali.GroupSubjects.Count() == 0)
            //{
            //    this.btnNewTermRadio.Checked = true;
            //    this.groupPreBox.Enabled = false;
            //    this.groupNewBox.Enabled = true;
            //}
            //else
            //{
            //    this.boxPreYearsCombo.Items.AddRange(this.taali.GroupSubjects.
            //        OrderByDescending(gs => gs.TermYear).Select(tt => tt.TermYear.ToString())
            //        .Distinct().ToArray());
            //    this.boxPreYearsCombo.SelectedIndex = this.boxPreYearsCombo.Items.Count - 1;
            //    this.boxPreSemesterCombo.SelectedIndex = this.taali.GroupSubjects
            //        .Where(gs => gs.TermYear == this.taali.GroupSubjects.Max(g => g.TermYear))
            //        .Distinct().Max(gs => gs.Semester) - 1;

            //}
            boxYearMasked.ValidatingType = typeof(int);
            this.boxYearMasked.EmptinessErrorText = "لطفا اطلاعات مربوط به سال را وارد کنید";
            string str = "شما نمی توانید هیچ کاراکتری را به آخر این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را از آخر حذف کنید.";
            this.boxYearMasked.EndOfFieldErrorText = str;
            str = "شما نمی توانید هیچ کاراکتری را به این فیلد اضافه کنید. ";
            str += "برای اضافه کردن، کاراکتری را حذف کنید.";
            this.boxYearMasked.MaskFulErrorText = str;
            this.boxYearMasked.InputCharacterErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";
            this.boxYearMasked.MaskCompletedErrorText = "شما باید این فیلد را تکمیل کنید";
            this.boxYearMasked.TypeInvalidErrorText = "شما فقط می توانید از اعداد استفاده نمایید.";

        }

        //private TaaliDataDataContext taali;
        public byte Year { get; set; }
        public byte Semester { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //if (this.btnPreTermRadio.Checked)
            //{
            //    this.Year = Convert.ToByte(this.boxPreYearsCombo.SelectedItem);
            //    this.Semester = Convert.ToByte(this.boxPreSemesterCombo.SelectedItem);
            //}
            //else
            //{
            if (this.boxYearMasked.CheckEmptinessOrDefault() ||
                !this.checkSemeseter())
            {
                //MessageBox.Show("لطفا اطلاعات مربوط به سال و ترم را وارد کنید.", "خطا",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                //    MessageBoxOptions.RtlReading);
                return;
            }
            this.Year = (byte)this.boxYearMasked.GetNumeric();
            this.Semester = Convert.ToByte(this.boxSemesterCombo.SelectedItem);
            //}
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnPreTermRadio_CheckedChanged(object sender, EventArgs e)
        {
            //    if (this.btnPreTermRadio.Checked)
            //    {
            //        this.groupNewBox.Enabled = true;
            //        this.groupPreBox.Enabled = false;
            //    }
            //    else
            //    {
            //        this.groupNewBox.Enabled = false;
            //        this.groupPreBox.Enabled = true;
            //    }
        }

        private void boxNewSemesterCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar.Equals('1') || e.KeyChar.Equals('2') || e.KeyChar.Equals('3'))
                && e.KeyChar != (int)Keys.Back)
            {
                ToolTip ttp = new ToolTip();
                ttp.InitialDelay = 50;
                ttp.Show("شما فقط می توانید از اعداد 0 تا 9 استفاده کنید.",
                    (ComboBox)sender, 2500);
                e.Handled = true;
            }
        }

        private bool checkSemeseter()
        {
            if (this.boxSemesterCombo.Text.Length == 1)
                this.boxSemesterCombo.SelectedIndex =
                    Convert.ToInt32(this.boxSemesterCombo.Text) - 1;
            if (this.boxSemesterCombo.SelectedIndex == -1)
            {
                ToolTip ttp = new ToolTip();
                ttp.InitialDelay = 50;
                ttp.Show("لطفا اطلاعات مربوط به ترم را وارد کنید.", this.boxSemesterCombo, 3000);
                this.boxSemesterCombo.BackColor = Color.LightPink;
                return false;
            }
            else
            {
                this.boxSemesterCombo.BackColor = Color.FromKnownColor(KnownColor.Window);
                return true;
            }
        }

        private void boxSemesterCombo_Leave(object sender, EventArgs e)
        {
            this.checkSemeseter();
        }
    }
}
