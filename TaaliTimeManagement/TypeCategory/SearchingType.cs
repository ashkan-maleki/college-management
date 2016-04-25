using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.TypeCategory
{
    public partial class SearchingType : TaaliTimeManagement.TypeCategory.AddingType
    {
        public SearchingType()
        {
            InitializeComponent();
        }

        public List<SubjectType> Types;

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            this.setData(new SubjectType());
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var typeList = data.FindType(this.TheType.TypeTitle, this.TheType.Theory);
            if (typeList.Count <= 0)
            {
                MessageBox.Show("نوع درس با این مشخصات یافت نشد.", "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
                return;
            }
            this.Types = typeList;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
