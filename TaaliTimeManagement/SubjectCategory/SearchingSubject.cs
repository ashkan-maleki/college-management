using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.SubjectCategory
{
    public partial class SearchingSubject : TaaliTimeManagement.SubjectCategory.AddingSubject
    {
        public SearchingSubject()
        {
            InitializeComponent();
            this.setAutoComplete();
        }

        public List<Subject> Subjects;

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            this.TheSubject = new Subject();
            this.setData();
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var subjects = data.FindSubject(this.TheSubject.Title, this.TheSubject.SubjectType);
            if (subjects.Count <= 0)
            {
                MessageBox.Show("هیچ درسی پیدا نشد.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                return;
            }
            this.Subjects = subjects;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
