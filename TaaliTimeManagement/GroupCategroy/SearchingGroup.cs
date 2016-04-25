using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.GroupCategroy
{
    public partial class SearchingGroup : TaaliTimeManagement.GroupCategroy.AddingGroup
    {
        public SearchingGroup()
        {
            InitializeComponent();
            this.setAutoComplete();
        }

        public List<Group> Groups;

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            this.TheGroup = new Group();
            this.setData();
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var groups = data.FindGroup(this.TheGroup.Major, this.TheGroup.Title,
                this.TheGroup.EnterYear, this.TheGroup.EnterSemester, this.TheGroup.NumberOfStudent);
            if (groups.Count <= 0)
            {
                MessageBox.Show("هیچ گروهی پیدا نشد.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                return;
            }
            this.Groups = groups;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
