using System;
using System.Threading;
using System.Windows.Forms;
using WharehouseManagementSystem.Forms.Customers;
using WharehouseManagementSystem.Forms.Employess;
using WharehouseManagementSystem.Forms.Items;
using WharehouseManagementSystem.Forms.Move_Items;
using WharehouseManagementSystem.Forms.Reports;
using WharehouseManagementSystem.Forms.Suppliers;
using WharehouseManagementSystem.Forms.Units;
using WharehouseManagementSystem.Forms.Warehouses;

namespace WharehouseManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
            {
                case "en-US":
                    englishToolStripMenuItem.Checked = true;
                    arabicToolStripMenuItem.Checked = false;
                    break;
                case "ar-EG":
                    englishToolStripMenuItem.Checked = false;
                    arabicToolStripMenuItem.Checked = true;
                    break;
            }
        }

        private void btnSupplyOrder_Click(object sender, EventArgs e)
        {
            SupplingOrders obj = new SupplingOrders();
            //this.Hide();
            obj.Show();

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!englishToolStripMenuItem.Checked)
            {
                switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                {
                    case "ar-EG":
                        Thread.CurrentThread.CurrentUICulture
                            = new System.Globalization.CultureInfo("en-US");
                        break;
                }
                this.Controls.Clear();
                InitializeComponent();
                this.RightToLeft = RightToLeft.No;
                englishToolStripMenuItem.Checked = true;
                arabicToolStripMenuItem.Checked = false;
            }
        }

        private void arabicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!arabicToolStripMenuItem.Checked)
            {
                switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
                {
                    case "en-US":
                        Thread.CurrentThread.CurrentUICulture
                            = new System.Globalization.CultureInfo("ar-EG");
                        break;
                }
                this.Controls.Clear();
                InitializeComponent();
                this.RightToLeft = RightToLeft.Yes;
                englishToolStripMenuItem.Checked = false;
                arabicToolStripMenuItem.Checked = true;
            }
        }

        private void btnPaymentOrder_Click(object sender, EventArgs e)
        {
            PaymentOrder obj = new PaymentOrder();
            obj.Show();
        }

        private void btnMoveItems_Click(object sender, EventArgs e)
        {
            MoveItems obj = new MoveItems();
            obj.Show();
        }

        private void btnWharehouses_Click(object sender, EventArgs e)
        {
            Warehouses obj = new Warehouses();
            obj.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Items obj = new Items();
            obj.Show();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            Units obj = new Units();
            obj.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers obj = new Suppliers();
            obj.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports obj = new Reports();
            obj.Show();
        }
    }
}
