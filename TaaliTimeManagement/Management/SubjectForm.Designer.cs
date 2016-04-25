namespace TaaliTimeManagement.Management
{
    partial class SubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupDataGridView = new System.Windows.Forms.DataGridView();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnterYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnterSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOfStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridView = new System.Windows.Forms.DataGridView();
            this.colMajorsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoursPerWeak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrerequisitesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(93, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "بازگشت";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(174, 402);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "بعدی";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.groupDataGridView);
            this.panel1.Controls.Add(this.subjectDataGridView);
            this.panel1.Location = new System.Drawing.Point(53, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 295);
            this.panel1.TabIndex = 4;
            // 
            // groupDataGridView
            // 
            this.groupDataGridView.AllowUserToAddRows = false;
            this.groupDataGridView.AllowUserToDeleteRows = false;
            this.groupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitle,
            this.colGroupID,
            this.colMajorID,
            this.colEnterYear,
            this.colEnterSemester,
            this.colNumberOfStudent,
            this.colMajor});
            this.groupDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupDataGridView.Location = new System.Drawing.Point(0, 0);
            this.groupDataGridView.MultiSelect = false;
            this.groupDataGridView.Name = "groupDataGridView";
            this.groupDataGridView.ReadOnly = true;
            this.groupDataGridView.RowHeadersVisible = false;
            this.groupDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupDataGridView.Size = new System.Drawing.Size(285, 295);
            this.groupDataGridView.TabIndex = 2;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "نام گروه";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.ToolTipText = "نام گروه";
            // 
            // colGroupID
            // 
            this.colGroupID.DataPropertyName = "GroupID";
            this.colGroupID.HeaderText = "GroupID";
            this.colGroupID.Name = "colGroupID";
            this.colGroupID.ReadOnly = true;
            this.colGroupID.ToolTipText = "GroupID";
            this.colGroupID.Visible = false;
            // 
            // colMajorID
            // 
            this.colMajorID.DataPropertyName = "MajorID";
            this.colMajorID.HeaderText = "MajorID";
            this.colMajorID.Name = "colMajorID";
            this.colMajorID.ReadOnly = true;
            this.colMajorID.ToolTipText = "MajorID";
            this.colMajorID.Visible = false;
            // 
            // colEnterYear
            // 
            this.colEnterYear.DataPropertyName = "EnterYear";
            this.colEnterYear.HeaderText = "EnterYear";
            this.colEnterYear.Name = "colEnterYear";
            this.colEnterYear.ReadOnly = true;
            this.colEnterYear.ToolTipText = "EnterYear";
            this.colEnterYear.Visible = false;
            // 
            // colEnterSemester
            // 
            this.colEnterSemester.DataPropertyName = "EnterSemester";
            this.colEnterSemester.HeaderText = "EnterSemester";
            this.colEnterSemester.Name = "colEnterSemester";
            this.colEnterSemester.ReadOnly = true;
            this.colEnterSemester.ToolTipText = "EnterSemester";
            this.colEnterSemester.Visible = false;
            // 
            // colNumberOfStudent
            // 
            this.colNumberOfStudent.DataPropertyName = "NumberOfStudent";
            this.colNumberOfStudent.HeaderText = "NumberOfStudent";
            this.colNumberOfStudent.Name = "colNumberOfStudent";
            this.colNumberOfStudent.ReadOnly = true;
            this.colNumberOfStudent.ToolTipText = "NumberOfStudent";
            this.colNumberOfStudent.Visible = false;
            // 
            // colMajor
            // 
            this.colMajor.DataPropertyName = "Major";
            this.colMajor.HeaderText = "Major";
            this.colMajor.Name = "colMajor";
            this.colMajor.ReadOnly = true;
            this.colMajor.ToolTipText = "Major";
            this.colMajor.Visible = false;
            // 
            // subjectDataGridView
            // 
            this.subjectDataGridView.AllowUserToAddRows = false;
            this.subjectDataGridView.AllowUserToDeleteRows = false;
            this.subjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMajorsName,
            this.colHoursPerWeak,
            this.colUnits,
            this.colSubjectType,
            this.colSubjectTypeID,
            this.colPrerequisitesName,
            this.colSubjectID,
            this.colSubjectTitle});
            this.subjectDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.subjectDataGridView.Location = new System.Drawing.Point(291, 0);
            this.subjectDataGridView.Name = "subjectDataGridView";
            this.subjectDataGridView.ReadOnly = true;
            this.subjectDataGridView.RowHeadersVisible = false;
            this.subjectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectDataGridView.Size = new System.Drawing.Size(316, 295);
            this.subjectDataGridView.TabIndex = 1;
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
            // colHoursPerWeak
            // 
            this.colHoursPerWeak.DataPropertyName = "HoursPerWeak";
            this.colHoursPerWeak.HeaderText = "HoursPerWeak";
            this.colHoursPerWeak.Name = "colHoursPerWeak";
            this.colHoursPerWeak.ReadOnly = true;
            this.colHoursPerWeak.ToolTipText = "HoursPerWeak";
            this.colHoursPerWeak.Visible = false;
            // 
            // colUnits
            // 
            this.colUnits.DataPropertyName = "Units";
            this.colUnits.HeaderText = "Units";
            this.colUnits.Name = "colUnits";
            this.colUnits.ReadOnly = true;
            this.colUnits.ToolTipText = "Units";
            this.colUnits.Visible = false;
            // 
            // colSubjectType
            // 
            this.colSubjectType.DataPropertyName = "SubjectType";
            this.colSubjectType.HeaderText = "SubjectType";
            this.colSubjectType.Name = "colSubjectType";
            this.colSubjectType.ReadOnly = true;
            this.colSubjectType.ToolTipText = "SubjectType";
            this.colSubjectType.Visible = false;
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
            // colPrerequisitesName
            // 
            this.colPrerequisitesName.DataPropertyName = "PrerequisitesName";
            this.colPrerequisitesName.HeaderText = "PrerequisitesName";
            this.colPrerequisitesName.Name = "colPrerequisitesName";
            this.colPrerequisitesName.ReadOnly = true;
            this.colPrerequisitesName.ToolTipText = "PrerequisitesName";
            this.colPrerequisitesName.Visible = false;
            // 
            // colSubjectID
            // 
            this.colSubjectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSubjectID.DataPropertyName = "SubjectID";
            this.colSubjectID.HeaderText = "کد درس";
            this.colSubjectID.Name = "colSubjectID";
            this.colSubjectID.ReadOnly = true;
            this.colSubjectID.ToolTipText = "کد درس";
            this.colSubjectID.Width = 66;
            // 
            // colSubjectTitle
            // 
            this.colSubjectTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubjectTitle.DataPropertyName = "Title";
            this.colSubjectTitle.HeaderText = "عنوان درس";
            this.colSubjectTitle.Name = "colSubjectTitle";
            this.colSubjectTitle.ReadOnly = true;
            this.colSubjectTitle.ToolTipText = "عنوان درس";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "درس ها";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "گروه ها";
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnDeleteGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteGroup.Enabled = false;
            this.btnDeleteGroup.Location = new System.Drawing.Point(7, 116);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(40, 33);
            this.btnDeleteGroup.TabIndex = 10;
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Plus_Blue_32x42_72;
            this.btnAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddGroup.Location = new System.Drawing.Point(7, 77);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(40, 33);
            this.btnAddGroup.TabIndex = 9;
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnDeleteSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteSubject.Enabled = false;
            this.btnDeleteSubject.Location = new System.Drawing.Point(666, 116);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(40, 33);
            this.btnDeleteSubject.TabIndex = 8;
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Plus_Blue_32x42_72;
            this.btnAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSubject.Location = new System.Drawing.Point(666, 77);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(40, 33);
            this.btnAddSubject.TabIndex = 7;
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // SubjectForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(713, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(729, 475);
            this.MinimumSize = new System.Drawing.Size(729, 475);
            this.Name = "SubjectForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مرحله 2 - ارایه درس";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView subjectDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView groupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnterYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnterSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajorsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoursPerWeak;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrerequisitesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectTitle;
    }
}