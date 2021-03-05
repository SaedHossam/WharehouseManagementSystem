using System;
using System.Linq;
using System.Windows.Forms;

namespace WharehouseManagementSystem
{
    public partial class SupplyOrderInfo : Form
    {
        WarehouseDB ent;
        SupplyingOrder order;
        string selectedItemName, unit;
        DateTime date;
        int itemQuantity, itemExpirationDuration, orderNum;
        public SupplyOrderInfo(int orderNumber)
        {
            InitializeComponent();
            order = new SupplyingOrder();
            orderNum = orderNumber;
            ent = new WarehouseDB();
        }

        private void SupplyOrderInfo_Load(object sender, System.EventArgs e)
        {
            try
            {
                order = (from ord in ent.SupplyingOrders
                         where ord.number == orderNum
                         select ord).FirstOrDefault();
                txtOrderNum.Text = order.number.ToString();
                txtWarehouse.Text = order.Wharehouse.name;
                txtSupplier.Text = order.Provider.name;
                dtpOrderDate.Value = order.date;

                cbItems.Items.Clear();
                cbUnits.Items.Clear();
                nudItemQuantity.Value = 0;
                nudExpirationDuration.Value = 0;

                dgvOrderItems.Rows.Clear();

                // load order items
                foreach (var order_item in order.SupplyingOrder_Items)
                {
                    dgvOrderItems.Rows.Add(order_item.Item.Name, order_item.quantity,
                        order_item.Production_Date, order_item.expiration_date);
                }
                // load all items in combobox
                foreach (var item in ent.Items)
                {
                    cbItems.Items.Add(item.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupplyOrderInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if unsaved data, ask if want to discard changes.
            DialogResult res = MessageBox.Show("Are you sure you want to Exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = res == DialogResult.No;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(DeleteItemFromOrder(sender, e))
            {
                InsertItemInOrder(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // delete item from order
            if(DeleteItemFromOrder(sender, e))
            {
                MessageBox.Show("Deleted Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SupplyOrderInfo_Load(sender, e);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // add item to order
            InsertItemInOrder(sender, e);
        }

        private void cbItems_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Item item = (from it in ent.Items
                         where it.Name == cbItems.Text
                         select it).FirstOrDefault();
            LoadItemUnits(item);
        }

        private void cbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 
            try
            {
                if(cbUnits.SelectedIndex != -1)
                {
                    int itemQuantity = (int)nudItemQuantity.Value;
                    int UnitNumber = (from unit in ent.Units
                                      where unit.Name == cbUnits.Text
                                      select unit.quantity).FirstOrDefault();
                    nudItemQuantity.Value = (decimal)((int) itemQuantity / UnitNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int quantity = (int) nudItemQuantity.Value;
            int unitNumber = (from unit in ent.Units
                              where unit.Name == cbUnits.Text
                              select unit.quantity).FirstOrDefault(); 
        }

        private void dgvOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvOrderItems.CurrentRow != null)
                {
                    DataGridViewRow row =
                        dgvOrderItems.Rows[e.RowIndex];

                    string itemName, itemUnit;
                    int quantity, expirationDuration;
                    DateTime productionDate;
                    
                    itemName = cbItems.Text;
                    itemUnit = cbUnits.Text;
                    quantity = (int) nudItemQuantity.Value;
                    productionDate = dtpItemProductionDate.Value;
                    expirationDuration = (int)nudExpirationDuration.Value;

                    bool load = true;
                    if (!string.IsNullOrEmpty(itemName) && !string.IsNullOrEmpty(itemUnit) && quantity > 0 && expirationDuration > 0)
                    {
                        var loadData = MessageBox.Show("There is unsaved data in textboxes\n" +
                        "Do you want to override them?", "", MessageBoxButtons.YesNo);
                        load = loadData == DialogResult.Yes;
                    }
                    // TODO: handle cell click
                    if (load)
                    {
                        string nameItem = row.Cells[0].Value.ToString();
                        Item item = (from it in ent.Items
                                     where it.Name == nameItem
                                     select it).FirstOrDefault();
                        LoadItemUnits(item);
                        cbItems.SelectedIndex = cbItems.FindString(row.Cells[0].Value.ToString());
                        cbUnits.SelectedIndex = 0;
                        int q = int.Parse(row.Cells[1].Value.ToString());
                        nudItemQuantity.Value = (decimal) q;
                        dtpItemProductionDate.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                        int d = (Convert.ToDateTime(row.Cells[3].Value.ToString()) - 
                            Convert.ToDateTime(row.Cells[2].Value.ToString())).Days;
                        nudExpirationDuration.Value = (decimal) d;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void InsertItemInOrder(object sender, EventArgs e)
        {
            try
            {
                selectedItemName = cbItems.Text;
                unit = cbUnits.Text;
                itemQuantity = (int) nudItemQuantity.Value;
                date = dtpItemProductionDate.Value;
                itemExpirationDuration = (int)nudExpirationDuration.Value;

                if (!string.IsNullOrEmpty(selectedItemName) && !string.IsNullOrEmpty(unit) &&
                    itemQuantity > 0 && itemExpirationDuration > 0)
                {

                    int unitNumber = (from u in ent.Units
                                      where u.Name == unit
                                      select u.quantity).FirstOrDefault();
                    // select item
                    Item selectedItem = (from item in ent.Items
                                         where item.Name == selectedItemName
                                         select item).FirstOrDefault();
                    // select warehouse_id
                    int warehouseId = (from warehouse in ent.Wharehouses
                                       where warehouse.name == txtWarehouse.Text
                                       select warehouse.ID).FirstOrDefault();
                    // order number
                    int orderNumber = int.Parse(txtOrderNum.Text);

                    // calculate expiration date
                    DateTime expirationDate = date.AddDays(itemExpirationDuration);

                    // check if item exist in current order, show error"Item already exists". 
                    SupplyingOrder_Items exists = (from order_items in ent.SupplyingOrder_Items
                                                   where order_items.item_code == selectedItem.Code
                                                   && order_items.order_number == orderNumber
                                                   select order_items).FirstOrDefault();
                    if (exists != null)
                    {
                        MessageBox.Show("Item already exists in current order!");
                    }
                    else
                    {
                        // add to supply order item
                        SupplyingOrder_Items order_Items = new SupplyingOrder_Items();
                        order_Items.item_code = selectedItem.Code;
                        order_Items.order_number = orderNumber;
                        order_Items.quantity = itemQuantity * unitNumber;
                        order_Items.Production_Date = date;
                        order_Items.expiration_date = expirationDate;
                        //order_Items.Item = selectedItem;

                        ent.SupplyingOrder_Items.Add(order_Items);
                        ent.SaveChanges();

                        // add to warehouse items
                        WarehouseItem warehouseItem = new WarehouseItem();
                        warehouseItem.item_id = selectedItem.Code;
                        warehouseItem.order_id = orderNumber;
                        warehouseItem.warehouse_id = warehouseId;
                        warehouseItem.quantity = itemQuantity * unitNumber;

                        ent.WarehouseItems.Add(warehouseItem);
                        ent.SaveChanges();
                        // update item quantity
                        selectedItem.quantity += (itemQuantity * unitNumber);
                        ent.SaveChanges();
                        
                        // add to transaction, buy = 1
                        Transaction buyItem = new Transaction();
                        buyItem.date = DateTime.Now;
                        buyItem.type_id = 1;
                        buyItem.order_id = orderNumber;
                        buyItem.item_id = selectedItem.Code;
                        buyItem.wharehouse_id = warehouseId;
                        buyItem.quantity = itemQuantity * unitNumber;
                        // total item quantity in all warehouses
                        buyItem.total_quantity_for_item_in_wharehouse = (int) selectedItem.quantity;
                        // total item quantity in current warehouse
                        buyItem.total_quantity_for_product_in_wharehouse = itemQuantity * unitNumber;
                        ent.Transactions.Add(buyItem);
                        ent.SaveChanges();

                        MessageBox.Show("Item added to Order!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SupplyOrderInfo_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Enter all data!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool DeleteItemFromOrder(object sender, EventArgs e)
        {
            // delete item from order
            // get item id
            Item item = (from ite in ent.Items
                         where ite.Name == cbItems.Text
                         select ite).FirstOrDefault();
            // get warehouse id
            Wharehouse wharehouse = (from warehouse in ent.Wharehouses
                                     where warehouse.name == txtWarehouse.Text
                                     select warehouse).FirstOrDefault();
            
            // get quantity in supplyingOrderItems
            SupplyingOrder_Items order_Items = (from so in ent.SupplyingOrder_Items
                                                where so.order_number == orderNum
                                                && so.item_code == item.Code
                                                select so).FirstOrDefault();

            // step 1: check if item still in warehouse with initial quantity
            // get quantity in warehouse
            WarehouseItem warehouseItem = (from warehouse in ent.WarehouseItems
                                           where warehouse.warehouse_id == wharehouse.ID
                                           && warehouse.order_id == order_Items.order_number
                                           && warehouse.item_id == item.Code
                                           select warehouse
                                     ).FirstOrDefault();

            // get transaction buy item
            Transaction transaction = (from tr in ent.Transactions
                                       where tr.type_id == 1
                                       && tr.order_id == orderNum
                                       && tr.wharehouse_id == wharehouse.ID
                                       && tr.item_id == item.Code
                                       select tr
                                       ).FirstOrDefault();
            // compare quantity
            if (order_Items.quantity == warehouseItem.quantity)
            {
                // step 2: in items: set quantity -= old value
                item.quantity -= order_Items.quantity;

                // step 3: in warehouse items: delete
                ent.WarehouseItems.Remove(warehouseItem);

                // step 4: in supplying order items: delete
                ent.SupplyingOrder_Items.Remove(order_Items);

                // step 5: in Transactions: delete
                ent.Transactions.Remove(transaction);

                ent.SaveChanges();

                
                return true;
            }
            else
            {
                MessageBox.Show("Can't edit/delete this Item Because it was moved or sold", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void LoadItemUnits(Item item)
        {
            try
            {
                if (cbItems.SelectedIndex == -1)
                {
                    cbUnits.Items.Clear();
                }
                else
                {
                    cbUnits.Items.Clear();
                    foreach (var unit in item.Units)
                    {
                        cbUnits.Items.Add(unit.Name);
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
