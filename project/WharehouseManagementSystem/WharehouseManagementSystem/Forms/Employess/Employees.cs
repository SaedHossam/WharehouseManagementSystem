using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WharehouseManagementSystem.Forms.Employess
{
    public partial class Employees : Form
    {
        WarehouseDB ent;
        public Employees()
        {
            InitializeComponent();
            ent = new WarehouseDB();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            try
            {
                // set textboxes = empty string
                txtId.Text = txtName.Text = "";
                dgvEmployess.Rows.Clear();

                foreach (var emp in ent.Employees)
                {
                    dgvEmployess.Rows.Add(emp.id, emp.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvEmployess.CurrentRow != null)
                {
                    DataGridViewRow row =
                        dgvEmployess.Rows[e.RowIndex];

                    string name;
                    name = txtName.Text;

                    bool load = true;
                    if (!string.IsNullOrEmpty(name))
                    {
                        var loadData = MessageBox.Show("There is unsaved data in textboxes\n" +
                        "Do you want to override them?", "", MessageBoxButtons.YesNo);
                        load = loadData == DialogResult.Yes;
                    }

                    if (load)
                    {
                        txtId.Text = row.Cells[0].Value.ToString();
                        txtName.Text = row.Cells[1].Value.ToString();
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

                if (!string.IsNullOrEmpty(name))
                {
                    Employee employee = new Employee
                    {
                        Name = name
                    };
                    ent.Employees.Add(employee);
                    ent.SaveChanges();
                    MessageBox.Show("Employee added!");
                    Employees_Load(sender, e);
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
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    int id = int.Parse(txtId.Text);
                    Employee employee = (from c in ent.Employees
                                         where c.id == id
                                         select c).FirstOrDefault();

                    if (!string.IsNullOrEmpty(name))
                    {
                        employee.Name = name;

                        ent.SaveChanges();
                        MessageBox.Show("Employee Updated!");
                        Employees_Load(sender, e);
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
                    Employee employee = (from c in ent.Employees
                                         where c.id == id
                                         select c).FirstOrDefault();
                    if (employee.Wharehouses.Count > 0)
                    {
                        MessageBox.Show("Can't Delete Employee!\n" +
                            "Remove from all involved warehouses first!");
                    }
                    else
                    {
                        ent.Employees.Remove(employee);
                        ent.SaveChanges();
                        MessageBox.Show("Employee Deleted!");
                        Employees_Load(sender, e);
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
