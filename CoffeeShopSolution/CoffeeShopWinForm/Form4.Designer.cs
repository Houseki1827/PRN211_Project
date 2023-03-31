using System.Windows.Forms;

namespace CoffeeShopWinForm {
    partial class Form4 {
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pHeader = new Panel();
            lbTitle = new Label();
            tbHeader = new TableLayoutPanel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cbSort = new ComboBox();
            fpContainer = new FlowLayoutPanel();
            tbOrder = new TableLayoutPanel();
            lbTotal = new Label();
            lbPhone = new Label();
            btnView = new Button();
            lbID = new Label();
            lbStatus = new Label();
            dgvOrderDetails = new DataGridView();
            tabPage2 = new TabPage();
            btnRegister = new Button();
            lbTitle_2 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtPhone = new MaskedTextBox();
            txtEmail = new TextBox();
            txtConfirm = new TextBox();
            txtPass = new TextBox();
            txtName = new TextBox();
            lbPhone_Pf = new Label();
            lbEmail = new Label();
            lbCPass = new Label();
            lbPass = new Label();
            lbName = new Label();
            btnLogout = new Button();
            label5 = new Label();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            pHeader.SuspendLayout();
            tbHeader.SuspendLayout();
            fpContainer.SuspendLayout();
            tbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(636, 661);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pHeader);
            tabPage1.Controls.Add(fpContainer);
            tabPage1.Controls.Add(dgvOrderDetails);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(628, 632);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Order history";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pHeader
            // 
            pHeader.Controls.Add(lbTitle);
            pHeader.Controls.Add(tbHeader);
            pHeader.Controls.Add(cbSort);
            pHeader.Dock = DockStyle.Top;
            pHeader.Location = new Point(4, 4);
            pHeader.Margin = new Padding(4);
            pHeader.Name = "pHeader";
            pHeader.Size = new Size(620, 141);
            pHeader.TabIndex = 4;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(185, 25);
            lbTitle.Margin = new Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(194, 37);
            lbTitle.TabIndex = 3;
            lbTitle.Text = "Order History";
            // 
            // tbHeader
            // 
            tbHeader.ColumnCount = 5;
            tbHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.88546F));
            tbHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.11454F));
            tbHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 122F));
            tbHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 164F));
            tbHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 106F));
            tbHeader.Controls.Add(label7, 3, 0);
            tbHeader.Controls.Add(label8, 0, 0);
            tbHeader.Controls.Add(label9, 2, 0);
            tbHeader.Controls.Add(label10, 1, 0);
            tbHeader.Dock = DockStyle.Bottom;
            tbHeader.Location = new Point(0, 97);
            tbHeader.Margin = new Padding(4);
            tbHeader.Name = "tbHeader";
            tbHeader.RowCount = 1;
            tbHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbHeader.Size = new Size(620, 44);
            tbHeader.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(410, 14);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 16);
            label7.TabIndex = 3;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(12, 14);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(61, 16);
            label8.TabIndex = 0;
            label8.Text = "OrderID";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(263, 14);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(50, 16);
            label9.TabIndex = 2;
            label9.Text = "Status";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(132, 14);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(48, 16);
            label10.TabIndex = 1;
            label10.Text = "Phone";
            // 
            // cbSort
            // 
            cbSort.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSort.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "(none)", "ID ↑", "ID ↓", "Total ↑", "Total ↓" });
            cbSort.Location = new Point(485, 61);
            cbSort.Margin = new Padding(4);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(135, 24);
            cbSort.TabIndex = 2;
            cbSort.Text = "(none)";
            cbSort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // fpContainer
            // 
            fpContainer.AutoScroll = true;
            fpContainer.Controls.Add(tbOrder);
            fpContainer.Dock = DockStyle.Bottom;
            fpContainer.Location = new Point(4, 154);
            fpContainer.Margin = new Padding(4, 4, 23, 4);
            fpContainer.Name = "fpContainer";
            fpContainer.Padding = new Padding(0, 0, 15, 0);
            fpContainer.Size = new Size(620, 231);
            fpContainer.TabIndex = 1;
            fpContainer.WrapContents = false;
            // 
            // tbOrder
            // 
            tbOrder.ColumnCount = 5;
            tbOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.35408F));
            tbOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.64592F));
            tbOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 133F));
            tbOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 127F));
            tbOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tbOrder.Controls.Add(lbTotal, 3, 0);
            tbOrder.Controls.Add(lbPhone, 1, 0);
            tbOrder.Controls.Add(btnView, 4, 0);
            tbOrder.Controls.Add(lbID, 0, 0);
            tbOrder.Controls.Add(lbStatus, 2, 0);
            tbOrder.Dock = DockStyle.Top;
            tbOrder.Location = new Point(4, 4);
            tbOrder.Margin = new Padding(4);
            tbOrder.Name = "tbOrder";
            tbOrder.RowCount = 1;
            tbOrder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbOrder.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tbOrder.Size = new Size(611, 49);
            tbOrder.TabIndex = 1;
            // 
            // lbTotal
            // 
            lbTotal.Anchor = AnchorStyles.Left;
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(392, 16);
            lbTotal.Margin = new Padding(4, 0, 4, 0);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(51, 16);
            lbTotal.TabIndex = 3;
            lbTotal.Text = "$33.00";
            // 
            // lbPhone
            // 
            lbPhone.Anchor = AnchorStyles.Left;
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(99, 16);
            lbPhone.Margin = new Padding(4, 0, 4, 0);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(97, 16);
            lbPhone.TabIndex = 1;
            lbPhone.Text = "0123-456-789";
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.Left;
            btnView.Location = new Point(519, 4);
            btnView.Margin = new Padding(4);
            btnView.Name = "btnView";
            btnView.Size = new Size(88, 41);
            btnView.TabIndex = 4;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            lbID.Anchor = AnchorStyles.None;
            lbID.AutoSize = true;
            lbID.Location = new Point(40, 16);
            lbID.Margin = new Padding(4, 0, 4, 0);
            lbID.Name = "lbID";
            lbID.Size = new Size(15, 16);
            lbID.TabIndex = 0;
            lbID.Text = "1";
            // 
            // lbStatus
            // 
            lbStatus.Anchor = AnchorStyles.Left;
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbStatus.ForeColor = Color.Firebrick;
            lbStatus.Location = new Point(259, 14);
            lbStatus.Margin = new Padding(4, 0, 4, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 20);
            lbStatus.TabIndex = 2;
            lbStatus.Text = "Paid";
            lbStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Dock = DockStyle.Bottom;
            dgvOrderDetails.Location = new Point(4, 385);
            dgvOrderDetails.Margin = new Padding(4);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 25;
            dgvOrderDetails.Size = new Size(620, 243);
            dgvOrderDetails.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRegister);
            tabPage2.Controls.Add(lbTitle_2);
            tabPage2.Controls.Add(btnCancel);
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(txtPhone);
            tabPage2.Controls.Add(txtEmail);
            tabPage2.Controls.Add(txtConfirm);
            tabPage2.Controls.Add(txtPass);
            tabPage2.Controls.Add(txtName);
            tabPage2.Controls.Add(lbPhone_Pf);
            tabPage2.Controls.Add(lbEmail);
            tabPage2.Controls.Add(lbCPass);
            tabPage2.Controls.Add(lbPass);
            tabPage2.Controls.Add(lbName);
            tabPage2.Controls.Add(btnLogout);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(15, 13, 15, 13);
            tabPage2.Size = new Size(628, 632);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Profile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.Dock = DockStyle.Bottom;
            btnRegister.Enabled = false;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.Crimson;
            btnRegister.Location = new Point(15, 505);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(598, 57);
            btnRegister.TabIndex = 99;
            btnRegister.Text = "Register Account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Visible = false;
            btnRegister.Click += button1_Click;
            // 
            // lbTitle_2
            // 
            lbTitle_2.Anchor = AnchorStyles.Top;
            lbTitle_2.AutoSize = true;
            lbTitle_2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle_2.Location = new Point(241, 38);
            lbTitle_2.Margin = new Padding(4, 0, 4, 0);
            lbTitle_2.Name = "lbTitle_2";
            lbTitle_2.Size = new Size(112, 41);
            lbTitle_2.TabIndex = 13;
            lbTitle_2.Text = "Profile";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(131, 416);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(379, 416);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(272, 332);
            txtPhone.Margin = new Padding(4);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(288, 24);
            txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(272, 281);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 24);
            txtEmail.TabIndex = 3;
            // 
            // txtConfirm
            // 
            txtConfirm.Enabled = false;
            txtConfirm.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirm.Location = new Point(272, 232);
            txtConfirm.Margin = new Padding(4);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.PlaceholderText = "**********";
            txtConfirm.Size = new Size(288, 24);
            txtConfirm.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(272, 183);
            txtPass.Margin = new Padding(4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "**********";
            txtPass.Size = new Size(288, 24);
            txtPass.TabIndex = 1;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(272, 136);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(288, 24);
            txtName.TabIndex = 0;
            // 
            // lbPhone_Pf
            // 
            lbPhone_Pf.AutoSize = true;
            lbPhone_Pf.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbPhone_Pf.Location = new Point(68, 335);
            lbPhone_Pf.Margin = new Padding(4, 0, 4, 0);
            lbPhone_Pf.Name = "lbPhone_Pf";
            lbPhone_Pf.Size = new Size(59, 17);
            lbPhone_Pf.TabIndex = 5;
            lbPhone_Pf.Text = "Phone:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(68, 284);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(58, 17);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "E-mail:";
            // 
            // lbCPass
            // 
            lbCPass.AutoSize = true;
            lbCPass.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbCPass.Location = new Point(68, 233);
            lbCPass.Margin = new Padding(4, 0, 4, 0);
            lbCPass.Name = "lbCPass";
            lbCPass.Size = new Size(146, 17);
            lbCPass.TabIndex = 3;
            lbCPass.Text = "Confirm password:";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbPass.Location = new Point(68, 184);
            lbPass.Margin = new Padding(4, 0, 4, 0);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(85, 17);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbName.Location = new Point(68, 136);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(88, 17);
            lbName.TabIndex = 1;
            lbName.Text = "Username:";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(15, 562);
            btnLogout.Margin = new Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(598, 57);
            btnLogout.TabIndex = 99;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(110, 40);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 3;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 42);
            label6.Name = "label6";
            label6.Size = new Size(1, 15);
            label6.TabIndex = 0;
            label6.Text = "OrderID";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 661);
            Controls.Add(tabControl1);
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pHeader.ResumeLayout(false);
            pHeader.PerformLayout();
            tbHeader.ResumeLayout(false);
            tbHeader.PerformLayout();
            fpContainer.ResumeLayout(false);
            tbOrder.ResumeLayout(false);
            tbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvOrderDetails;
        private TabPage tabPage2;
        private ComboBox cbSort;
        private FlowLayoutPanel fpContainer;
        private TableLayoutPanel tbHeader;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label5;
        private Label label6;
        private Label lbTitle_2;
        private Button btnCancel;
        private Button btnSave;
        private MaskedTextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtConfirm;
        private TextBox txtPass;
        private TextBox txtName;
        private Label lbPhone_Pf;
        private Label lbEmail;
        private Label lbCPass;
        private Label lbPass;
        private Label lbName;
        private Button btnLogout;
        private TableLayoutPanel tbOrder;
        private Label lbTotal;
        private Label lbID;
        private Label lbPhone;
        private Button btnView;
        private Label lbStatus;
        private Label lbTitle;
        private Panel pHeader;
        private Button btnRegister;
    }
}