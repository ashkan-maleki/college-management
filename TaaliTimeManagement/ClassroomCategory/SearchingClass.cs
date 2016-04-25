using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.ClassCategory
{
    public partial class SearchingClass : TaaliTimeManagement.ClassCategory.AddingClass
    {
        public SearchingClass()
        {
            InitializeComponent();
            this.setAutoComplete();
        }

        public List<Class> Classes { get; set;}

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            this.setData(new Class());
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var cList = data.FindClass(this.TheClass.ClassID,
                this.TheClass.Department, this.TheClass.BuildingFloor, this.TheClass.Capacity);
            if (cList.Count <= 0)
            {
                MessageBox.Show("هیج کلاسی با ابن مشخصات یافت نشد.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                return;
            }
            this.Classes = cList;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
