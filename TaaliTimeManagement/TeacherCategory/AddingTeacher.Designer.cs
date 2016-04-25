namespace TaaliTimeManagement.TeacherCategory
{
    partial class AddingTeacher
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
            this.boxLastName = new WiseTextBox.WiseTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxSubjectsCombo = new System.Windows.Forms.ComboBox();
            this.boxTimesCombo = new System.Windows.Forms.ComboBox();
            this.btnAddSubjects = new System.Windows.Forms.Button();
            this.btnDeleteSubjects = new System.Windows.Forms.Button();
            this.btnAddTimes = new System.Windows.Forms.Button();
            this.btnDeleteTimes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boxFirstName = new WiseTextBox.WiseTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(150, 132);
            this.btnOK.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 132);
            this.btnCancel.TabIndex = 5;
            // 
            // boxLastName
            // 
            this.boxLastName.DefaultText = null;
            this.boxLastName.EmptinessSensibility = true;
            this.boxLastName.EmptinessToolTipText = "لطفا نام خانوادگی استاد را وارد کنید";
            this.boxLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxLastName.Location = new System.Drawing.Point(87, 40);
            this.boxLastName.Name = "boxLastName";
            this.boxLastName.NumericSensibililty = false;
            this.boxLastName.NumericText = "";
            this.boxLastName.NumericToolTipText = null;
            this.boxLastName.Size = new System.Drawing.Size(246, 20);
            this.boxLastName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 89;
            this.label6.Text = "نام خانوادگی*";
            // 
            // boxSubjectsCombo
            // 
            this.boxSubjectsCombo.FormattingEnabled = true;
            this.boxSubjectsCombo.Location = new System.Drawing.Point(87, 97);
            this.boxSubjectsCombo.Name = "boxSubjectsCombo";
            this.boxSubjectsCombo.Size = new System.Drawing.Size(246, 21);
            this.boxSubjectsCombo.TabIndex = 88;
            // 
            // boxTimesCombo
            // 
            this.boxTimesCombo.FormattingEnabled = true;
            this.boxTimesCombo.Location = new System.Drawing.Point(87, 68);
            this.boxTimesCombo.Name = "boxTimesCombo";
            this.boxTimesCombo.Size = new System.Drawing.Size(246, 21);
            this.boxTimesCombo.TabIndex = 87;
            // 
            // btnAddSubjects
            // 
            this.btnAddSubjects.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Plus_Blue_32x42_72;
            this.btnAddSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSubjects.Location = new System.Drawing.Point(47, 95);
            this.btnAddSubjects.Name = "btnAddSubjects";
            this.btnAddSubjects.Size = new System.Drawing.Size(34, 23);
            this.btnAddSubjects.TabIndex = 3;
            this.btnAddSubjects.UseVisualStyleBackColor = true;
            this.btnAddSubjects.Click += new System.EventHandler(this.btnAddSubjects_Click);
            // 
            // btnDeleteSubjects
            // 
            this.btnDeleteSubjects.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnDeleteSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteSubjects.Enabled = false;
            this.btnDeleteSubjects.Location = new System.Drawing.Point(10, 95);
            this.btnDeleteSubjects.Name = "btnDeleteSubjects";
            this.btnDeleteSubjects.Size = new System.Drawing.Size(34, 23);
            this.btnDeleteSubjects.TabIndex = 7;
            this.btnDeleteSubjects.UseVisualStyleBackColor = true;
            this.btnDeleteSubjects.Click += new System.EventHandler(this.btnDeleteSubjects_Click);
            // 
            // btnAddTimes
            // 
            this.btnAddTimes.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Plus_Blue_32x42_72;
            this.btnAddTimes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTimes.Location = new System.Drawing.Point(47, 66);
            this.btnAddTimes.Name = "btnAddTimes";
            this.btnAddTimes.Size = new System.Drawing.Size(34, 23);
            this.btnAddTimes.TabIndex = 2;
            this.btnAddTimes.UseVisualStyleBackColor = true;
            this.btnAddTimes.Click += new System.EventHandler(this.btnAddTimes_Click);
            // 
            // btnDeleteTimes
            // 
            this.btnDeleteTimes.BackgroundImage = global::TaaliTimeManagement.Properties.Resources._112_Minus_Orange_32x42_72;
            this.btnDeleteTimes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteTimes.Enabled = false;
            this.btnDeleteTimes.Location = new System.Drawing.Point(10, 66);
            this.btnDeleteTimes.Name = "btnDeleteTimes";
            this.btnDeleteTimes.Size = new System.Drawing.Size(34, 23);
            this.btnDeleteTimes.TabIndex = 6;
            this.btnDeleteTimes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "نام*";
            // 
            // boxFirstName
            // 
            this.boxFirstName.DefaultText = null;
            this.boxFirstName.EmptinessSensibility = true;
            this.boxFirstName.EmptinessToolTipText = "لطفا نام استاد را وارد کنید";
            this.boxFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.boxFirstName.Location = new System.Drawing.Point(87, 12);
            this.boxFirstName.Name = "boxFirstName";
            this.boxFirstName.NumericSensibililty = false;
            this.boxFirstName.NumericText = "";
            this.boxFirstName.NumericToolTipText = null;
            this.boxFirstName.Size = new System.Drawing.Size(246, 20);
            this.boxFirstName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "دروس قادر به تدریس*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "زمان های حضور*";
            // 
            // AddingTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(456, 167);
            this.Controls.Add(this.boxLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxSubjectsCombo);
            this.Controls.Add(this.boxTimesCombo);
            this.Controls.Add(this.btnAddSubjects);
            this.Controls.Add(this.btnDeleteSubjects);
            this.Controls.Add(this.btnAddTimes);
            this.Controls.Add(this.btnDeleteTimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "AddingTeacher";
            this.Text = "افزودن استاد";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.boxFirstName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnDeleteTimes, 0);
            this.Controls.SetChildIndex(this.btnAddTimes, 0);
            this.Controls.SetChildIndex(this.btnDeleteSubjects, 0);
            this.Controls.SetChildIndex(this.btnAddSubjects, 0);
            this.Controls.SetChildIndex(this.boxTimesCombo, 0);
            this.Controls.SetChildIndex(this.boxSubjectsCombo, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.boxLastName, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected WiseTextBox.WiseTextBox boxLastName;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.ComboBox boxSubjectsCombo;
        protected System.Windows.Forms.ComboBox boxTimesCombo;
        protected System.Windows.Forms.Button btnAddSubjects;
        protected System.Windows.Forms.Button btnDeleteSubjects;
        protected System.Windows.Forms.Button btnAddTimes;
        protected System.Windows.Forms.Button btnDeleteTimes;
        private System.Windows.Forms.Label label2;
        protected WiseTextBox.WiseTextBox boxFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
