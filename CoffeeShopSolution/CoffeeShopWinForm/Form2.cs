using BusinessObject.Models;
using DataAccess;
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

namespace CoffeeShopWinForm {
    public partial class Form2 : Form {
        UserRepository repository = new UserRepository();
        public int id { get; set; } = 0;
        //This form is for 'creating user account'. DO NOT change name until it's design is finalized
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            bool check = false;
            string phoneNum = "";
            try {
                checkEmpty();
                matchPasswordAndName();
                checkExists();
                check = true;
                txtPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                phoneNum = txtPhone.Text;
                txtPhone.TextMaskFormat = MaskFormat.IncludeLiterals;
                int.Parse(phoneNum);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            if (check) {
                User u = new User {
                    Username = txtName.Text,
                    Password = txtPwd.Text,
                    Email = txtEmail.Text,
                    Phone = phoneNum
                };
                repository.AddUser(u);

                DialogResult = DialogResult.OK;
                id = repository.GetUserByLogin(u.Username, u.Password).UserId;
                MessageBox.Show("User created.");
                this.Close();
            }
        }

        private void checkEmpty() {
            bool check = false;
            string phone = "";
            txtPhone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            phone = txtPhone.Text;
            txtPhone.TextMaskFormat = MaskFormat.IncludeLiterals;
            if (txtName.Text.Length == 0) { check = true; }
            if (txtPwd.Text.Length == 0) { check = true; }
            if (txtEmail.Text.Length == 0) { check = true; }
            if (txtPwdCfm.Text.Length == 0) { check = true; }
            if (phone.Length != 10) { check = true; }
            if (check) throw new Exception("Field(s) must not be empty!");
        }

        private void matchPasswordAndName() {
            if (txtPwd.Text != txtPwdCfm.Text) throw new Exception("Password do not match.");
            if (txtName.Text.Length < 6 || txtName.Text.Length > 40) throw new Exception("Username must be between 6 and 40 characters.");
            if (txtPwd.Text.Length < 6 || txtPwd.Text.Length > 40) throw new Exception("Password must be between 6 and 40 characters.");
            if (txtName.Text.Contains("guest")) throw new Exception("Username cannot contain \"guest\"");
        }

        private void checkExists() {
            if (repository.GetUsers().Where(c => c.Username == txtName.Text).Count() != 0) throw new Exception("Username already used.");
            if (repository.GetUsers().Where(c => c.Email == txtEmail.Text).Count() != 0) throw new Exception("Email already used.");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void Form2_Load_1(object sender, EventArgs e) {

        }
    }
}
