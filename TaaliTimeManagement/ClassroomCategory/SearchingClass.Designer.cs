namespace TaaliTimeManagement.ClassCategory
{
    partial class SearchingClass
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
            // boxFloor
            // 
            this.boxFloor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxFloor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // boxDepartment
            // 
            this.boxDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // boxCapacity
            // 
            this.boxCapacity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxCapacity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxCapacity.EmptinessSensibility = false;
            // 
            // boxID
            // 
            this.boxID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.boxID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.boxID.EmptinessSensibility = false;
            // 
            // SearchingClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(251, 216);
            this.Name = "SearchingClass";
            this.Text = "جستجو کلاس";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
