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
            DGVLoad();
            // ***** Combo box *****

            foreach (var item in context.Categories) cbItemCat.Items.Add(item.CategoryName);
            cbItemCat.SelectedIndex = 0;
        }

        private void DGVLoad() {
            List<Tuple<string, string, string, decimal>> itemList = new List<Tuple<string, string, string, decimal>>();
            List<Tuple<int, string>> catList = new List<Tuple<int, string>>();
            List<Tuple<int, string, string, string, string>> userList = new List<Tuple<int, string, string, string, string>>();
            foreach (var item in context.Items) {
                Tuple<string, string, string, decimal> t = new Tuple<string, string, string, decimal>(item.ItemId, item.Category.CategoryName, item.ItemName, item.Price);
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
            dgvItem.Columns[0].HeaderText = "ItemId"; dgvItem.Columns[1].HeaderText = "Category"; dgvItem.Columns[2].HeaderText = "ItemName"; dgvItem.Columns[3].HeaderText = "Price";
            dgvCategory.DataSource = catList;
            dgvCategory.Columns[0].HeaderText = "CategoryId"; dgvCategory.Columns[1].HeaderText = "CategoryName";
            dgvUserList.DataSource = userList;
            dgvUserList.Columns[0].HeaderText = "UserId"; dgvUserList.Columns[1].HeaderText = "Username"; dgvUserList.Columns[2].HeaderText = "Password"; dgvUserList.Columns[3].HeaderText = "Email"; dgvUserList.Columns[4].HeaderText = "Phone";

            if (txtUserId.Text.Length == 0) dgvOrder.DataSource = null;
            else {
                try {
                    int id = int.Parse(txtUserId.Text);
                    if (context.Users.Find(id) != null) {

                        List<Tuple<int, string, decimal, string>> orderList = new List<Tuple<int, string, decimal, string>>();
                        foreach (var item in context.Orders.Where(o => o.UserId == id)) {
                            Tuple<int, string, decimal, string> t = new Tuple<int, string, decimal, string>(item.OrderId, item.Phone, item.Total, item.Status);
                            orderList.Add(t);
                        }

                        dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvOrder.DataSource = orderList;
                        dgvOrder.Columns[0].HeaderText = "OrderId"; dgvOrder.Columns[1].HeaderText = "Phone"; dgvOrder.Columns[2].HeaderText = "Total"; dgvOrder.Columns[3].HeaderText = "Status";

                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
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
                        Item item = new Item { ItemName = txtItemName.Text, Price = price, CategoryId = context.Categories.Where(c => c.CategoryName == cbItemCat.Text).FirstOrDefault().CategoryId };
                        int id = context.Items.Where(i => i.CategoryId == item.CategoryId).Count();
                        string cat = context.Categories.Find(item.CategoryId).CategoryName.Substring(0, 1).ToLower();
                        item.ItemId = cat + (id + 1);
                        context.Items.Add(item);
                        context.SaveChanges();
                        txtItemId.Clear();
                        txtItemName.Clear();
                        txtItemPrice.Clear();
                        cbItemCat.SelectedIndex = 0;
                        MessageBox.Show("New item added.");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            else MessageBox.Show("Item parameter(s) are not set properly.");
            DGVLoad();
        }

        private void btnSaveItem_Click(object sender, EventArgs e) {
            if (txtItemId.Text.Length > 0) {
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
                        i.CategoryId = context.Categories.Where(c => c.CategoryName == cbItemCat.Text).FirstOrDefault().CategoryId;
                        try {
                            context.Items.Update(i);
                            context.SaveChanges();
                            txtItemId.Clear();
                            txtItemName.Clear();
                            txtItemPrice.Clear();
                            cbItemCat.SelectedIndex = 0;
                            MessageBox.Show("Item changes saved.");
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }
                    }
                }
                else MessageBox.Show("Item parameter(s) are not set properly.");

            }
            else {
                MessageBox.Show("Item not selected.");
            }
            DGVLoad();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e) {
            if (txtItemId.Text.Length > 0) {
                if (context.Items.Find(txtItemId.Text) == null) {
                    MessageBox.Show("Cannot find item.");
                    return;
                }
                DialogResult re = MessageBox.Show("Delete item?", "Confirm", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes) {
                    try {
                        context.Items.Remove(context.Items.Find(txtItemId.Text));
                        context.SaveChanges();
                        txtItemId.Clear();
                        txtItemName.Clear();
                        txtItemPrice.Clear();
                        cbItemCat.SelectedIndex = 0;
                        MessageBox.Show("Item deleted.");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
            else {
                MessageBox.Show("Item not selected.");
            }
            DGVLoad();
        }

        private void btnAddCat_Click(object sender, EventArgs e) {
            if (txtCatName.Text.Length > 0) {
                if (context.Categories.Where(c => c.CategoryName == txtCatName.Text).Count() == 0) {
                    DialogResult re = MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo);
                    if (re == DialogResult.Yes) {
                        Category c = new Category { CategoryName = txtCatName.Text };
                        context.Categories.Add(c);
                        context.SaveChanges();
                        var itemCat = from ic in context.Categories
                                      select ic.CategoryName;
                        cbItemCat.DataSource = itemCat.ToList();
                        txtCatName.Clear();
                        txtCatId.Clear();
                        MessageBox.Show("New category added.");
                    }
                }
                else { MessageBox.Show("Category name duplicated."); }
            }
            else { MessageBox.Show("Enter category name."); }
            DGVLoad();
        }

        private void btnSaveCat_Click(object sender, EventArgs e) {
            if (txtCatId.Text.Length > 0) {
                if (txtCatName.Text.Length > 0) {
                    try {
                        if (context.Categories.Where(c => c.CategoryName == txtCatName.Text && c.CategoryId != int.Parse(txtCatId.Text)).Count() == 0) {
                            DialogResult re = MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo);
                            if (re == DialogResult.Yes) {
                                Category c = context.Categories.FirstOrDefault(c => c.CategoryId == int.Parse(txtCatId.Text));
                                c.CategoryName = txtCatName.Text;
                                context.Categories.Update(c);
                                context.SaveChanges();
                                txtCatId.Clear();
                                txtCatName.Clear();
                                MessageBox.Show("Category changes saved.");
                            }
                        }

                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
                else { MessageBox.Show("Category name cannot be empty."); }
            }
            else { MessageBox.Show("Select a category to update."); }
            DGVLoad();
        }

        private void btnDeleteCat_Click(object sender, EventArgs e) {
            if (txtCatId.Text.Length > 0) {
                try {
                    if (context.Categories.Where(c => c.CategoryId == int.Parse(txtCatId.Text)).Count() != 0) {
                        DialogResult re = MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo);
                        if (re == DialogResult.Yes) {
                            context.Categories.Remove(context.Categories.Find(int.Parse(txtCatId.Text)));
                            context.SaveChanges();
                            txtCatId.Clear();
                            txtCatName.Clear();
                            MessageBox.Show("Category deleted.");
                        }
                    }
                    else { MessageBox.Show("Cannot find category."); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Category not selected."); }
            DGVLoad();
        }


        private void btnSaveUser_Click(object sender, EventArgs e) {
            string phone = "";
            try {
                txtUserPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                phone = txtUserPhone.Text;
                txtUserPhone.TextMaskFormat = MaskFormat.IncludeLiterals;
                int.Parse(phone);
                if (phone.Length != 10) { phone = ""; throw new Exception(); }
            }
            catch (Exception ex) { MessageBox.Show("Phone number must be a 10-digits number"); }
            if (txtUserId.Text.Length > 0 && txtUserName.Text.Length > 0 && txtUserPass.Text.Length > 0 && txtUserMail.Text.Length > 0 && phone.Length > 0) {
                try {
                    if (context.Users.Where(c => c.UserId == int.Parse(txtUserId.Text)).Count() != 0) {
                        User u = context.Users.Where(c => c.UserId == int.Parse(txtUserId.Text)).FirstOrDefault();
                        u.Username = txtUserName.Text;
                        u.Phone = phone;
                        u.Email = txtUserMail.Text;
                        u.Password = txtUserPass.Text;
                        DialogResult re = MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo);
                        if (re == DialogResult.Yes) {
                            context.Users.Update(u);
                            context.SaveChanges();
                            txtUserPass.Clear();
                            txtUserMail.Clear();
                            txtUserId.Clear();
                            txtUserName.Clear();
                            txtUserPhone.Clear();
                            MessageBox.Show("User updated.");
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else MessageBox.Show("Cannot save user. Required field(s) is empty.");
            DGVLoad();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e) {
            if (txtUserId.Text.Length > 0) {
                try {
                    if (context.Users.Find(int.Parse(txtUserId.Text)) != null) {
                        DialogResult re = MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo);
                        if (re == DialogResult.Yes) {
                            context.Users.Remove(context.Users.Find(int.Parse(txtUserId.Text)));
                            context.SaveChanges();
                            txtUserPass.Clear();
                            txtUserMail.Clear();
                            txtUserId.Clear();
                            txtUserName.Clear();
                            txtUserPhone.Clear();
                            MessageBox.Show("User deleted.");
                        }
                    }
                    else { MessageBox.Show("Cannot find user."); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Select a user."); }
            DGVLoad();
        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                string id = dgvUserList.CurrentRow.Cells[0].Value.ToString();
                if (id != null) {
                    User u = context.Users.Find(int.Parse(id));
                    txtUserId.Text = u.UserId.ToString();
                    txtUserName.Text = u.Username;
                    txtUserPass.Text = u.Password;
                    txtUserMail.Text = u.Email;
                    txtUserPhone.Text = u.Phone;

                    List<Tuple<int, string, decimal, string>> orderList = new List<Tuple<int, string, decimal, string>>();
                    foreach (var item in context.Orders.Where(o => o.UserId == u.UserId)) {
                        Tuple<int, string, decimal, string> t = new Tuple<int, string, decimal, string>(item.OrderId, item.Phone, item.Total, item.Status);
                        orderList.Add(t);
                    }

                    dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvOrder.DataSource = orderList;
                    dgvOrder.Columns[0].HeaderText = "OrderId"; dgvOrder.Columns[1].HeaderText = "Phone"; dgvOrder.Columns[2].HeaderText = "Total"; dgvOrder.Columns[3].HeaderText = "Status";

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                string id = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                if (id != null) {
                    tabControl2.SelectedIndex = 0;
                    cbItemCat.SelectedItem = context.Categories.Where(c => c.CategoryId.ToString() == id).FirstOrDefault().CategoryName;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            try {
                string id = dgvCategory.CurrentRow.Cells[0].Value.ToString();
                if (id != null) {
                    tabControl2.SelectedIndex = 1;
                    txtCatId.Text = id;
                    txtCatName.Text = context.Categories.Find(int.Parse(id)).CategoryName;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                string id = dgvItem.CurrentRow.Cells[0].Value.ToString();
                if (id != null) {
                    Item i = context.Items.Find(id);
                    tabControl2.SelectedIndex = 0;
                    txtItemId.Text = i.ItemId;
                    txtItemName.Text = i.ItemName;
                    txtItemPrice.Text = i.Price.ToString();
                    cbItemCat.Text = i.Category.CategoryName;
                    //cbItemCat.SelectedIndex = i.CategoryId - 1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClearItem_Click(object sender, EventArgs e) {
            txtItemId.Text = "";
            txtItemName.Text = "";
            txtItemPrice.Text = "";
            cbItemCat.SelectedIndex = 0;
            DGVLoad();
        }

        private void btnClearCat_Click(object sender, EventArgs e) {
            txtCatId.Text = "";
            txtCatName.Text = "";
            DGVLoad();
        }

        private void btnClearUser_Click(object sender, EventArgs e) {
            txtUserId.Text = "";
            txtUserName.Text = "";
            txtUserMail.Text = "";
            txtUserPass.Text = "";
            txtUserPhone.Text = "";

            dgvOrder.DataBindings.Clear();
            dgvOrder.Columns.Clear();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                string id = dgvOrder.CurrentRow.Cells[0].Value.ToString();
                if (id != null) {
                    txtStatId.Text = id;
                    bool check = false;
                    foreach (var item in cbStat.Items) if (item.ToString() == context.Orders.Where(o => o.OrderId == int.Parse(id)).FirstOrDefault().Status) check = true;
                    if (check) cbStat.Text = context.Orders.Where(o => o.OrderId == int.Parse(id)).FirstOrDefault().Status;
                    else cbStat.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClearStat_Click(object sender, EventArgs e) {
            cbStat.Text = string.Empty;
            txtStatId.Clear();
        }

        private void btnSaveStat_Click(object sender, EventArgs e) {
            try {
                bool check = false;
                foreach (var item in cbStat.Items) { if (cbStat.Text == item.ToString()) { check = true; } }
                if (!check) throw new Exception("Please choose order status from the dropdown list instead of typing it in yourself.");
                if (txtStatId.Text.Length > 0) {
                    if (context.Orders.Where(o => o.OrderId == int.Parse(txtStatId.Text)).FirstOrDefault() != null) {
                        DialogResult re = MessageBox.Show("Save changes?", "Confirm", MessageBoxButtons.YesNo);
                        if (re == DialogResult.Yes) {
                            Order o = context.Orders.Where(o => o.OrderId == int.Parse(txtStatId.Text)).FirstOrDefault();
                            o.Status = cbStat.Text;
                            context.Orders.Update(o);
                            context.SaveChanges();
                            cbStat.Text = "";
                            txtStatId.Text = "";

                        }
                    }
                }
                else MessageBox.Show("Please select an order.");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            DGVLoad();
        }

        private void cbStat_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Form6_Load_1(object sender, EventArgs e) {

        }
    }
}
