namespace TaaliTimeManagement.SubjectCategory
{
    partial class BaseSubjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subjectDataGridView = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrerequisitesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajorsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterPanel
            // 
            this.masterPanel.Controls.Add(this.subjectDataGridView);
            this.masterPanel.Size = new System.Drawing.Size(667, 215);
            this.masterPanel.Controls.SetChildIndex(this.subjectDataGridView, 0);
            // 
            // subjectDataGridView
            // 
            this.subjectDataGridView.AllowUserToAddRows = false;
            this.subjectDataGridView.AllowUserToDeleteRows = false;
            this.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTitle,
            this.colType,
            this.colUnits,
            this.colPrerequisitesName,
            this.colSubjectTypeID,
            this.colMajorsName,
            this.colHours});
            this.subjectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectDataGridView.Location = new System.Drawing.Point(0, 0);
            this.subjectDataGridView.MultiSelect = false;
            this.subjectDataGridView.Name = "subjectDataGridView";
            this.subjectDataGridView.ReadOnly = true;
            this.subjectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectDataGridView.Size = new System.Drawing.Size(667, 190);
            this.subjectDataGridView.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.DataPropertyName = "SubjectID";
            this.colID.HeaderText = "کد درس";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.ToolTipText = "کد درس";
            this.colID.Width = 66;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "نام درس";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.Width = 67;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colType.DataPropertyName = "SubjectType";
            this.colType.HeaderText = "نوع درس";
            this.colType.MinimumWidth = 70;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.ToolTipText = "نوع درس";
            this.colType.Width = 71;
            // 
            // colUnits
            // 
            this.colUnits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colUnits.DataPropertyName = "Units";
            this.colUnits.HeaderText = "واحد ها";
            this.colUnits.Name = "colUnits";
            this.colUnits.ReadOnly = true;
            this.colUnits.ToolTipText = "واحد ها";
            this.colUnits.Width = 67;
            // 
            // colPrerequisitesName
            // 
            this.colPrerequisitesName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrerequisitesName.DataPropertyName = "PrerequisitesName";
            this.colPrerequisitesName.HeaderText = "پشنیاز ها";
            this.colPrerequisitesName.Name = "colPrerequisitesName";
            this.colPrerequisitesName.ReadOnly = true;
            this.colPrerequisitesName.ToolTipText = "پشنیاز ها";
            // 
            // colSubjectTypeID
            // 
            this.colSubjectTypeID.DataPropertyName = "SubjectTypeID";
            this.colSubjectTypeID.HeaderText = "SubjectTypeID";
            this.colSubjectTypeID.Name = "colSubjectTypeID";
            this.colSubjectTypeID.ReadOnly = true;
            this.colSubjectTypeID.ToolTipText = "SubjectTypeID";
            this.colSubjectTypeID.Visible = false;
            // 
            // colMajorsName
            // 
            this.colMajorsName.DataPropertyName = "MajorsName";
            this.colMajorsName.HeaderText = "MajorsName";
            this.colMajorsName.Name = "colMajorsName";
            this.colMajorsName.ReadOnly = true;
            this.colMajorsName.ToolTipText = "MajorsName";
            this.colMajorsName.Visible = false;
            // 
            // colHours
            // 
            this.colHours.DataPropertyName = "HoursPerWeak";
            this.colHours.HeaderText = "Hours";
            this.colHours.Name = "colHours";
            this.colHours.ReadOnly = true;
            this.colHours.ToolTipText = "Hours";
            this.colHours.Visible = false;
            // 
            // BaseSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(667, 215);
            this.Name = "BaseSubjectForm";
            this.Text = "درس";
            this.Load += new System.EventHandler(this.BaseSubjectForm_Load);
            this.masterPanel.ResumeLayout(false);
            this.masterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView subjectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrerequisitesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajorsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHours;


    }
}
