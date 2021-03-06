
namespace WharehouseManagementSystem
{
    partial class SupplingOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplingOrders));
            this.dgvSupplyOrders = new System.Windows.Forms.DataGridView();
            this.order_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wharehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.cbWarehouses = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.btnEditItems = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplyOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplyOrders
            // 
            resources.ApplyResources(this.dgvSupplyOrders, "dgvSupplyOrders");
            this.dgvSupplyOrders.AllowUserToAddRows = false;
            this.dgvSupplyOrders.AllowUserToDeleteRows = false;
            this.dgvSupplyOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplyOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_number,
            this.wharehouse,
            this.supplier,
            this.date});
            this.dgvSupplyOrders.Name = "dgvSupplyOrders";
            this.dgvSupplyOrders.ReadOnly = true;
            this.dgvSupplyOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplyOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplyOrders_CellClick);
            // 
            // order_number
            // 
            resources.ApplyResources(this.order_number, "order_number");
            this.order_number.Name = "order_number";
            this.order_number.ReadOnly = true;
            // 
            // wharehouse
            // 
            resources.ApplyResources(this.wharehouse, "wharehouse");
            this.wharehouse.Name = "wharehouse";
            this.wharehouse.ReadOnly = true;
            // 
            // supplier
            // 
            resources.ApplyResources(this.supplier, "supplier");
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // btnEditOrder
            // 
            resources.ApplyResources(this.btnEditOrder, "btnEditOrder");
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnNew
            // 
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Name = "btnNew";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtOrderNumber
            // 
            resources.ApplyResources(this.txtOrderNumber, "txtOrderNumber");
            this.txtOrderNumber.Name = "txtOrderNumber";
            // 
            // cbWarehouses
            // 
            resources.ApplyResources(this.cbWarehouses, "cbWarehouses");
            this.cbWarehouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarehouses.FormattingEnabled = true;
            this.cbWarehouses.Name = "cbWarehouses";
            // 
            // dtpDate
            // 
            resources.ApplyResources(this.dtpDate, "dtpDate");
            this.dtpDate.Name = "dtpDate";
            // 
            // cbSuppliers
            // 
            resources.ApplyResources(this.cbSuppliers, "cbSuppliers");
            this.cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Name = "cbSuppliers";
            // 
            // btnEditItems
            // 
            resources.ApplyResources(this.btnEditItems, "btnEditItems");
            this.btnEditItems.Name = "btnEditItems";
            this.btnEditItems.UseVisualStyleBackColor = true;
            this.btnEditItems.Click += new System.EventHandler(this.btnEditItems_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // SupplingOrders
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditItems);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbWarehouses);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.dgvSupplyOrders);
            this.Name = "SupplingOrders";
            this.Load += new System.EventHandler(this.SupplingOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplyOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSupplyOrders;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn wharehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.ComboBox cbWarehouses;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Button btnEditItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}