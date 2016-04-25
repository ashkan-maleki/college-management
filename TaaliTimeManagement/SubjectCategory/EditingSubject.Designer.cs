namespace TaaliTimeManagement.SubjectCategory
{
    partial class EditingSubject
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
            // btnAddType
            // 
            this.btnAddType.Enabled = false;
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Enabled = true;
            // 
            // boxIDMask
            // 
            this.boxIDMask.Enabled = false;
            // 
            // EditingSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(383, 226);
            this.Name = "EditingSubject";
            this.Text = "اصلاح درس";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
