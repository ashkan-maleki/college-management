namespace TaaliTimeManagement.ReportCategory
{
    partial class TimeTableForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.boxYearCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.boxSemesterCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowReport = new System.Windows.Forms.ToolStripButton();
            this.timeTableViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.boxYearCombo,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.boxSemesterCombo,
            this.toolStripSeparator2,
            this.btnShowReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabel1.Text = "سال";
            // 
            // boxYearCombo
            // 
            this.boxYearCombo.Name = "boxYearCombo";
            this.boxYearCombo.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(22, 22);
            this.toolStripLabel2.Text = "ترم";
            // 
            // boxSemesterCombo
            // 
            this.boxSemesterCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.boxSemesterCombo.Name = "boxSemesterCombo";
            this.boxSemesterCombo.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnShowReport
            // 
            this.btnShowReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowReport.Image = global::TaaliTimeManagement.Properties.Resources.ViewAllPages_32x32;
            this.btnShowReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(23, 22);
            this.btnShowReport.Text = "نمایش گزارش برنامه هفتگی";
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // timeTableViewer
            // 
            this.timeTableViewer.ActiveViewIndex = -1;
            this.timeTableViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeTableViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.timeTableViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeTableViewer.Location = new System.Drawing.Point(0, 25);
            this.timeTableViewer.Name = "timeTableViewer";
            this.timeTableViewer.Size = new System.Drawing.Size(704, 376);
            this.timeTableViewer.TabIndex = 1;
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 401);
            this.Controls.Add(this.timeTableViewer);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TimeTableForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش برنامه هفتگی";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox boxYearCombo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox boxSemesterCombo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnShowReport;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer timeTableViewer;
    }
}