
namespace WharehouseManagementSystem
{
    partial class PaymentOrder
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditItems = new System.Windows.Forms.Button();
            this.cbCustomers = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.dgvPaymentOrders = new System.Windows.Forms.DataGridView();
            this.order_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.arabicToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageToolStripMenuItem.Text = "&Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // arabicToolStripMenuItem
            // 
            this.arabicToolStripMenuItem.Name = "arabicToolStripMenuItem";
            this.arabicToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.arabicToolStripMenuItem.Text = "العربية - مصر";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.customerName,
            this.date});
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 263);
            this.dataGridView1.TabIndex = 10;
            // 
            // orderNumber
            // 
            this.orderNumber.Frozen = true;
            this.orderNumber.HeaderText = "#";
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Orders List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(339, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(162, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Customer";
            // 
            // btnEditItems
            // 
            this.btnEditItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditItems.Location = new System.Drawing.Point(675, 47);
            this.btnEditItems.Name = "btnEditItems";
            this.btnEditItems.Size = new System.Drawing.Size(75, 23);
            this.btnEditItems.TabIndex = 25;
            this.btnEditItems.Text = "Edit Items";
            this.btnEditItems.UseVisualStyleBackColor = true;
            this.btnEditItems.Click += new System.EventHandler(this.btnEditItems_Click);
            // 
            // cbCustomers
            // 
            this.cbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomers.FormattingEnabled = true;
            this.cbCustomers.Location = new System.Drawing.Point(165, 45);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(121, 21);
            this.cbCustomers.TabIndex = 24;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(342, 46);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(131, 20);
            this.dtpDate.TabIndex = 23;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Enabled = false;
            this.txtOrderNumber.Location = new System.Drawing.Point(12, 46);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNumber.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(9, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Order Number";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Enabled = false;
            this.btnDeleteOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteOrder.Location = new System.Drawing.Point(690, 100);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrder.TabIndex = 19;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNewOrder.Location = new System.Drawing.Point(513, 100);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 18;
            this.btnNewOrder.Text = "New";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditOrder.Location = new System.Drawing.Point(595, 100);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(75, 23);
            this.btnEditOrder.TabIndex = 17;
            this.btnEditOrder.Text = "Edit Info";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click_1);
            // 
            // dgvPaymentOrders
            // 
            this.dgvPaymentOrders.AllowUserToAddRows = false;
            this.dgvPaymentOrders.AllowUserToDeleteRows = false;
            this.dgvPaymentOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPaymentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_number,
            this.customer,
            this.dataGridViewTextBoxColumn1});
            this.dgvPaymentOrders.Location = new System.Drawing.Point(0, 129);
            this.dgvPaymentOrders.Name = "dgvPaymentOrders";
            this.dgvPaymentOrders.ReadOnly = true;
            this.dgvPaymentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentOrders.Size = new System.Drawing.Size(800, 319);
            this.dgvPaymentOrders.TabIndex = 16;
            this.dgvPaymentOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentOrders_CellClick);
            // 
            // order_number
            // 
            this.order_number.HeaderText = "#";
            this.order_number.Name = "order_number";
            this.order_number.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // PaymentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditItems);
            this.Controls.Add(this.cbCustomers);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.dgvPaymentOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PaymentOrder";
            this.Text = "Payment Order";
            this.Load += new System.EventHandler(this.PaymentOrder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabicToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditItems;
        private System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.DataGridView dgvPaymentOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}