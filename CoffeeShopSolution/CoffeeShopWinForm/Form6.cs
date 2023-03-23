using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWinForm {
    public partial class Form6 : Form {
        CoffeeShopContext context = new CoffeeShopContext();
        //This form is for 'admin user'. DO NOT change name until it's design is finalized
        public Form6() {
            InitializeComponent();

            // ***** Data grids *****
            context.Users.Load();
            context.Orders.Load();
            context.Items.Load();
            context.Categories.Load();

            List<Tuple<string, int, string, decimal>> itemList = new List<Tuple<string, int, string, decimal>>();
            List<Tuple<int, string>> catList = new List<Tuple<int, string>>();
            List<Tuple<int, string, string, string, string>> userList = new List<Tuple<int, string, string, string, string>>();
            foreach (var item in context.Items) {
                Tuple<string, int, string, decimal> t = new Tuple<string, int, string, decimal>(item.ItemId, item.CategoryId, item.ItemName, item.Price);
                itemList.Add(t);
            }
            foreach (var item in context.Categories) {
                Tuple<int, string> t = new Tuple<int, string>(item.CategoryId, item.CategoryName);
                catList.Add(t);
            }
            foreach (var item in context.Users) {
                Tuple<int, string, string, string, string> t = new Tuple<int, string, string, string, string>(item.UserId, item.Username, item.Password, item.Email, item.Phone);
                userList.Add(t);
            }

            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvItem.DataSource = itemList;
            dgvItem.Columns[0].HeaderText = "ItemId"; dgvItem.Columns[1].HeaderText = "CategoryId"; dgvItem.Columns[2].HeaderText = "ItemName"; dgvItem.Columns[3].HeaderText = "Price";
            dgvCategory.DataSource = catList;
            dgvCategory.Columns[0].HeaderText = "CategoryId"; dgvCategory.Columns[1].HeaderText = "CategoryName";
            dgvUserList.DataSource = userList;
            dgvUserList.Columns[0].HeaderText = "UserId"; dgvUserList.Columns[1].HeaderText = "Username"; dgvUserList.Columns[2].HeaderText = "Password"; dgvUserList.Columns[3].HeaderText = "Email"; dgvUserList.Columns[4].HeaderText = "Phone";

            // ***** Combo box *****

            foreach (var item in context.Categories) cbItemCat.Items.Add(item.CategoryName);
            cbItemCat.SelectedIndex = 0;
        }

        private void Form6_Load(object sender, EventArgs e) {

        }

        private void btnPic_Click(object sender, EventArgs e) {

        }

        private void btnAddItem_Click(object sender, EventArgs e) {
            if (txtItemName.Text.Length > 0 && txtItemPrice.Text.Length > 0 && cbItemCat.Text.Length > 0) {
                decimal price = 0;
                try {
                    price = decimal.Parse(txtItemPrice.Text);
                    if (price <= 0) throw new Exception("a");
                }
                catch {
                    MessageBox.Show("Item Price must be a positive number.");
                    txtItemPrice.Focus();
                    return;
                }
                if (context.Categories.Where(c => c.CategoryName == cbItemCat.Text).Count() == 0) {
                    MessageBox.Show("Unknown item category.");
                    cbItemCat.Focus();
                    return;
                }
                if (context.Items.Where(i => i.ItemName == txtItemName.Text).Count() != 0) {
                    MessageBox.Show("Item name is in database.");
                    txtItemName.Focus();
                    return;
                }

                DialogResult re = MessageBox.Show("Add new item?", "Confirm", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes) {
                    try {
                        context.Items.Add(new Item { ItemName = txtItemName.Text, Price = price, CategoryId = context.Categories.Where(c => c.CategoryName == cbItemCat.SelectedText).FirstOrDefault().CategoryId });
                        context.SaveChanges();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message);}
                }
            }
            else MessageBox.Show("Item parameter(s) are not set properly.");
        }

        private void btnSaveItem_Click(object sender, EventArgs e) {
            if(txtItemId.Text.Length > 0) {
                if (txtItemName.Text.Length > 0 && txtItemPrice.Text.Length > 0 && cbItemCat.Text.Length > 0) {
                    decimal price = 0;
                    try {
                        price = decimal.Parse(txtItemPrice.Text);
                        if (price <= 0) throw new Exception();
                    }
                    catch {
                        MessageBox.Show("Item Price must be a positive number.");
                        txtItemPrice.Focus();
                        return;
                    }
                    if (context.Categories.Where(c => c.CategoryName == cbItemCat.Text).Count() == 0) {
                        MessageBox.Show("Unknown item category.");
                        cbItemCat.Focus();
                        return;
                    }

                    DialogResult re = MessageBox.Show("Update item?", "Confirm", MessageBoxButtons.YesNo);
                    if (re == DialogResult.Yes) {
                        Item i = context.Items.Find(txtItemId.Text);
                        i.ItemName = txtItemName.Text;
                        i.Price = price;
                        i.CategoryId = context.Categories.Where(c => c.CategoryName == cbItemCat.SelectedText).FirstOrDefault().CategoryId;
                        try {
                            context.Items.Update(i);
                            context.SaveChanges();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message);}
                    }
                }
                else MessageBox.Show("Item parameter(s) are not set properly.");

            }
            else {
                MessageBox.Show("Item not selected.");
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e) {
            if(txtItemId.Text.Length > 0) {
                if (context.Items.Find(txtItemId.Text) == null) {
                    MessageBox.Show("Cannot find item.");
                    return;
                }
                DialogResult re = MessageBox.Show("Delete item?","Confirm",MessageBoxButtons.YesNo);
                if(re == DialogResult.Yes) {
                    try {
                        context.Items.Remove(context.Items.Find(txtItemId.Text));
                        context.SaveChanges();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message);}
                }
            }
            else {
                MessageBox.Show("Item not selected.");
            }
        }

        private void btnAddCat_Click(object sender, EventArgs e) {

        }

        private void btnSaveCat_Click(object sender, EventArgs e) {

        }

        private void btnDeleteCat_Click(object sender, EventArgs e) {

        }

        private void btnAddUser_Click(object sender, EventArgs e) {

        }

        private void btnSaveUser_Click(object sender, EventArgs e) {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e) {

        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e) {
            tabControl2.SelectedIndex = 0;
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnItemClear_Click(object sender, EventArgs e) {
            txtItemId.Text = "";
            txtItemName.Text = "";
            txtItemPrice.Text = "";
        }
    }
}
