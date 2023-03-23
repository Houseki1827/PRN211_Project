using BusinessObject.Models;
using DataAccess;
using Microsoft.IdentityModel.Tokens;

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
            if (txtUser.Text.IsNullOrEmpty()) {
                txtUser.Focus();
                errLogin.SetError(txtUser, "Username must not be blank!");
            }
            else {
                errLogin.SetError(txtUser, "");
                checkUser = true;
            }
            if (txtPass.Text.IsNullOrEmpty()) {
                txtPass.Focus();
                errLogin.SetError(txtPass, "Password must not be blank!");
            }
            else {
                errLogin.SetError(txtPass, "");
                checkPass = true;
            }
            if (context.Users.Where(c => c.Username == txtUser.Text || c.Email == txtUser.Text).Count() == 0) {
                MessageBox.Show("Cannot find user.");
                txtUser.Clear();
                txtPass.Clear();
                ActiveControl = txtUser;
                return;
            }
            else checkLogin = true;
            if (checkUser && checkPass && checkLogin) {
                User user = context.Users.Where(u => u.Username == txtUser.Text.Trim() && u.Password == txtPass.Text.Trim()).FirstOrDefault();
                if (user != null) {
                    if (user.Username == "admin") {
                        Hide();
                        this.ShowInTaskbar = false;
                        Form6 frmAdmin = new Form6();
                        frmAdmin.ShowDialog();
                        return;
                    }
                    Form3 frmShopping = new Form3(user);
                    Hide();
                    this.ShowInTaskbar = false;
                    frmShopping.ShowDialog();
                    return;
                }
                else MessageBox.Show("Username or password incorrect.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Form2 frmCreate = new Form2();
            frmCreate.FormClosed += new FormClosedEventHandler(focus_Close);
            frmCreate.ShowDialog();
            return;
        }

        private void focus_Close(object? sender, EventArgs e) {
            txtUser.Select();
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
            User guest = new User {
                Username = "guest" + random.Next(1000, 9999),
                Password = (random.Next(1000, 9999)* random.Next(10, 99)).ToString(),
                Phone = "0000000000",
                Email = "guest"
            };

            Form3 frmShopping = new Form3(guest);
            Hide();
            this.ShowInTaskbar = false;
            frmShopping.ShowDialog();
        }
    }
}