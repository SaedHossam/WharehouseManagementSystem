
namespace WharehouseManagementSystem.Forms.Reports
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.btnExpireReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExpireReport
            // 
            resources.ApplyResources(this.btnExpireReport, "btnExpireReport");
            this.btnExpireReport.Name = "btnExpireReport";
            this.btnExpireReport.UseVisualStyleBackColor = true;
            this.btnExpireReport.Click += new System.EventHandler(this.btnExpireReport_Click);
            // 
            // Reports
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExpireReport);
            this.Name = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExpireReport;
    }
}