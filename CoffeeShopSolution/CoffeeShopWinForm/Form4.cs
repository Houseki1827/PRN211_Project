﻿using BusinessObject.Models;
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
using Microsoft.VisualBasic;

namespace CoffeeShopWinForm {
    public partial class Form4 : Form {
        CoffeeShopContext context = new CoffeeShopContext();
        BindingSource source = new BindingSource();
        User u = new User();
        //This form is for 'user cart and purchase'. DO NOT change name until it's design is finalized
        public Form4(User user) {
            InitializeComponent();

            // **** Order ****
            tbOrder.AutoSize = true;
            //tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            fpContainer.HorizontalScroll.Maximum = 0;
            fpContainer.AutoScroll = false;
            //flowLayoutPanel1.VerticalScroll.Visible = false;
            fpContainer.HorizontalScroll.Enabled = false;
            fpContainer.HorizontalScroll.Visible = false;
            fpContainer.AutoScroll = true;
            tbOrder.MaximumSize = new Size(fpContainer.Width - SystemInformation.VerticalScrollBarWidth - 6, Screen.PrimaryScreen.WorkingArea.Height);
            tbOrder.MinimumSize = new Size(fpContainer.Width - SystemInformation.VerticalScrollBarWidth - 15, 0);
            u = user;
            if (context.Orders.Where(o => o.UserId == u.UserId).Count() > 0) {
                var height = tbOrder.Height;
                Fill_OrderTable();
                tbOrder.RowStyles[1].Height = height;

                context.OrderDetails.Load();
                //source.DataSource = context.OrderDetails.Local.ToBindingList();
            }
            else {
                //tbOrder.Controls.Clear();

                Label lbNoOrder = new Label();
                lbNoOrder.Name = "lbNoOrder";
                lbNoOrder.Text = "You have no orders!";
                lbNoOrder.Anchor = AnchorStyles.None;
                lbNoOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
                lbNoOrder.TextAlign = ContentAlignment.MiddleCenter;
                lbNoOrder.Size = new Size(fpContainer.Width - 7, fpContainer.Height - 7);
                fpContainer.Controls.Remove(tbOrder);
                fpContainer.Controls.Add(lbNoOrder);
            }

            // **** Profile ****

            txtPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string phoneNum = txtPhone.Text;
            txtPhone.TextMaskFormat = MaskFormat.IncludeLiterals;
            if (u.Username.Length > 5 && phoneNum.Equals("0000000000") && u.Email.Length == 5) {
                if (u.Username.Substring(0, 5).Equals("guest") && u.Email.Equals("guest")) {
                    txtName.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtPass.ReadOnly = true;
                }
            }

            txtName.Text = u.Username;
            txtEmail.Text = u.Email;
            txtPhone.Text = u.Phone;

            // **** Regster *****
            if (u.Email == "guest" && u.Phone == "0000000000" && u.Username.Length > 5) {
                if (u.Username.Substring(0, 5) == "guest") {
                    btnRegister.Enabled = true;
                    btnRegister.Visible = true;
                }
            }
        }

        private void Fill_OrderTable() {
            tbOrder.Controls.Clear();
            tbOrder.RowCount = 0;

            var userOrders = context.Orders.Where(o => o.UserId == u.UserId);
            if (cbSort.SelectedItem.Equals("ID ↑")) foreach (var item in userOrders.OrderBy(o => o.OrderId)) Fill_Order(item);
            else if (cbSort.SelectedItem.Equals("ID ↓")) foreach (var item in userOrders.OrderByDescending(o => o.OrderId)) Fill_Order(item);
            else if (cbSort.SelectedItem.Equals("Total ↑")) foreach (var item in userOrders.OrderBy(o => o.Total)) Fill_Order(item);
            else if (cbSort.SelectedItem.Equals("Total ↓")) foreach (var item in userOrders.OrderByDescending(o => o.Total)) Fill_Order(item);
            else foreach (var item in userOrders) Fill_Order(item);
        }

