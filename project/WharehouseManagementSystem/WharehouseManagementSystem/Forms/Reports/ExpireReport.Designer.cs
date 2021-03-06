
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
            this.cbWarehouses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // cbWarehouses
            // 
            this.cbWarehouses.FormattingEnabled = true;
            this.cbWarehouses.Location = new System.Drawing.Point(44, 72);
            this.cbWarehouses.Name = "cbWarehouses";
            this.cbWarehouses.Size = new System.Drawing.Size(121, 21);
            this.cbWarehouses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warehouse";
            // 
            // dgvItems
            // 
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
            this.dgvItems.Location = new System.Drawing.Point(12, 209);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.Size = new System.Drawing.Size(776, 229);
            this.dgvItems.TabIndex = 2;
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(229, 72);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(120, 20);
            this.nudDuration.TabIndex = 3;
            this.nudDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudDuration_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remaining Duration";
            // 
            // orderId
            // 
            this.orderId.HeaderText = "Order Number";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // productionDate
            // 
            this.productionDate.HeaderText = "Production Date";
            this.productionDate.Name = "productionDate";
            this.productionDate.ReadOnly = true;
            // 
            // expirationDate
            // 
            this.expirationDate.HeaderText = "Expiration Date";
            this.expirationDate.Name = "expirationDate";
            this.expirationDate.ReadOnly = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(548, 68);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(86, 39);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View Report";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // ExpireReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbWarehouses);
            this.Name = "ExpireReport";
            this.Text = "ExpireReport";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDate;
        private System.Windows.Forms.Button btnView;
    }
}