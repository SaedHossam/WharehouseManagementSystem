
namespace WharehouseManagementSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSupplyOrder = new System.Windows.Forms.Button();
            this.btnPaymentOrder = new System.Windows.Forms.Button();
            this.btnMoveItems = new System.Windows.Forms.Button();
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnWharehouses = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.arabicToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // arabicToolStripMenuItem
            // 
            this.arabicToolStripMenuItem.Name = "arabicToolStripMenuItem";
            resources.ApplyResources(this.arabicToolStripMenuItem, "arabicToolStripMenuItem");
            this.arabicToolStripMenuItem.Click += new System.EventHandler(this.arabicToolStripMenuItem_Click);
            // 
            // btnSupplyOrder
            // 
            resources.ApplyResources(this.btnSupplyOrder, "btnSupplyOrder");
            this.btnSupplyOrder.Name = "btnSupplyOrder";
            this.btnSupplyOrder.UseVisualStyleBackColor = true;
            this.btnSupplyOrder.Click += new System.EventHandler(this.btnSupplyOrder_Click);
            // 
            // btnPaymentOrder
            // 
            resources.ApplyResources(this.btnPaymentOrder, "btnPaymentOrder");
            this.btnPaymentOrder.Name = "btnPaymentOrder";
            this.btnPaymentOrder.UseVisualStyleBackColor = true;
            this.btnPaymentOrder.Click += new System.EventHandler(this.btnPaymentOrder_Click);
            // 
            // btnMoveItems
            // 
            resources.ApplyResources(this.btnMoveItems, "btnMoveItems");
            this.btnMoveItems.Name = "btnMoveItems";
            this.btnMoveItems.UseVisualStyleBackColor = true;
            this.btnMoveItems.Click += new System.EventHandler(this.btnMoveItems_Click);
            // 
            // btnUnits
            // 
            resources.ApplyResources(this.btnUnits, "btnUnits");
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.UseVisualStyleBackColor = true;
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // btnItems
            // 
            resources.ApplyResources(this.btnItems, "btnItems");
            this.btnItems.Name = "btnItems";
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnWharehouses
            // 
            resources.ApplyResources(this.btnWharehouses, "btnWharehouses");
            this.btnWharehouses.Name = "btnWharehouses";
            this.btnWharehouses.UseVisualStyleBackColor = true;
            this.btnWharehouses.Click += new System.EventHandler(this.btnWharehouses_Click);
            // 
            // btnReports
            // 
            resources.ApplyResources(this.btnReports, "btnReports");
            this.btnReports.Name = "btnReports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnEmployees
            // 
            resources.ApplyResources(this.btnEmployees, "btnEmployees");
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnCustomers
            // 
            resources.ApplyResources(this.btnCustomers, "btnCustomers");
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSuppliers
            // 
            resources.ApplyResources(this.btnSuppliers, "btnSuppliers");
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnSuppliers);
            this.Controls.Add(this.btnUnits);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnWharehouses);
            this.Controls.Add(this.btnMoveItems);
            this.Controls.Add(this.btnPaymentOrder);
            this.Controls.Add(this.btnSupplyOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabicToolStripMenuItem;
        private System.Windows.Forms.Button btnSupplyOrder;
        private System.Windows.Forms.Button btnPaymentOrder;
        private System.Windows.Forms.Button btnMoveItems;
        private System.Windows.Forms.Button btnUnits;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnWharehouses;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSuppliers;
    }
}

