namespace TaaliTimeManagement.MajorCategory
{
    partial class BaseMajorForm
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
            this.majorDataGridView = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterPanel
            // 
            this.masterPanel.Controls.Add(this.majorDataGridView);
            this.masterPanel.Controls.SetChildIndex(this.majorDataGridView, 0);
            // 
            // majorDataGridView
            // 
            this.majorDataGridView.AllowUserToAddRows = false;
            this.majorDataGridView.AllowUserToDeleteRows = false;
            this.majorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.majorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colLevel,
            this.colTitle,
            this.colBranch});
            this.majorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.majorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.majorDataGridView.MultiSelect = false;
            this.majorDataGridView.Name = "majorDataGridView";
            this.majorDataGridView.ReadOnly = true;
            this.majorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.majorDataGridView.Size = new System.Drawing.Size(527, 190);
            this.majorDataGridView.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "MajorID";
            this.colID.HeaderText = "Column1";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colLevel
            // 
            this.colLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colLevel.DataPropertyName = "MajorLevel";
            this.colLevel.HeaderText = "مقطع تحصیلی";
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            this.colLevel.ToolTipText = "مقطع تحصیلی";
            this.colLevel.Width = 96;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTitle.DataPropertyName = "Title";
            this.colTitle.HeaderText = "عنوان رشته";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            this.colTitle.ToolTipText = "عنوان رشته";
            this.colTitle.Width = 85;
            // 
            // colBranch
            // 
            this.colBranch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBranch.DataPropertyName = "Branch";
            this.colBranch.HeaderText = "گرایش";
            this.colBranch.Name = "colBranch";
            this.colBranch.ReadOnly = true;
            this.colBranch.ToolTipText = "گرایش";
            // 
            // BaseMajorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(527, 215);
            this.Name = "BaseMajorForm";
            this.Text = "رشته ها";
            this.masterPanel.ResumeLayout(false);
            this.masterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.majorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView majorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBranch;

    }
}
