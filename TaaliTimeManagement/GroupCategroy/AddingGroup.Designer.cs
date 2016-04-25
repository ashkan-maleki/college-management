namespace TaaliTimeManagement.GroupCategroy
{
    partial class AddingGroup
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
            this.boxYear = new WiseTextBox.WiseMaskedTextBox();
            this.boxMajor = new WiseTextBox.WiseTextBox();
            this.boxSemester = new WiseTextBox.WiseMaskedTextBox();
            this.boxGroupTitle = new WiseTextBox.WiseTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteMajor = new System.Windows.Forms.Button();
            this.btnAddMajor = new System.Windows.Forms.Button();
            this.boxNumberOFStudent = new WiseTextBox.WiseTextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(139, 151);
            this.btnOK.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 151);
            this.btnCancel.TabIndex = 6;
            // 
            // boxYear
            // 
            this.boxYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxYear.AutoSensitiveMaskCompleted = true;
            this.boxYear.AutoSensitiveTypeValidation = true;
            this.boxYear.DefaultText = null;
            this.boxYear.EmptinessErrorText = "لطفا اطلاعات مربوط به سال ورود را وارد کنید";
            this.boxYear.EmptinessErrorTitle = null;
            this.boxYear.EmptinessSensibility = true;
            this.boxYear.EndOfFieldErrorText = "شما نمی توانید هیچ کاراکتری را به انتهای این فیلد اضافه کنید. برای اضافه کردن کار" +
                "اکتری را از آخر حذف کنید.";
            this.boxYear.EndOfFieldErrorTitle = null;
            this.boxYear.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxYear.InputCharacterErrorText = null;
            this.boxYear.InputCharacterErrorTitle = null;
            this.boxYear.Location = new System.Drawing.Point(89, 38);
            this.boxYear.Mask = "00";
            this.boxYear.MaskCompletedErrorText = null;
            this.boxYear.MaskCompletedErrorTitle = null;
            this.boxYear.MaskFulErrorText = null;
            this.boxYear.MaskFulErrorTitle = null;
            this.boxYear.Name = "boxYear";
            this.boxYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxYear.Size = new System.Drawing.Size(242, 20);
            this.boxYear.TabIndex = 1;
            this.boxYear.TypeInvalidErrorText = null;
            this.boxYear.TypeInvalidErrorTitle = null;
            this.boxYear.Leave += new System.EventHandler(this.boxYear_Leave);
            // 
            // boxMajor
            // 
            this.boxMajor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxMajor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxMajor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxMajor.DefaultText = null;
            this.boxMajor.EmptinessSensibility = true;
            this.boxMajor.EmptinessToolTipText = "لطفا اطلاعات مربوط به رشته را وارد کنید";
            this.boxMajor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxMajor.Location = new System.Drawing.Point(89, 12);
            this.boxMajor.Name = "boxMajor";
            this.boxMajor.NumericSensibililty = false;
            this.boxMajor.NumericText = "";
            this.boxMajor.NumericToolTipText = null;
            this.boxMajor.Size = new System.Drawing.Size(242, 20);
            this.boxMajor.TabIndex = 8;
            // 
            // boxSemester
            // 
            this.boxSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxSemester.AutoSensitiveMaskCompleted = true;
            this.boxSemester.AutoSensitiveTypeValidation = true;
            this.boxSemester.DefaultText = null;
            this.boxSemester.EmptinessErrorText = null;
            this.boxSemester.EmptinessErrorTitle = null;
            this.boxSemester.EmptinessSensibility = true;
            this.boxSemester.EndOfFieldErrorText = null;
            this.boxSemester.EndOfFieldErrorTitle = null;
            this.boxSemester.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxSemester.InputCharacterErrorText = null;
            this.boxSemester.InputCharacterErrorTitle = null;
            this.boxSemester.Location = new System.Drawing.Point(89, 64);
            this.boxSemester.Mask = "0";
            this.boxSemester.MaskCompletedErrorText = null;
            this.boxSemester.MaskCompletedErrorTitle = null;
            this.boxSemester.MaskFulErrorText = null;
            this.boxSemester.MaskFulErrorTitle = null;
            this.boxSemester.Name = "boxSemester";
            this.boxSemester.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxSemester.Size = new System.Drawing.Size(242, 20);
            this.boxSemester.TabIndex = 2;
            this.boxSemester.TypeInvalidErrorText = null;
            this.boxSemester.TypeInvalidErrorTitle = null;
            this.boxSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxSemester_KeyPress);
            // 
            // boxGroupTitle
            // 
            this.boxGroupTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxGroupTitle.DefaultText = null;
            this.boxGroupTitle.EmptinessSensibility = true;
            this.boxGroupTitle.EmptinessToolTipText = "لطفا اطلاعات مربوط به عنوان گروه را وارد کنید";
            this.boxGroupTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxGroupTitle.Location = new System.Drawing.Point(89, 90);
            this.boxGroupTitle.Name = "boxGroupTitle";
            this.boxGroupTitle.NumericSensibililty = false;
            this.boxGroupTitle.NumericText = "";
            this.boxGroupTitle.NumericToolTipText = null;
            this.boxGroupTitle.Size = new System.Drawing.Size(242, 20);
            this.boxGroupTitle.TabIndex = 3;
            this.boxGroupTitle.TextChanged += new System.EventHandler(this.boxGroupTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "رشته*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "سال ورود*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "ترم ورود*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "عنوان گروه*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "تعداد دانشجویان";
            // 
            // btnDeleteMajor
            // 
            this.btnDeleteMajor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteMajor.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnDeleteMajor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteMajor.Enabled = false;
            this.btnDeleteMajor.Location = new System.Drawing.Point(12, 10);
            this.btnDeleteMajor.Name = "btnDeleteMajor";
            this.btnDeleteMajor.Size = new System.Drawing.Size(34, 23);
            this.btnDeleteMajor.TabIndex = 7;
            this.btnDeleteMajor.UseVisualStyleBackColor = true;
            this.btnDeleteMajor.Click += new System.EventHandler(this.boxDeleteMajor_Click);
            // 
            // btnAddMajor
            // 
            this.btnAddMajor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMajor.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Plus_Blue_32x42_72;
            this.btnAddMajor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMajor.Location = new System.Drawing.Point(49, 10);
            this.btnAddMajor.Name = "btnAddMajor";
            this.btnAddMajor.Size = new System.Drawing.Size(34, 23);
            this.btnAddMajor.TabIndex = 0;
            this.btnAddMajor.UseVisualStyleBackColor = true;
            this.btnAddMajor.Click += new System.EventHandler(this.btnAddMajor_Click);
            // 
            // boxNumberOFStudent
            // 
            this.boxNumberOFStudent.DefaultText = null;
            this.boxNumberOFStudent.EmptinessSensibility = false;
            this.boxNumberOFStudent.EmptinessToolTipText = null;
            this.boxNumberOFStudent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxNumberOFStudent.Location = new System.Drawing.Point(89, 116);
            this.boxNumberOFStudent.Name = "boxNumberOFStudent";
            this.boxNumberOFStudent.NumericSensibililty = true;
            this.boxNumberOFStudent.NumericText = "";
            this.boxNumberOFStudent.NumericToolTipText = "شما فقط می توانید از اعداد استفاده نمایید.";
            this.boxNumberOFStudent.Size = new System.Drawing.Size(242, 20);
            this.boxNumberOFStudent.TabIndex = 4;
            this.boxNumberOFStudent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_KeyPress);
            // 
            // AddingGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(434, 186);
            this.Controls.Add(this.boxMajor);
            this.Controls.Add(this.boxYear);
            this.Controls.Add(this.boxNumberOFStudent);
            this.Controls.Add(this.btnAddMajor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteMajor);
            this.Controls.Add(this.boxGroupTitle);
            this.Controls.Add(this.boxSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(450, 224);
            this.MinimumSize = new System.Drawing.Size(450, 224);
            this.Name = "AddingGroup";
            this.Text = "افزودن گروه";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.boxSemester, 0);
            this.Controls.SetChildIndex(this.boxGroupTitle, 0);
            this.Controls.SetChildIndex(this.btnDeleteMajor, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnAddMajor, 0);
            this.Controls.SetChildIndex(this.boxNumberOFStudent, 0);
            this.Controls.SetChildIndex(this.boxYear, 0);
            this.Controls.SetChildIndex(this.boxMajor, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected WiseTextBox.WiseMaskedTextBox boxYear;
        protected WiseTextBox.WiseTextBox boxMajor;
        protected WiseTextBox.WiseMaskedTextBox boxSemester;
        protected WiseTextBox.WiseTextBox boxGroupTitle;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnDeleteMajor;
        protected System.Windows.Forms.Button btnAddMajor;
        protected WiseTextBox.WiseTextBox boxNumberOFStudent;


    }
}
