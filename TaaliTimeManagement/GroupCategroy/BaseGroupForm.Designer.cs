namespace TaaliTimeManagement.GroupCategroy
{
    partial class BaseGroupForm
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
            this.groupDataGridView = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSemester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOFStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterPanel
            // 
            this.masterPanel.Controls.Add(this.groupDataGridView);
            this.masterPanel.Size = new System.Drawing.Size(597, 215);
            this.masterPanel.Controls.SetChildIndex(this.groupDataGridView, 0);
            // 
            // groupDataGridView
            // 
            this.groupDataGridView.AllowUserToAddRows = false;
            this.groupDataGridView.AllowUserToDeleteRows = false;
            this.groupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colMajorID,
            this.colTitle,
            this.colMajor,
            this.colYear,
            this.colSemester,
            this.colNumberOFStudent});
            this.groupDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDataGridView.Location = new System.Drawing.Point(0, 0);
            this.groupDataGridView.MultiSelect = false;
            this.groupDataGridView.Name = "groupDataGridView";
            this.groupDataGridView.ReadOnly = true;
            this.groupDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupDataGridView.Size = new System.Drawing.Size(597, 190);
            this.groupDataGridView.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "GroupID";
            this.colID.HeaderText = "شمارنده";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.ToolTipText = "شمارنده";
            this.colID.Visible = false;
            // 
            // colMajorID
            // 
            this.colMajorID.DataPropertyName = "MajorID";
            this.colMajorID.HeaderText = "شمارنده رشته";
            this.colMajorID.Name = "colMajorID";
            this.colMajorID.ReadOnly = true;
            this.colMajorID.ToolTipText = "شمارنده رشته";
            this.colMajorID.Visible = false;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "عنوان گروه";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.ToolTipText = "عنوان گروه";
            this.colTitle.Width = 79;
            // 
            // colMajor
            // 
            this.colMajor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMajor.DataPropertyName = "Major";
            this.colMajor.HeaderText = "رشته";
            this.colMajor.Name = "colMajor";
            this.colMajor.ReadOnly = true;
            this.colMajor.ToolTipText = "رشته";
            // 
            // colYear
            // 
            this.colYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colYear.DataPropertyName = "EnterYear";
            this.colYear.HeaderText = "سال ورود";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            this.colYear.ToolTipText = "سال ورود";
            this.colYear.Width = 71;
            // 
            // colSemester
            // 
            this.colSemester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colSemester.DataPropertyName = "EnterSemester";
            this.colSemester.HeaderText = "ترم ورود";
            this.colSemester.Name = "colSemester";
            this.colSemester.ReadOnly = true;
            this.colSemester.Width = 66;
            // 
            // colNumberOFStudent
            // 
            this.colNumberOFStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colNumberOFStudent.DataPropertyName = "NumberOfStudent";
            this.colNumberOFStudent.HeaderText = "تعداد دانشجویان";
            this.colNumberOFStudent.Name = "colNumberOFStudent";
            this.colNumberOFStudent.ReadOnly = true;
            this.colNumberOFStudent.Width = 98;
            // 
            // BaseGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(597, 215);
            this.Name = "BaseGroupForm";
            this.Text = "گروه";
            this.masterPanel.ResumeLayout(false);
            this.masterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView groupDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSemester;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOFStudent;
    }
}
