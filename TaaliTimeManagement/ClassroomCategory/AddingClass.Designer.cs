namespace TaaliTimeManagement.ClassCategory
{
    partial class AddingClass
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
            this.boxDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxID = new WiseTextBox.WiseTextBox();
            this.boxFloor = new WiseTextBox.WiseTextBox();
            this.boxCapacity = new WiseTextBox.WiseTextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(47, 131);
            this.btnOK.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(128, 131);
            this.btnCancel.TabIndex = 7;
            // 
            // boxDepartment
            // 
            this.boxDepartment.Location = new System.Drawing.Point(19, 44);
            this.boxDepartment.Name = "boxDepartment";
            this.boxDepartment.Size = new System.Drawing.Size(147, 20);
            this.boxDepartment.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "ظرفیت*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "دانشکده";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "شماره*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "طبقه";
            // 
            // boxID
            // 
            this.boxID.DefaultText = null;
            this.boxID.EmptinessSensibility = true;
            this.boxID.EmptinessToolTipText = "لطفا شماره کلاس را وارد کنید";
            this.boxID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxID.Location = new System.Drawing.Point(19, 16);
            this.boxID.Name = "boxID";
            this.boxID.NumericSensibililty = true;
            this.boxID.NumericText = "";
            this.boxID.NumericToolTipText = "شماره باید فقط شامل اعداد باشد";
            this.boxID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxID.Size = new System.Drawing.Size(147, 20);
            this.boxID.TabIndex = 0;
            this.boxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_KeyPress);
            // 
            // boxFloor
            // 
            this.boxFloor.DefaultText = null;
            this.boxFloor.EmptinessSensibility = false;
            this.boxFloor.EmptinessToolTipText = null;
            this.boxFloor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxFloor.Location = new System.Drawing.Point(19, 70);
            this.boxFloor.Name = "boxFloor";
            this.boxFloor.NumericSensibililty = true;
            this.boxFloor.NumericText = "";
            this.boxFloor.NumericToolTipText = "طبقه باید فقط شامل اعداد باشد";
            this.boxFloor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxFloor.Size = new System.Drawing.Size(147, 20);
            this.boxFloor.TabIndex = 2;
            this.boxFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_KeyPress);
            // 
            // boxCapacity
            // 
            this.boxCapacity.DefaultText = null;
            this.boxCapacity.EmptinessSensibility = true;
            this.boxCapacity.EmptinessToolTipText = "لطفا ظرفیت کلاس را وارد کنید";
            this.boxCapacity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxCapacity.Location = new System.Drawing.Point(19, 96);
            this.boxCapacity.Name = "boxCapacity";
            this.boxCapacity.NumericSensibililty = true;
            this.boxCapacity.NumericText = "";
            this.boxCapacity.NumericToolTipText = "ظرفیت باید فقط شامل اعداد باشد";
            this.boxCapacity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxCapacity.Size = new System.Drawing.Size(147, 20);
            this.boxCapacity.TabIndex = 3;
            this.boxCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_KeyPress);
            // 
            // AddingClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(251, 171);
            this.Controls.Add(this.boxID);
            this.Controls.Add(this.boxFloor);
            this.Controls.Add(this.boxDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxCapacity);
            this.MaximumSize = new System.Drawing.Size(267, 209);
            this.MinimumSize = new System.Drawing.Size(267, 209);
            this.Name = "AddingClass";
            this.Text = "افزودن کلاس";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.boxCapacity, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.boxDepartment, 0);
            this.Controls.SetChildIndex(this.boxFloor, 0);
            this.Controls.SetChildIndex(this.boxID, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected WiseTextBox.WiseTextBox boxFloor;
        protected System.Windows.Forms.TextBox boxDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        protected WiseTextBox.WiseTextBox boxCapacity;
        protected WiseTextBox.WiseTextBox boxID;

    }
}
