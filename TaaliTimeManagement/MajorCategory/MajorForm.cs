using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.MajorCategory
{
    public partial class MajorForm : TaaliTimeManagement.MajorCategory.BaseMajorForm
    {
        public MajorForm()
        {
            InitializeComponent();
            this.majorDataGridView.MultiSelect = true;
            this.setShowControls();
        }
    }
}
