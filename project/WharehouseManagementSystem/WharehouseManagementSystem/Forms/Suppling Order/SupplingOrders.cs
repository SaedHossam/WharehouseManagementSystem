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
    public partial class SupplingOrders : Form
    {
        WarehouseDB ent;
        SupplyOrderInfo obj;
        public SupplingOrders()
        {
            InitializeComponent();
            ent = new WarehouseDB();
        }

        private void SupplingOrders_Load(object sender, EventArgs e)
        {
            cbSuppliers.Items.Clear();
            cbWarehouses.Items.Clear();
            txtOrderNumber.Text = "";
            dgvSupplyOrders.Rows.Clear();

            foreach (var supplier in ent.Providers)
            {
                cbSuppliers.Items.Add(supplier.name);
            }

            foreach (var warehouse in ent.Wharehouses)
            {
                cbWarehouses.Items.Add(warehouse.name);
            }

            foreach (var order in ent.SupplyingOrders)
            {
                dgvSupplyOrders.Rows.Add(order.number, order.Wharehouse.name, order.Provider.name, order.date);
            }
            cbSuppliers.SelectedIndex = cbWarehouses.SelectedIndex = -1;
        }

        private void dgvSupplyOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSupplyOrders.CurrentRow != null)
                {
                    DataGridViewRow row =
                        dgvSupplyOrders.Rows[e.RowIndex];

                    string warehouse, supplier, date;
                    warehouse = cbWarehouses.Text;
                    supplier = cbSuppliers.Text;
                    date = dtpDate.Text;


                    bool load = true;
                    if (!string.IsNullOrEmpty(warehouse) && !string.IsNullOrEmpty(supplier) && !string.IsNullOrEmpty(date))
                    {
                        var loadData = MessageBox.Show("There is unsaved data in textboxes\n" +
                        "Do you want to override them?", "", MessageBoxButtons.YesNo);
                        load = loadData == DialogResult.Yes;
                    }

                    if (load)
                    {
                        // check that date converted right
                        txtOrderNumber.Text = row.Cells[0].Value.ToString();
                        cbWarehouses.SelectedIndex = cbWarehouses.FindString(row.Cells[1].Value.ToString());
                        cbSuppliers.SelectedIndex = cbSuppliers.FindString(row.Cells[2].Value.ToString());
                        dtpDate.Value = (DateTime)row.Cells[3].Value;
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
                string warehouse, supplier, date;
                warehouse = cbWarehouses.Text;
                supplier = cbSuppliers.Text;
                date = dtpDate.Text;

                if (!string.IsNullOrEmpty(warehouse) && !string.IsNullOrEmpty(supplier) && !string.IsNullOrEmpty(date))
                {
                    int warehouseId = (from w in ent.Wharehouses
                                       where w.name == warehouse
                                       select w.ID).FirstOrDefault();

                    int supplierId = (from s in ent.Providers
                                      where s.name == supplier
                                      select s.id).FirstOrDefault();
                    var d = Convert.ToDateTime(date);
                    SupplyingOrder order = new SupplyingOrder
                    {
                        supplier_id = supplierId,
                        warehouse_id = warehouseId,
                        date = d
                    };
                    ent.SupplyingOrders.Add(order);
                    ent.SaveChanges();
                    MessageBox.Show("Order added!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //SupplingOrders_Load(sender, e);
                    obj = new SupplyOrderInfo(order.number);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("All Fields Required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string warehouse, supplier, date;
                warehouse = cbWarehouses.Text;
                supplier = cbSuppliers.Text;
                date = dtpDate.Text;

                if (!string.IsNullOrEmpty(txtOrderNumber.Text))
                {
                    int id = int.Parse(txtOrderNumber.Text);
                    SupplyingOrder order = (from c in ent.SupplyingOrders
                                            where c.number == id
                                            select c).FirstOrDefault();

                    if (!string.IsNullOrEmpty(warehouse) && !string.IsNullOrEmpty(supplier) && !string.IsNullOrEmpty(date))
                    {
                        int warehouseId = (from w in ent.Wharehouses
                                           where w.name == warehouse
                                           select w.ID).FirstOrDefault();

                        int supplierId = (from s in ent.Providers
                                          where s.name == supplier
                                          select s.id).FirstOrDefault();
                        var d = Convert.ToDateTime(date);
                        order.supplier_id = supplierId;
                        order.warehouse_id = warehouseId;
                        order.date = d;

                        ent.SaveChanges();
                        MessageBox.Show("Order Updated!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SupplingOrders_Load(sender, e);
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

        private void btnEditItems_Click(object sender, EventArgs e)
        {
            try
            {
                string warehouse, supplier, date;
                warehouse = cbWarehouses.Text;
                supplier = cbSuppliers.Text;
                date = dtpDate.Text;

                if (!string.IsNullOrEmpty(txtOrderNumber.Text))
                {
                    int id = int.Parse(txtOrderNumber.Text);
                    SupplyingOrder order = (from c in ent.SupplyingOrders
                                            where c.number == id
                                            select c).FirstOrDefault();

                    obj = new SupplyOrderInfo(order.number);
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Error!\n" +
                        "the Order you are trying to update doesn't exist.\n" +
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
                string warehouse, supplier, date;
                warehouse = cbWarehouses.Text;
                supplier = cbSuppliers.Text;
                date = dtpDate.Text;

                if (!string.IsNullOrEmpty(txtOrderNumber.Text))
                {
                    int id = int.Parse(txtOrderNumber.Text);
                    SupplyingOrder order = (from c in ent.SupplyingOrders
                                            where c.number == id
                                            select c).FirstOrDefault();
                    if (order.Inovice_Items.Count > 0)
                    {
                        MessageBox.Show("Can't delete this order\nSome of the items in order were sold!");
                    }
                    else
                    {
                        // foreach item in this order, decrease Item.quantity
                        // delete from transctions, warehouse items, suppling order items , supplying order
                        
                        foreach (Transaction transaction in ent.Transactions)
                        {
                            if (transaction.order_id == order.number)
                            {
                                ent.Transactions.Remove(transaction);
                            }
                        }

                        foreach (WarehouseItem warehouseItem in ent.WarehouseItems)
                        {
                            if (warehouseItem.order_id == order.number)
                            {
                                //get item, decrease quantity, delete warehouseItem
                                int itemId = warehouseItem.item_id;
                                Item item = (from i in ent.Items
                                             where i.Code == itemId
                                             select i).FirstOrDefault();
                                item.quantity -= warehouseItem.quantity;
                                ent.WarehouseItems.Remove(warehouseItem);
                            }
                        }

                        foreach(SupplyingOrder_Items i in ent.SupplyingOrder_Items)
                        {
                            if(i.order_number == order.number)
                            {
                                ent.SupplyingOrder_Items.Remove(i);
                            }
                        }
                        
                        ent.SupplyingOrders.Remove(order);
                        
                        ent.SaveChanges();
                        
                        MessageBox.Show("Order Deleted!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SupplingOrders_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Select Order to Delete!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
