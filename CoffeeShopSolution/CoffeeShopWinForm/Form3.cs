using BusinessObject.Models;
using DataAccess.Repositories.Inteface;
using DataAccess.Repositories.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeShopWinForm {
    public partial class Form3 : Form {
        IItemRepository repoItem = new ItemRepository();

        private CoffeeShopContext db = new CoffeeShopContext();
        User u = new User();
        public Form3(User user) {
            InitializeComponent();
            u = user;
        }

        private void Form3_Load(object sender, EventArgs e) {

        }
        private void rbCoffee_CheckedChanged(object sender, EventArgs e) {
            //cbSelect.Items.Clear();
            var id = 1;
            var coffee = from item in db.Items
                         join category in db.Categories
                         on item.CategoryId equals category.CategoryId
                         where item.CategoryId == id
                         select item.ItemName;
            cbSelect.DataSource = coffee.ToList();
        }

        private void rbDessert_CheckedChanged(object sender, EventArgs e) {
            //cbSelect.Items.Clear();
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

            Decimal price = db.Items.Where(x => x.ItemName == name).Select(x => x.Price).FirstOrDefault();
            tbPrice.Text = price.ToString();
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e) {
            if (numericQuantity.Value > 120) {
                MessageBox.Show("Quantity must be less than 120");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            //var cart = from c in db.Carts
            //           join item in db.Items
            //           on c.ItemId equals item.ItemId
            //           join user in db.Users
            //           on c.UserId equals user.UserId
            //           select new {item.ItemName, item.Price, c.Quantity, c.OrderDate};

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



            //dgvCart.Rows.Add(cbSelect.Text, tbPrice.Text, numericQuantity.Value.ToString(), tbTotal.Text, DateTime.Now);
            //decimal amount = decimal.Parse(tbAmount.Text) + decimal.Parse(tbPrice.Text);
            //tbAmount.Text = amount.ToString(); 

        }

        private void btnDelete_Click(object sender, EventArgs e) {
            //if(dgvCart.SelectedRows.Count > 0)
            //{
            //    for(int i = 0; i < dgvCart.SelectedRows.Count; i++)
            //    {
            //        if (dgvCart.Rows[i].Selected)
            //        {
            //            tbAmount.Text = (decimal.Parse(tbAmount.Text) - decimal.Parse(dgvCart.Rows[i].Cells[3].Value)).ToString();
            //            dgvCart.Rows.RemoveAt(i);
            //        }
            //    }
            //}
        }

        private void btnLoad_Click(object sender, EventArgs e) {

        }

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void btnClear_Click(object sender, EventArgs e) {

        }

        private void tbTotal_TextChanged(object sender, EventArgs e) {
            decimal price = decimal.Parse(tbPrice.Text);
            decimal quantity = numericQuantity.Value;
            decimal total = price * quantity;
            //Decimal.Multiply(price, quantity);
            if (numericQuantity.Value > 0) {
                tbTotal.Text += total.ToString();
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void ReloadDataGridView() {
            var cart = from c in db.Carts
                       join i in db.Items
                       on c.ItemId equals i.ItemId
                       select new {
                           i.ItemName,
                           i.Price,
                           c.Quantity,
                           c.OrderDate
                       };
            dgvCart.DataSource = cart.ToList();

        }
    }
}
