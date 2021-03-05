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
    public partial class PaymentOrderInfo : Form
    {
        WarehouseDB ent;
        Payment_Order order;
        public PaymentOrderInfo(Payment_Order payment_Order)
        {
            InitializeComponent();
            ent = new WarehouseDB();
            order = payment_Order;
        }

        private void PaymentOrderInfo_Load(object sender, EventArgs e)
        {
            txtOrderNum.Text = order.number.ToString();
            txtCustomer.Text = order.Customer.name;
            dtpOrderDate.Value = order.Date;
            cbWharehouses.Items.Clear();
            cbSupplyingOrders.Items.Clear();
            cbItems.Items.Clear();
            cbUnits.Items.Clear();
            nudItemQuantity.Value = 0;

            // load warehouses
            foreach (Wharehouse warehouse in ent.Wharehouses)
            {
                cbWharehouses.Items.Add(warehouse.name);
            }
            // load data grid view
            foreach (Inovice_Items info in ent.Inovice_Items)
            {
                // load data grid view Items
                // item name(item), quantity(), 
                // (production date, expiration date) (supplyOrderItems)
                // (warehouse, supplier) (supplyingOrder)
                // select supplyOrderItems where orderId, ProductId
                if (info.order_number == order.number)
                {
                    SupplyingOrder_Items supplyOrderItem =
                    (
                     from sOrder in ent.SupplyingOrder_Items
                     where sOrder.order_number == info.supplyingOrder_id
                     && sOrder.item_code == info.product_id
                     select sOrder
                    ).FirstOrDefault();

                    dgvOrderItems.Rows.Add(
                        info.Item.Name,
                        info.quantity,
                        supplyOrderItem.Production_Date,
                        supplyOrderItem.expiration_date,
                        info.SupplyingOrder.Wharehouse.name,
                        info.SupplyingOrder.Provider.name
                        );
                }

            }
        }

        private void cbWharehouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbSupplyingOrders.Items.Clear();
                cbSupplyingOrders.Text = "";
                cbItems.Items.Clear();
                cbItems.Text = "";
                cbUnits.Items.Clear();
                cbUnits.Text = "";
                nudItemQuantity.Value = 0;
                if (cbWharehouses.SelectedIndex != -1)
                {
                    // get warehouse
                    string warehouseName = cbWharehouses.Text;
                    Wharehouse warehouse = (from w in ent.Wharehouses
                                            where w.name == warehouseName
                                            select w).FirstOrDefault();
                    // get all orders in this warehouse
                    List<int> orders = new List<int>();
                    foreach (var o in ent.WarehouseItems)
                    {
                        if (o.warehouse_id == warehouse.ID)
                        {
                            orders.Add(o.order_id);
                        }
                    }
                    IEnumerable<int> distinctOrders = orders.Distinct();
                    foreach (int orderNum in distinctOrders)
                    {
                        cbSupplyingOrders.Items.Add(orderNum);
                    }
                    cbSupplyingOrders.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSupplyingOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbItems.Items.Clear();
                cbItems.Text = "";
                cbUnits.Items.Clear();
                cbUnits.Text = "";
                nudItemQuantity.Value = 0;
                if (cbSupplyingOrders.SelectedIndex != -1)
                {
                    // get Order
                    int orderNum = int.Parse(cbSupplyingOrders.Text);
                    SupplyingOrder order = (from sOrder in ent.SupplyingOrders
                                            where sOrder.number == orderNum
                                            select sOrder).FirstOrDefault();
                    // get all order Items
                    //foreach (SupplyingOrder_Items order_Items in ent.SupplyingOrder_Items)
                    //{
                    //    if (order_Items.order_number == orderNum)
                    //    {
                    //        cbItems.Items.Add(order_Items.Item.Name);
                    //    }
                    //}

                    string warehouseName = cbWharehouses.Text;
                    Wharehouse warehouse = (from w in ent.Wharehouses
                                            where w.name == warehouseName
                                            select w).FirstOrDefault();
                    foreach (WarehouseItem wi in ent.WarehouseItems)
                    {
                        if (wi.order_id == orderNum && wi.warehouse_id == warehouse.ID && wi.quantity > 0)
                        {
                            cbItems.Items.Add(wi.Item.Name);
                        }
                    }

                    cbItems.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbUnits.Items.Clear();
                nudItemQuantity.Value = 0;
                if (cbItems.SelectedIndex != -1)
                {
                    // get Item, item units, max quantity in warehouse
                    string itemName = cbItems.Text;
                    Item item = (from i in ent.Items
                                 where i.Name == itemName
                                 select i).FirstOrDefault();
                    // get all order Items
                    foreach (Unit u in item.Units)
                    {
                        cbUnits.Items.Add(u.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                nudItemQuantity.Value = 0;
                if (cbItems.SelectedIndex != -1)
                {
                    // set max quantity
                    // get avalible quantity in warehouse
                    string unitName = cbUnits.Text;
                    Unit unit = (from u in ent.Units
                                 where u.Name == unitName
                                 select u).FirstOrDefault();

                    string warehouseName = cbWharehouses.Text;
                    Wharehouse warehouse = (from w in ent.Wharehouses
                                            where w.name == warehouseName
                                            select w).FirstOrDefault();

                    int orderNum = int.Parse(cbSupplyingOrders.Text);
                    SupplyingOrder order = (from sOrder in ent.SupplyingOrders
                                            where sOrder.number == orderNum
                                            select sOrder).FirstOrDefault();

                    string itemName = cbItems.Text;
                    Item item = (from i in ent.Items
                                 where i.Name == itemName
                                 select i).FirstOrDefault();

                    WarehouseItem warehouseItem =
                        (from wi in ent.WarehouseItems
                         where wi.warehouse_id == warehouse.ID
                         && wi.order_id == order.number
                         && wi.item_id == item.Code
                         select wi
                        ).FirstOrDefault();

                    nudItemQuantity.Maximum = warehouseItem.quantity / unit.quantity;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // make numericUpDown accept integers only
        private void nudItemQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                string warehouseName, supplyingOrderNumber, itemName, unitName;
                int quantity = (int)nudItemQuantity.Value, 
                    paymentOrderNumber = int.Parse(txtOrderNum.Text);
                warehouseName = cbWharehouses.Text;
                supplyingOrderNumber = cbSupplyingOrders.Text;
                itemName = cbItems.Text;
                unitName = cbUnits.Text;
                if (!string.IsNullOrEmpty(warehouseName) && !string.IsNullOrEmpty(warehouseName)
                    && !string.IsNullOrEmpty(warehouseName) && !string.IsNullOrEmpty(warehouseName)
                    && quantity > 0)
                {
                    int supplyingOrderId = int.Parse(supplyingOrderNumber);
                    // prepare data
                    Item item = (from i in ent.Items
                                 where i.Name == itemName
                                 select i).FirstOrDefault();

                    Unit unit = (from u in ent.Units
                                 where u.Name == unitName
                                 select u).FirstOrDefault();

                    Wharehouse warehouse = (from w in ent.Wharehouses
                                            where w.name == warehouseName
                                            select w).FirstOrDefault();

                    SupplyingOrder order = (from sOrder in ent.SupplyingOrders
                                            where sOrder.number == supplyingOrderId
                                            select sOrder).FirstOrDefault();

                    WarehouseItem warehouseItem =
                        (from wi in ent.WarehouseItems
                         where wi.warehouse_id == warehouse.ID
                         && wi.order_id == order.number
                         && wi.item_id == item.Code
                         select wi
                        ).FirstOrDefault();

                    // check if item exist in current payment order
                    Inovice_Items inovice_Item = (from i in ent.Inovice_Items
                                                  where i.product_id == item.Code
                                                  && i.order_number == paymentOrderNumber
                                                  && i.supplyingOrder_id == order.number
                                                  select i).FirstOrDefault();
                    if (inovice_Item == null)
                    {
                        quantity *= unit.quantity;
                        // step 1: insert into inovice_items(order_number, item_number, 
                        // supplyOrder_number, quantity)
                        inovice_Item = new Inovice_Items();
                        inovice_Item.order_number = paymentOrderNumber;
                        inovice_Item.product_id = item.Code;
                        inovice_Item.supplyingOrder_id = order.number;
                        inovice_Item.quantity = quantity;
                        ent.Inovice_Items.Add(inovice_Item);

                        // update item, warehouse_items
                        // step 2: update item_quantity -= order_quantity
                        item.quantity -= quantity;
                        // step 3: update Warehouse_item_quantity -= order_quantity
                        warehouseItem.quantity -= quantity;
                        // insert into transaction sell = 2
                        // insert into transaction(2, supOrderId, itemId, quantity,
                        // warehouseId, WarehouseItemsQuantity, itemQuantity, date, paymentOrderId)
                        Transaction sellTransaction = new Transaction();
                        sellTransaction.type_id = 2;
                        sellTransaction.order_id = order.number;
                        sellTransaction.item_id = item.Code;
                        sellTransaction.quantity = quantity;
                        sellTransaction.wharehouse_id = warehouse.ID;
                        sellTransaction.total_quantity_for_item_in_wharehouse = (int)item.quantity;
                        sellTransaction.total_quantity_for_product_in_wharehouse = (int)warehouseItem.quantity;
                        sellTransaction.date = DateTime.Now;
                        sellTransaction.paymentOrderId = paymentOrderNumber;
                        ent.Transactions.Add(sellTransaction);
                        ent.SaveChanges();
                        MessageBox.Show("Item Added!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PaymentOrderInfo_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Item already exist in this order!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("All Data Required!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
