using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WharehouseManagementSystem.Forms.Items
{
    public partial class Items : Form
    {
        WarehouseDB ent;
        public Items()
        {
            InitializeComponent();
            ent = new WarehouseDB();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            try
            {
                dgvItems.Rows.Clear();
                lbItemUnits.Items.Clear();
                txtNumber.Text = "";
                txtName.Text = "";
                txtQuantity.Text = "";
                foreach (var item in ent.Items)
                {
                    dgvItems.Rows.Add(item.Code, item.Name, item.quantity);
                }

                foreach (var unit in ent.Units)
                {
                    lbItemUnits.Items.Add(unit.Name);
                }
                lbItemUnits.SetItemChecked(0, true);

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
                string name = txtName.Text;
                if (!string.IsNullOrEmpty(name))
                {
                    try
                    {
                        Item item = new Item();
                        item.Name = name;
                        item.quantity = 0;

                        string firstListItem = lbItemUnits.Items[0].ToString();
                        var firstUnit = ((from un in ent.Units
                                          where un.Name == firstListItem
                                          select un).FirstOrDefault());
                        item.Units.Add(firstUnit);
                        // get and insert selected units
                        // insert all itemUnits
                        for (int i = 1; i < lbItemUnits.CheckedItems.Count; ++i)
                        {
                            string s = lbItemUnits.CheckedItems[i].ToString();
                            var unit = (from u in ent.Units
                                        where u.Name == s
                                        select u).FirstOrDefault();
                            item.Units.Add(unit);
                        }
                        ent.Items.Add(item);
                        ent.SaveChanges();
                        MessageBox.Show("Item added!");
                        Items_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Item Name is Required!");
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
                if (!string.IsNullOrEmpty(txtNumber.Text) && !string.IsNullOrEmpty(txtName.Text))
                {
                    int id = int.Parse(txtNumber.Text);
                    Item item = new Item();
                    item = (from i in ent.Items
                            where i.Code == id
                            select i).FirstOrDefault();
                    item.Name = txtName.Text;

                    // item units
                    item.Units.Clear();
                    string firstListItem = lbItemUnits.Items[0].ToString();
                    var firstUnit = ((from un in ent.Units
                                      where un.Name == firstListItem
                                      select un).FirstOrDefault());
                    item.Units.Add(firstUnit);
                    // get and insert selected units
                    // insert all itemUnits
                    for (int i = 1; i < lbItemUnits.CheckedItems.Count; ++i)
                    {
                        string s = lbItemUnits.CheckedItems[i].ToString();
                        var unit = (from u in ent.Units
                                    where u.Name == s
                                    select u).FirstOrDefault();
                        item.Units.Add(unit);
                    }

                    ent.SaveChanges();
                    MessageBox.Show("Item Updated!");
                    Items_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Select an Item to edit or Enter Item Name!");
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
                if (!string.IsNullOrEmpty(txtNumber.Text) && !string.IsNullOrEmpty(txtName.Text))
                {
                    int id = int.Parse(txtNumber.Text);

                    Item item = new Item();
                    item = (from i in ent.Items
                            where i.Code == id
                            select i).FirstOrDefault();
                    if (item.SupplyingOrder_Items.Count > 0)
                    {
                        MessageBox.Show("Cant Delete Item!\n" +
                            "it may be contained in supply order\n");
                    }
                    else
                    {
                        item.Units.Clear();
                        ent.Items.Remove(item);
                        ent.SaveChanges();
                        MessageBox.Show("Item Deleted!");
                        Items_Load(sender, e);
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

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvItems.CurrentRow != null)
                {
                    DataGridViewRow row =
                    dgvItems.Rows[e.RowIndex];

                    // if textBoxes doesn't contain any values, load row data
                    // else ask user first
                    bool load = true;
                    if (!string.IsNullOrEmpty(txtNumber.Text))
                    {
                        var loadData = MessageBox.Show("There is unsaved data in textboxes\n" +
                            "Do you want to override them?", "", MessageBoxButtons.YesNo);
                        load = loadData == DialogResult.Yes;
                    }

                    if (load)
                    {
                        txtNumber.Text = row.Cells[0].Value.ToString();
                        txtName.Text = row.Cells[1].Value.ToString();
                        txtQuantity.Text = row.Cells[2].Value.ToString();

                        int id = (int.Parse(txtNumber.Text));
                        var item = (from it in ent.Items
                                    where it.Code == id
                                    select it).FirstOrDefault();
                        // foreach unit in itemUnits cheched = true;
                        lbItemUnits.SetItemChecked(0, true);
                        foreach (var unit in item.Units)
                        {
                            string u = unit.Name;
                            for (int i = 1; i < lbItemUnits.Items.Count; ++i)
                            {
                                if (lbItemUnits.Items[i].ToString() == u)
                                {
                                    lbItemUnits.SetItemChecked(i, true);
                                }
                                else
                                {
                                    lbItemUnits.SetItemChecked(i, false);
                                }
                            }
                        }
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
