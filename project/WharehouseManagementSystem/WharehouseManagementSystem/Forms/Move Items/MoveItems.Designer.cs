
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
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.dgvWarehouseFrom = new System.Windows.Forms.DataGridView();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvWarehouseTo = new System.Windows.Forms.DataGridView();
            this.btnMove = new System.Windows.Forms.Button();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseTo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(13, 59);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 21);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // dgvWarehouseFrom
            // 
            this.dgvWarehouseFrom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouseFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouseFrom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.Item,
            this.quantity});
            this.dgvWarehouseFrom.Location = new System.Drawing.Point(13, 125);
            this.dgvWarehouseFrom.Name = "dgvWarehouseFrom";
            this.dgvWarehouseFrom.RowHeadersVisible = false;
            this.dgvWarehouseFrom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehouseFrom.Size = new System.Drawing.Size(353, 298);
            this.dgvWarehouseFrom.TabIndex = 1;
            this.dgvWarehouseFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarehouseFrom_CellClick);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(414, 59);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 21);
            this.cbTo.TabIndex = 2;
            this.cbTo.SelectedIndexChanged += new System.EventHandler(this.cbTo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // dgvWarehouseTo
            // 
            this.dgvWarehouseTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouseTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouseTo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvWarehouseTo.Location = new System.Drawing.Point(414, 125);
            this.dgvWarehouseTo.Name = "dgvWarehouseTo";
            this.dgvWarehouseTo.RowHeadersVisible = false;
            this.dgvWarehouseTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehouseTo.Size = new System.Drawing.Size(353, 298);
            this.dgvWarehouseTo.TabIndex = 5;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(367, 220);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(46, 35);
            this.btnMove.TabIndex = 6;
            this.btnMove.Text = ">>";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // orderNumber
            // 
            this.orderNumber.HeaderText = "Order Number";
            this.orderNumber.Name = "orderNumber";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Order Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // MoveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.dgvWarehouseTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.dgvWarehouseFrom);
            this.Controls.Add(this.cbFrom);
            this.Name = "MoveItems";
            this.Text = "MoveItems";
            this.Load += new System.EventHandler(this.MoveItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.DataGridView dgvWarehouseFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvWarehouseTo;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}