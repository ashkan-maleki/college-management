namespace TaaliTimeManagement.TypeCategory
{
    partial class AddingType
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
            this.boxTheoryCheck = new System.Windows.Forms.CheckBox();
            this.boxType = new WiseTextBox.WiseTextBox();
            this.boxPrice = new WiseTextBox.WiseTextBox();
            this.boxHours = new WiseTextBox.WiseTextBox();
            this.boxSalary = new WiseTextBox.WiseTextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(74, 152);
            this.btnOK.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 152);
            this.btnCancel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "نوع*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "ساعات به ازای یک واحد*";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "دستمزد به ازای یک واحد*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "قیمت به ازای یک واحد*";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "تئوری*";
            // 
            // boxTheoryCheck
            // 
            this.boxTheoryCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxTheoryCheck.AutoSize = true;
            this.boxTheoryCheck.Checked = true;
            this.boxTheoryCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boxTheoryCheck.Location = new System.Drawing.Point(150, 116);
            this.boxTheoryCheck.Name = "boxTheoryCheck";
            this.boxTheoryCheck.Size = new System.Drawing.Size(15, 14);
            this.boxTheoryCheck.TabIndex = 65;
            this.boxTheoryCheck.UseVisualStyleBackColor = true;
            // 
            // boxType
            // 
            this.boxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxType.DefaultText = null;
            this.boxType.EmptinessSensibility = true;
            this.boxType.EmptinessToolTipText = "لطفا نوع درس را وارد کنید";
            this.boxType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxType.Location = new System.Drawing.Point(12, 12);
            this.boxType.Name = "boxType";
            this.boxType.NumericSensibililty = false;
            this.boxType.NumericText = "";
            this.boxType.NumericToolTipText = "";
            this.boxType.Size = new System.Drawing.Size(153, 20);
            this.boxType.TabIndex = 0;
            // 
            // boxPrice
            // 
            this.boxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxPrice.DefaultText = null;
            this.boxPrice.EmptinessSensibility = true;
            this.boxPrice.EmptinessToolTipText = "لطفا قیمت درس را وارد کنید";
            this.boxPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxPrice.Location = new System.Drawing.Point(12, 90);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.NumericSensibililty = true;
            this.boxPrice.NumericText = "";
            this.boxPrice.NumericToolTipText = "قیمت باید فقط شامل اعداد باشد";
            this.boxPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxPrice.Size = new System.Drawing.Size(153, 20);
            this.boxPrice.TabIndex = 3;
            this.boxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_KeyPress);
            // 
            // boxHours
            // 
            this.boxHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxHours.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxHours.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxHours.DefaultText = null;
            this.boxHours.EmptinessSensibility = true;
            this.boxHours.EmptinessToolTipText = "لطفا ساعات درس را وارد کنید";
            this.boxHours.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxHours.Location = new System.Drawing.Point(12, 38);
            this.boxHours.Name = "boxHours";
            this.boxHours.NumericSensibililty = true;
            this.boxHours.NumericText = "";
            this.boxHours.NumericToolTipText = "ساعات باید فقط شامل اعداد باشد";
            this.boxHours.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxHours.Size = new System.Drawing.Size(153, 20);
            this.boxHours.TabIndex = 1;
            this.boxHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_KeyPress);
            // 
            // boxSalary
            // 
            this.boxSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxSalary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxSalary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxSalary.DefaultText = null;
            this.boxSalary.EmptinessSensibility = true;
            this.boxSalary.EmptinessToolTipText = "لطفا دستمزد درس را وارد کنید";
            this.boxSalary.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxSalary.Location = new System.Drawing.Point(12, 64);
            this.boxSalary.Name = "boxSalary";
            this.boxSalary.NumericSensibililty = true;
            this.boxSalary.NumericText = "";
            this.boxSalary.NumericToolTipText = "دستمزد باید فقط شامل اعداد باشد";
            this.boxSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxSalary.Size = new System.Drawing.Size(153, 20);
            this.boxSalary.TabIndex = 2;
            this.boxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_KeyPress);
            // 
            // AddingType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(304, 187);
            this.Controls.Add(this.boxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxTheoryCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxPrice);
            this.Controls.Add(this.boxHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxSalary);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(320, 225);
            this.MinimumSize = new System.Drawing.Size(320, 225);
            this.Name = "AddingType";
            this.Text = "افزودن نوع درس";
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.boxSalary, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.boxHours, 0);
            this.Controls.SetChildIndex(this.boxPrice, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.boxTheoryCheck, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.boxType, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected WiseTextBox.WiseTextBox boxHours;
        protected WiseTextBox.WiseTextBox boxSalary;
        protected WiseTextBox.WiseTextBox boxPrice;
        protected WiseTextBox.WiseTextBox boxType;
        protected System.Windows.Forms.CheckBox boxTheoryCheck;
    }
}
