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
            panel3 = new Panel();
            gbStatus = new GroupBox();
            btnClearStat = new Button();
            btnSaveStat = new Button();
            cbStat = new ComboBox();
            txtStatId = new TextBox();
            lbStatus = new Label();
            lbStatId = new Label();
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
            panel3.SuspendLayout();
            gbStatus.SuspendLayout();
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
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(939, 619);
            tabControl1.TabIndex = 0;
            // 
            // tpItemAndCat
            // 
            tpItemAndCat.Controls.Add(tabControl2);
            tpItemAndCat.Controls.Add(gbItem);
            tpItemAndCat.Controls.Add(gbCategory);
            tpItemAndCat.Location = new Point(4, 25);
            tpItemAndCat.Margin = new Padding(4);
            tpItemAndCat.Name = "tpItemAndCat";
            tpItemAndCat.Padding = new Padding(4);
            tpItemAndCat.Size = new Size(931, 590);
            tpItemAndCat.TabIndex = 0;
            tpItemAndCat.Text = "Items";
            tpItemAndCat.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Controls.Add(tpCategory);
            tabControl2.Dock = DockStyle.Left;
            tabControl2.Location = new Point(4, 4);
            tabControl2.Margin = new Padding(4);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(373, 582);
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
            tabPage1.Location = new Point(4, 25);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(365, 553);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Item";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnItemClear
            // 
            btnItemClear.Location = new Point(23, 238);
            btnItemClear.Margin = new Padding(4);
            btnItemClear.Name = "btnItemClear";
            btnItemClear.Size = new Size(71, 40);
            btnItemClear.TabIndex = 10;
            btnItemClear.Text = "Clear";
            btnItemClear.UseVisualStyleBackColor = true;
            btnItemClear.Click += btnClearItem_Click;
            // 
            // txtItemId
            // 
            txtItemId.Location = new Point(23, 203);
            txtItemId.Margin = new Padding(4);
            txtItemId.Name = "txtItemId";
            txtItemId.ReadOnly = true;
            txtItemId.Size = new Size(71, 23);
            txtItemId.TabIndex = 9;
            // 
            // cbItemCat
            // 
            cbItemCat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbItemCat.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbItemCat.FormattingEnabled = true;
            cbItemCat.Location = new Point(133, 390);
            cbItemCat.Margin = new Padding(4);
            cbItemCat.Name = "cbItemCat";
            cbItemCat.Size = new Size(197, 24);
            cbItemCat.TabIndex = 8;
            // 
            // lbItemCat
            // 
            lbItemCat.AutoSize = true;
            lbItemCat.Location = new Point(23, 394);
            lbItemCat.Margin = new Padding(4, 0, 4, 0);
            lbItemCat.Name = "lbItemCat";
            lbItemCat.Size = new Size(73, 16);
            lbItemCat.TabIndex = 7;
            lbItemCat.Text = "Category:";
            // 
            // txtItemPrice
            // 
            txtItemPrice.Location = new Point(133, 344);
            txtItemPrice.Margin = new Padding(4);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.Size = new Size(197, 23);
            txtItemPrice.TabIndex = 2;
            txtItemPrice.Text = "0";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(133, 296);
            txtItemName.Margin = new Padding(4);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(197, 23);
            txtItemName.TabIndex = 1;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(8, 490);
            btnDeleteItem.Margin = new Padding(4);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(349, 47);
            btnDeleteItem.TabIndex = 5;
            btnDeleteItem.Text = "Delete";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(203, 442);
            btnAddItem.Margin = new Padding(4);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(119, 40);
            btnAddItem.TabIndex = 3;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnSaveItem
            // 
            btnSaveItem.Location = new Point(42, 442);
            btnSaveItem.Margin = new Padding(4);
            btnSaveItem.Name = "btnSaveItem";
            btnSaveItem.Size = new Size(119, 40);
            btnSaveItem.TabIndex = 4;
            btnSaveItem.Text = "Save";
            btnSaveItem.UseVisualStyleBackColor = true;
            btnSaveItem.Click += btnSaveItem_Click;
            // 
            // btnPic
            // 
            btnPic.Location = new Point(133, 238);
            btnPic.Margin = new Padding(4);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(150, 40);
            btnPic.TabIndex = 6;
            btnPic.Text = "Add Picture";
            btnPic.UseVisualStyleBackColor = true;
            // 
            // lbItemPrice
            // 
            lbItemPrice.AutoSize = true;
            lbItemPrice.Location = new Point(23, 348);
            lbItemPrice.Margin = new Padding(4, 0, 4, 0);
            lbItemPrice.Name = "lbItemPrice";
            lbItemPrice.Size = new Size(46, 16);
            lbItemPrice.TabIndex = 2;
            lbItemPrice.Text = "Price:";
            // 
            // lbItemName
            // 
            lbItemName.AutoSize = true;
            lbItemName.Location = new Point(23, 299);
            lbItemName.Margin = new Padding(4, 0, 4, 0);
            lbItemName.Name = "lbItemName";
            lbItemName.Size = new Size(83, 16);
            lbItemName.TabIndex = 1;
            lbItemName.Text = "Item Name:";
            // 
            // picPreview
            // 
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            picPreview.Image = Properties.Resources.banbaro;
            picPreview.Location = new Point(102, 4);
            picPreview.Margin = new Padding(4);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(205, 226);
            picPreview.SizeMode = PictureBoxSizeMode.CenterImage;
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
            tpCategory.Margin = new Padding(4);
            tpCategory.Name = "tpCategory";
            tpCategory.Padding = new Padding(4);
            tpCategory.Size = new Size(365, 554);
            tpCategory.TabIndex = 1;
            tpCategory.Text = "Category";
            tpCategory.UseVisualStyleBackColor = true;
            // 
            // btnClearCat
            // 
            btnClearCat.Location = new Point(221, 147);
            btnClearCat.Margin = new Padding(4);
            btnClearCat.Name = "btnClearCat";
            btnClearCat.Size = new Size(95, 40);
            btnClearCat.TabIndex = 7;
            btnClearCat.Text = "Clear";
            btnClearCat.UseVisualStyleBackColor = true;
            btnClearCat.Click += btnClearCat_Click;
            // 
            // txtCatId
            // 
            txtCatId.Location = new Point(153, 154);
            txtCatId.Margin = new Padding(4);
            txtCatId.Name = "txtCatId";
            txtCatId.ReadOnly = true;
            txtCatId.Size = new Size(57, 23);
            txtCatId.TabIndex = 6;
            // 
            // lbCatId
            // 
            lbCatId.AutoSize = true;
            lbCatId.Location = new Point(35, 157);
            lbCatId.Margin = new Padding(4, 0, 4, 0);
            lbCatId.Name = "lbCatId";
            lbCatId.Size = new Size(90, 16);
            lbCatId.TabIndex = 5;
            lbCatId.Text = "Category Id:";
            // 
            // btnDeleteCat
            // 
            btnDeleteCat.Location = new Point(20, 317);
            btnDeleteCat.Margin = new Padding(4);
            btnDeleteCat.Name = "btnDeleteCat";
            btnDeleteCat.Size = new Size(321, 40);
            btnDeleteCat.TabIndex = 4;
            btnDeleteCat.Text = "Delete";
            btnDeleteCat.UseVisualStyleBackColor = true;
            btnDeleteCat.Click += btnDeleteCat_Click;
            // 
            // btnSaveCat
            // 
            btnSaveCat.Location = new Point(47, 265);
            btnSaveCat.Margin = new Padding(4);
            btnSaveCat.Name = "btnSaveCat";
            btnSaveCat.Size = new Size(119, 40);
            btnSaveCat.TabIndex = 3;
            btnSaveCat.Text = "Save";
            btnSaveCat.UseVisualStyleBackColor = true;
            btnSaveCat.Click += btnSaveCat_Click;
            // 
            // btnAddCat
            // 
            btnAddCat.Location = new Point(206, 265);
            btnAddCat.Margin = new Padding(4);
            btnAddCat.Name = "btnAddCat";
            btnAddCat.Size = new Size(119, 40);
            btnAddCat.TabIndex = 2;
            btnAddCat.Text = "Add";
            btnAddCat.UseVisualStyleBackColor = true;
            btnAddCat.Click += btnAddCat_Click;
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(153, 197);
            txtCatName.Margin = new Padding(4);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(163, 23);
            txtCatName.TabIndex = 1;
            // 
            // lbCatName
            // 
            lbCatName.AutoSize = true;
            lbCatName.Location = new Point(35, 200);
            lbCatName.Margin = new Padding(4, 0, 4, 0);
            lbCatName.Name = "lbCatName";
            lbCatName.Size = new Size(73, 16);
            lbCatName.TabIndex = 0;
            lbCatName.Text = "Category:";
            // 
            // gbItem
            // 
            gbItem.Controls.Add(dgvItem);
            gbItem.Location = new Point(373, 176);
            gbItem.Margin = new Padding(4);
            gbItem.Name = "gbItem";
            gbItem.Padding = new Padding(4);
            gbItem.Size = new Size(554, 402);
            gbItem.TabIndex = 2;
            gbItem.TabStop = false;
            gbItem.Text = "Item list";
            // 
            // dgvItem
            // 
            dgvItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItem.Dock = DockStyle.Fill;
            dgvItem.Location = new Point(4, 20);
            dgvItem.Margin = new Padding(4);
            dgvItem.Name = "dgvItem";
            dgvItem.ReadOnly = true;
            dgvItem.RowHeadersWidth = 51;
            dgvItem.RowTemplate.Height = 25;
            dgvItem.Size = new Size(546, 378);
            dgvItem.TabIndex = 0;
            dgvItem.CellClick += dgvItem_CellClick;
            // 
            // gbCategory
            // 
            gbCategory.AutoSize = true;
            gbCategory.Controls.Add(dgvCategory);
            gbCategory.Location = new Point(373, 8);
            gbCategory.Margin = new Padding(4);
            gbCategory.Name = "gbCategory";
            gbCategory.Padding = new Padding(4);
            gbCategory.Size = new Size(554, 160);
            gbCategory.TabIndex = 0;
            gbCategory.TabStop = false;
            gbCategory.Text = "Category";
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Dock = DockStyle.Fill;
            dgvCategory.Location = new Point(4, 20);
            dgvCategory.Margin = new Padding(4);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowTemplate.Height = 25;
            dgvCategory.Size = new Size(546, 136);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellClick += dgvCategory_CellClick;
            dgvCategory.CellDoubleClick += dgvCategory_CellDoubleClick;
            // 
            // tpUser
            // 
            tpUser.Controls.Add(panel3);
            tpUser.Controls.Add(panel2);
            tpUser.Location = new Point(4, 25);
            tpUser.Margin = new Padding(4);
            tpUser.Name = "tpUser";
            tpUser.Padding = new Padding(4);
            tpUser.Size = new Size(931, 590);
            tpUser.TabIndex = 1;
            tpUser.Text = "Users";
            tpUser.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(gbStatus);
            panel3.Controls.Add(gbOrder);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(4, 312);
            panel3.Name = "panel3";
            panel3.Size = new Size(923, 274);
            panel3.TabIndex = 2;
            // 
            // gbStatus
            // 
            gbStatus.Controls.Add(btnClearStat);
            gbStatus.Controls.Add(btnSaveStat);
            gbStatus.Controls.Add(cbStat);
            gbStatus.Controls.Add(txtStatId);
            gbStatus.Controls.Add(lbStatus);
            gbStatus.Controls.Add(lbStatId);
            gbStatus.Dock = DockStyle.Left;
            gbStatus.Location = new Point(0, 0);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(290, 274);
            gbStatus.TabIndex = 2;
            gbStatus.TabStop = false;
            gbStatus.Text = "OrderStatus";
            // 
            // btnClearStat
            // 
            btnClearStat.Location = new Point(160, 63);
            btnClearStat.Name = "btnClearStat";
            btnClearStat.Size = new Size(83, 27);
            btnClearStat.TabIndex = 5;
            btnClearStat.Text = "Clear";
            btnClearStat.UseVisualStyleBackColor = true;
            btnClearStat.Click += btnClearStat_Click;
            // 
            // btnSaveStat
            // 
            btnSaveStat.Location = new Point(101, 188);
            btnSaveStat.Name = "btnSaveStat";
            btnSaveStat.Size = new Size(75, 23);
            btnSaveStat.TabIndex = 4;
            btnSaveStat.Text = "Save";
            btnSaveStat.UseVisualStyleBackColor = true;
            btnSaveStat.Click += btnSaveStat_Click;
            // 
            // cbStat
            // 
            cbStat.FormattingEnabled = true;
            cbStat.Items.AddRange(new object[] { "Paid", "Waiting", "Shipping", "Processing", "Pick-up", "Cancel", "Complete" });
            cbStat.Location = new Point(101, 115);
            cbStat.Name = "cbStat";
            cbStat.Size = new Size(142, 24);
            cbStat.TabIndex = 3;
            cbStat.SelectedIndexChanged += cbStat_SelectedIndexChanged;
            // 
            // txtStatId
            // 
            txtStatId.Location = new Point(101, 65);
            txtStatId.Name = "txtStatId";
            txtStatId.ReadOnly = true;
            txtStatId.Size = new Size(53, 23);
            txtStatId.TabIndex = 2;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(22, 118);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(54, 16);
            lbStatus.TabIndex = 1;
            lbStatus.Text = "Status:";
            // 
            // lbStatId
            // 
            lbStatId.AutoSize = true;
            lbStatId.Location = new Point(22, 68);
            lbStatId.Name = "lbStatId";
            lbStatId.Size = new Size(73, 16);
            lbStatId.TabIndex = 0;
            lbStatId.Text = "Order ID: ";
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(dgvOrder);
            gbOrder.Dock = DockStyle.Right;
            gbOrder.Location = new Point(293, 0);
            gbOrder.Margin = new Padding(4);
            gbOrder.Name = "gbOrder";
            gbOrder.Padding = new Padding(4);
            gbOrder.Size = new Size(630, 274);
            gbOrder.TabIndex = 1;
            gbOrder.TabStop = false;
            gbOrder.Text = "User's Orders";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Dock = DockStyle.Bottom;
            dgvOrder.Location = new Point(4, 37);
            dgvOrder.Margin = new Padding(4);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 25;
            dgvOrder.Size = new Size(622, 233);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(gbUser);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(4, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(923, 305);
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
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 305);
            panel1.TabIndex = 9;
            // 
            // btnClearUser
            // 
            btnClearUser.Location = new Point(196, 27);
            btnClearUser.Margin = new Padding(4);
            btnClearUser.Name = "btnClearUser";
            btnClearUser.Size = new Size(86, 31);
            btnClearUser.TabIndex = 10;
            btnClearUser.Text = "Clear";
            btnClearUser.UseVisualStyleBackColor = true;
            btnClearUser.Click += btnClearUser_Click;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(130, 27);
            txtUserId.Margin = new Padding(4);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(55, 23);
            txtUserId.TabIndex = 9;
            // 
            // lbUserId
            // 
            lbUserId.AutoSize = true;
            lbUserId.Location = new Point(21, 31);
            lbUserId.Margin = new Padding(4, 0, 4, 0);
            lbUserId.Name = "lbUserId";
            lbUserId.Size = new Size(25, 16);
            lbUserId.TabIndex = 8;
            lbUserId.Text = "ID:";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(46, 242);
            btnDeleteUser.Margin = new Padding(4);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(119, 31);
            btnDeleteUser.TabIndex = 7;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // txtUserPhone
            // 
            txtUserPhone.Location = new Point(130, 188);
            txtUserPhone.Margin = new Padding(4);
            txtUserPhone.Mask = "(999) 000-0000";
            txtUserPhone.Name = "txtUserPhone";
            txtUserPhone.Size = new Size(214, 23);
            txtUserPhone.TabIndex = 4;
            // 
            // txtUserMail
            // 
            txtUserMail.Location = new Point(130, 150);
            txtUserMail.Margin = new Padding(4);
            txtUserMail.Name = "txtUserMail";
            txtUserMail.Size = new Size(214, 23);
            txtUserMail.TabIndex = 3;
            // 
            // txtUserPass
            // 
            txtUserPass.Location = new Point(130, 108);
            txtUserPass.Margin = new Padding(4);
            txtUserPass.Name = "txtUserPass";
            txtUserPass.PasswordChar = '*';
            txtUserPass.Size = new Size(214, 23);
            txtUserPass.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(130, 68);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(214, 23);
            txtUserName.TabIndex = 1;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Location = new Point(209, 242);
            btnSaveUser.Margin = new Padding(4);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new Size(119, 31);
            btnSaveUser.TabIndex = 6;
            btnSaveUser.Text = "Save";
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // lbUserPhone
            // 
            lbUserPhone.AutoSize = true;
            lbUserPhone.Location = new Point(21, 192);
            lbUserPhone.Margin = new Padding(4, 0, 4, 0);
            lbUserPhone.Name = "lbUserPhone";
            lbUserPhone.Size = new Size(52, 16);
            lbUserPhone.TabIndex = 3;
            lbUserPhone.Text = "Phone:";
            // 
            // lbUserEmail
            // 
            lbUserEmail.AutoSize = true;
            lbUserEmail.Location = new Point(21, 154);
            lbUserEmail.Margin = new Padding(4, 0, 4, 0);
            lbUserEmail.Name = "lbUserEmail";
            lbUserEmail.Size = new Size(57, 16);
            lbUserEmail.TabIndex = 2;
            lbUserEmail.Text = "E-mail: ";
            // 
            // lbUserPass
            // 
            lbUserPass.AutoSize = true;
            lbUserPass.Location = new Point(21, 112);
            lbUserPass.Margin = new Padding(4, 0, 4, 0);
            lbUserPass.Name = "lbUserPass";
            lbUserPass.Size = new Size(78, 16);
            lbUserPass.TabIndex = 1;
            lbUserPass.Text = "Password:";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(21, 72);
            lbUserName.Margin = new Padding(4, 0, 4, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(80, 16);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "Username:";
            // 
            // gbUser
            // 
            gbUser.Controls.Add(dgvUserList);
            gbUser.Dock = DockStyle.Right;
            gbUser.Location = new Point(377, 0);
            gbUser.Margin = new Padding(4);
            gbUser.Name = "gbUser";
            gbUser.Padding = new Padding(4);
            gbUser.Size = new Size(546, 305);
            gbUser.TabIndex = 0;
            gbUser.TabStop = false;
            gbUser.Text = "Users";
            // 
            // dgvUserList
            // 
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Dock = DockStyle.Fill;
            dgvUserList.Location = new Point(4, 20);
            dgvUserList.Margin = new Padding(4);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.RowHeadersWidth = 51;
            dgvUserList.RowTemplate.Height = 25;
            dgvUserList.Size = new Size(538, 281);
            dgvUserList.TabIndex = 0;
            dgvUserList.CellClick += dgvUserList_CellClick;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 619);
            Controls.Add(tabControl1);
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            Load += Form6_Load_1;
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
            panel3.ResumeLayout(false);
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
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
        private Panel panel3;
        private GroupBox gbStatus;
        private Button btnClearStat;
        private Button btnSaveStat;
        private ComboBox cbStat;
        private TextBox txtStatId;
        private Label lbStatus;
        private Label lbStatId;
    }
}