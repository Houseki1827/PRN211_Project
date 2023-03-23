namespace CoffeeShopWinForm {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            lbLogin = new Label();
            lbUser = new Label();
            lbPass = new Label();
            txtUser = new TextBox();
            btnLogin = new Button();
            btnCreate = new Button();
            txtPass = new TextBox();
            errLogin = new ErrorProvider(components);
            btnGuest = new Button();
            ((System.ComponentModel.ISupportInitialize)errLogin).BeginInit();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbLogin.Location = new Point(141, 26);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(84, 37);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(23, 84);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(60, 15);
            lbUser.TabIndex = 1;
            lbUser.Text = "Username";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(23, 133);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(57, 15);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(90, 81);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(228, 23);
            txtUser.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(223, 185);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(56, 185);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(90, 130);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(228, 23);
            txtPass.TabIndex = 2;
            // 
            // errLogin
            // 
            errLogin.ContainerControl = this;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(56, 223);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(242, 32);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Login as Guest";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // Form1
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            CausesValidation = false;
            ClientSize = new Size(351, 267);
            Controls.Add(btnGuest);
            Controls.Add(txtPass);
            Controls.Add(btnCreate);
            Controls.Add(btnLogin);
            Controls.Add(txtUser);
            Controls.Add(lbPass);
            Controls.Add(lbUser);
            Controls.Add(lbLogin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Label lbUser;
        private Label lbPass;
        private TextBox txtUser;
        private Button btnLogin;
        private Button btnCreate;
        private TextBox txtPass;
        private ErrorProvider errLogin;
        private Button btnGuest;
    }
}