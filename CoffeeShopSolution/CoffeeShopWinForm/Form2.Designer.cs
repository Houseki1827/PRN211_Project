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
            this.lbName = new System.Windows.Forms.Label();
            this.lbPwd = new System.Windows.Forms.Label();
            this.lbPwdCfm = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwdCfm = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(43, 97);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(111, 22);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Username:";
            // 
            // lbPwd
            // 
            this.lbPwd.AutoSize = true;
            this.lbPwd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPwd.Location = new System.Drawing.Point(43, 145);
            this.lbPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPwd.Name = "lbPwd";
            this.lbPwd.Size = new System.Drawing.Size(106, 22);
            this.lbPwd.TabIndex = 9;
            this.lbPwd.Text = "Password:";
            // 
            // lbPwdCfm
            // 
            this.lbPwdCfm.AutoSize = true;
            this.lbPwdCfm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPwdCfm.Location = new System.Drawing.Point(43, 195);
            this.lbPwdCfm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPwdCfm.Name = "lbPwdCfm";
            this.lbPwdCfm.Size = new System.Drawing.Size(183, 22);
            this.lbPwdCfm.TabIndex = 6;
            this.lbPwdCfm.Text = "Confirm Password:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(43, 241);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(73, 22);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "E-mail:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(230, 94);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 28);
            this.txtName.TabIndex = 0;
            // 
            // txtPwdCfm
            // 
            this.txtPwdCfm.Location = new System.Drawing.Point(230, 192);
            this.txtPwdCfm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwdCfm.Name = "txtPwdCfm";
            this.txtPwdCfm.PasswordChar = '*';
            this.txtPwdCfm.Size = new System.Drawing.Size(239, 28);
            this.txtPwdCfm.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(230, 142);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(239, 28);
            this.txtPwd.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(230, 238);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 28);
            this.txtEmail.TabIndex = 3;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(153, 23);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(199, 46);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Create user";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(187, 350);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(119, 40);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhone.Location = new System.Drawing.Point(43, 286);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(73, 22);
            this.lbPhone.TabIndex = 11;
            this.lbPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(230, 283);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(239, 28);
            this.txtPhone.TabIndex = 12;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 426);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtPwdCfm);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPwdCfm);
            this.Controls.Add(this.lbPwd);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

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