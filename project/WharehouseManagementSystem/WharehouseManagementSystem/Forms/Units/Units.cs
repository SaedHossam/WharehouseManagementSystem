using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WharehouseManagementSystem.Forms.Units
{
    public partial class Units : Form
    {
        WarehouseDB ent;
        public Units()
        {
            InitializeComponent();
            ent = new WarehouseDB();
        }

        private void Units_Load(object sender, EventArgs e)
        {
            try
            {
                // set values of textboxes to empty strign
                txtId.Text = txtName.Text = "";
                nudQuantity.Value = 0;
                dgvUnits.Rows.Clear();

                // load data grid values
                foreach (var unit in ent.Units)
                {
                    dgvUnits.Rows.Add(unit.ID, unit.Name, unit.quantity);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvUnits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvUnits.CurrentRow != null)
                {
                    DataGridViewRow row =
                        dgvUnits.Rows[e.RowIndex];

                    string name;
                    name = txtName.Text;
                    int quantity = (int)nudQuantity.Value;
                    bool load = true;
                    if (!string.IsNullOrEmpty(name) && quantity > 0)
                    {
                        var loadData = MessageBox.Show("There is unsaved data in textboxes\n" +
                        "Do you want to override them?", "", MessageBoxButtons.YesNo);
                        load = loadData == DialogResult.Yes;
                    }

                    if (load)
                    {
                        txtId.Text = row.Cells[0].Value.ToString();
                        txtName.Text = row.Cells[1].Value.ToString();
                        int q = int.Parse(row.Cells[2].Value.ToString());
                        nudQuantity.Value = q;
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
                string name;
                name = txtName.Text;
                int quantity = (int)nudQuantity.Value;
                if (!string.IsNullOrEmpty(name) && quantity > 0)
                {
                    Unit unit = new Unit
                    {
                        Name = name,
                        quantity = quantity
                    };
                    ent.Units.Add(unit);
                    ent.SaveChanges();
                    MessageBox.Show("Unit added!");
                    Units_Load(sender, e);
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
                string name;
                name = txtName.Text;
                int quantity = (int)nudQuantity.Value;
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    Unit unit = (from c in ent.Units
                                         where c.ID == id
                                         select c).FirstOrDefault();

                    if (!string.IsNullOrEmpty(name))
                    {
                        unit.Name = name;
                        unit.quantity = quantity;
                        ent.SaveChanges();
                        MessageBox.Show("Unit Updated!");
                        Units_Load(sender, e);
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
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    Unit unit = (from c in ent.Units
                                         where c.ID == id
                                         select c).FirstOrDefault();
                    if (unit.Items.Count > 0)
                    {
                        MessageBox.Show("Can't Delete Unit!\n" +
                            "Remove from all Items first!");
                    }
                    else
                    {
                        ent.Units.Remove(unit);
                        ent.SaveChanges();
                        MessageBox.Show("Unit Deleted!");
                        Units_Load(sender, e);
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
