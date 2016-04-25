namespace TaaliTimeManagement.Management
{
    partial class TermForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.boxYearMasked = new WiseTextBox.WiseMaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxSemesterCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(138, 68);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "بعدی";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(57, 68);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ترم*";
            // 
            // boxYearMasked
            // 
            this.boxYearMasked.AutoSensitiveMaskCompleted = true;
            this.boxYearMasked.AutoSensitiveTypeValidation = true;
            this.boxYearMasked.DefaultText = null;
            this.boxYearMasked.EmptinessErrorText = null;
            this.boxYearMasked.EmptinessErrorTitle = null;
            this.boxYearMasked.EmptinessSensibility = true;
            this.boxYearMasked.EndOfFieldErrorText = null;
            this.boxYearMasked.EndOfFieldErrorTitle = null;
            this.boxYearMasked.ErrorIcon = System.Windows.Forms.ToolTipIcon.None;
            this.boxYearMasked.InputCharacterErrorText = null;
            this.boxYearMasked.InputCharacterErrorTitle = null;
            this.boxYearMasked.Location = new System.Drawing.Point(14, 12);
            this.boxYearMasked.Mask = "00";
            this.boxYearMasked.MaskCompletedErrorText = null;
            this.boxYearMasked.MaskCompletedErrorTitle = null;
            this.boxYearMasked.MaskFulErrorText = null;
            this.boxYearMasked.MaskFulErrorTitle = null;
            this.boxYearMasked.Name = "boxYearMasked";
            this.boxYearMasked.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxYearMasked.Size = new System.Drawing.Size(205, 20);
            this.boxYearMasked.TabIndex = 0;
            this.boxYearMasked.TypeInvalidErrorText = null;
            this.boxYearMasked.TypeInvalidErrorTitle = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "سال*";
            // 
            // boxSemesterCombo
            // 
            this.boxSemesterCombo.FormattingEnabled = true;
            this.boxSemesterCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.boxSemesterCombo.Location = new System.Drawing.Point(14, 36);
            this.boxSemesterCombo.MaxLength = 1;
            this.boxSemesterCombo.Name = "boxSemesterCombo";
            this.boxSemesterCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxSemesterCombo.Size = new System.Drawing.Size(205, 21);
            this.boxSemesterCombo.TabIndex = 1;
            this.boxSemesterCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxNewSemesterCombo_KeyPress);
            this.boxSemesterCombo.Leave += new System.EventHandler(this.boxSemesterCombo_Leave);
            // 
            // TermForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(270, 100);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxYearMasked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxSemesterCombo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(286, 138);
            this.MinimumSize = new System.Drawing.Size(286, 138);
            this.Name = "TermForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مرحله 1 - انتخاب ترم";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private WiseTextBox.WiseMaskedTextBox boxYearMasked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxSemesterCombo;
    }
}