using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.GroupCategroy
{
    public partial class GroupForm : TaaliTimeManagement.GroupCategroy.BaseGroupForm
    {
        public GroupForm()
        {
            InitializeComponent();
            this.groupDataGridView.MultiSelect = true;
            this.setShowControls();
        }
    }
}
