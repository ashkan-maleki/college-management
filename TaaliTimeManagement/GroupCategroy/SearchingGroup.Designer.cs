namespace TaaliTimeManagement.GroupCategroy
{
    partial class SearchingGroup
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
            this.SuspendLayout();
            // 
            // boxYear
            // 
            this.boxYear.AutoSensitiveMaskCompleted = false;
            this.boxYear.AutoSensitiveTypeValidation = false;
            this.boxYear.EmptinessSensibility = false;
            // 
            // boxMajor
            // 
            this.boxMajor.EmptinessSensibility = false;
            // 
            // boxSemester
            // 
            this.boxSemester.AutoSensitiveMaskCompleted = false;
            this.boxSemester.AutoSensitiveTypeValidation = false;
            // 
            // boxGroupTitle
            // 
            this.boxGroupTitle.EmptinessSensibility = false;
            // 
            // boxNumberOFStudent
            // 
            this.boxNumberOFStudent.Enabled = false;
            // 
            // SearchingGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(434, 186);
            this.Name = "SearchingGroup";
            this.Text = "جستجوی گروه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
