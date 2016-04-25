using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.SubjectCategory
{
    public partial class SubjectForm :TaaliTimeManagement.SubjectCategory.BaseSubjectForm
    {
        public SubjectForm()
        {
            InitializeComponent();
            this.subjectDataGridView.MultiSelect = true;
            this.setShowControls();
        }
    }
}
