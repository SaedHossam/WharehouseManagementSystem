
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
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wharehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderItems
            // 
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
            this.dgvOrderItems.Location = new System.Drawing.Point(3, 254);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersVisible = false;
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems.Size = new System.Drawing.Size(743, 155);
            this.dgvOrderItems.TabIndex = 7;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
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
            // wharehouse
            // 
            this.wharehouse.HeaderText = "Wharehouse";
            this.wharehouse.Name = "wharehouse";
            this.wharehouse.ReadOnly = true;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Supplier";
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.cbSupplyingOrders);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.cbWharehouses);
            this.groupBox2.Controls.Add(this.nudItemQuantity);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbUnits);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbItems);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(3, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Info";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(344, 71);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 20;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(631, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbSupplyingOrders
            // 
            this.cbSupplyingOrders.FormattingEnabled = true;
            this.cbSupplyingOrders.Location = new System.Drawing.Point(171, 33);
            this.cbSupplyingOrders.Name = "cbSupplyingOrders";
            this.cbSupplyingOrders.Size = new System.Drawing.Size(121, 21);
            this.cbSupplyingOrders.TabIndex = 6;
            this.cbSupplyingOrders.SelectedIndexChanged += new System.EventHandler(this.cbSupplyingOrders_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(483, 71);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // cbWharehouses
            // 
            this.cbWharehouses.FormattingEnabled = true;
            this.cbWharehouses.Location = new System.Drawing.Point(23, 32);
            this.cbWharehouses.Name = "cbWharehouses";
            this.cbWharehouses.Size = new System.Drawing.Size(121, 21);
            this.cbWharehouses.TabIndex = 5;
            this.cbWharehouses.SelectedIndexChanged += new System.EventHandler(this.cbWharehouses_SelectedIndexChanged);
            // 
            // nudItemQuantity
            // 
            this.nudItemQuantity.Location = new System.Drawing.Point(613, 33);
            this.nudItemQuantity.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudItemQuantity.Name = "nudItemQuantity";
            this.nudItemQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudItemQuantity.TabIndex = 13;
            this.nudItemQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudItemQuantity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplying Order Number";
            // 
            // cbUnits
            // 
            this.cbUnits.FormattingEnabled = true;
            this.cbUnits.Location = new System.Drawing.Point(473, 33);
            this.cbUnits.Name = "cbUnits";
            this.cbUnits.Size = new System.Drawing.Size(121, 21);
            this.cbUnits.TabIndex = 12;
            this.cbUnits.SelectedIndexChanged += new System.EventHandler(this.cbUnits_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wharehouse";
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(325, 32);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(121, 21);
            this.cbItems.TabIndex = 11;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Item Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.dtpOrderDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOrderNum);
            this.groupBox1.Location = new System.Drawing.Point(3, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "order info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(150, 46);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtCustomer.TabIndex = 21;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Enabled = false;
            this.dtpOrderDate.Location = new System.Drawing.Point(278, 46);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Number";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Enabled = false;
            this.txtOrderNum.Location = new System.Drawing.Point(34, 46);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(100, 20);
            this.txtOrderNum.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
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
            // PaymentOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentOrderInfo";
            this.Text = "PaymentOrderInfo";
            this.Load += new System.EventHandler(this.PaymentOrderInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabicToolStripMenuItem;
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