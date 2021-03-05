using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WharehouseManagementSystem.Forms.Warehouses
{
    public partial class Warehouses : Form
    {
        WarehouseDB ent;
        public Warehouses()
        {
            InitializeComponent();
            ent = new WarehouseDB();
        }

        private void Warehouses_Load(object sender, EventArgs e)
        {
            // set initial values
            txtId.Text = txtName.Text = rtbAddress.Text = "";
            cbEmployess.Items.Clear();
            dgvWarehouses.Rows.Clear();

            foreach (var warehouse in ent.Wharehouses)
            {
                dgvWarehouses.Rows.Add(warehouse.ID, warehouse.name, 
                    warehouse.address, warehouse.Employee.Name);
            }

            foreach (var emp in ent.Employees)
            {
                cbEmployess.Items.Add(emp.Name);
            }
        }

        private void dgvWarehouses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvWarehouses.CurrentRow != null)
                {
                    DataGridViewRow row =
                    dgvWarehouses.Rows[e.RowIndex];

                    // if textBoxes doesn't contain any values, load row data
                    // else ask user first
                    bool load = true;
                    if (!string.IsNullOrEmpty(txtId.Text))
                    {
                        var loadData = MessageBox.Show("There is unsaved data in textboxes\n" +
                            "Do you want to override them?", "", MessageBoxButtons.YesNo);
                        load = loadData == DialogResult.Yes;
                    }

                    if (load)
                    {
                        txtId.Text = row.Cells[0].Value.ToString();
                        txtName.Text = row.Cells[1].Value.ToString();
                        rtbAddress.Text = row.Cells[2].Value.ToString();

                        //int id = (int.Parse(txtId.Text));
                        //var warehouse = (from ware in ent.Wharehouses
                        //            where ware.ID == id
                        //            select ware).FirstOrDefault();
                        int ind = cbEmployess.FindString(row.Cells[3].Value.ToString());
                        cbEmployess.SelectedIndex = ind;
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
                string name, address, empName;
                name = txtName.Text;
                address = rtbAddress.Text;
                empName = cbEmployess.Text;
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(empName))
                {
                    try
                    {
                        Employee employee = (from emp in ent.Employees
                                        where emp.Name == empName
                                        select emp).FirstOrDefault();
                        Wharehouse warehouse = new Wharehouse();
                        warehouse.name = name;
                        warehouse.address = address;
                        warehouse.employee_id = employee.id;
                        
                        ent.Wharehouses.Add(warehouse);
                        ent.SaveChanges();
                        MessageBox.Show("Warehouse added!");
                        Warehouses_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("all data Required!");
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
                string name, address, empName;
                name = txtName.Text;
                address = rtbAddress.Text;
                empName = cbEmployess.Text;
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(empName))
                {
                    int id = int.Parse(txtId.Text);
                    Wharehouse warehouse = new Wharehouse();
                    warehouse = (from w in ent.Wharehouses
                                 where w.ID == id
                            select w).FirstOrDefault();

                    int empId = (from employee in ent.Employees
                           where employee.Name == empName
                           select employee.id).FirstOrDefault();
                    warehouse.name = name;
                    warehouse.address = address;
                    warehouse.employee_id = empId;

                    ent.SaveChanges();
                    MessageBox.Show("Warehouse Updated!");
                    Warehouses_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Select Warehouse to edit or Enter all data!");
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

                    Wharehouse warehouse = new Wharehouse();
                    warehouse = (from i in ent.Wharehouses
                            where i.ID == id
                            select i).FirstOrDefault();
                    
                    if (warehouse.WarehouseItems.Count > 0)
                    {
                        MessageBox.Show("Cant Delete Warehouse!\n" +
                            "Move all Items from Warehouse first!\n");
                    }
                    else
                    {
                        ent.Wharehouses.Remove(warehouse);
                        ent.SaveChanges();
                        MessageBox.Show("Warehouse Deleted!");
                        Warehouses_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Select an Item to Delete!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
