using BusinessObject.Models;
using DataAccess.Repositories.Inteface;
using DataAccess.Repositories.Repo;
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

namespace CoffeeShopWinForm
{
    public partial class Form3 : Form
    {
        IUserRepository repo = new UserRepository();
        private CoffeeShopContext db = new CoffeeShopContext();
        BindingSource source = new BindingSource();
        User u = new User();
        public Form3(User user)
        {
            InitializeComponent();
            this.u = user;
            lbUsername.Text = user.Username;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void rbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            //cbSelect.Items.Clear();
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
            //cbSelect.Items.Clear();
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
            tbPrice.Text = price.ToString();
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(numericQuantity.Value > 120)
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
                            tbTotal.Text = (d*numericQuantity.Value).ToString();
                        }
                }
                    else
                    {
                        tbTotal.Clear();
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message);}
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
            String itemId = "c1";
            var cart = new Cart
            {
                UserId = userId,
                ItemId = itemId,
                ItemName = cbSelect.Text.Trim(),
                Price = decimal.Parse(tbPrice.Text.Trim()),
                Quantity = (int)numericQuantity.Value,
                OrderDate = DateTime.Now,
            };
            db.Carts.Add(cart);
            db.SaveChanges();


            dgvCart.Rows.Add(cbSelect.Text, tbPrice.Text, numericQuantity.Value.ToString(), tbTotal.Text, DateTime.Now);
            decimal amount = decimal.Parse(tbAmount.Text) + decimal.Parse(tbPrice.Text);
            tbAmount.Text = amount.ToString();

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
                var item = db.Carts.SingleOrDefault(c => c.ItemName == name);

                var cart = from c in db.Carts
                           where c.ItemName == name
                           select c;

                foreach (Cart c in cart)
                {
                    db.Carts.Remove(c);
                }

                if (item != null)
                {
                    db.Carts.Remove(item);
                    db.SaveChanges();
                    //ReloadDataGridView();
                }
                cbSelect.Text = string.Empty;
                tbPrice.Text = string.Empty;
                numericQuantity.Text = string.Empty;
                tbTotal.Text = string.Empty;
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

            int userId = 2;
            String itemId = "c1";
            var cart = new Cart
            {
                UserId = userId,
                ItemId = itemId,
                ItemName = cbSelect.Text.Trim(),
                Price = decimal.Parse(tbPrice.Text.Trim()),
                Quantity = (int)numericQuantity.Value,
                OrderDate = DateTime.Now,
            };
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
            tbAmount.Text = "0";
        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {
            
                
            //if (numericQuantity.Value > 0)
            //{
            //    decimal price = decimal.Parse(tbPrice.Text.Trim());
            //    decimal quantity = numericQuantity.Value;
            //    decimal total = decimal.Multiply(price, quantity);
            //                    //price * quantity;

            //    tbTotal.Text += total.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Test");
            //}
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ReloadDataGridView()
        {
            var cart = from c in db.Carts
                       join i in db.Items
                       on c.ItemId equals i.ItemId
                       select new
                       {
                           i.ItemName,
                           i.Price,
                           c.Quantity,
                           c.OrderDate
                       };
            dgvCart.DataSource = cart.ToList();
                        
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            //Form4 frm = new Form4(user);
            //frm.ShowDialog();
        }

        private void tbGreeting_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void tbItemId_TextChanged(object sender, EventArgs e)
        {
            string itemName = cbSelect.Text.Trim();
            //var itemId = from c in db.Carts
            //             join i in db.Items
            //             on c.ItemName equals i.ItemName
            //             where i.ItemName.Equals(itemName)
            //             select i.ItemId;

            //var lsit1 = db.Carts.Where(c => c.ItemName == itemName);
            //var lsit2 = db.Items.Where(c => c.ItemName == itemName);
            //lsit1.Join(lsit2,c => c.ItemId == lsit2.)
            //string itemId = db.Carts.Join(db.Items, c => c.ItemId, i => i.ItemId, (i, c) => new { item = i, cart = c }).Where(i => i.ItemName == itemName);
            //tbItemId.Text = itemId.ToString();
        }
    }
}
