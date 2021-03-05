using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WharehouseManagementSystem.Forms.Move_Items
{
    public partial class MoveItems : Form
    {
        WarehouseDB ent;
        string warehouseFrom, warehouseTo;
        int rowIndex;
        public MoveItems()
        {
            InitializeComponent();
            ent = new WarehouseDB();
            rowIndex = -1;
        }

        private void MoveItems_Load(object sender, EventArgs e)
        {
            // initial values
            if (string.IsNullOrEmpty(warehouseFrom) && string.IsNullOrEmpty(warehouseFrom))
            {
                cbFrom.Items.Clear();
                cbTo.Items.Clear();
                dgvWarehouseFrom.Rows.Clear();
                dgvWarehouseTo.Rows.Clear();

                foreach (Wharehouse w in ent.Wharehouses)
                {
                    cbFrom.Items.Add(w.name);
                    //cbTo.Items.Add(w.name);
                }
            }
            else
            {
                if (string.IsNullOrEmpty(warehouseFrom))
                    dgvWarehouseFrom.Rows.Clear();
                else
                {
                    dgvWarehouseFrom.Rows.Clear();
                    loadWarehouseItems(warehouseFrom, dgvWarehouseFrom);
                }
                if (string.IsNullOrEmpty(warehouseTo))
                    dgvWarehouseTo.Rows.Clear();
                else
                {
                    dgvWarehouseTo.Rows.Clear();
                    loadWarehouseItems(warehouseTo, dgvWarehouseTo);
                }
            }
        }

        private void cbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvWarehouseFrom.Rows.Clear();
                dgvWarehouseTo.Rows.Clear();
                cbTo.Items.Clear();
                cbTo.Text = string.Empty;
                if (cbFrom.SelectedIndex != -1)
                {
                    warehouseFrom = cbFrom.Text;
                    loadWarehouseItems(warehouseFrom, dgvWarehouseFrom);
                    foreach (Wharehouse w in ent.Wharehouses)
                    {
                        if (w.name != warehouseFrom)
                            cbTo.Items.Add(w.name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvWarehouseTo.Rows.Clear();
                if (cbTo.SelectedIndex != -1)
                {
                    warehouseTo = cbTo.Text;
                    loadWarehouseItems(warehouseTo, dgvWarehouseTo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                // if both warehouses selected
                if (!string.IsNullOrEmpty(warehouseFrom) && !string.IsNullOrEmpty(warehouseTo))
                {
                    // if row selected
                    if (rowIndex != -1)
                    {
                        // get item details
                        string itemName =
                            dgvWarehouseFrom.Rows[rowIndex].Cells[1].Value.ToString();
                        Item item = (from i in ent.Items
                                     where i.Name == itemName
                                     select i).FirstOrDefault();

                        // get warehouseItems from row
                        int orderId = int.Parse(dgvWarehouseFrom.Rows[rowIndex].Cells[0].Value.ToString());
                        WarehouseItem warehouseFromItems =
                            (from w in ent.WarehouseItems
                             where w.Wharehouse.name == warehouseFrom
                             && w.Item.Name == itemName
                             && w.order_id == orderId
                             select w).FirstOrDefault();

                        // get warehouse_To details
                        Wharehouse warehouse = (from w in ent.Wharehouses
                                                where w.name == warehouseTo
                                                select w).FirstOrDefault();
                        // TODO: check if exist, increase quantity
                        // insert into warehouse items
                        WarehouseItem warehouseItemTo = (from w in ent.WarehouseItems
                                                         where w.item_id == warehouseFromItems.item_id
                                                            && w.warehouse_id == warehouse.ID
                                                            && w.order_id == warehouseFromItems.order_id
                                                         select w
                                                         ).FirstOrDefault();
                        if(warehouseItemTo == null)
                        {
                            warehouseItemTo = new WarehouseItem();
                            warehouseItemTo.item_id = warehouseFromItems.item_id;
                            warehouseItemTo.warehouse_id = warehouse.ID;
                            warehouseItemTo.order_id = warehouseFromItems.order_id;
                            warehouseItemTo.quantity = warehouseFromItems.quantity;
                            ent.WarehouseItems.Add(warehouseItemTo);
                        }
                        else
                        {
                            warehouseItemTo.quantity += warehouseFromItems.quantity;
                        }

                        // Move from transaction moveFrom = 4, moveTo = 3
                        Transaction moveFrom = new Transaction();
                        moveFrom.date = DateTime.Now;
                        moveFrom.type_id = 4;
                        moveFrom.order_id = warehouseFromItems.order_id;
                        moveFrom.item_id = warehouseFromItems.item_id;
                        moveFrom.wharehouse_id = warehouseFromItems.warehouse_id;
                        moveFrom.quantity = warehouseFromItems.quantity;
                        // total item quantity in all warehouses
                        moveFrom.total_quantity_for_item_in_wharehouse = (int)item.quantity;
                        // total item quantity in current warehouse
                        moveFrom.total_quantity_for_product_in_wharehouse = (int)item.quantity;
                        ent.Transactions.Add(moveFrom);
                        ent.SaveChanges();

                        ent.WarehouseItems.Remove(warehouseFromItems);

                        // Move to transaction
                        Transaction moveTo = new Transaction();
                        moveTo.date = DateTime.Now;
                        moveTo.type_id = 3;
                        moveTo.move_from_transaction_id = moveFrom.id;
                        moveTo.order_id = warehouseItemTo.order_id;
                        moveTo.item_id = warehouseItemTo.item_id;
                        moveTo.wharehouse_id = warehouseItemTo.warehouse_id;
                        moveTo.quantity = warehouseItemTo.quantity;
                        // total item quantity in all warehouses
                        moveTo.total_quantity_for_item_in_wharehouse = (int)item.quantity;
                        // total item quantity in current warehouse
                        moveTo.total_quantity_for_product_in_wharehouse = (int)item.quantity;
                        ent.Transactions.Add(moveTo);
                        ent.SaveChanges();

                        MoveItems_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Select Item", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Select warehouses", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvWarehouseFrom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWarehouseFrom.CurrentRow != null)
            {
                rowIndex = e.RowIndex;
            }
            else
            {
                rowIndex = -1;
            }
        }

        void loadWarehouseItems(string warehouseName, DataGridView dgv)
        {
            Wharehouse warehouse = (from w in ent.Wharehouses
                                    where w.name == warehouseName
                                    select w).FirstOrDefault();
            foreach (WarehouseItem w in ent.WarehouseItems)
            {
                if (w.warehouse_id == warehouse.ID)
                    dgv.Rows.Add(w.order_id, w.Item.Name, w.quantity);
            }
        }
    }
}
