namespace TaaliTimeManagement.MajorCategory
{
    partial class AddingMajor
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
            this.boxBranch = new WiseTextBox.WiseTextBox();
            this.boxTitle = new WiseTextBox.WiseTextBox();
            this.boxMajorLevel = new WiseTextBox.WiseTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(68, 113);
            this.btnOK.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(149, 113);
            this.btnCancel.TabIndex = 4;
            // 
            // boxBranch
            // 
            this.boxBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxBranch.DefaultText = null;
            this.boxBranch.EmptinessSensibility = false;
            this.boxBranch.EmptinessToolTipText = null;
            this.boxBranch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxBranch.Location = new System.Drawing.Point(11, 75);
            this.boxBranch.Name = "boxBranch";
            this.boxBranch.NumericSensibililty = false;
            this.boxBranch.NumericText = "";
            this.boxBranch.NumericToolTipText = null;
            this.boxBranch.Size = new System.Drawing.Size(190, 20);
            this.boxBranch.TabIndex = 2;
            // 
            // boxTitle
            // 
            this.boxTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxTitle.DefaultText = null;
            this.boxTitle.EmptinessSensibility = true;
            this.boxTitle.EmptinessToolTipText = "لطفا اطلاعات مربوط به عنوان رشته را وارد کنید";
            this.boxTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxTitle.Location = new System.Drawing.Point(11, 45);
            this.boxTitle.Name = "boxTitle";
            this.boxTitle.NumericSensibililty = false;
            this.boxTitle.NumericText = "";
            this.boxTitle.NumericToolTipText = null;
            this.boxTitle.Size = new System.Drawing.Size(190, 20);
            this.boxTitle.TabIndex = 1;
            // 
            // boxMajorLevel
            // 
            this.boxMajorLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxMajorLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxMajorLevel.DefaultText = null;
            this.boxMajorLevel.EmptinessSensibility = true;
            this.boxMajorLevel.EmptinessToolTipText = "لطفا اطلاعات مربوط به مقطع تحصیلی را وارد کنید";
            this.boxMajorLevel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxMajorLevel.Location = new System.Drawing.Point(11, 12);
            this.boxMajorLevel.MaximumSize = new System.Drawing.Size(190, 20);
            this.boxMajorLevel.MinimumSize = new System.Drawing.Size(190, 20);
            this.boxMajorLevel.Name = "boxMajorLevel";
            this.boxMajorLevel.NumericSensibililty = false;
            this.boxMajorLevel.NumericText = "";
            this.boxMajorLevel.NumericToolTipText = null;
            this.boxMajorLevel.Size = new System.Drawing.Size(190, 20);
            this.boxMajorLevel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "گرایش تحصیلی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "عنوان رشته*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "مقطع تحصیلی*";
            // 
            // AddingMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(292, 148);
            this.Controls.Add(this.boxBranch);
            this.Controls.Add(this.boxTitle);
            this.Controls.Add(this.boxMajorLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddingMajor";
            this.Text = "افزودن رشته";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.boxMajorLevel, 0);
            this.Controls.SetChildIndex(this.boxTitle, 0);
            this.Controls.SetChildIndex(this.boxBranch, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected WiseTextBox.WiseTextBox boxBranch;
        protected WiseTextBox.WiseTextBox boxTitle;
        protected WiseTextBox.WiseTextBox boxMajorLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