        private void Fill_Order(Order item) {
            Label lID = new Label { Anchor = AnchorStyles.None, AutoSize = true };
            Label lPhone = new Label { Anchor = AnchorStyles.Left, AutoSize = true };
            Label lStatus = new Label { Anchor = AnchorStyles.Left, AutoSize = true };
            Label lTotal = new Label { Anchor = AnchorStyles.Left, AutoSize = true };
            Button btView = new Button { Anchor = AnchorStyles.None, AutoSize = false };
            lID.Name = "lbID" + item.OrderId;
            lPhone.Name = "lbPhone" + item.OrderId;
            lStatus.Name = "lbStatus" + item.OrderId; lStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lTotal.Name = "lbTotal" + item.OrderId;
            btView.Name = "btnView_" + item.OrderId; btView.Click += btnView_Click; btView.Text = "View";

            //**** Values ****
            lID.Text = item.OrderId.ToString();
            lPhone.Text = item.Phone;
            lStatus.Text = item.Status;
            lTotal.Text = "$" + item.Total;

            // Status color
            if (lStatus.Text.Equals("Paid")) lStatus.ForeColor = Color.YellowGreen;
            else if (lStatus.Text.Equals("Waiting")) lStatus.ForeColor = Color.DarkViolet;
            else if (lStatus.Text.Equals("Shipping")) lStatus.ForeColor = Color.LightSkyBlue;
            else if (lStatus.Text.Equals("Processing")) lStatus.ForeColor = Color.DarkGray;
            else if (lStatus.Text.Equals("Pick-up")) lStatus.ForeColor = Color.DodgerBlue;
            else if (lStatus.Text.Equals("Cancel")) lStatus.ForeColor = Color.Red;
            else if (lStatus.Text.Equals("Complete")) lStatus.ForeColor = Color.Orchid;

            // Phone number mask
            if (lPhone.Text.Length == 10) {
                var mask = "(" + lPhone.Text.Substring(0, 3) + ") " + lPhone.Text.Substring(3, 3) + "-" + lPhone.Text.Substring(6, 4);
                lPhone.Text = mask;
            }

            tbOrder.RowCount++;
            //tableLayoutPanel1.Height = tableLayoutPanel1.Height + height;
            tbOrder.Controls.Add(lID, 0, tbOrder.RowCount - 1);
            tbOrder.Controls.Add(lPhone, 1, tbOrder.RowCount - 1);
            tbOrder.Controls.Add(lStatus, 2, tbOrder.RowCount - 1);
            tbOrder.Controls.Add(lTotal, 3, tbOrder.RowCount - 1);
            tbOrder.Controls.Add(btView, 4, tbOrder.RowCount - 1);
        }

        private void Form4_Load(object sender, EventArgs e) {
        }

