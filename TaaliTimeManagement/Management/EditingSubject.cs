using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.Management
{
    public partial class EditingSubject : TaaliTimeManagement.Management.AddingSubject
    {
        public EditingSubject()
        {
            InitializeComponent();
        }

        private void EditingSubject_Load(object sender, EventArgs e)
        {
            if (this.TheGroup != null)
            {
                this.boxGroup.Text = this.TheGroup.Title;
                this.btnAddGroup.Enabled = false;
                this.btnDeleteGroup.Enabled = true;
                this.btnAddSubject.Enabled = true;
            }
            if (this.TheSubject != null)
            {

                this.boxSubject.Text = this.TheSubject.Title;
                this.btnAddSubject.Enabled = false;
                this.btnDeleteSubject.Enabled = true;
                this.btnAddTeacher.Enabled = true;
            }
            if (this.TheTeacher != null)
            {
                this.boxTeacher.Text = this.TheTeacher.ToString();
                this.btnAddTeacher.Enabled = false;
                this.btnDeleteTeacher.Enabled = true;
                this.btnAddClass.Enabled = true;
            }
            if (this.boxClass != null)
            {
                this.boxClass.Text = this.TheClass.ClassID.ToString();
                this.btnAddClass.Enabled = false;
                this.btnDeleteClass.Enabled = true;
            }

        }
    }
}
