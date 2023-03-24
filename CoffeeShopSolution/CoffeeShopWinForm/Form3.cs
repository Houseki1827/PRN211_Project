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

namespace CoffeeShopWinForm
{
    public partial class Form3 : Form
    {
        private CoffeeShopContext db = new CoffeeShopContext();
        BindingSource source = new BindingSource();
        User u = new User();
        public Form3(User user)
        {
            InitializeComponent();
            this.u = user;
            lbUsername.Text = user.Username;
            dgvLoad();
        }

        private void dgvLoad()
        {
            string total = tbTotal.Text.Trim();
            List<Tuple<string, decimal, int, string, DateTime>> list = new List<Tuple<string, decimal, int, string, DateTime>>();
            foreach (var item in db.Carts.Where(c => c.UserId == u.UserId))
            {
                Tuple<string, decimal, int, string, DateTime> t = new Tuple<string, decimal, int, string, DateTime>(
                    item.ItemName, item.Price, item.Quantity, total, item.OrderDate);
                list.Add(t);
            }
            dgvCart.DataSource = list;
            dgvCart.Columns[0].HeaderText = "Items Name";
            dgvCart.Columns[1].HeaderText = "Prices";
            dgvCart.Columns[2].HeaderText = "Quantity";
            dgvCart.Columns[3].HeaderText = "Total";
            dgvCart.Columns[4].HeaderText = "Order Date";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void rbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            var id = 1;
            var coffee = from item in db.Items
                         join category in db.Categories
                         on item.CategoryId equals category.CategoryId
                         where item.CategoryId == id
                         select item.ItemName;
            cbSelect.DataSource = coffee.ToList();
        }

