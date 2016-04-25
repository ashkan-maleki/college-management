using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.TypeCategory
{
    public partial class TypeForm : TaaliTimeManagement.TypeCategory.BaseTypeForm
    {
        public TypeForm()
        {
            InitializeComponent();
            this.typeDataGridView.MultiSelect = true;
            this.setShowControls();
        }
    }
}
