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
    public partial class EditingSubject : TaaliTimeManagement.SubjectCategory.AddingSubject
    {
        public EditingSubject()
        {
            InitializeComponent();
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (!this.boxValidation())
                return;
            this.TheSubject = taali.Subjects.Where(s => s.SubjectID == this.TheSubject.SubjectID).First();
            this.setData();
            if (this.taali == null && this.TheSubject == null)
                return;
            try
            {
                foreach (var m in this.TheSubject.MajorSubjects)
                {
                    if (this.majors.Where(ms => ms.MajorID == m.MajorID)
                         .Count() == 0)
                    {
                        var deleteMajors = this.taali.MajorSubjects.Where
                            (ms => ms.ID == m.ID);
                        if (deleteMajors != null && deleteMajors.Count() > 0)
                            this.taali.MajorSubjects.DeleteAllOnSubmit(deleteMajors);
                    }
                }
                foreach (var p in this.TheSubject.Prerequisites)
                {
                    if (this.prerequisites.Where(pr => pr.SubjectID == p.PrerequisiteSubjectID)
                        .Count() == 0)
                    {
                        var deletePrerequisites = this.taali.Prerequisites.Where
                            (pr => pr.PrerequisiteID == p.PrerequisiteID);
                        if (deletePrerequisites != null && deletePrerequisites.Count() > 0)
                            this.taali.Prerequisites.DeleteAllOnSubmit(deletePrerequisites);
                    }
                }
                taali.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("این درس قبلا وجود داشت. لطفا از تغییر به درس های تکراری خود داری نمایید.",
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
            if (this.TheSubject == null)
                return;
            this.boxIDMask.Text = this.TheSubject.SubjectID.ToString();
            this.boxTitle.Text = this.TheSubject.Title;
            this.boxType.Text = this.TheSubject.SubjectType.ToString();
            this.boxUnitsNumberMask.Text = this.TheSubject.Units.ToString();
            this.majors = this.TheSubject.MajorSubjects.OrderBy(ms => ms.Major.ToString())
                .Select(m => m.Major).ToList();
            if (this.majors != null && this.majors.Count > 0)
                this.boxMajorCombo.Items.AddRange(this.majors.Select(m => m.ToString()).ToArray());
            if (this.boxMajorCombo.Items.Count > 0)
                this.boxMajorCombo.SelectedIndex = 0;
            this.prerequisites = this.TheSubject.Prerequisites.OrderBy(p => p.Subject1.Title)
                .Select(p => p.Subject1).ToList();
            if (this.prerequisites != null && this.prerequisites.Count > 0)
                this.boxPrerequisitesCombo.Items.AddRange(this.prerequisites.Select(p => p.Title).ToArray());
            if (this.boxPrerequisitesCombo.Items.Count > 0)
                this.boxPrerequisitesCombo.SelectedIndex = 0;
            if (this.boxMajorCombo.Items.Count > 1)
                this.btnDeleteMajor.Enabled = true;
            if (this.boxPrerequisitesCombo.Items.Count > 0)
                this.btnDeletePrerequisites.Enabled = true;
            this.subjectType = this.TheSubject.SubjectType;
            this.boxMajorCombo_SelectedIndexChanged(null, null);
        }
        protected override void boxIDMask_Validated(object sender, EventArgs e)
        {
          
        }

        protected override void boxMajorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var groups = taali.Groups.ToList().Where(g => g.Major.ToString() == this.boxMajorCombo.Text);
            var grupCount = (from g in groups
                             where taali.GroupSubjects
                             .Where(gs => gs.GroupID
                                 == g.GroupID && gs.SubjectID
                                 == this.TheSubject.SubjectID)
                                 .Count() != 0
                             select g).Count();
            this.btnDeleteMajor.Enabled = grupCount == 0;
        }
    }
}
