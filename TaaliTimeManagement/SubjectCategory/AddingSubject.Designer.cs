namespace TaaliTimeManagement.SubjectCategory
{
    partial class AddingSubject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxIDMask = new WiseTextBox.WiseMaskedTextBox();
            this.boxTitle = new WiseTextBox.WiseTextBox();
            this.boxUnitsNumberMask = new WiseTextBox.WiseMaskedTextBox();
            this.btnAddPrerequisites = new System.Windows.Forms.Button();
            this.btnDeletePrerequisites = new System.Windows.Forms.Button();
            this.btnAddMajor = new System.Windows.Forms.Button();
            this.btnDeleteMajor = new System.Windows.Forms.Button();
            this.boxPrerequisitesCombo = new System.Windows.Forms.ComboBox();
            this.boxMajorCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxType = new WiseTextBox.WiseTextBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(113, 191);
            this.btnOK.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 191);
            this.btnCancel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "کد درس*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "عنوان درس*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "تعداد واحد*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "پیشنیاز";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "رشته*";
            // 
            // boxIDMask
            // 
            this.boxIDMask.AutoSensitiveMaskCompleted = true;
            this.boxIDMask.AutoSensitiveTypeValidation = true;
            this.boxIDMask.DefaultText = null;
            this.boxIDMask.EmptinessErrorText = null;
            this.boxIDMask.EmptinessErrorTitle = null;
            this.boxIDMask.EmptinessSensibility = true;
            this.boxIDMask.EndOfFieldErrorText = null;
            this.boxIDMask.EndOfFieldErrorTitle = null;
            this.boxIDMask.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxIDMask.InputCharacterErrorText = null;
            this.boxIDMask.InputCharacterErrorTitle = null;
            this.boxIDMask.Location = new System.Drawing.Point(86, 8);
            this.boxIDMask.Mask = "00000";
            this.boxIDMask.MaskCompletedErrorText = null;
            this.boxIDMask.MaskCompletedErrorTitle = null;
            this.boxIDMask.MaskFulErrorText = null;
            this.boxIDMask.MaskFulErrorTitle = null;
            this.boxIDMask.Name = "boxIDMask";
            this.boxIDMask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxIDMask.Size = new System.Drawing.Size(218, 20);
            this.boxIDMask.TabIndex = 0;
            this.boxIDMask.TypeInvalidErrorText = null;
            this.boxIDMask.TypeInvalidErrorTitle = null;
            this.boxIDMask.ValidatingType = typeof(int);
            this.boxIDMask.Validated += new System.EventHandler(this.boxIDMask_Validated);
            // 
            // boxTitle
            // 
            this.boxTitle.DefaultText = null;
            this.boxTitle.EmptinessSensibility = true;
            this.boxTitle.EmptinessToolTipText = "لطفا اطلاعات مربوط به عنوان درس را وارد کنید";
            this.boxTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxTitle.Location = new System.Drawing.Point(86, 37);
            this.boxTitle.Name = "boxTitle";
            this.boxTitle.NumericSensibililty = false;
            this.boxTitle.NumericText = "";
            this.boxTitle.NumericToolTipText = null;
            this.boxTitle.Size = new System.Drawing.Size(218, 20);
            this.boxTitle.TabIndex = 1;
            // 
            // boxUnitsNumberMask
            // 
            this.boxUnitsNumberMask.AutoSensitiveMaskCompleted = true;
            this.boxUnitsNumberMask.AutoSensitiveTypeValidation = true;
            this.boxUnitsNumberMask.DefaultText = null;
            this.boxUnitsNumberMask.EmptinessErrorText = null;
            this.boxUnitsNumberMask.EmptinessErrorTitle = null;
            this.boxUnitsNumberMask.EmptinessSensibility = true;
            this.boxUnitsNumberMask.EndOfFieldErrorText = null;
            this.boxUnitsNumberMask.EndOfFieldErrorTitle = null;
            this.boxUnitsNumberMask.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxUnitsNumberMask.InputCharacterErrorText = null;
            this.boxUnitsNumberMask.InputCharacterErrorTitle = null;
            this.boxUnitsNumberMask.Location = new System.Drawing.Point(86, 95);
            this.boxUnitsNumberMask.Mask = "0";
            this.boxUnitsNumberMask.MaskCompletedErrorText = null;
            this.boxUnitsNumberMask.MaskCompletedErrorTitle = null;
            this.boxUnitsNumberMask.MaskFulErrorText = null;
            this.boxUnitsNumberMask.MaskFulErrorTitle = null;
            this.boxUnitsNumberMask.Name = "boxUnitsNumberMask";
            this.boxUnitsNumberMask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxUnitsNumberMask.Size = new System.Drawing.Size(218, 20);
            this.boxUnitsNumberMask.TabIndex = 3;
            this.boxUnitsNumberMask.TypeInvalidErrorText = null;
            this.boxUnitsNumberMask.TypeInvalidErrorTitle = null;
            // 
            // btnAddPrerequisites
            // 
            this.btnAddPrerequisites.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Plus_Blue_32x42_72;
            this.btnAddPrerequisites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPrerequisites.Location = new System.Drawing.Point(46, 122);
            this.btnAddPrerequisites.Name = "btnAddPrerequisites";
            this.btnAddPrerequisites.Size = new System.Drawing.Size(34, 23);
            this.btnAddPrerequisites.TabIndex = 4;
            this.btnAddPrerequisites.UseVisualStyleBackColor = true;
            this.btnAddPrerequisites.Click += new System.EventHandler(this.btnAddPrerequisites_Click);
            // 
            // btnDeletePrerequisites
            // 
            this.btnDeletePrerequisites.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnDeletePrerequisites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeletePrerequisites.Enabled = false;
            this.btnDeletePrerequisites.Location = new System.Drawing.Point(9, 122);
            this.btnDeletePrerequisites.Name = "btnDeletePrerequisites";
            this.btnDeletePrerequisites.Size = new System.Drawing.Size(34, 23);
            this.btnDeletePrerequisites.TabIndex = 9;
            this.btnDeletePrerequisites.UseVisualStyleBackColor = true;
            this.btnDeletePrerequisites.Click += new System.EventHandler(this.btnDeletePrerequisites_Click);
            // 
            // btnAddMajor
            // 
            this.btnAddMajor.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Plus_Blue_32x42_72;
            this.btnAddMajor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMajor.Location = new System.Drawing.Point(46, 152);
            this.btnAddMajor.Name = "btnAddMajor";
            this.btnAddMajor.Size = new System.Drawing.Size(34, 23);
            this.btnAddMajor.TabIndex = 5;
            this.btnAddMajor.UseVisualStyleBackColor = true;
            this.btnAddMajor.Click += new System.EventHandler(this.btnAddMajor_Click);
            // 
            // btnDeleteMajor
            // 
            this.btnDeleteMajor.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnDeleteMajor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteMajor.Enabled = false;
            this.btnDeleteMajor.Location = new System.Drawing.Point(9, 152);
            this.btnDeleteMajor.Name = "btnDeleteMajor";
            this.btnDeleteMajor.Size = new System.Drawing.Size(34, 23);
            this.btnDeleteMajor.TabIndex = 10;
            this.btnDeleteMajor.UseVisualStyleBackColor = true;
            this.btnDeleteMajor.Click += new System.EventHandler(this.btnDeleteMajor_Click);
            // 
            // boxPrerequisitesCombo
            // 
            this.boxPrerequisitesCombo.FormattingEnabled = true;
            this.boxPrerequisitesCombo.Location = new System.Drawing.Point(86, 124);
            this.boxPrerequisitesCombo.Name = "boxPrerequisitesCombo";
            this.boxPrerequisitesCombo.Size = new System.Drawing.Size(218, 21);
            this.boxPrerequisitesCombo.TabIndex = 69;
            // 
            // boxMajorCombo
            // 
            this.boxMajorCombo.FormattingEnabled = true;
            this.boxMajorCombo.Location = new System.Drawing.Point(86, 154);
            this.boxMajorCombo.Name = "boxMajorCombo";
            this.boxMajorCombo.Size = new System.Drawing.Size(218, 21);
            this.boxMajorCombo.TabIndex = 70;
            this.boxMajorCombo.SelectedIndexChanged += new System.EventHandler(this.boxMajorCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "نوع درس*";
            // 
            // boxType
            // 
            this.boxType.DefaultText = null;
            this.boxType.EmptinessSensibility = true;
            this.boxType.EmptinessToolTipText = "لطفا اطلاعات مربوط به نوع درس را وارد کنید";
            this.boxType.Enabled = false;
            this.boxType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxType.Location = new System.Drawing.Point(86, 66);
            this.boxType.Name = "boxType";
            this.boxType.NumericSensibililty = false;
            this.boxType.NumericText = "";
            this.boxType.NumericToolTipText = null;
            this.boxType.Size = new System.Drawing.Size(218, 20);
            this.boxType.TabIndex = 72;
            // 
            // btnAddType
            // 
            this.btnAddType.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Plus_Blue_32x42_72;
            this.btnAddType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddType.Location = new System.Drawing.Point(46, 64);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(34, 23);
            this.btnAddType.TabIndex = 2;
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnDeleteType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteType.Enabled = false;
            this.btnDeleteType.Location = new System.Drawing.Point(9, 64);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(34, 23);
            this.btnDeleteType.TabIndex = 8;
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // AddingSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(383, 226);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.btnDeleteType);
            this.Controls.Add(this.boxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxMajorCombo);
            this.Controls.Add(this.boxPrerequisitesCombo);
            this.Controls.Add(this.btnAddMajor);
            this.Controls.Add(this.btnDeleteMajor);
            this.Controls.Add(this.btnAddPrerequisites);
            this.Controls.Add(this.btnDeletePrerequisites);
            this.Controls.Add(this.boxUnitsNumberMask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxIDMask);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(399, 264);
            this.MinimumSize = new System.Drawing.Size(399, 264);
            this.Name = "AddingSubject";
            this.Text = "افزودن درس";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.boxIDMask, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.boxTitle, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.boxUnitsNumberMask, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnDeletePrerequisites, 0);
            this.Controls.SetChildIndex(this.btnAddPrerequisites, 0);
            this.Controls.SetChildIndex(this.btnDeleteMajor, 0);
            this.Controls.SetChildIndex(this.btnAddMajor, 0);
            this.Controls.SetChildIndex(this.boxPrerequisitesCombo, 0);
            this.Controls.SetChildIndex(this.boxMajorCombo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.boxType, 0);
            this.Controls.SetChildIndex(this.btnDeleteType, 0);
            this.Controls.SetChildIndex(this.btnAddType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnAddPrerequisites;
        protected System.Windows.Forms.Button btnDeletePrerequisites;
        protected System.Windows.Forms.Button btnAddMajor;
        protected System.Windows.Forms.Button btnDeleteMajor;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Button btnAddType;
        protected System.Windows.Forms.Button btnDeleteType;
        protected System.Windows.Forms.ComboBox boxMajorCombo;
        protected WiseTextBox.WiseMaskedTextBox boxIDMask;
        protected WiseTextBox.WiseTextBox boxTitle;
        protected WiseTextBox.WiseMaskedTextBox boxUnitsNumberMask;
        protected System.Windows.Forms.ComboBox boxPrerequisitesCombo;
        protected WiseTextBox.WiseTextBox boxType;
    }
}
