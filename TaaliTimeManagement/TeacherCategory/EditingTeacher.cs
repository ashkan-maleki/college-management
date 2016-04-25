using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.TeacherCategory
{
    public partial class EditingTeacher : TaaliTimeManagement.TeacherCategory.AddingTeacher
    {
        public EditingTeacher()
        {
            InitializeComponent();
            if (boxSubjectsCombo.Items.Count >= 0)
                this.btnDeleteSubjects.Enabled = true;
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            this.TheTeacher = this.taali.Teachers.Where(t => t.TeacherID == this.TheTeacher.TeacherID).Single();
            this.setData();
            if (this.taali == null && this.TheTeacher == null)
                return;
            try
            {
                taali.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("مشخصات این استاد قبلا وجود داشت. لطفا از تغییر به استاد های تکراری خود داری نمایید.",
                    "خطا",  MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.TargetSite + "\n" + ex.Message);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


        protected override void MasterEntryForm_Load(object sender, EventArgs e)
        {
            if (this.TheTeacher == null)
                return;
            this.TheTeacher = taali.Teachers.Where(t => t.TeacherID == this.TheTeacher.TeacherID).First();
            this.boxFirstName.Text = this.TheTeacher.FirstName;
            this.boxLastName.Text = this.TheTeacher.LastName;
            this.times = this.TheTeacher.TimeTeachers.Where(tt => tt.Active && tt.UniversityHoldingTime.Enabled)
                .Select(tt => tt.UniversityHoldingTime).ToList();
            if (this.times != null && this.times.Count > 0)
                this.boxTimesCombo.Items.AddRange(this.times.Select(t => t.ToString()).ToArray());
            if (this.boxTimesCombo.Items.Count > 0)
                this.boxTimesCombo.SelectedIndex = 0;
            this.subjects = this.TheTeacher.SubjectTeachers.Where(st => st.Active)
                .Select(tt => tt.Subject).ToList();
            if (this.subjects != null && this.subjects.Count > 0)
                this.boxSubjectsCombo.Items.AddRange(this.subjects.Select(s => s.ToString()).ToArray());
            if (this.boxSubjectsCombo.Items.Count > 0)
                this.boxSubjectsCombo.SelectedIndex = 0;
        }
    }
}
