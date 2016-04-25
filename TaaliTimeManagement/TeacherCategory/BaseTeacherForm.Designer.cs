namespace TaaliTimeManagement.TeacherCategory
{
    partial class BaseTeacherForm
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
            this.teacherDataGridView = new System.Windows.Forms.DataGridView();
            this.colTeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterPanel
            // 
            this.masterPanel.Controls.Add(this.teacherDataGridView);
            this.masterPanel.Controls.SetChildIndex(this.teacherDataGridView, 0);
            // 
            // teacherDataGridView
            // 
            this.teacherDataGridView.AllowUserToAddRows = false;
            this.teacherDataGridView.AllowUserToDeleteRows = false;
            this.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTeacherID,
            this.colFirstName,
            this.colLastName});
            this.teacherDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherDataGridView.Location = new System.Drawing.Point(0, 0);
            this.teacherDataGridView.MultiSelect = false;
            this.teacherDataGridView.Name = "teacherDataGridView";
            this.teacherDataGridView.ReadOnly = true;
            this.teacherDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.teacherDataGridView.Size = new System.Drawing.Size(527, 190);
            this.teacherDataGridView.TabIndex = 1;
            // 
            // colTeacherID
            // 
            this.colTeacherID.DataPropertyName = "TeacherID";
            this.colTeacherID.HeaderText = "شمارنده";
            this.colTeacherID.Name = "colTeacherID";
            this.colTeacherID.ReadOnly = true;
            this.colTeacherID.ToolTipText = "شمارنده";
            this.colTeacherID.Visible = false;
            // 
            // colFirstName
            // 
            this.colFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "نام";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            this.colFirstName.ToolTipText = "نام";
            // 
            // colLastName
            // 
            this.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "نام خانوادگی";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            this.colLastName.ToolTipText = "نام خانوادگی";
            // 
            // BaseTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(527, 215);
            this.Name = "BaseTeacherForm";
            this.Text = "استاد";
            this.Load += new System.EventHandler(this.BaseTeacherForm_Load);
            this.masterPanel.ResumeLayout(false);
            this.masterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView teacherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;

    }
}
