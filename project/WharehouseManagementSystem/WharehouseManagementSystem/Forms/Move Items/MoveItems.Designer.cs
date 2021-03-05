
namespace WharehouseManagementSystem.Forms.Move_Items
{
    partial class MoveItems
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
            this.cbFromWarehouse = new System.Windows.Forms.ComboBox();
            this.dgvWarehouseItems = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbToWarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFromWarehouse
            // 
            this.cbFromWarehouse.FormattingEnabled = true;
            this.cbFromWarehouse.Location = new System.Drawing.Point(86, 80);
            this.cbFromWarehouse.Name = "cbFromWarehouse";
            this.cbFromWarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbFromWarehouse.TabIndex = 0;
            // 
            // dgvWarehouseItems
            // 
            this.dgvWarehouseItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouseItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.quantity});
            this.dgvWarehouseItems.Location = new System.Drawing.Point(34, 211);
            this.dgvWarehouseItems.Name = "dgvWarehouseItems";
            this.dgvWarehouseItems.Size = new System.Drawing.Size(319, 150);
            this.dgvWarehouseItems.TabIndex = 1;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // cbToWarehouse
            // 
            this.cbToWarehouse.FormattingEnabled = true;
            this.cbToWarehouse.Location = new System.Drawing.Point(318, 80);
            this.cbToWarehouse.Name = "cbToWarehouse";
            this.cbToWarehouse.Size = new System.Drawing.Size(121, 21);
            this.cbToWarehouse.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // MoveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbToWarehouse);
            this.Controls.Add(this.dgvWarehouseItems);
            this.Controls.Add(this.cbFromWarehouse);
            this.Name = "MoveItems";
            this.Text = "MoveItems";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFromWarehouse;
        private System.Windows.Forms.DataGridView dgvWarehouseItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.ComboBox cbToWarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}