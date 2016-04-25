namespace TaaliTimeManagement.TimeCategory
{
    partial class BaseAutoTimeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.boxRestTimeMasked = new WiseTextBox.WiseMaskedTextBox();
            this.boxClassPeriodMasked = new WiseTextBox.WiseMaskedTextBox();
            this.boxEndUniversityMasked = new WiseTextBox.WiseMaskedTextBox();
            this.boxStartUniversityMasked = new WiseTextBox.WiseMaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.boxEndDelayMasked = new WiseTextBox.WiseMaskedTextBox();
            this.boxStartDelayMasked = new WiseTextBox.WiseMaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.timeDataGridView = new System.Windows.Forms.DataGridView();
            this.colPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaturday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSunday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMonday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTuesday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWednesday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colThursday = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsEmpty = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMake);
            this.groupBox1.Controls.Add(this.boxRestTimeMasked);
            this.groupBox1.Controls.Add(this.boxClassPeriodMasked);
            this.groupBox1.Controls.Add(this.boxEndUniversityMasked);
            this.groupBox1.Controls.Add(this.boxStartUniversityMasked);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "زمان برگزاری کلاس ها";
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(21, 49);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(75, 23);
            this.btnMake.TabIndex = 4;
            this.btnMake.Text = "ایجاد";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // boxRestTimeMasked
            // 
            this.boxRestTimeMasked.AutoSensitiveMaskCompleted = true;
            this.boxRestTimeMasked.AutoSensitiveTypeValidation = true;
            this.boxRestTimeMasked.DefaultText = null;
            this.boxRestTimeMasked.EmptinessErrorText = null;
            this.boxRestTimeMasked.EmptinessErrorTitle = null;
            this.boxRestTimeMasked.EmptinessSensibility = true;
            this.boxRestTimeMasked.EndOfFieldErrorText = null;
            this.boxRestTimeMasked.EndOfFieldErrorTitle = null;
            this.boxRestTimeMasked.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxRestTimeMasked.InputCharacterErrorText = null;
            this.boxRestTimeMasked.InputCharacterErrorTitle = null;
            this.boxRestTimeMasked.Location = new System.Drawing.Point(178, 51);
            this.boxRestTimeMasked.Mask = "90:00";
            this.boxRestTimeMasked.MaskCompletedErrorText = null;
            this.boxRestTimeMasked.MaskCompletedErrorTitle = null;
            this.boxRestTimeMasked.MaskFulErrorText = null;
            this.boxRestTimeMasked.MaskFulErrorTitle = null;
            this.boxRestTimeMasked.Name = "boxRestTimeMasked";
            this.boxRestTimeMasked.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxRestTimeMasked.Size = new System.Drawing.Size(100, 20);
            this.boxRestTimeMasked.TabIndex = 3;
            this.boxRestTimeMasked.TypeInvalidErrorText = null;
            this.boxRestTimeMasked.TypeInvalidErrorTitle = null;
            this.boxRestTimeMasked.ValidatingType = typeof(System.DateTime);
            // 
            // boxClassPeriodMasked
            // 
            this.boxClassPeriodMasked.AutoSensitiveMaskCompleted = true;
            this.boxClassPeriodMasked.AutoSensitiveTypeValidation = true;
            this.boxClassPeriodMasked.DefaultText = null;
            this.boxClassPeriodMasked.EmptinessErrorText = null;
            this.boxClassPeriodMasked.EmptinessErrorTitle = null;
            this.boxClassPeriodMasked.EmptinessSensibility = true;
            this.boxClassPeriodMasked.EndOfFieldErrorText = null;
            this.boxClassPeriodMasked.EndOfFieldErrorTitle = null;
            this.boxClassPeriodMasked.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxClassPeriodMasked.InputCharacterErrorText = null;
            this.boxClassPeriodMasked.InputCharacterErrorTitle = null;
            this.boxClassPeriodMasked.Location = new System.Drawing.Point(178, 25);
            this.boxClassPeriodMasked.Mask = "90:00";
            this.boxClassPeriodMasked.MaskCompletedErrorText = null;
            this.boxClassPeriodMasked.MaskCompletedErrorTitle = null;
            this.boxClassPeriodMasked.MaskFulErrorText = null;
            this.boxClassPeriodMasked.MaskFulErrorTitle = null;
            this.boxClassPeriodMasked.Name = "boxClassPeriodMasked";
            this.boxClassPeriodMasked.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxClassPeriodMasked.Size = new System.Drawing.Size(100, 20);
            this.boxClassPeriodMasked.TabIndex = 2;
            this.boxClassPeriodMasked.TypeInvalidErrorText = null;
            this.boxClassPeriodMasked.TypeInvalidErrorTitle = null;
            this.boxClassPeriodMasked.ValidatingType = typeof(System.DateTime);
            // 
            // boxEndUniversityMasked
            // 
            this.boxEndUniversityMasked.AutoSensitiveMaskCompleted = true;
            this.boxEndUniversityMasked.AutoSensitiveTypeValidation = true;
            this.boxEndUniversityMasked.DefaultText = null;
            this.boxEndUniversityMasked.EmptinessErrorText = null;
            this.boxEndUniversityMasked.EmptinessErrorTitle = null;
            this.boxEndUniversityMasked.EmptinessSensibility = true;
            this.boxEndUniversityMasked.EndOfFieldErrorText = null;
            this.boxEndUniversityMasked.EndOfFieldErrorTitle = null;
            this.boxEndUniversityMasked.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxEndUniversityMasked.InputCharacterErrorText = null;
            this.boxEndUniversityMasked.InputCharacterErrorTitle = null;
            this.boxEndUniversityMasked.Location = new System.Drawing.Point(459, 51);
            this.boxEndUniversityMasked.Mask = "90:00";
            this.boxEndUniversityMasked.MaskCompletedErrorText = null;
            this.boxEndUniversityMasked.MaskCompletedErrorTitle = null;
            this.boxEndUniversityMasked.MaskFulErrorText = null;
            this.boxEndUniversityMasked.MaskFulErrorTitle = null;
            this.boxEndUniversityMasked.Name = "boxEndUniversityMasked";
            this.boxEndUniversityMasked.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxEndUniversityMasked.Size = new System.Drawing.Size(100, 20);
            this.boxEndUniversityMasked.TabIndex = 1;
            this.boxEndUniversityMasked.TypeInvalidErrorText = null;
            this.boxEndUniversityMasked.TypeInvalidErrorTitle = null;
            this.boxEndUniversityMasked.ValidatingType = typeof(System.DateTime);
            // 
            // boxStartUniversityMasked
            // 
            this.boxStartUniversityMasked.AutoSensitiveMaskCompleted = true;
            this.boxStartUniversityMasked.AutoSensitiveTypeValidation = true;
            this.boxStartUniversityMasked.DefaultText = null;
            this.boxStartUniversityMasked.EmptinessErrorText = null;
            this.boxStartUniversityMasked.EmptinessErrorTitle = null;
            this.boxStartUniversityMasked.EmptinessSensibility = true;
            this.boxStartUniversityMasked.EndOfFieldErrorText = null;
            this.boxStartUniversityMasked.EndOfFieldErrorTitle = null;
            this.boxStartUniversityMasked.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxStartUniversityMasked.InputCharacterErrorText = null;
            this.boxStartUniversityMasked.InputCharacterErrorTitle = null;
            this.boxStartUniversityMasked.Location = new System.Drawing.Point(459, 25);
            this.boxStartUniversityMasked.Mask = "90:00";
            this.boxStartUniversityMasked.MaskCompletedErrorText = null;
            this.boxStartUniversityMasked.MaskCompletedErrorTitle = null;
            this.boxStartUniversityMasked.MaskFulErrorText = null;
            this.boxStartUniversityMasked.MaskFulErrorTitle = null;
            this.boxStartUniversityMasked.Name = "boxStartUniversityMasked";
            this.boxStartUniversityMasked.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxStartUniversityMasked.Size = new System.Drawing.Size(100, 20);
            this.boxStartUniversityMasked.TabIndex = 0;
            this.boxStartUniversityMasked.TypeInvalidErrorText = null;
            this.boxStartUniversityMasked.TypeInvalidErrorTitle = null;
            this.boxStartUniversityMasked.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "مدت زمان استراحت*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "مدت زمان هر کلاس*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "زمان پایان دانشگاه*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "زمان شروع دانشگاه*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnApply);
            this.groupBox2.Controls.Add(this.boxEndDelayMasked);
            this.groupBox2.Controls.Add(this.boxStartDelayMasked);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "وقفه بین کلاس ها";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(21, 22);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "اعمال";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // boxEndDelayMasked
            // 
            this.boxEndDelayMasked.AutoSensitiveMaskCompleted = false;
            this.boxEndDelayMasked.AutoSensitiveTypeValidation = false;
            this.boxEndDelayMasked.DefaultText = null;
            this.boxEndDelayMasked.EmptinessErrorText = null;
            this.boxEndDelayMasked.EmptinessErrorTitle = null;
            this.boxEndDelayMasked.EmptinessSensibility = false;
            this.boxEndDelayMasked.EndOfFieldErrorText = null;
            this.boxEndDelayMasked.EndOfFieldErrorTitle = null;
            this.boxEndDelayMasked.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxEndDelayMasked.InputCharacterErrorText = null;
            this.boxEndDelayMasked.InputCharacterErrorTitle = null;
            this.boxEndDelayMasked.Location = new System.Drawing.Point(178, 24);
            this.boxEndDelayMasked.Mask = "90:00";
            this.boxEndDelayMasked.MaskCompletedErrorText = null;
            this.boxEndDelayMasked.MaskCompletedErrorTitle = null;
            this.boxEndDelayMasked.MaskFulErrorText = null;
            this.boxEndDelayMasked.MaskFulErrorTitle = null;
            this.boxEndDelayMasked.Name = "boxEndDelayMasked";
            this.boxEndDelayMasked.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxEndDelayMasked.Size = new System.Drawing.Size(100, 20);
            this.boxEndDelayMasked.TabIndex = 1;
            this.boxEndDelayMasked.TypeInvalidErrorText = null;
            this.boxEndDelayMasked.TypeInvalidErrorTitle = null;
            this.boxEndDelayMasked.ValidatingType = typeof(System.DateTime);
            // 
            // boxStartDelayMasked
            // 
            this.boxStartDelayMasked.AutoSensitiveMaskCompleted = false;
            this.boxStartDelayMasked.AutoSensitiveTypeValidation = false;
            this.boxStartDelayMasked.DefaultText = null;
            this.boxStartDelayMasked.EmptinessErrorText = null;
            this.boxStartDelayMasked.EmptinessErrorTitle = null;
            this.boxStartDelayMasked.EmptinessSensibility = false;
            this.boxStartDelayMasked.EndOfFieldErrorText = null;
            this.boxStartDelayMasked.EndOfFieldErrorTitle = null;
            this.boxStartDelayMasked.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxStartDelayMasked.InputCharacterErrorText = null;
            this.boxStartDelayMasked.InputCharacterErrorTitle = null;
            this.boxStartDelayMasked.Location = new System.Drawing.Point(459, 24);
            this.boxStartDelayMasked.Mask = "90:00";
            this.boxStartDelayMasked.MaskCompletedErrorText = null;
            this.boxStartDelayMasked.MaskCompletedErrorTitle = null;
            this.boxStartDelayMasked.MaskFulErrorText = null;
            this.boxStartDelayMasked.MaskFulErrorTitle = null;
            this.boxStartDelayMasked.Name = "boxStartDelayMasked";
            this.boxStartDelayMasked.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxStartDelayMasked.Size = new System.Drawing.Size(100, 20);
            this.boxStartDelayMasked.TabIndex = 0;
            this.boxStartDelayMasked.TypeInvalidErrorText = null;
            this.boxStartDelayMasked.TypeInvalidErrorTitle = null;
            this.boxStartDelayMasked.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "شروع وقفه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "پایان وقفه";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 33);
            this.panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::TaaliTimeManagement.Properties.Resources.delete;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(405, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Tick_Green_64x64_72;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOk.Location = new System.Drawing.Point(324, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // timeDataGridView
            // 
            this.timeDataGridView.AllowUserToAddRows = false;
            this.timeDataGridView.AllowUserToDeleteRows = false;
            this.timeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPeriod,
            this.colStartTime,
            this.colEndTime,
            this.colSaturday,
            this.colSunday,
            this.colMonday,
            this.colTuesday,
            this.colWednesday,
            this.colThursday,
            this.colIsEmpty});
            this.timeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeDataGridView.Location = new System.Drawing.Point(0, 141);
            this.timeDataGridView.Name = "timeDataGridView";
            this.timeDataGridView.RowHeadersVisible = false;
            this.timeDataGridView.Size = new System.Drawing.Size(804, 280);
            this.timeDataGridView.TabIndex = 2;
            // 
            // colPeriod
            // 
            this.colPeriod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPeriod.DataPropertyName = "Period";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.colPeriod.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPeriod.HeaderText = "";
            this.colPeriod.Name = "colPeriod";
            // 
            // colStartTime
            // 
            this.colStartTime.DataPropertyName = "StartTime";
            this.colStartTime.HeaderText = "شروع";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.ToolTipText = "شروع";
            this.colStartTime.Visible = false;
            // 
            // colEndTime
            // 
            this.colEndTime.DataPropertyName = "EndTime";
            this.colEndTime.HeaderText = "پایان";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.ToolTipText = "پایان";
            this.colEndTime.Visible = false;
            // 
            // colSaturday
            // 
            this.colSaturday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSaturday.DataPropertyName = "Saturday";
            this.colSaturday.HeaderText = "شنبه";
            this.colSaturday.Name = "colSaturday";
            this.colSaturday.ToolTipText = "شنبه";
            // 
            // colSunday
            // 
            this.colSunday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSunday.DataPropertyName = "Sunday";
            this.colSunday.HeaderText = "یک شنبه";
            this.colSunday.Name = "colSunday";
            this.colSunday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSunday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSunday.ToolTipText = "یک شنبه";
            // 
            // colMonday
            // 
            this.colMonday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMonday.DataPropertyName = "Monday";
            this.colMonday.HeaderText = "دو شنبه";
            this.colMonday.Name = "colMonday";
            this.colMonday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMonday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMonday.ToolTipText = "دو شنبه";
            // 
            // colTuesday
            // 
            this.colTuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTuesday.DataPropertyName = "Tuesday";
            this.colTuesday.HeaderText = "سه شنبه";
            this.colTuesday.Name = "colTuesday";
            this.colTuesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTuesday.ToolTipText = "سه شنبه";
            // 
            // colWednesday
            // 
            this.colWednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWednesday.DataPropertyName = "Wednesday";
            this.colWednesday.HeaderText = "چهار شنبه";
            this.colWednesday.Name = "colWednesday";
            this.colWednesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colWednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colWednesday.ToolTipText = "چهار شنبه";
            // 
            // colThursday
            // 
            this.colThursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colThursday.DataPropertyName = "Thursday";
            this.colThursday.HeaderText = "پنج شنبه";
            this.colThursday.Name = "colThursday";
            this.colThursday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colThursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colThursday.ToolTipText = "پنج شنبه";
            // 
            // colIsEmpty
            // 
            this.colIsEmpty.DataPropertyName = "IsEmpty";
            this.colIsEmpty.HeaderText = "خالی";
            this.colIsEmpty.Name = "colIsEmpty";
            this.colIsEmpty.ToolTipText = "خالی";
            this.colIsEmpty.Visible = false;
            // 
            // BaseAutoTimeForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.timeDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaseAutoTimeForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "زمان کار دانشگاه";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMake;
        private WiseTextBox.WiseMaskedTextBox boxRestTimeMasked;
        private WiseTextBox.WiseMaskedTextBox boxClassPeriodMasked;
        private WiseTextBox.WiseMaskedTextBox boxEndUniversityMasked;
        private WiseTextBox.WiseMaskedTextBox boxStartUniversityMasked;
        private System.Windows.Forms.Button btnApply;
        private WiseTextBox.WiseMaskedTextBox boxEndDelayMasked;
        private WiseTextBox.WiseMaskedTextBox boxStartDelayMasked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnOk;
        protected System.Windows.Forms.DataGridView timeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSaturday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSunday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMonday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTuesday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWednesday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colThursday;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsEmpty;

    }
}