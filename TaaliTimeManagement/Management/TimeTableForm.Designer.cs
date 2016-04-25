namespace TaaliTimeManagement.Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTableForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.boxYearCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.boxSemesterCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.boxGroupCombo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddCoarse = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCoarse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnContinue = new System.Windows.Forms.ToolStripButton();
            this.btnReprogram = new System.Windows.Forms.ToolStripButton();
            this.btnView = new System.Windows.Forms.ToolStripButton();
            this.btnEditCoarse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnRestore = new System.Windows.Forms.ToolStripButton();
            this.timeTableGridView = new System.Windows.Forms.DataGridView();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsEmpty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableGridView)).BeginInit();
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
            this.toolStripLabel3,
            this.boxGroupCombo,
            this.toolStripSeparator4,
            this.btnAddCoarse,
            this.btnDeleteCoarse,
            this.toolStripSeparator5,
            this.btnContinue,
            this.btnReprogram,
            this.btnView,
            this.btnEditCoarse,
            this.toolStripSeparator3,
            this.btnSave,
            this.btnRestore});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(714, 25);
            this.toolStrip1.TabIndex = 9;
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
            this.boxYearCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxYearCombo.Size = new System.Drawing.Size(75, 25);
            this.boxYearCombo.SelectedIndexChanged += new System.EventHandler(this.boxYearCombo_SelectedIndexChanged);
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
            this.boxSemesterCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxSemesterCombo.Size = new System.Drawing.Size(75, 25);
            this.boxSemesterCombo.SelectedIndexChanged += new System.EventHandler(this.boxSemesterCombo_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel3.Text = "گروه";
            // 
            // boxGroupCombo
            // 
            this.boxGroupCombo.Name = "boxGroupCombo";
            this.boxGroupCombo.Size = new System.Drawing.Size(240, 25);
            this.boxGroupCombo.SelectedIndexChanged += new System.EventHandler(this.boxGroupCombo_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddCoarse
            // 
            this.btnAddCoarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCoarse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCoarse.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCoarse.Image")));
            this.btnAddCoarse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCoarse.Name = "btnAddCoarse";
            this.btnAddCoarse.Size = new System.Drawing.Size(23, 22);
            this.btnAddCoarse.Text = "ارایه درس";
            this.btnAddCoarse.Click += new System.EventHandler(this.btnAddCoarse_Click);
            // 
            // btnDeleteCoarse
            // 
            this.btnDeleteCoarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteCoarse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCoarse.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCoarse.Image")));
            this.btnDeleteCoarse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCoarse.Name = "btnDeleteCoarse";
            this.btnDeleteCoarse.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteCoarse.Text = "حذف درس";
            this.btnDeleteCoarse.Click += new System.EventHandler(this.btnDeleteCoarse_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnContinue
            // 
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContinue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnContinue.Image = ((System.Drawing.Image)(resources.GetObject("btnContinue.Image")));
            this.btnContinue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(23, 22);
            this.btnContinue.Text = "ادامه برنامه ریزی";
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnReprogram
            // 
            this.btnReprogram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReprogram.Image = ((System.Drawing.Image)(resources.GetObject("btnReprogram.Image")));
            this.btnReprogram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReprogram.Name = "btnReprogram";
            this.btnReprogram.Size = new System.Drawing.Size(23, 22);
            this.btnReprogram.Text = "برنامه ریزی مجدد";
            this.btnReprogram.Click += new System.EventHandler(this.btnReprogram_Click);
            // 
            // btnView
            // 
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(23, 22);
            this.btnView.Text = "مشاهده دروس بدون استاد";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEditCoarse
            // 
            this.btnEditCoarse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditCoarse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditCoarse.Enabled = false;
            this.btnEditCoarse.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCoarse.Image")));
            this.btnEditCoarse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCoarse.Name = "btnEditCoarse";
            this.btnEditCoarse.Size = new System.Drawing.Size(23, 22);
            this.btnEditCoarse.Text = "اصلاح درس";
            this.btnEditCoarse.Visible = false;
            this.btnEditCoarse.Click += new System.EventHandler(this.btnEditCoarse_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "ذخیره سازی";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRestore.Enabled = false;
            this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
            this.btnRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(23, 20);
            this.btnRestore.Text = "باز گرداندن جدول به حالت اولیه";
            this.btnRestore.ToolTipText = "باز گرداندن جدول به حالت اولیه";
            this.btnRestore.Visible = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // timeTableGridView
            // 
            this.timeTableGridView.AllowUserToAddRows = false;
            this.timeTableGridView.AllowUserToDeleteRows = false;
            this.timeTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeTableGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStartTime,
            this.colEndTime,
            this.colPeriod,
            this.colSaturday,
            this.colSunday,
            this.colMonday,
            this.colTuesday,
            this.colWednesday,
            this.colThursday,
            this.colIsEmpty});
            this.timeTableGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeTableGridView.Location = new System.Drawing.Point(0, 25);
            this.timeTableGridView.Name = "timeTableGridView";
            this.timeTableGridView.ReadOnly = true;
            this.timeTableGridView.RowHeadersVisible = false;
            this.timeTableGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.timeTableGridView.Size = new System.Drawing.Size(714, 317);
            this.timeTableGridView.TabIndex = 10;
            // 
            // colStartTime
            // 
            this.colStartTime.DataPropertyName = "StartTime";
            this.colStartTime.HeaderText = "StartTime";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ReadOnly = true;
            this.colStartTime.ToolTipText = "StartTime";
            this.colStartTime.Visible = false;
            // 
            // colEndTime
            // 
            this.colEndTime.DataPropertyName = "EndTime";
            this.colEndTime.HeaderText = "EndTime";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.ReadOnly = true;
            this.colEndTime.ToolTipText = "EndTime";
            this.colEndTime.Visible = false;
            // 
            // colPeriod
            // 
            this.colPeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPeriod.DataPropertyName = "Period";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.colPeriod.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPeriod.HeaderText = "";
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.ReadOnly = true;
            this.colPeriod.Width = 19;
            // 
            // colSaturday
            // 
            this.colSaturday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSaturday.DataPropertyName = "Saturday";
            this.colSaturday.HeaderText = "شنبه";
            this.colSaturday.Name = "colSaturday";
            this.colSaturday.ReadOnly = true;
            this.colSaturday.ToolTipText = "شنبه";
            // 
            // colSunday
            // 
            this.colSunday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSunday.DataPropertyName = "Sunday";
            this.colSunday.HeaderText = "یک شنبه";
            this.colSunday.Name = "colSunday";
            this.colSunday.ReadOnly = true;
            this.colSunday.ToolTipText = "یک شنبه";
            // 
            // colMonday
            // 
            this.colMonday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMonday.DataPropertyName = "Monday";
            this.colMonday.HeaderText = "دو شنبه";
            this.colMonday.Name = "colMonday";
            this.colMonday.ReadOnly = true;
            this.colMonday.ToolTipText = "دو شنبه";
            // 
            // colTuesday
            // 
            this.colTuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTuesday.DataPropertyName = "Tuesday";
            this.colTuesday.HeaderText = "سه شنبه";
            this.colTuesday.Name = "colTuesday";
            this.colTuesday.ReadOnly = true;
            this.colTuesday.ToolTipText = "سه شنبه";
            // 
            // colWednesday
            // 
            this.colWednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWednesday.DataPropertyName = "Wednesday";
            this.colWednesday.HeaderText = "چهار شنبه";
            this.colWednesday.Name = "colWednesday";
            this.colWednesday.ReadOnly = true;
            this.colWednesday.ToolTipText = "چهار شنبه";
            // 
            // colThursday
            // 
            this.colThursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThursday.DataPropertyName = "Thursday";
            this.colThursday.HeaderText = "پنج شنبه";
            this.colThursday.Name = "colThursday";
            this.colThursday.ReadOnly = true;
            this.colThursday.ToolTipText = "پنج شنبه";
            // 
            // colIsEmpty
            // 
            this.colIsEmpty.DataPropertyName = "IsEmpty";
            this.colIsEmpty.HeaderText = "خالی";
            this.colIsEmpty.Name = "colIsEmpty";
            this.colIsEmpty.ReadOnly = true;
            this.colIsEmpty.ToolTipText = "خالی";
            this.colIsEmpty.Visible = false;
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 342);
            this.Controls.Add(this.timeTableGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TimeTableForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "برنامه هفتگی کلاس ها";
            this.Load += new System.EventHandler(this.TimeTableForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox boxYearCombo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox boxSemesterCombo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox boxGroupCombo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAddCoarse;
        private System.Windows.Forms.ToolStripButton btnDeleteCoarse;
        private System.Windows.Forms.ToolStripButton btnEditCoarse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnContinue;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.DataGridView timeTableGridView;
        private System.Windows.Forms.ToolStripButton btnReprogram;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSunday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsEmpty;

    }
}