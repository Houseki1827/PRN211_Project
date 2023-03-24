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
            lbLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbLogin.Location = new Point(185, 36);
            lbLogin.Margin = new Padding(4, 0, 4, 0);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(89, 37);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbUser.Location = new Point(35, 112);
            lbUser.Margin = new Padding(4, 0, 4, 0);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(83, 17);
            lbUser.TabIndex = 1;
            lbUser.Text = "Username";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbPass.Location = new Point(35, 177);
            lbPass.Margin = new Padding(4, 0, 4, 0);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(80, 17);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(142, 108);
            txtUser.Margin = new Padding(4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(261, 24);
            txtUser.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(250, 247);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(69, 247);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(119, 40);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(142, 173);
            txtPass.Margin = new Padding(4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(261, 24);
            txtPass.TabIndex = 2;
            // 
            // errLogin
            // 
            errLogin.ContainerControl = this;
            // 
            // btnGuest
            // 
            btnGuest.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuest.Location = new Point(69, 297);
            btnGuest.Margin = new Padding(4);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(300, 43);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Login as Guest";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // Form1
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            CausesValidation = false;
            ClientSize = new Size(441, 380);
            Controls.Add(btnGuest);
            Controls.Add(txtPass);
            Controls.Add(btnCreate);
            Controls.Add(btnLogin);
            Controls.Add(txtUser);
            Controls.Add(lbPass);
            Controls.Add(lbUser);
            Controls.Add(lbLogin);
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
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