
namespace WharehouseManagementSystem
{
    partial class PaymentOrderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentOrderInfo));
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbSupplyingOrders = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbWharehouses = new System.Windows.Forms.ComboBox();
            this.nudItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUnits = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wharehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderItems
            // 
            resources.ApplyResources(this.dgvOrderItems, "dgvOrderItems");
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            this.dgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.quantity,
            this.productionDate,
            this.expirationDate,
            this.wharehouse,
            this.supplier});
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersVisible = false;
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.cbSupplyingOrders);
            this.groupBox2.Controls.Add(this.cbUnits);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudItemQuantity);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.cbWharehouses);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbItems);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnAddItem
            // 
            resources.ApplyResources(this.btnAddItem, "btnAddItem");
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbSupplyingOrders
            // 
            resources.ApplyResources(this.cbSupplyingOrders, "cbSupplyingOrders");
            this.cbSupplyingOrders.FormattingEnabled = true;
            this.cbSupplyingOrders.Name = "cbSupplyingOrders";
            this.cbSupplyingOrders.SelectedIndexChanged += new System.EventHandler(this.cbSupplyingOrders_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // cbWharehouses
            // 
            resources.ApplyResources(this.cbWharehouses, "cbWharehouses");
            this.cbWharehouses.FormattingEnabled = true;
            this.cbWharehouses.Name = "cbWharehouses";
            this.cbWharehouses.SelectedIndexChanged += new System.EventHandler(this.cbWharehouses_SelectedIndexChanged);
            // 
            // nudItemQuantity
            // 
            resources.ApplyResources(this.nudItemQuantity, "nudItemQuantity");
            this.nudItemQuantity.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudItemQuantity.Name = "nudItemQuantity";
            this.nudItemQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudItemQuantity_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbUnits
            // 
            resources.ApplyResources(this.cbUnits, "cbUnits");
            this.cbUnits.FormattingEnabled = true;
            this.cbUnits.Name = "cbUnits";
            this.cbUnits.SelectedIndexChanged += new System.EventHandler(this.cbUnits_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbItems
            // 
            resources.ApplyResources(this.cbItems, "cbItems");
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Name = "cbItems";
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.dtpOrderDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOrderNum);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtCustomer
            // 
            resources.ApplyResources(this.txtCustomer, "txtCustomer");
            this.txtCustomer.Name = "txtCustomer";
            // 
            // dtpOrderDate
            // 
            resources.ApplyResources(this.dtpOrderDate, "dtpOrderDate");
            this.dtpOrderDate.Name = "dtpOrderDate";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtOrderNum
            // 
            resources.ApplyResources(this.txtOrderNum, "txtOrderNum");
            this.txtOrderNum.Name = "txtOrderNum";
            // 
            // itemName
            // 
            resources.ApplyResources(this.itemName, "itemName");
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
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
            // PaymentOrderInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentOrderInfo";
            this.Load += new System.EventHandler(this.PaymentOrderInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.NumericUpDown nudItemQuantity;
        private System.Windows.Forms.ComboBox cbUnits;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.ComboBox cbSupplyingOrders;
        private System.Windows.Forms.ComboBox cbWharehouses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn wharehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
    }
}