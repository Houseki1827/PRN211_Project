namespace CoffeeShopWinForm {
    partial class Form6 {
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
            tpItemAndCat = new TabPage();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            btnItemClear = new Button();
            txtItemId = new TextBox();
            cbItemCat = new ComboBox();
            lbItemCat = new Label();
            txtItemPrice = new TextBox();
            txtItemName = new TextBox();
            btnDeleteItem = new Button();
            btnAddItem = new Button();
            btnSaveItem = new Button();
            btnPic = new Button();
            lbItemPrice = new Label();
            lbItemName = new Label();
            picPreview = new PictureBox();
            tpCategory = new TabPage();
            btnClearCat = new Button();
            txtCatId = new TextBox();
            lbCatId = new Label();
            btnDeleteCat = new Button();
            btnSaveCat = new Button();
            btnAddCat = new Button();
            txtCatName = new TextBox();
            lbCatName = new Label();
            gbItem = new GroupBox();
            dgvItem = new DataGridView();
            gbCategory = new GroupBox();
            dgvCategory = new DataGridView();
            tpUser = new TabPage();
            gbOrder = new GroupBox();
            dgvOrder = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            btnClearUser = new Button();
            txtUserId = new TextBox();
            lbUserId = new Label();
            btnDeleteUser = new Button();
            txtUserPhone = new MaskedTextBox();
            txtUserMail = new TextBox();
            txtUserPass = new TextBox();
            txtUserName = new TextBox();
            btnSaveUser = new Button();
            lbUserPhone = new Label();
            lbUserEmail = new Label();
            lbUserPass = new Label();
            lbUserName = new Label();
            gbUser = new GroupBox();
            dgvUserList = new DataGridView();
            tabControl1.SuspendLayout();
            tpItemAndCat.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            tpCategory.SuspendLayout();
            gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItem).BeginInit();
            gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            tpUser.SuspendLayout();
            gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpItemAndCat);
            tabControl1.Controls.Add(tpUser);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(636, 430);
            tabControl1.TabIndex = 0;
            // 
            // tpItemAndCat
            // 
            tpItemAndCat.Controls.Add(tabControl2);
            tpItemAndCat.Controls.Add(gbItem);
            tpItemAndCat.Controls.Add(gbCategory);
            tpItemAndCat.Location = new Point(4, 24);
            tpItemAndCat.Name = "tpItemAndCat";
            tpItemAndCat.Padding = new Padding(3);
            tpItemAndCat.Size = new Size(628, 402);
            tpItemAndCat.TabIndex = 0;
            tpItemAndCat.Text = "Items";
            tpItemAndCat.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tpCategory);
            tabControl2.Dock = DockStyle.Left;
            tabControl2.Location = new Point(3, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(277, 396);
            tabControl2.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnItemClear);
            tabPage1.Controls.Add(txtItemId);
            tabPage1.Controls.Add(cbItemCat);
            tabPage1.Controls.Add(lbItemCat);
            tabPage1.Controls.Add(txtItemPrice);
            tabPage1.Controls.Add(txtItemName);
            tabPage1.Controls.Add(btnDeleteItem);
            tabPage1.Controls.Add(btnAddItem);
            tabPage1.Controls.Add(btnSaveItem);
            tabPage1.Controls.Add(btnPic);
            tabPage1.Controls.Add(lbItemPrice);
            tabPage1.Controls.Add(lbItemName);
            tabPage1.Controls.Add(picPreview);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(269, 368);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnItemClear
            // 
            btnItemClear.Location = new Point(21, 136);
            btnItemClear.Name = "btnItemClear";
            btnItemClear.Size = new Size(47, 30);
            btnItemClear.TabIndex = 10;
            btnItemClear.Text = "Clear";
            btnItemClear.UseVisualStyleBackColor = true;
            btnItemClear.Click += btnClearItem_Click;
            // 
            // txtItemId
            // 
            txtItemId.Location = new Point(21, 105);
            txtItemId.Name = "txtItemId";
            txtItemId.ReadOnly = true;
            txtItemId.Size = new Size(47, 23);
            txtItemId.TabIndex = 9;
            // 
            // cbItemCat
            // 
            cbItemCat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbItemCat.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbItemCat.FormattingEnabled = true;
            cbItemCat.Location = new Point(95, 253);
            cbItemCat.Name = "cbItemCat";
            cbItemCat.Size = new Size(145, 23);
            cbItemCat.TabIndex = 8;
            // 
            // lbItemCat
            // 
            lbItemCat.AutoSize = true;
            lbItemCat.Location = new Point(21, 256);
            lbItemCat.Name = "lbItemCat";
            lbItemCat.Size = new Size(58, 15);
            lbItemCat.TabIndex = 7;
            lbItemCat.Text = "Category:";
            // 
            // txtItemPrice
            // 
            txtItemPrice.Location = new Point(95, 218);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(145, 23);
            txtItemPrice.TabIndex = 2;
            txtItemPrice.Text = "0";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(95, 179);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(145, 23);
            txtItemName.TabIndex = 1;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(16, 327);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(237, 35);
            btnDeleteItem.TabIndex = 5;
            btnDeleteItem.Text = "Delete";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(147, 289);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnSaveItem
            // 
            btnSaveItem.Location = new Point(45, 289);
            btnSaveItem.Name = "btnSaveItem";
            btnSaveItem.Size = new Size(75, 23);
            btnSaveItem.TabIndex = 4;
            btnSaveItem.Text = "Save";
            btnSaveItem.UseVisualStyleBackColor = true;
            btnSaveItem.Click += btnSaveItem_Click;
            // 
            // btnPic
            // 
            btnPic.Location = new Point(81, 134);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(141, 30);
            btnPic.TabIndex = 6;
            btnPic.Text = "Add Picture";
            btnPic.UseVisualStyleBackColor = true;
            btnPic.Click += btnPic_Click;
            // 
            // lbItemPrice
            // 
            lbItemPrice.AutoSize = true;
            lbItemPrice.Location = new Point(21, 221);
            lbItemPrice.Name = "lbItemPrice";
            lbItemPrice.Size = new Size(36, 15);
            lbItemPrice.TabIndex = 2;
            lbItemPrice.Text = "Price:";
            // 
            // lbItemName
            // 
            lbItemName.AutoSize = true;
            lbItemName.Location = new Point(21, 182);
            lbItemName.Name = "lbItemName";
            lbItemName.Size = new Size(69, 15);
            lbItemName.TabIndex = 1;
            lbItemName.Text = "Item Name:";
            // 
            // picPreview
            // 
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            picPreview.Location = new Point(81, 16);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(141, 112);
            picPreview.TabIndex = 0;
            picPreview.TabStop = false;
            // 
            // tpCategory
            // 
            tpCategory.Controls.Add(btnClearCat);
            tpCategory.Controls.Add(txtCatId);
            tpCategory.Controls.Add(lbCatId);
            tpCategory.Controls.Add(btnDeleteCat);
            tpCategory.Controls.Add(btnSaveCat);
            tpCategory.Controls.Add(btnAddCat);
            tpCategory.Controls.Add(txtCatName);
            tpCategory.Controls.Add(lbCatName);
            tpCategory.Location = new Point(4, 24);
            tpCategory.Name = "tpCategory";
            tpCategory.Padding = new Padding(3);
            tpCategory.Size = new Size(269, 368);
            tpCategory.TabIndex = 1;
            tpCategory.Text = "Category";
            tpCategory.UseVisualStyleBackColor = true;
            // 
            // btnClearCat
            // 
            btnClearCat.Location = new Point(141, 78);
            btnClearCat.Name = "btnClearCat";
            btnClearCat.Size = new Size(60, 23);
            btnClearCat.TabIndex = 7;
            btnClearCat.Text = "Clear";
            btnClearCat.UseVisualStyleBackColor = true;
            btnClearCat.Click += btnClearCat_Click;
            // 
            // txtCatId
            // 
            txtCatId.Location = new Point(97, 78);
            txtCatId.Name = "txtCatId";
            txtCatId.ReadOnly = true;
            txtCatId.Size = new Size(37, 23);
            txtCatId.TabIndex = 6;
            // 
            // lbCatId
            // 
            lbCatId.AutoSize = true;
            lbCatId.Location = new Point(23, 81);
            lbCatId.Name = "lbCatId";
            lbCatId.Size = new Size(71, 15);
            lbCatId.TabIndex = 5;
            lbCatId.Text = "Category Id:";
            // 
            // btnDeleteCat
            // 
            btnDeleteCat.Location = new Point(23, 201);
            btnDeleteCat.Name = "btnDeleteCat";
            btnDeleteCat.Size = new Size(205, 28);
            btnDeleteCat.TabIndex = 4;
            btnDeleteCat.Text = "Delete";
            btnDeleteCat.UseVisualStyleBackColor = true;
            btnDeleteCat.Click += btnDeleteCat_Click;
            // 
            // btnSaveCat
            // 
            btnSaveCat.Location = new Point(39, 162);
            btnSaveCat.Name = "btnSaveCat";
            btnSaveCat.Size = new Size(75, 23);
            btnSaveCat.TabIndex = 3;
            btnSaveCat.Text = "Save";
            btnSaveCat.UseVisualStyleBackColor = true;
            btnSaveCat.Click += btnSaveCat_Click;
            // 
            // btnAddCat
            // 
            btnAddCat.Location = new Point(141, 162);
            btnAddCat.Name = "btnAddCat";
            btnAddCat.Size = new Size(75, 23);
            btnAddCat.TabIndex = 2;
            btnAddCat.Text = "Add";
            btnAddCat.UseVisualStyleBackColor = true;
            btnAddCat.Click += btnAddCat_Click;
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(97, 110);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(131, 23);
            txtCatName.TabIndex = 1;
            // 
            // lbCatName
            // 
            lbCatName.AutoSize = true;
            lbCatName.Location = new Point(23, 113);
            lbCatName.Name = "lbCatName";
            lbCatName.Size = new Size(58, 15);
            lbCatName.TabIndex = 0;
            lbCatName.Text = "Category:";
            // 
            // gbItem
            // 
            gbItem.Controls.Add(dgvItem);
            gbItem.Location = new Point(289, 132);
            gbItem.Name = "gbItem";
            gbItem.Size = new Size(331, 262);
            gbItem.TabIndex = 2;
            gbItem.TabStop = false;
            gbItem.Text = "Item list";
            // 
            // dgvItem
            // 
            dgvItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItem.Dock = DockStyle.Fill;
            dgvItem.Location = new Point(3, 19);
            dgvItem.Name = "dgvItem";
            dgvItem.ReadOnly = true;
            dgvItem.RowTemplate.Height = 25;
            dgvItem.Size = new Size(325, 240);
            dgvItem.TabIndex = 0;
            dgvItem.CellClick += dgvItem_CellClick;
            // 
            // gbCategory
            // 
            gbCategory.AutoSize = true;
            gbCategory.Controls.Add(dgvCategory);
            gbCategory.Location = new Point(289, 6);
            gbCategory.Name = "gbCategory";
            gbCategory.Size = new Size(331, 120);
            gbCategory.TabIndex = 0;
            gbCategory.TabStop = false;
            gbCategory.Text = "Category";
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Dock = DockStyle.Fill;
            dgvCategory.Location = new Point(3, 19);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowTemplate.Height = 25;
            dgvCategory.Size = new Size(325, 98);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellClick += dgvCategory_CellClick;
            dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            dgvCategory.CellDoubleClick += dgvCategory_CellDoubleClick;
            // 
            // tpUser
            // 
            tpUser.Controls.Add(gbOrder);
            tpUser.Controls.Add(panel2);
            tpUser.Location = new Point(4, 24);
            tpUser.Name = "tpUser";
            tpUser.Padding = new Padding(3);
            tpUser.Size = new Size(628, 402);
            tpUser.TabIndex = 1;
            tpUser.Text = "Users";
            tpUser.UseVisualStyleBackColor = true;
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(dgvOrder);
            gbOrder.Dock = DockStyle.Bottom;
            gbOrder.Location = new Point(3, 238);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new Size(622, 161);
            gbOrder.TabIndex = 1;
            gbOrder.TabStop = false;
            gbOrder.Text = "User's Orders";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Dock = DockStyle.Bottom;
            dgvOrder.Location = new Point(3, 19);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowTemplate.Height = 25;
            dgvOrder.Size = new Size(616, 139);
            dgvOrder.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(gbUser);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 229);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClearUser);
            panel1.Controls.Add(txtUserId);
            panel1.Controls.Add(lbUserId);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(txtUserPhone);
            panel1.Controls.Add(txtUserMail);
            panel1.Controls.Add(txtUserPass);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(btnSaveUser);
            panel1.Controls.Add(lbUserPhone);
            panel1.Controls.Add(lbUserEmail);
            panel1.Controls.Add(lbUserPass);
            panel1.Controls.Add(lbUserName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 229);
            panel1.TabIndex = 9;
            // 
            // btnClearUser
            // 
            btnClearUser.Location = new Point(124, 15);
            btnClearUser.Name = "btnClearUser";
            btnClearUser.Size = new Size(54, 23);
            btnClearUser.TabIndex = 10;
            btnClearUser.Text = "Clear";
            btnClearUser.UseVisualStyleBackColor = true;
            btnClearUser.Click += btnClearUser_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(82, 15);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(36, 23);
            txtUserId.TabIndex = 9;
            // 
            // lbUserId
            // 
            lbUserId.AutoSize = true;
            lbUserId.Location = new Point(13, 18);
            lbUserId.Name = "lbUserId";
            lbUserId.Size = new Size(21, 15);
            lbUserId.TabIndex = 8;
            lbUserId.Text = "ID:";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(30, 176);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(75, 23);
            btnDeleteUser.TabIndex = 7;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // txtUserPhone
            // 
            txtUserPhone.Location = new Point(82, 136);
            txtUserPhone.Mask = "(999) 000-0000";
            txtUserPhone.Name = "txtUserPhone";
            txtUserPhone.Size = new Size(138, 23);
            txtUserPhone.TabIndex = 4;
            // 
            // txtUserMail
            // 
            txtUserMail.Location = new Point(82, 107);
            txtUserMail.Name = "txtUserMail";
            txtUserMail.Size = new Size(138, 23);
            txtUserMail.TabIndex = 3;
            // 
            // txtUserPass
            // 
            txtUserPass.Location = new Point(82, 76);
            txtUserPass.Name = "txtUserPass";
            txtUserPass.PasswordChar = '*';
            txtUserPass.Size = new Size(138, 23);
            txtUserPass.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(82, 46);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(138, 23);
            txtUserName.TabIndex = 1;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(133, 176);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(75, 23);
            btnSaveUser.TabIndex = 6;
            btnSaveUser.Text = "Save";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // lbUserPhone
            // 
            lbUserPhone.AutoSize = true;
            lbUserPhone.Location = new Point(13, 139);
            lbUserPhone.Name = "lbUserPhone";
            lbUserPhone.Size = new Size(44, 15);
            lbUserPhone.TabIndex = 3;
            lbUserPhone.Text = "Phone:";
            // 
            // lbUserEmail
            // 
            lbUserEmail.AutoSize = true;
            lbUserEmail.Location = new Point(13, 110);
            lbUserEmail.Name = "lbUserEmail";
            lbUserEmail.Size = new Size(47, 15);
            lbUserEmail.TabIndex = 2;
            lbUserEmail.Text = "E-mail: ";
            // 
            // lbUserPass
            // 
            lbUserPass.AutoSize = true;
            lbUserPass.Location = new Point(13, 79);
            lbUserPass.Name = "lbUserPass";
            lbUserPass.Size = new Size(60, 15);
            lbUserPass.TabIndex = 1;
            lbUserPass.Text = "Password:";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(13, 49);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(63, 15);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Username:";
            // 
            // gbUser
            // 
            gbUser.Controls.Add(dgvUserList);
            gbUser.Dock = DockStyle.Right;
            gbUser.Location = new Point(255, 0);
            gbUser.Name = "gbUser";
            gbUser.Size = new Size(367, 229);
            gbUser.TabIndex = 0;
            gbUser.TabStop = false;
            gbUser.Text = "Users";
            // 
            // dgvUserList
            // 
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Dock = DockStyle.Fill;
            dgvUserList.Location = new Point(3, 19);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.RowTemplate.Height = 25;
            dgvUserList.Size = new Size(361, 207);
            dgvUserList.TabIndex = 0;
            dgvUserList.CellClick += dgvUserList_CellClick;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 430);
            Controls.Add(tabControl1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load;
            tabControl1.ResumeLayout(false);
            tpItemAndCat.ResumeLayout(false);
            tpItemAndCat.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            tpCategory.ResumeLayout(false);
            tpCategory.PerformLayout();
            gbItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItem).EndInit();
            gbCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            tpUser.ResumeLayout(false);
            gbOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpItemAndCat;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TextBox txtItemPrice;
        private TextBox txtItemName;
        private Button btnDeleteItem;
        private Button btnAddItem;
        private Button btnSaveItem;
        private Button btnPic;
        private Label lbItemPrice;
        private Label lbItemName;
        private PictureBox picPreview;
        private TabPage tpCategory;
        private Button btnDeleteCat;
        private Button btnSaveCat;
        private Button btnAddCat;
        private TextBox txtCatName;
        private Label lbCatName;
        private GroupBox gbItem;
        private DataGridView dgvItem;
        private GroupBox gbCategory;
        private DataGridView dgvCategory;
        private TabPage tpUser;
        private Panel panel2;
        private GroupBox gbOrder;
        private DataGridView dgvOrder;
        private GroupBox gbUser;
        private DataGridView dgvUserList;
        private Panel panel1;
        private Button btnSaveUser;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtCatId;
        private Label lbUserPhone;
        private Label lbUserEmail;
        private Label lbUserPass;
        private Label lbUserName;
        private MaskedTextBox txtUserPhone;
        private TextBox txtUserMail;
        private TextBox txtUserPass;
        private TextBox txtUserName;
        private Button btnDeleteUser;
        private ComboBox cbItemCat;
        private Label lbItemCat;
        private Button btnItemClear;
        private TextBox txtItemId;
        private Label lbCatId;
        private Button btnClearCat;
        private Label lbUserId;
        private Button btnClearUser;
        private TextBox txtUserId;
    }
}