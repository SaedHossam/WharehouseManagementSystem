using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WharehouseManagementSystem.Forms.Customers
{
    public partial class Customers : Form
    {
        WarehouseDB ent;
        public Customers()
        {
            InitializeComponent();
            ent = new WarehouseDB();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // set textboxes to empty string
            try
            {
                txtEmail.Text = txtFax.Text = txtId.Text =
                txtMobile.Text = txtName.Text =
                txtPhone.Text = txtWebsite.Text = "";
                dgvCustomers.Rows.Clear();

                // get all customers
                foreach (var cus in ent.Customers)
                {
                    dgvCustomers.Rows.Add(cus.id, cus.name, cus.phone, cus.mobile, cus.fax, cus.website, cus.email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                string name, mobile, phone, fax, website, email;
                name = txtName.Text;
                email = txtEmail.Text;
                fax = txtFax.Text;
                mobile = txtMobile.Text;
                phone = txtPhone.Text;
                website = txtWebsite.Text;

                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(fax)
                    && !string.IsNullOrEmpty(mobile) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(website))
                {
                    Customer customer = new Customer
                    {
                        email = email,
                        name = name,
                        mobile = mobile,
                        phone = phone,
                        fax = fax,
                        website = website
                    };
                    ent.Customers.Add(customer);
                    ent.SaveChanges();
                    MessageBox.Show("Customer added!");
                    Customers_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("All Fields Required!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name, mobile, phone, fax, website, email;
                name = txtName.Text;
                email = txtEmail.Text;
                fax = txtFax.Text;
                mobile = txtMobile.Text;
                phone = txtPhone.Text;
                website = txtWebsite.Text;
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    Customer customer = (from c in ent.Customers
                                         where c.id == id
                                         select c).FirstOrDefault();

                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(fax)
                        && !string.IsNullOrEmpty(mobile) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(website))
                    {
                        customer.email = email;
                        customer.name = name;
                        customer.mobile = mobile;
                        customer.phone = phone;
                        customer.fax = fax;
                        customer.website = website;

                        ent.SaveChanges();
                        MessageBox.Show("Customer Updated!");
                        Customers_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("All Fields Required!");
                    }
                }
                else
                {
                    MessageBox.Show("Error!\n" +
                        "the field you are trying to update doesn't exist.\n" +
                        "hint: try \"New\" instaed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string name, mobile, phone, fax, website, email;
                name = txtName.Text;
                email = txtEmail.Text;
                fax = txtFax.Text;
                mobile = txtMobile.Text;
                phone = txtPhone.Text;
                website = txtWebsite.Text;
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    Customer customer = (from c in ent.Customers
                                         where c.id == id
                                         select c).FirstOrDefault();
                    if(customer.Payment_Order.Count > 0)
                    {
                        MessageBox.Show("Can't Delete Customer!\n" +
                            "Delete all Payment orders made by him First");
                    }
                    else
                    {
                        ent.Customers.Remove(customer);
                        ent.SaveChanges();
                        MessageBox.Show("Customer Deleted!");
                        Customers_Load(sender, e);
                    }
                    //if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(fax)
                    //    && !string.IsNullOrEmpty(mobile) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(website))
                    //{
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCustomers.CurrentRow != null)
                {
                    DataGridViewRow row =
                        dgvCustomers.Rows[e.RowIndex];

                    string name, mobile, phone, fax, website, email;
                    name = txtName.Text;
                    email = txtEmail.Text;
                    fax = txtFax.Text;
                    mobile = txtMobile.Text;
                    phone = txtPhone.Text;
                    website = txtWebsite.Text;

                    bool load = true;
                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(fax)
                        && !string.IsNullOrEmpty(mobile) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(website))
                    {
                        var loadData = MessageBox.Show("There is unsaved data in textboxes\n" +
                        "Do you want to override them?", "", MessageBoxButtons.YesNo);
                        load = loadData == DialogResult.Yes;
                    }

                    if (load)
                    {
                        txtId.Text = row.Cells[0].Value.ToString();
                        txtName.Text = row.Cells[1].Value.ToString();
                        txtPhone.Text = row.Cells[2].Value.ToString();
                        txtMobile.Text = row.Cells[3].Value.ToString();
                        txtFax.Text = row.Cells[4].Value.ToString();
                        txtWebsite.Text = row.Cells[5].Value.ToString();
                        txtEmail.Text = row.Cells[6].Value.ToString();
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
