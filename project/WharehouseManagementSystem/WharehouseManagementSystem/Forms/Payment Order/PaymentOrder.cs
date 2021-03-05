using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WharehouseManagementSystem
{
    public partial class PaymentOrder : Form
    {
        WarehouseDB ent;
        PaymentOrderInfo obj;
        public PaymentOrder()
        {
            InitializeComponent();
            ent = new WarehouseDB();
        }

        private void PaymentOrder_Load(object sender, EventArgs e)
        {
            txtOrderNumber.Text = "";
            cbCustomers.Items.Clear();
            dgvPaymentOrders.Rows.Clear();

            // load customers
            foreach (Customer customer in ent.Customers)
            {
                cbCustomers.Items.Add(customer.name);
            }
            cbCustomers.SelectedIndex = -1;
            // load orders
            foreach (Payment_Order order in ent.Payment_Order)
            {
                dgvPaymentOrders.Rows.Add(order.number, order.Customer.name, order.Date);
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = cbCustomers.Text;
                DateTime date = dtpDate.Value;
                
                if (!string.IsNullOrEmpty(customerName))
                {
                    Payment_Order order = new Payment_Order();
                    int customerId = (from c in ent.Customers
                                         where c.name == customerName
                                         select c.id).FirstOrDefault();
                    order.customer_id = customerId;
                    order.Date = date;
                    ent.Payment_Order.Add(order);
                    ent.SaveChanges();
                    MessageBox.Show("Order Added!", "", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PaymentOrder_Load(sender, e);
                    obj = new PaymentOrderInfo(order);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Enter Order Name!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                string customerName = cbCustomers.Text;
                DateTime date = dtpDate.Value;

                if (!string.IsNullOrEmpty(txtOrderNumber.Text))
                {
                    int orderNumber = int.Parse(txtOrderNumber.Text);
                    Payment_Order order = (from o in ent.Payment_Order
                                           where o.number == orderNumber
                                           select o).FirstOrDefault();
                    int customerId = (from c in ent.Customers
                                      where c.name == customerName
                                      select c.id).FirstOrDefault();
                    order.customer_id = customerId;
                    order.Date = date;
                    ent.SaveChanges();
                    MessageBox.Show("Order Updated!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PaymentOrder_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Select order to delete", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtOrderNumber.Text))
                {
                    int orderNumber = int.Parse(txtOrderNumber.Text);
                    Payment_Order order = (from o in ent.Payment_Order
                                           where o.number == orderNumber
                                           select o).FirstOrDefault();
                    obj = new PaymentOrderInfo(order);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Select order first!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPaymentOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPaymentOrders.CurrentRow != null)
                {
                    DataGridViewRow row =
                        dgvPaymentOrders.Rows[e.RowIndex];

                    string customerName;
                    customerName = cbCustomers.Text;


                    bool load = true;
                    if (!string.IsNullOrEmpty(customerName) )
                    {
                        var loadData = MessageBox.Show("There is unsaved data in textboxes\n" +
                        "Do you want to override them?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        load = loadData == DialogResult.Yes;
                    }

                    if (load)
                    {
                        // check that date converted right
                        txtOrderNumber.Text = row.Cells[0].Value.ToString();
                        cbCustomers.SelectedIndex = cbCustomers.FindString(row.Cells[1].Value.ToString());
                        dtpDate.Value = (DateTime)row.Cells[2].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
