using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CoffeeShopWinForm {
    public partial class Form3 : Form {
        private CoffeeShopContext db = new CoffeeShopContext();
        BindingSource source = new BindingSource();
        User u = new User();
        public Form3(User user) {
            InitializeComponent();
            this.u = user;
            lbUsername.Text = user.Username;
            dgvLoad();
        }

        private void dgvLoad() {
            List<Tuple<string, decimal, int, decimal, DateTime>> list = new List<Tuple<string, decimal, int, decimal, DateTime>>();
            foreach (var item in db.Carts.Where(c => c.UserId == u.UserId)) {
                Tuple<string, decimal, int, decimal, DateTime> t = new Tuple<string, decimal, int, decimal, DateTime>(
                    item.ItemName, item.Price, item.Quantity, item.Price * item.Quantity, item.OrderDate);
                list.Add(t);
            }
            dgvCart.DataSource = list;
            dgvCart.Columns[0].HeaderText = "Items Name";
            dgvCart.Columns[1].HeaderText = "Prices";
            dgvCart.Columns[2].HeaderText = "Quantity";
            dgvCart.Columns[3].HeaderText = "Total";
            dgvCart.Columns[4].HeaderText = "Order Date";
        }

        private void Form3_Load(object sender, EventArgs e) {

        }
        private void rbCoffee_CheckedChanged(object sender, EventArgs e) {
            var id = 1;
            var coffee = from item in db.Items
                         join category in db.Categories
                         on item.CategoryId equals category.CategoryId
                         where item.CategoryId == id
                         select item.ItemName;
            cbSelect.DataSource = coffee.ToList();
        }

        private void rbDessert_CheckedChanged(object sender, EventArgs e) {
            var id = 2;
            var dessert = from item in db.Items
                          join category in db.Categories
                          on item.CategoryId equals category.CategoryId
                          where item.CategoryId == id
                          select item.ItemName;
            cbSelect.DataSource = dessert.ToList();
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e) {
            String name = cbSelect.Text.Trim();

            //var price = from i in db.Items
            //           where i.ItemName == name
            //           select i.Price;
            try {
                decimal price = db.Items.Where(x => x.ItemName == name).Select(x => x.Price).FirstOrDefault();
                string itemId = db.Items.Where(x => x.ItemName == name).Select(x => x.ItemId).FirstOrDefault();

                var amount = decimal.Parse(tbAmount.Text);
                tbPrice.Text = price.ToString();
                tbItemId.Text = itemId;
                tbItemId.Hide();
                tbTotal.Text = "";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e) {
            if (numericQuantity.Value > 120) {
                MessageBox.Show("Quantity must be less than 120");
            }
            else {
                try {
                    if (numericQuantity.Value > 0) {
                        decimal d = decimal.Parse(tbPrice.Text);
                        if (d > 0) {
                            tbTotal.Text = (d * numericQuantity.Value).ToString();
                        }
                    }
                    else {
                        tbTotal.Text = "";
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            try {
                if (tbPrice.Text.Length > 0 && tbTotal.Text.Length > 0) {
                    decimal price = decimal.Parse(tbPrice.Text);
                    decimal total = decimal.Parse(tbTotal.Text);
                    int userId = u.UserId;
                    var cart = new Cart {
                        UserId = userId,
                        ItemId = tbItemId.Text.Trim(),
                        ItemName = cbSelect.Text.Trim(),
                        Price = price,
                        Quantity = (int)numericQuantity.Value,
                        OrderDate = DateTime.Now,
                    };
                    db.Carts.Add(cart);
                    db.SaveChanges();

                    //dgvCart.Rows.Add(cbSelect.Text, tbPrice.Text, numericQuantity.Value.ToString(), tbTotal.Text, DateTime.Now);
                    decimal amount = decimal.Parse(tbAmount.Text) + total;
                    tbAmount.Text = amount.ToString();
                }
                else { MessageBox.Show("Please select Item and Amount."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            dgvLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dgvCart.SelectedRows.Count > 0) {
                string name = dgvCart.SelectedRows[0].Cells[0].Value.ToString();
                //String itemid = db.Carts.SingleOrDefault(c => c.ItemName == name);

                var cart = from c in db.Carts
                           where c.ItemName == name
                           select c;

                foreach (Cart c in cart) {
                    db.Carts.Remove(c);
                    tbAmount.Text = (decimal.Parse(tbAmount.Text) - c.Price * c.Quantity).ToString();
                    db.SaveChanges();
                    dgvLoad();
                }
            }
            else { MessageBox.Show("Item not selected."); }

        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                if (db.Carts.Where(c => c.UserId == u.UserId).Count() > 0) {
                    var order = new Order {
                        UserId = u.UserId,
                        Phone = u.Phone,
                        Total = decimal.Parse(tbAmount.Text.Trim()),
                        Status = "Waiting"
                    };
                    db.Orders.Add(order);
                    db.SaveChanges();

                    foreach (var item in db.Carts.Where(c => c.UserId == u.UserId)) {
                        OrderDetail o = new OrderDetail {
                            OrderId = order.OrderId,
                            ItemId = item.ItemId,
                            Quantity = item.Quantity,
                            OrderDate = item.OrderDate
                        };
                        db.OrderDetails.Add(o);
                    }
                    db.SaveChanges();

                    MessageBox.Show("Order successfull!");

                    cbSelect.Text = string.Empty;
                    tbPrice.Text = string.Empty;
                    numericQuantity.Text = string.Empty;
                    tbTotal.Text = string.Empty;
                    tbAmount.Text = "0";


                    int userid = u.UserId;
                    var cart = db.Carts.Where(c => c.UserId == userid);
                    foreach (var item in cart) {
                        db.Carts.Remove(item);
                    }
                    db.SaveChanges();
                }
                else { MessageBox.Show("Your cart is empty."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            dgvLoad();

        }

        private void btnClear_Click(object sender, EventArgs e) {
            try {
                if (db.Carts.Where(c => c.UserId == u.UserId).Count() == 0) { MessageBox.Show("Your cart is empty."); return; }
                int userid = u.UserId;
                var cart = db.Carts.Where(c => c.UserId == userid);
                DialogResult re = MessageBox.Show("Do you want to clear your cart?", "Confirm", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes) {
                    foreach (var item in cart) { db.Carts.Remove(item); }
                    db.SaveChanges();
                    cbSelect.Text = string.Empty;
                    tbPrice.Text = string.Empty;
                    numericQuantity.Text = string.Empty;
                    tbTotal.Text = string.Empty;
                    tbAmount.Text = "0";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            dgvLoad();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            try {
                string name = dgvCart.CurrentRow.Cells[0].Value.ToString();
                if (name != null) {
                    if (db.Items.Where(c => c.ItemName == name).Any()) {
                        var carts = db.Carts.Where(
                            c => c.UserId == u.UserId
                            && c.ItemId == db.Items.Where(i => i.ItemName == name).FirstOrDefault().ItemId
                            && c.Quantity == int.Parse(dgvCart.CurrentRow.Cells[2].Value.ToString())
                            //&& c.OrderDate.ToString().Trim() == dgvCart.CurrentRow.Cells[3].Value.ToString().Trim()
                            );
                        Cart cart = null;
                        foreach (var item in carts)
                            if (item.OrderDate.ToString().Trim() == dgvCart.CurrentRow.Cells[4].Value.ToString().Trim()) {
                                //MessageBox.Show(item.OrderDate.ToString().Trim() +" " + dgvCart.CurrentRow.Cells[4].Value.ToString().Trim());
                                cart = item;
                            }
                        if (cart == null) { throw new Exception("Cannot find cart."); }
                        //MessageBox.Show(dgvCart.CurrentRow.Cells[3].Value.ToString().Trim());
                        var cat = db.Items.Where(c => c.ItemName == name).FirstOrDefault().CategoryId;
                        if (db.Categories.Where(c => c.CategoryId == cat).FirstOrDefault().CategoryName.ToLower() == rbCoffee.Text.ToLower()) {
                            rbCoffee.Checked = true;
                        }
                        else if (db.Items.Where(c => c.ItemName == name).FirstOrDefault().Category.CategoryName.ToLower() == rbDessert.Text.ToLower()) {
                            rbDessert.Checked = true;
                        }
                        else { MessageBox.Show("Cannot find item."); }
                        cbSelect.Text = cart.ItemName;
                        tbPrice.Text = cart.Price.ToString();
                        tbItemId.Text = cart.ItemId.ToString();
                        numericQuantity.Value = cart.Quantity;
                        tbTotal.Text = (cart.Price * cart.Quantity).ToString();
                    }
                    else { MessageBox.Show("Deleted item."); }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void btnForm4_Click(object sender, EventArgs e) {
            try {
                Form4 frmCart = new Form4(u);
                frmCart.FormClosed += new FormClosedEventHandler(isLogout);
                frmCart.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void isLogout(object? sender, FormClosedEventArgs e) {
            var frm = sender as Form4;
            if (frm != null) {
                if (frm.DialogResult == DialogResult.Abort) {
                    DialogResult = DialogResult.Abort;
                    Close();
                }
            }
        }

        private void tbAmount_TextChanged(object sender, EventArgs e) {

        }
    }

}
