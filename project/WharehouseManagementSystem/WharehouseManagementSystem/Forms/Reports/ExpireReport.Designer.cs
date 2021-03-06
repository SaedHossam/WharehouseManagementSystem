
namespace WharehouseManagementSystem.Forms.Reports
{
    partial class ExpireReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpireReport));
            this.cbWarehouses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // cbWarehouses
            // 
            resources.ApplyResources(this.cbWarehouses, "cbWarehouses");
            this.cbWarehouses.FormattingEnabled = true;
            this.cbWarehouses.Name = "cbWarehouses";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgvItems
            // 
            resources.ApplyResources(this.dgvItems, "dgvItems");
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.ItemName,
            this.quantity,
            this.productionDate,
            this.expirationDate});
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            // 
            // nudDuration
            // 
            resources.ApplyResources(this.nudDuration, "nudDuration");
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudDuration_KeyPress);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnView
            // 
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // orderId
            // 
            resources.ApplyResources(this.orderId, "orderId");
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // ItemName
            // 
            resources.ApplyResources(this.ItemName, "ItemName");
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // quantity
            // 
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // productionDate
            // 
            resources.ApplyResources(this.productionDate, "productionDate");
            this.productionDate.Name = "productionDate";
            this.productionDate.ReadOnly = true;
            // 
            // expirationDate
            // 
            resources.ApplyResources(this.expirationDate, "expirationDate");
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.ReadOnly = true;
            // 
            // ExpireReport
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWarehouses);
            this.Name = "ExpireReport";
            this.Load += new System.EventHandler(this.ExpireReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWarehouses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDate;
    }
}