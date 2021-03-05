using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WharehouseManagementSystem.Forms.Suppliers
{
    public partial class Suppliers : Form
    {
        WarehouseDB ent;
        public Suppliers()
        {
            InitializeComponent();
            ent = new WarehouseDB();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // set textboxes to empty string
            try
            {
                txtEmail.Text = txtFax.Text = txtId.Text =
                txtMobile.Text = txtName.Text =
                txtPhone.Text = txtWebsite.Text = "";
                dgvSuppliers.Rows.Clear();

                // get all customers
                foreach (var cus in ent.Providers)
                {
                    dgvSuppliers.Rows.Add(cus.id, cus.name, cus.phone, cus.mobile, cus.fax, cus.website, cus.email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSuppliers.CurrentRow != null)
                {
                    DataGridViewRow row =
                        dgvSuppliers.Rows[e.RowIndex];

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
                    Provider provider = new Provider
                    {
                        email = email,
                        name = name,
                        mobile = mobile,
                        phone = phone,
                        fax = fax,
                        website = website
                    };
                    ent.Providers.Add(provider);
                    ent.SaveChanges();
                    MessageBox.Show("Supplier added!");
                    Suppliers_Load(sender, e);
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
                    Provider provider = (from c in ent.Providers
                                         where c.id == id
                                         select c).FirstOrDefault();

                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(fax)
                        && !string.IsNullOrEmpty(mobile) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(website))
                    {
                        provider.email = email;
                        provider.name = name;
                        provider.mobile = mobile;
                        provider.phone = phone;
                        provider.fax = fax;
                        provider.website = website;

                        ent.SaveChanges();
                        MessageBox.Show("Supplier Updated!");
                        Suppliers_Load(sender, e);
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
                    Provider provider = (from c in ent.Providers
                                         where c.id == id
                                         select c).FirstOrDefault();
                    if (provider.SupplyingOrders.Count > 0)
                    {
                        MessageBox.Show("Can't Delete Customer!\n" +
                            "Delete all Supplying orders made by him First");
                    }
                    else
                    {
                        ent.Providers.Remove(provider);
                        ent.SaveChanges();
                        MessageBox.Show("Supplier Deleted!");
                        Suppliers_Load(sender, e);
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
