namespace TaaliTimeManagement.TypeCategory
{
    partial class BaseTypeForm
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
            this.typeDataGridView = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTheory = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterPanel
            // 
            this.masterPanel.Controls.Add(this.typeDataGridView);
            this.masterPanel.Controls.SetChildIndex(this.typeDataGridView, 0);
            // 
            // typeDataGridView
            // 
            this.typeDataGridView.AllowUserToAddRows = false;
            this.typeDataGridView.AllowUserToDeleteRows = false;
            this.typeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colType,
            this.colTheory,
            this.colHours,
            this.colPrice,
            this.colSalary});
            this.typeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.typeDataGridView.Name = "typeDataGridView";
            this.typeDataGridView.ReadOnly = true;
            this.typeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typeDataGridView.Size = new System.Drawing.Size(527, 190);
            this.typeDataGridView.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "SubjectTypeID";
            this.colID.HeaderText = "شمارنده";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.ToolTipText = "شمارنده";
            this.colID.Visible = false;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colType.DataPropertyName = "TypeTitle";
            this.colType.HeaderText = "نوع درس";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.ToolTipText = "نوع درس";
            // 
            // colTheory
            // 
            this.colTheory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTheory.DataPropertyName = "Theory";
            this.colTheory.HeaderText = "تئوری";
            this.colTheory.Name = "colTheory";
            this.colTheory.ReadOnly = true;
            this.colTheory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTheory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTheory.ToolTipText = "تئوری";
            this.colTheory.Width = 50;
            // 
            // colHours
            // 
            this.colHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colHours.DataPropertyName = "HoursPerUnit";
            this.colHours.HeaderText = "ساعات به ازای هر واحد";
            this.colHours.Name = "colHours";
            this.colHours.ReadOnly = true;
            this.colHours.ToolTipText = "ساعات به ازای هر واحد";
            this.colHours.Width = 95;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPrice.DataPropertyName = "PricePerUnit";
            this.colPrice.HeaderText = "هزینه به ازای هر واحد";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.ToolTipText = "هزینه به ازای هر واحد";
            this.colPrice.Width = 102;
            // 
            // colSalary
            // 
            this.colSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSalary.DataPropertyName = "SalaryPerUnit";
            this.colSalary.HeaderText = "دستمزد به ازای هر واحد";
            this.colSalary.Name = "colSalary";
            this.colSalary.ReadOnly = true;
            this.colSalary.ToolTipText = "دستمزد به ازای هر واحد";
            this.colSalary.Width = 96;
            // 
            // BaseTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(527, 215);
            this.Name = "BaseTypeForm";
            this.Text = "نوع درس";
            this.masterPanel.ResumeLayout(false);
            this.masterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView typeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTheory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalary;
    }
}