        private void rbDessert_CheckedChanged(object sender, EventArgs e)
        {
            var id = 2;
            var dessert = from item in db.Items
                          join category in db.Categories
                          on item.CategoryId equals category.CategoryId
                          where item.CategoryId == id
                          select item.ItemName;
            cbSelect.DataSource = dessert.ToList();
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = cbSelect.Text.Trim();

            //var price = from i in db.Items
            //           where i.ItemName == name
            //           select i.Price;

            decimal price = db.Items.Where(x => x.ItemName == name).Select(x => x.Price).FirstOrDefault();
            string itemId = db.Items.Where(x => x.ItemName == name).Select(x => x.ItemId).FirstOrDefault();

            tbPrice.Text = price.ToString();
            tbItemId.Text = itemId;
            tbItemId.Hide();
            numericQuantity.Value = 0;
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (numericQuantity.Value > 120)
            {
                MessageBox.Show("Quantity must be less than 120");
            }
            else
            {
                try
                {
                    if (numericQuantity.Value > 0)
                    {
                        decimal d = decimal.Parse(tbPrice.Text);
                        if (d > 0)
                        {
                            tbTotal.Text = (d * numericQuantity.Value).ToString();
                        }
                    }
                    else
                    {
                        tbTotal.Clear();
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var cart = from c in db.Carts
            //           join item in db.Items
            //           on c.ItemId equals item.ItemId
            //           join user in db.Users
            //           on c.UserId equals user.UserId
            //           select new { item.ItemName, item.Price, c.Quantity, c.OrderDate };

            //var cart = new Cart
            //{
            //    ItemId = cbSelect.Text.Trim(),
            //    Quantity = (int)numericQuantity.Value,
            //    OrderDate = DateTime.Now
            //};
            //db.Carts.Add(cart);
            //db.SaveChanges();
            //ReloadDataGridView();

            //foreach(var c in db.Carts) 
            //{
            //    foreach (var item in db.Items)
            //    {
            //        item.ItemName = cbSelect.Text.Trim();
            //        item.Price = decimal.Parse(tbPrice.Text.Trim());
            //    }
            //    c.Quantity = Convert.ToInt16(numericQuantity.Value);
            //    c.OrderDate = DateTime.Now;
            //    db.Carts.Add(c);
            //}
            //db.SaveChanges();
            //ReloadDataGridView();

            //{
            //    ItemName = item.ItemName,
            //    Price = 
            //{
            //    itemName = cbSelect.Text.Trim(),
            //    .price = tbPrice.Text.Trim(),
            //    cart.quantity = numericQuantity.Value,
            //    cart.total = tbTotal.Text.Trim()

            //db.Carts.Add(new Cart {ItemId = cbSelect.Text, Price = tbPrice.Text}  )

            int userId = u.UserId;
            //String itemName = cbSelect.Text.Trim();;
            //string itemId = db.Items.Where(x => x.ItemName == itemName).Select(x => x.ItemId).FirstOrDefault();
            var cart = new Cart
            {
                UserId = userId,
                ItemId = tbItemId.Text.Trim(),
                ItemName = cbSelect.Text.Trim(),
                Price = decimal.Parse(tbPrice.Text.Trim()),
                Quantity = (int)numericQuantity.Value,
                OrderDate = DateTime.Now,
            };
            db.Carts.Add(cart);
            db.SaveChanges();

            //dgvCart.Rows.Add(cbSelect.Text, tbPrice.Text, numericQuantity.Value.ToString(), tbTotal.Text, DateTime.Now);
            decimal amount = decimal.Parse(tbAmount.Text) + decimal.Parse(tbTotal.Text);
            tbAmount.Text = amount.ToString();
            dgvLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (dgvCart.SelectedRows.Count > 0)
            //{
            //    for (int i = 0; i < dgvCart.SelectedRows.Count; i++)
            //    {
            //        if (dgvCart.Rows[i].Selected)
            //        {
            //            tbAmount.Text = (int.Parse(tbAmount.Text) - int.Parse(dgvCart.Rows[i].Cells[3].Value)).ToString();
            //            dgvCart.Rows.RemoveAt(i);
            //        }
            //    }
            //    cbSelect.Text = string.Empty;
            //    tbPrice.Text = string.Empty;
            //    numericQuantity.Text = string.Empty;
            //    tbTotal.Text = string.Empty;
            ////}

            if (dgvCart.SelectedRows.Count > 0)
            {
                string name = dgvCart.SelectedRows[0].Cells[0].Value.ToString();
                //String itemid = db.Carts.SingleOrDefault(c => c.ItemName == name);

                var cart = from c in db.Carts
                           where c.ItemName == name
                           select c;

                foreach (Cart c in cart)
                {
                    db.Carts.Remove(c);
                    tbAmount.Text = (decimal.Parse(tbAmount.Text) - c.Price).ToString();
                    db.SaveChanges();
                    dgvLoad();
                }

                //cbSelect.Text = string.Empty;
                //tbPrice.Text = string.Empty;
                //numericQuantity.Text = string.Empty;
                //tbTotal.Text = string.Empty;

                //var order = from o in db.Orders
                //            join c in db.Carts
                //            on o.UserId equals c.UserId
                //            where c.ItemName == name
                //            select o;

                //foreach(Order o in order)
                //{
                //    db.Orders.Remove(o);
                //    db.SaveChanges();
                //}

                //var orderDetail = from od in db.OrderDetails
                //                  join o in db.Orders
                //                  on od.OrderId equals o.OrderId
                //                  where od.ItemId == 
                //                  select od;


            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //string name = cbSelect.Text.Trim();
            //var cart = from c in db.Carts
            //           join i in db.Items
            //             on c.ItemId equals i.ItemId
            //           where i.ItemName == name
            //           select new { i.ItemId, i.Price, c.Quantity, c.OrderDate};



            //from c in db.Carts
            //       join i in db.Items
            //       on c.ItemId equals i.ItemId
            //       select new
            //       {
            //           i.ItemName,
            //           i.Price,
            //           c.Quantity,
            //           c.OrderDate
            //       };

            //decimal price = db.Items.Where(x => x.ItemName == name).Select(x => x.Price).FirstOrDefault();

            //var orderDetail = new OrderDetail
            //{
            //    OrderId = order.OrderId,
            //    ItemId = ;
            //    Quantity = ;
            //      OrderDate
            //};

            
            var order = new Order
            {
                UserId = u.UserId,
                Phone = u.Phone,
                Total = decimal.Parse(tbAmount.Text.Trim()),
                Status = "Waiting"
            };
            db.Orders.Add(order);
            db.SaveChanges();

            //var orderDetail = new OrderDetail
            //{
            //    OrderId = order.OrderId,
            //    ItemId = itemId,
            //    Quantity = (int)numericQuantity.Value,
            //    OrderDate = DateTime.Now,
            //};
            //db.OrderDetails.Add(orderDetail);
            //db.SaveChanges();

            MessageBox.Show("Order successfull!");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //dgvCart.Rows.Clear();
            //tbAmount.Text = "0";
            if (dgvCart.SelectedRows.Count > 0)
            {
                int userid = u.UserId;

                //var clear = from c in db.Carts
                //           where c.UserId == userid
                //           select c;

                var clear = db.Carts.FirstOrDefault(c => c.UserId == userid);
                if (clear != null)
                {
                    db.Carts.Remove(clear);
                    db.SaveChanges();
                    dgvLoad();
                }

                cbSelect.Text = string.Empty;
                tbPrice.Text = string.Empty;
                numericQuantity.Text = string.Empty;
                tbTotal.Text = string.Empty;
                tbAmount.Text = "0";
            }

        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string name = dgvCart.CurrentRow.Cells[0].Value.ToString();
                if (name != null)
                {
                    if (db.Items.Where(c => c.ItemName == name).Any())
                    {
                        var carts = db.Carts.Where(
                            c => c.UserId == u.UserId
                            && c.ItemId == db.Items.Where(i => i.ItemName == name).FirstOrDefault().ItemId
                            && c.Quantity == int.Parse(dgvCart.CurrentRow.Cells[2].Value.ToString())
                            //&& c.OrderDate.ToString().Trim() == dgvCart.CurrentRow.Cells[3].Value.ToString().Trim()
                            );
                        Cart cart = null;
                        foreach (var item in carts) if (item.OrderDate.ToString().Trim() == dgvCart.CurrentRow.Cells[3].Value.ToString().Trim()) cart = item;
                        if (cart == null) { return; }
                        //MessageBox.Show(dgvCart.CurrentRow.Cells[3].Value.ToString().Trim());
                        var cat = db.Items.Where(c => c.ItemName == name).FirstOrDefault().CategoryId;
                        if (db.Categories.Where(c => c.CategoryId == cat).FirstOrDefault().CategoryName.ToLower() == rbCoffee.Text.ToLower())
                        {
                            rbCoffee.Checked = true;
                        }
                        else if (db.Items.Where(c => c.ItemName == name).FirstOrDefault().Category.CategoryName.ToLower() == rbDessert.Text.ToLower())
                        {
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
    

        private void btnForm4_Click(object sender, EventArgs e)
        {
            try
            {
                Form4 frmCart = new Form4(u);
                frmCart.FormClosed += new FormClosedEventHandler(isLogout);
                frmCart.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void isLogout(object? sender, FormClosedEventArgs e)
        {
            var frm = sender as Form4;
            if (frm != null)
            {
                if (frm.DialogResult == DialogResult.Abort)
                {
                    DialogResult = DialogResult.Abort;
                    Close();
                }
            }
        } 
    }

}
