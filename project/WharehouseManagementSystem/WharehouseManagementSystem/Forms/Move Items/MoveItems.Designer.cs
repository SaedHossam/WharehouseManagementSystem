
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveItems));
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
            resources.ApplyResources(this.cbFrom, "cbFrom");
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // dgvWarehouseFrom
            // 
            resources.ApplyResources(this.dgvWarehouseFrom, "dgvWarehouseFrom");
            this.dgvWarehouseFrom.AllowUserToAddRows = false;
            this.dgvWarehouseFrom.AllowUserToDeleteRows = false;
            this.dgvWarehouseFrom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouseFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouseFrom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.Item,
            this.quantity});
            this.dgvWarehouseFrom.Name = "dgvWarehouseFrom";
            this.dgvWarehouseFrom.RowHeadersVisible = false;
            this.dgvWarehouseFrom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehouseFrom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarehouseFrom_CellClick);
            // 
            // cbTo
            // 
            resources.ApplyResources(this.cbTo, "cbTo");
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Name = "cbTo";
            this.cbTo.SelectedIndexChanged += new System.EventHandler(this.cbTo_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dgvWarehouseTo
            // 
            resources.ApplyResources(this.dgvWarehouseTo, "dgvWarehouseTo");
            this.dgvWarehouseTo.AllowUserToAddRows = false;
            this.dgvWarehouseTo.AllowUserToDeleteRows = false;
            this.dgvWarehouseTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouseTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouseTo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvWarehouseTo.Name = "dgvWarehouseTo";
            this.dgvWarehouseTo.RowHeadersVisible = false;
            this.dgvWarehouseTo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btnMove
            // 
            resources.ApplyResources(this.btnMove, "btnMove");
            this.btnMove.Name = "btnMove";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // orderNumber
            // 
            resources.ApplyResources(this.orderNumber, "orderNumber");
            this.orderNumber.Name = "orderNumber";
            // 
            // Item
            // 
            resources.ApplyResources(this.Item, "Item");
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // quantity
            // 
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // MoveItems
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.dgvWarehouseTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.dgvWarehouseFrom);
            this.Controls.Add(this.cbFrom);
            this.Name = "MoveItems";
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