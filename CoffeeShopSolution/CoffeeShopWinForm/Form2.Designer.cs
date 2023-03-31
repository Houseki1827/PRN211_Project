namespace CoffeeShopWinForm {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lbName = new Label();
            lbPwd = new Label();
            lbPwdCfm = new Label();
            lbEmail = new Label();
            txtName = new TextBox();
            txtPwdCfm = new TextBox();
            txtPwd = new TextBox();
            txtEmail = new TextBox();
            lbTitle = new Label();
            btnCreate = new Button();
            lbPhone = new Label();
            txtPhone = new MaskedTextBox();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(43, 97);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(84, 18);
            lbName.TabIndex = 10;
            lbName.Text = "Username:";
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbPwd.Location = new Point(43, 145);
            lbPwd.Margin = new Padding(4, 0, 4, 0);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(85, 17);
            lbPwd.TabIndex = 9;
            lbPwd.Text = "Password:";
            // 
            // lbPwdCfm
            // 
            lbPwdCfm.AutoSize = true;
            lbPwdCfm.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbPwdCfm.Location = new Point(43, 195);
            lbPwdCfm.Margin = new Padding(4, 0, 4, 0);
            lbPwdCfm.Name = "lbPwdCfm";
            lbPwdCfm.Size = new Size(147, 17);
            lbPwdCfm.TabIndex = 6;
            lbPwdCfm.Text = "Confirm Password:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(43, 241);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(58, 17);
            lbEmail.TabIndex = 8;
            lbEmail.Text = "E-mail:";
            // 
            // txtName
            // 
            txtName.Location = new Point(230, 94);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 24);
            txtName.TabIndex = 0;
            // 
            // txtPwdCfm
            // 
            txtPwdCfm.Location = new Point(230, 192);
            txtPwdCfm.Margin = new Padding(4);
            txtPwdCfm.Name = "txtPwdCfm";
            txtPwdCfm.PasswordChar = '*';
            txtPwdCfm.Size = new Size(239, 24);
            txtPwdCfm.TabIndex = 2;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(230, 142);
            txtPwd.Margin = new Padding(4);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(239, 24);
            txtPwd.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(230, 238);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 24);
            txtEmail.TabIndex = 3;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(153, 23);
            lbTitle.Margin = new Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(162, 37);
            lbTitle.TabIndex = 8;
            lbTitle.Text = "Create user";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(187, 350);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(119, 40);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbPhone.Location = new Point(43, 286);
            lbPhone.Margin = new Padding(4, 0, 4, 0);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(59, 17);
            lbPhone.TabIndex = 11;
            lbPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(230, 283);
            txtPhone.Margin = new Padding(4);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(239, 24);
            txtPhone.TabIndex = 4;
            // 
            // Form2
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 426);
            Controls.Add(txtPhone);
            Controls.Add(lbPhone);
            Controls.Add(btnCreate);
            Controls.Add(lbTitle);
            Controls.Add(txtEmail);
            Controls.Add(txtPwd);
            Controls.Add(txtPwdCfm);
            Controls.Add(txtName);
            Controls.Add(lbEmail);
            Controls.Add(lbPwdCfm);
            Controls.Add(lbPwd);
            Controls.Add(lbName);
            Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbPwd;
        private Label lbPwdCfm;
        private Label lbEmail;
        private TextBox txtName;
        private TextBox txtPwdCfm;
        private TextBox txtPwd;
        private TextBox txtEmail;
        private Label lbTitle;
        private Button btnCreate;
        private Label lbPhone;
        private MaskedTextBox txtPhone;
    }
}