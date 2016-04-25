using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaaliTimeManagement.Management
{
    public partial class SubjectForm : Form
    {
        public SubjectForm()
        {
            InitializeComponent();
            this.groups = new List<Group>();
            this.GroupSubjects = new List<GroupSubject>();
            this.dataSource = new BindingSource();
            this.dataSource.PositionChanged += new EventHandler(dataSource_PositionChanged);
        }

        private void styleView()
        {
            if (this.dataSource.Position == -1)
                return;
            if (this.groups[this.dataSource.Position].Subjects != null &&
                this.groups[this.dataSource.Position].Subjects.Count > 0)
            {
                this.btnDeleteSubject.Enabled = true;
                foreach (var sub in this.groups[this.dataSource.Position].Subjects)
                {
                    if (this.GroupSubjects.Where(gs => gs.SubjectID == sub.SubjectID
                        && gs.GroupID == this.groups[this.dataSource.Position].GroupID)
                        .Count() == 1)
                    {
                        System.Diagnostics.Debug.WriteLine("Position Changed!\n");
                        int gsID = this.GroupSubjects.Where(gs => gs.SubjectID == sub.SubjectID
                            && gs.GroupID == this.groups[this.dataSource.Position].GroupID)
                            .Single().GroupSubjectID;
                        System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                            "ID", gsID));
                        TaaliDataDataContext taali = new TaaliDataDataContext();
                        System.Diagnostics.Debug.WriteLine(string.Format("{0} : {1}\n",
                            "Count", taali.TimeTables.Where(tt => tt.GroupSubjectID == gsID)
                            .Count()));
                        if (taali.TimeTables.Where(tt => tt.GroupSubjectID == gsID).Count() == 0
                            && this.subjectDataGridView.RowCount > 0)
                        {
                            int subIndex = this.groups[this.dataSource.Position].Subjects.IndexOf(sub);
                            this.subjectDataGridView["colSubjectID", subIndex].Style.BackColor =
                    Color.FromKnownColor(KnownColor.InactiveCaption);
                            this.subjectDataGridView["colSubjectID", subIndex].ReadOnly = true;
                            this.subjectDataGridView["colSubjectID", subIndex].ToolTipText =
                                "این درس بدون استاد میباشد.";
                            this.subjectDataGridView["colSubjectTitle", subIndex].Style.BackColor =
                    Color.FromKnownColor(KnownColor.InactiveCaption);
                            this.subjectDataGridView["colSubjectTitle", subIndex].ReadOnly = true;
                            this.subjectDataGridView["colSubjectTitle", subIndex].ToolTipText =
                                "این درس بدون استاد میباشد.";
                        }
                    }
                    else
                    {
                        int subIndex = this.groups[this.dataSource.Position].Subjects.IndexOf(sub);
                        this.subjectDataGridView["colSubjectID", subIndex].Style.BackColor =
                Color.FromKnownColor(KnownColor.InactiveCaption);
                        this.subjectDataGridView["colSubjectID", subIndex].ReadOnly = true;
                        this.subjectDataGridView["colSubjectID", subIndex].ToolTipText =
                            "این درس بدون استاد میباشد.";
                        this.subjectDataGridView["colSubjectTitle", subIndex].Style.BackColor =
                Color.FromKnownColor(KnownColor.InactiveCaption);
                        this.subjectDataGridView["colSubjectTitle", subIndex].ReadOnly = true;
                        this.subjectDataGridView["colSubjectTitle", subIndex].ToolTipText =
                            "این درس بدون استاد میباشد.";
                    }
                }
            }
            else
                this.btnDeleteSubject.Enabled = false;
        }

        void dataSource_PositionChanged(object sender, EventArgs e)
        {
            this.styleView();
        }

        private List<Group> groups { get; set; }
        public List<GroupSubject> GroupSubjects { get; set; }
        private BindingSource dataSource;

        private void refreshGridView()
        {
            this.dataSource.DataSource = this.groups;
        }

        public void SetButtons()
        {
            this.btnBack.Visible = false;
            this.btnCancel.Visible = false;
            int x = (this.Size.Width / 2) - (this.btnOk.Size.Width / 2);
            this.btnOk.Location = new Point(x, this.btnOk.Location.Y);
            this.btnOk.Text = "تایید";
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            this.groups = this.GroupSubjects.Select(gs => gs.Group).Distinct()
                .OrderBy(gs => gs.Title).ToList();
            if (this.groups.Count > 0)
                this.btnDeleteGroup.Enabled = true;
            for (int i = 0; i < this.groups.Count; i++)
            {
                this.groups[i].Subjects = this.GroupSubjects.Where(gs => gs.GroupID
                    == this.groups[i].GroupID).Select(gs => gs.Subject).Distinct()
                .OrderBy(gs => gs.ToString()).ToList();
            }
                this.refreshGridView();
            this.groupDataGridView.DataSource = this.dataSource;
            this.subjectDataGridView.DataSource = this.dataSource;
            this.subjectDataGridView.DataMember = "Subjects";
            this.styleView();


            //TaaliDataDataContext taali = new TaaliDataDataContext();
            //this.dataSource.DataSource = taali.Subjects;
            //this.subjectDataGridView.DataSource = this.dataSource;
            //this.subjectDataGridView.DataMember = "Subject";
            //this.groupDataGridView.DataSource = this.dataSource;
            //this.groupDataGridView.DataMember = "MajorSubjects";
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            GroupCategroy.BaseGroupForm bgf = new GroupCategroy.BaseGroupForm();
            bgf.SetDontShowControls();
            bgf.MultiSelect = true;
            DialogResult dr = bgf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                int id = 0;
                if (bgf.SelectedItems.SelectedItems == null || bgf.SelectedItems.SelectedItems.Count == 0)
                    return;
                if (this.groups == null || this.groups.Count() == 0)
                    this.groups = bgf.SelectedItems.SelectedItems.OrderBy(g => g.Title).ToList();
                else
                {
                    this.groups.AddRange(from g in bgf.SelectedItems.SelectedItems
                                         where this.groups.Where(gr =>
                                                    gr.GroupID == g.GroupID).Count() == 0
                                         select g);
                    this.groups = this.groups.OrderBy(g => g.Title).ToList();
                }
                id = bgf.SelectedItems.SelectedItems[bgf.SelectedItems.SelectedItems.Count - 1].GroupID;
                this.refreshGridView();
                this.dataSource.Position = this.groups.IndexOf(this.groups.Where
                    (g => g.GroupID == id).Single());
                if (this.groupDataGridView.RowCount > 0)
                    this.btnDeleteGroup.Enabled = true;
                this.styleView();
            }
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            int i = this.groupDataGridView.SelectedRows[0].Index;
            this.groups = this.groups.Where(g => g.GroupID != this.groups[i].GroupID)
                .OrderBy(g => g.Title).ToList();
            this.refreshGridView();
            if (this.groupDataGridView.RowCount == 0)
                this.btnDeleteGroup.Enabled = false;
            this.styleView();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (this.groups == null || this.groups.Count == 0 || this.groupDataGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("لطفا یک گروه انتخاب کنید.");
                return;
            }
            GroupSubject subject = new GroupSubject();
            SubjectCategory.BaseSubjectForm bsf = new SubjectCategory.BaseSubjectForm();
            bsf.MultiSelect = true;
            bsf.SetDontShowControls();
            TaaliDataDataContext data = new TaaliDataDataContext();
            bsf.Subjects = data.MajorSubjects.Where(ms => ms.MajorID ==
                this.groups[this.dataSource.Position].MajorID).Select(ms => ms.Subject).ToList();
            DialogResult dr = bsf.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (bsf.SelectedItems.SelectedItems == null || bsf.SelectedItems.SelectedItems.Count == 0)
                    return;
                if (this.groups[this.dataSource.Position].Subjects == null ||
                    this.groups[this.dataSource.Position].Subjects.Count == 0)
                    this.groups[this.dataSource.Position].Subjects = bsf.SelectedItems.SelectedItems
                        .OrderBy(sub => sub.SubjectID).ToList();
                else
                {
                    List<Subject> subs = new List<Subject>();
                    subs.AddRange(this.groups[this.dataSource.Position].Subjects);
                    subs.AddRange(from s in bsf.SelectedItems.SelectedItems
                                  where this.groups[this.dataSource.Position]
                                  .Subjects.Where(su => su.SubjectID ==
                                      s.SubjectID).Count() == 0
                                  select s);
                    this.groups[this.dataSource.Position].Subjects = subs.OrderBy(sub => sub.SubjectID).ToList();
                }
                this.groups = this.groups.OrderBy(g => g.Title).ToList();
                this.refreshGridView();
                this.subjectDataGridView.ClearSelection();
                foreach (var s in bsf.SelectedItems.SelectedItems)
                {
                    int i = this.groups[this.dataSource.Position].Subjects.IndexOf
                        (this.groups[this.dataSource.Position].Subjects.Where
                        (sub => sub.SubjectID == s.SubjectID).Single());
                    this.subjectDataGridView.Rows[i].Selected = true;
                } 
                if (this.subjectDataGridView.RowCount > 0)
                    this.btnDeleteSubject.Enabled = true;
                this.styleView();
            }
            
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in this.subjectDataGridView.SelectedRows)
            {
                int i = row.Index;
                ids.Add(this.groups[this.dataSource.Position].Subjects[i].SubjectID);
            }
            foreach(int id in ids)
                this.groups[this.dataSource.Position].Subjects = this.groups[this.dataSource.Position]
                    .Subjects.Where(s => s.SubjectID != id).ToList();
            this.groups = this.groups.OrderBy(g => g.Title).ToList();
            this.refreshGridView();
            if (this.groupDataGridView.RowCount == 0)
                this.btnDeleteGroup.Enabled = false;
            this.styleView();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.GroupSubjects = new List<GroupSubject>();
            foreach (var gsub in this.groups)
            {
                if (gsub.Subjects != null && gsub.Subjects.Count > 0)
                    this.GroupSubjects.AddRange(gsub.Subjects.Select(sub =>
                        new GroupSubject() { Group = gsub, Subject = sub }));
            }
            if (this.groups.Count == 0 || this.groupDataGridView.RowCount == 0)
            {
                MessageBox.Show("لطفا حداقل یک گروه انتخاب کنید.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading);
                return;
            }
            else
            {
                foreach (var gp in this.groups)
                {
                    if (gp.Subjects == null || gp.Subjects.Count == 0)
                    {
                        string text = string.Format("لطفا برای گروه {0} حداقل یک درس انتخاب کنید.",
                            gp.Title);
                        MessageBox.Show(text, "خطا",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading);
                        return;
                    }
                }
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Retry;
        }


       

        
    }
}
