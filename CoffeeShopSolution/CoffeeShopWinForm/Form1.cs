using BusinessObject.Models;
using DataAccess;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;

namespace CoffeeShopWinForm {
    public partial class Form1 : Form {
        //This form is for 'initial login'. DO NOT change name until it's design is finalized
        CoffeeShopContext context = new CoffeeShopContext();

        public Form1() {
            InitializeComponent();
            txtUser.Focus();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            bool checkUser = false, checkPass = false, checkLogin = false;
            if (txtUser.Text.Length == 0) {
                txtUser.Focus();
                errLogin.SetError(txtUser, "Username must not be blank!");
                MessageBox.Show("Please enter username.");
                return;
            }
            else {
                errLogin.SetError(txtUser, "");
                checkUser = true;
            }
            if (txtPass.Text.Length == 0) {
                txtPass.Focus();
                errLogin.SetError(txtPass, "Password must not be blank!");
                MessageBox.Show("Please enter password.");
                return;
            }
            else {
                errLogin.SetError(txtPass, "");
                checkPass = true;
            }
            if (txtUser.Text == context.admin.Username && txtPass.Text == context.admin.Password) {
                this.ShowInTaskbar = false;
                Form6 frmAdmin = new Form6();
                txtUser.Clear();
                txtPass.Clear();
                frmAdmin.ShowDialog();
                return;
            }
            if (context.Users.Where(c => c.Username == txtUser.Text || c.Email == txtUser.Text).Count() == 0) {
                MessageBox.Show("Cannot find user.");
                txtUser.Clear();
                ActiveControl = txtUser;
                return;
            }
            else checkLogin = true;
            if (checkUser && checkPass && checkLogin) {
                BusinessObject.Models.User user = context.Users.Where(u => u.Username == txtUser.Text.Trim() && u.Password == txtPass.Text.Trim()).FirstOrDefault();
                if (user != null) {
                    Form3 frmMenu = new Form3(user);
                    frmMenu.FormClosed += new FormClosedEventHandler(MenuClosed);
                    Hide();
                    this.ShowInTaskbar = false;
                    frmMenu.ShowDialog();
                    return;
                }
                else MessageBox.Show("Username or password incorrect.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Form2 frmCreate = new Form2();
            txtUser.Clear();
            txtPass.Clear();
            Focus();
            txtUser.Select();
            frmCreate.ShowDialog();
            txtUser.Focus();
            return;
        }

        private void txtUser_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (txtUser.Text.IsNullOrEmpty()) {
                e.Cancel = true;
                txtUser.Focus();
                errLogin.SetError(txtUser, "Username must not be blank!");
            }
            else {
                errLogin.SetError(txtUser, "");
            }
        }

        private void txtPass_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (txtPass.Text.IsNullOrEmpty()) {

                errLogin.SetError(txtPass, "Password must not be blank!");
            }
            else {
                errLogin.SetError(txtPass, "");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
        }

        private void btnGuest_Click(object sender, EventArgs e) {
            Random random = new Random();
            string guestName;
            do {
                guestName = "guest" + random.Next(1000, 9999);
            }
            while (context.Users.Where(c => c.Username == guestName).Count() > 0);
            BusinessObject.Models.User guest = new BusinessObject.Models.User
            {
                Username = guestName,
                Password = (random.Next(1000, 9999)* random.Next(10, 99)).ToString(),
                Phone = "0000000000",
                Email = "guest"
            };

            context.Users.Add(guest);
            context.SaveChanges();

            Form3 frmMenu = new Form3(guest);
            frmMenu.FormClosed += new FormClosedEventHandler(MenuClosed);
            Hide();
            this.ShowInTaskbar = false;
            frmMenu.ShowDialog();
        }

        private void MenuClosed(object? sender, FormClosedEventArgs e) {
            var frm = sender as Form3;   
            if(frm.DialogResult == DialogResult.Abort) {
                txtUser.Clear();
                txtPass.Clear();
                Focus();
                txtUser.Select();
                Show();
            }
            else {
                Application.Exit();
            }
        }
    }
}