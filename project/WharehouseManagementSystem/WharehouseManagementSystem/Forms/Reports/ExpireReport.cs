using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WharehouseManagementSystem.Forms.Reports
{
    public partial class ExpireReport : Form
    {
        WarehouseDB ent;
        public ExpireReport()
        {
            InitializeComponent();
            ent = new WarehouseDB();
        }

        private void ExpireReport_Load(object sender, EventArgs e)
        {
            cbWarehouses.Items.Clear();
            dgvItems.Rows.Clear();
            foreach(Wharehouse w in ent.Wharehouses)
            {
                cbWarehouses.Items.Add(w.name);
            }
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Clear();
            if(cbWarehouses.SelectedIndex != -1 && nudDuration.Value > 0)
            {
                string warehouseName = cbWarehouses.Text;
                Wharehouse warehouse = (from w in ent.Wharehouses
                                        where w.name == warehouseName
                                        select w).FirstOrDefault();
                int duration = (int) nudDuration.Value;
                // foreach item in warehouseItems, get orderId
                // in SupplyOrderItems where itemCode, and orderId get date
                foreach (WarehouseItem wItem in ent.WarehouseItems)
                {
                    if(wItem.warehouse_id == warehouse.ID)
                    {
                        SupplyingOrder_Items item = (from i in ent.SupplyingOrder_Items
                                    where i.item_code == wItem.item_id
                                    && i.order_number == wItem.order_id
                                    select i).FirstOrDefault();
                        // calc date
                        DateTime expiratinDate = (DateTime.Today).AddDays(duration);
                        if(item.expiration_date == expiratinDate)
                        {
                            dgvItems.Rows.Add(item.order_number, item.Item.Name,
                                wItem.quantity, item.Production_Date, item.expiration_date);
                        }
                    }
                }
                MessageBox.Show("Done!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select warehouse, and Enter duration");
            }
        }

        private void nudDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }
    }
}
