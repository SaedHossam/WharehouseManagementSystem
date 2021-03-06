
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
            this.btnExpireReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExpireReport
            // 
            this.btnExpireReport.Location = new System.Drawing.Point(79, 50);
            this.btnExpireReport.Name = "btnExpireReport";
            this.btnExpireReport.Size = new System.Drawing.Size(132, 77);
            this.btnExpireReport.TabIndex = 0;
            this.btnExpireReport.Text = "Items about to Expire";
            this.btnExpireReport.UseVisualStyleBackColor = true;
            this.btnExpireReport.Click += new System.EventHandler(this.btnExpireReport_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExpireReport);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExpireReport;
    }
}