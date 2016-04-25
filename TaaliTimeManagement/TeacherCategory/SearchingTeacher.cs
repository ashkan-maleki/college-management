using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.TeacherCategory
{
    public partial class SearchingTeacher : TaaliTimeManagement.TeacherCategory.AddingTeacher
    {
        public SearchingTeacher()
        {
            InitializeComponent();
        }

        public List<Teacher> Teachers;

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            this.TheTeacher = new Teacher();
            this.setData();
            TaaliClasses.DataList data = new TaaliClasses.DataList();
            var teachers = data.FindTeacher(this.TheTeacher.FirstName, this.TheTeacher.LastName);
            if (teachers.Count <= 0)
            {
                MessageBox.Show("هیچ استادی با این مشخصات یافت نشد.", "خطا",
                       MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
                return;
            }
            this.Teachers = teachers;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
