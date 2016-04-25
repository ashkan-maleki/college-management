using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.TeacherCategory
{
    public partial class TeacherForm : TaaliTimeManagement.TeacherCategory.BaseTeacherForm
    {
        public TeacherForm()
        {
            InitializeComponent();
            this.teacherDataGridView.MultiSelect = true;
            this.setShowControls();
        }
    }
}