        private void btnView_Click(object sender, EventArgs e) {
            Button b = sender as Button;
            try {
                int OrderId = int.Parse(b.Name.Split('_')[1]);
                //source = context.OrderDetails.Where(x => x.OrderId == OrderId).ToList();
                List<Tuple<string, int, decimal, DateTime>> list = new List<Tuple<string, int, decimal, DateTime>>();
                foreach (var item in context.OrderDetails.Where(x => x.OrderId == OrderId)) {
                    Tuple<string, int, decimal, DateTime> t = new Tuple<string, int, decimal, DateTime>(context.Items.Where(i => i.ItemId == item.ItemId).FirstOrDefault().ItemName, item.Quantity, context.Items.Where(i => i.ItemId == item.ItemId).FirstOrDefault().Price * item.Quantity, item.OrderDate);
                    list.Add(t);
                }
                dgvOrderDetails.DataSource = list;
                dgvOrderDetails.Columns[0].HeaderText = "Item";
                dgvOrderDetails.Columns[1].HeaderText = "Quantity";
                dgvOrderDetails.Columns[2].HeaderText = "Price";
                dgvOrderDetails.Columns[3].HeaderText = "Order date";
                dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                b.Enabled = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            DialogResult re = MessageBox.Show("Log out?", "Confirm", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes) {
                DialogResult = DialogResult.Abort;
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            txtPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string phoneNum = txtPhone.Text;
            txtPhone.TextMaskFormat = MaskFormat.IncludeLiterals;
            //if (txtName.Text.Equals(u.Username) && txtEmail.Text.Equals(u.Email) && txtPhone.Text.Equals(phoneNum)) {
            //}

            if (u.Username.Length > 5 && phoneNum.Equals("0000000000") && u.Email.Length == 5) {
                if (u.Username.Substring(0, 5).Equals("guest") && u.Email.Equals("guest")) {
                    MessageBox.Show("Cannot save guest account.");
                    return;
                }
            }

            if (txtName.Text.Length != 0 || txtEmail.Text.Length != 0 || phoneNum.Length != 0) {
                string newPass = "";
                if (txtPass.Text.Length > 0) {
                    if (txtPass.Text.Equals(txtConfirm.Text)) {
                        newPass = txtPass.Text;
                    }
                    else {
                        if (txtConfirm.Text.Length == 0) MessageBox.Show("Please verify new password.");
                        else MessageBox.Show("Password do not match.");
                    }
                }
                if (newPass.Length > 0) {
                    string result = Interaction.InputBox("Enter old password to save changes:\n", "Enter password", "");
                    if (result.Equals(u.Password)) {
                        u.Username = txtName.Text;
                        u.Password = txtPass.Text;
                        u.Email = txtEmail.Text;
                        u.Phone = phoneNum;
                        context.Users.Update(u);
                        context.SaveChanges();
                        MessageBox.Show("User information updated.");
                    }
                    else {
                        MessageBox.Show("Password incorrect.");
                    }
                }
                else {
                    string result = Interaction.InputBox("Enter password to save changes:\n", "Enter password", "");
                    if (result.Equals(u.Password)) {
                        u.Username = txtName.Text;
                        u.Email = txtEmail.Text;
                        u.Phone = phoneNum;
                        context.Users.Update(u);
                        context.SaveChanges();
                        MessageBox.Show("User information updated.");
                    }
                    else {
                        MessageBox.Show("Password incorrect.");
                    }
                }
            }
            else {
                if (txtName.Text.Length == 0) { MessageBox.Show("Username cannot be empty."); txtName.Focus(); }
                else if (txtEmail.Text.Length == 0) { MessageBox.Show("E-mail cannot be empty."); txtEmail.Focus(); }
                else if (phoneNum.Length == 0) { MessageBox.Show("Phone number cannot be empty."); txtPhone.Focus(); }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            txtPass.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtEmail.Text = u.Email;
            txtPhone.Text = u.Phone;
            txtName.Text = u.Username;
        }

        private void txtPass_TextChanged(object sender, EventArgs e) {
            if (txtPass.Text.Length == 0) {
                txtConfirm.Enabled = false;
            }
            else { txtConfirm.Text = ""; txtConfirm.Enabled = true; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            Fill_OrderTable();
        }

        private void btnView_Click_1(object sender, EventArgs e) {
            MessageBox.Show("Test");
        }

        private void button1_Click(object sender, EventArgs e) {
            Form2 frmRegister = new Form2();
            frmRegister.ShowDialog();
            if (frmRegister.DialogResult == DialogResult.OK && frmRegister.id != 0) {
                foreach (var item in context.Orders.Where(c => c.UserId == u.UserId)) {
                    item.UserId = frmRegister.id;
                    context.Orders.Update(item);
                }
                context.SaveChanges();
                MessageBox.Show("Please re-login to your new account.");
                btnLogout_Click(sender, new EventArgs());
            }
        }

        private void Form4_Load_1(object sender, EventArgs e) {

        }
    }
}
