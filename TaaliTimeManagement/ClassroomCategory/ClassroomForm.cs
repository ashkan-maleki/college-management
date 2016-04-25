using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.ClassCategory
{
    public partial class ClassroomForm : TaaliTimeManagement.ClassCategory.BaseClassForm
    {
        public ClassroomForm()
        {
            InitializeComponent();
            this.classDataGridView.MultiSelect = true;
            this.setShowControls();
        }
    }
}
