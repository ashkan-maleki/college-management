using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.MajorCategory
{
    public partial class SearchingMajor : TaaliTimeManagement.MajorCategory.AddingMajor
    {
        public SearchingMajor()
        {
            InitializeComponent();
        }
        public List<Major> Majors;

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            this.setData(new Major());
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var majors = data.FindMajor(this.TheMajor.MajorLevel,
                this.TheMajor.Title, this.TheMajor.Branch);
            if (majors.Count <= 0)
            {
                MessageBox.Show("رشته تحصیلی با این مشخصات وجود ندارد.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                return;
            }
            //TaaliClasses.DataExchange.Majors = majors;
            this.Majors = majors;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
