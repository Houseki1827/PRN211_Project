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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpItemAndCat = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnItemClear = new System.Windows.Forms.Button();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.cbItemCat = new System.Windows.Forms.ComboBox();
            this.lbItemCat = new System.Windows.Forms.Label();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.lbItemPrice = new System.Windows.Forms.Label();
            this.lbItemName = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.btnClearCat = new System.Windows.Forms.Button();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.lbCatId = new System.Windows.Forms.Label();
            this.btnDeleteCat = new System.Windows.Forms.Button();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lbCatName = new System.Windows.Forms.Label();
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.tpUser = new System.Windows.Forms.TabPage();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearUser = new System.Windows.Forms.Button();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lbUserId = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtUserPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.lbUserPhone = new System.Windows.Forms.Label();
            this.lbUserEmail = new System.Windows.Forms.Label();
            this.lbUserPass = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpItemAndCat.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.tpCategory.SuspendLayout();
            this.gbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.gbCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.tpUser.SuspendLayout();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpItemAndCat);
            this.tabControl1.Controls.Add(this.tpUser);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 619);
            this.tabControl1.TabIndex = 0;
            // 
            // tpItemAndCat
            // 
            this.tpItemAndCat.Controls.Add(this.tabControl2);
            this.tpItemAndCat.Controls.Add(this.gbItem);
            this.tpItemAndCat.Controls.Add(this.gbCategory);
            this.tpItemAndCat.Location = new System.Drawing.Point(4, 29);
            this.tpItemAndCat.Margin = new System.Windows.Forms.Padding(4);
            this.tpItemAndCat.Name = "tpItemAndCat";
            this.tpItemAndCat.Padding = new System.Windows.Forms.Padding(4);
            this.tpItemAndCat.Size = new System.Drawing.Size(931, 586);
            this.tpItemAndCat.TabIndex = 0;
            this.tpItemAndCat.Text = "Items";
            this.tpItemAndCat.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tpCategory);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl2.Location = new System.Drawing.Point(4, 4);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(373, 578);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnItemClear);
            this.tabPage1.Controls.Add(this.txtItemId);
            this.tabPage1.Controls.Add(this.cbItemCat);
            this.tabPage1.Controls.Add(this.lbItemCat);
            this.tabPage1.Controls.Add(this.txtItemPrice);
            this.tabPage1.Controls.Add(this.txtItemName);
            this.tabPage1.Controls.Add(this.btnDeleteItem);
            this.tabPage1.Controls.Add(this.btnAddItem);
            this.tabPage1.Controls.Add(this.btnSaveItem);
            this.tabPage1.Controls.Add(this.btnPic);
            this.tabPage1.Controls.Add(this.lbItemPrice);
            this.tabPage1.Controls.Add(this.lbItemName);
            this.tabPage1.Controls.Add(this.picPreview);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(365, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Item";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnItemClear
            // 
            this.btnItemClear.Location = new System.Drawing.Point(38, 238);
            this.btnItemClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnItemClear.Name = "btnItemClear";
            this.btnItemClear.Size = new System.Drawing.Size(71, 40);
            this.btnItemClear.TabIndex = 10;
            this.btnItemClear.Text = "Clear";
            this.btnItemClear.UseVisualStyleBackColor = true;
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(8, 181);
            this.txtItemId.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.ReadOnly = true;
            this.txtItemId.Size = new System.Drawing.Size(71, 27);
            this.txtItemId.TabIndex = 9;
            // 
            // cbItemCat
            // 
            this.cbItemCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbItemCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbItemCat.FormattingEnabled = true;
            this.cbItemCat.Location = new System.Drawing.Point(133, 390);
            this.cbItemCat.Margin = new System.Windows.Forms.Padding(4);
            this.cbItemCat.Name = "cbItemCat";
            this.cbItemCat.Size = new System.Drawing.Size(197, 28);
            this.cbItemCat.TabIndex = 8;
            // 
            // lbItemCat
            // 
            this.lbItemCat.AutoSize = true;
            this.lbItemCat.Location = new System.Drawing.Point(23, 394);
            this.lbItemCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbItemCat.Name = "lbItemCat";
            this.lbItemCat.Size = new System.Drawing.Size(90, 20);
            this.lbItemCat.TabIndex = 7;
            this.lbItemCat.Text = "Category:";
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(133, 344);
            this.txtItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(197, 27);
            this.txtItemPrice.TabIndex = 2;
            this.txtItemPrice.Text = "0";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(133, 296);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(197, 27);
            this.txtItemName.TabIndex = 1;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(8, 490);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(349, 47);
            this.btnDeleteItem.TabIndex = 5;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(203, 442);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(119, 40);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.Location = new System.Drawing.Point(42, 442);
            this.btnSaveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(119, 40);
            this.btnSaveItem.TabIndex = 4;
            this.btnSaveItem.Text = "Save";
            this.btnSaveItem.UseVisualStyleBackColor = true;
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(133, 238);
            this.btnPic.Margin = new System.Windows.Forms.Padding(4);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(150, 40);
            this.btnPic.TabIndex = 6;
            this.btnPic.Text = "Add Picture";
            this.btnPic.UseVisualStyleBackColor = true;
            // 
            // lbItemPrice
            // 
            this.lbItemPrice.AutoSize = true;
            this.lbItemPrice.Location = new System.Drawing.Point(23, 348);
            this.lbItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbItemPrice.Name = "lbItemPrice";
            this.lbItemPrice.Size = new System.Drawing.Size(57, 20);
            this.lbItemPrice.TabIndex = 2;
            this.lbItemPrice.Text = "Price:";
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Location = new System.Drawing.Point(23, 299);
            this.lbItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(102, 20);
            this.lbItemName.TabIndex = 1;
            this.lbItemName.Text = "Item Name:";
            // 
            // picPreview
            // 
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(92, 8);
            this.picPreview.Margin = new System.Windows.Forms.Padding(4);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(200, 200);
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.btnClearCat);
            this.tpCategory.Controls.Add(this.txtCatId);
            this.tpCategory.Controls.Add(this.lbCatId);
            this.tpCategory.Controls.Add(this.btnDeleteCat);
            this.tpCategory.Controls.Add(this.btnSaveCat);
            this.tpCategory.Controls.Add(this.btnAddCat);
            this.tpCategory.Controls.Add(this.txtCatName);
            this.tpCategory.Controls.Add(this.lbCatName);
            this.tpCategory.Location = new System.Drawing.Point(4, 29);
            this.tpCategory.Margin = new System.Windows.Forms.Padding(4);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(4);
            this.tpCategory.Size = new System.Drawing.Size(365, 545);
            this.tpCategory.TabIndex = 1;
            this.tpCategory.Text = "Category";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // btnClearCat
            // 
            this.btnClearCat.Location = new System.Drawing.Point(221, 147);
            this.btnClearCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearCat.Name = "btnClearCat";
            this.btnClearCat.Size = new System.Drawing.Size(95, 40);
            this.btnClearCat.TabIndex = 7;
            this.btnClearCat.Text = "Clear";
            this.btnClearCat.UseVisualStyleBackColor = true;
            // 
            // txtCatId
            // 
            this.txtCatId.Location = new System.Drawing.Point(153, 154);
            this.txtCatId.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.ReadOnly = true;
            this.txtCatId.Size = new System.Drawing.Size(57, 27);
            this.txtCatId.TabIndex = 6;
            // 
            // lbCatId
            // 
            this.lbCatId.AutoSize = true;
            this.lbCatId.Location = new System.Drawing.Point(35, 157);
            this.lbCatId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCatId.Name = "lbCatId";
            this.lbCatId.Size = new System.Drawing.Size(110, 20);
            this.lbCatId.TabIndex = 5;
            this.lbCatId.Text = "Category Id:";
            // 
            // btnDeleteCat
            // 
            this.btnDeleteCat.Location = new System.Drawing.Point(20, 317);
            this.btnDeleteCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCat.Name = "btnDeleteCat";
            this.btnDeleteCat.Size = new System.Drawing.Size(321, 40);
            this.btnDeleteCat.TabIndex = 4;
            this.btnDeleteCat.Text = "Delete";
            this.btnDeleteCat.UseVisualStyleBackColor = true;
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(47, 265);
            this.btnSaveCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(119, 40);
            this.btnSaveCat.TabIndex = 3;
            this.btnSaveCat.Text = "Save";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(206, 265);
            this.btnAddCat.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(119, 40);
            this.btnAddCat.TabIndex = 2;
            this.btnAddCat.Text = "Add";
            this.btnAddCat.UseVisualStyleBackColor = true;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(153, 197);
            this.txtCatName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(163, 27);
            this.txtCatName.TabIndex = 1;
            // 
            // lbCatName
            // 
            this.lbCatName.AutoSize = true;
            this.lbCatName.Location = new System.Drawing.Point(35, 200);
            this.lbCatName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCatName.Name = "lbCatName";
            this.lbCatName.Size = new System.Drawing.Size(90, 20);
            this.lbCatName.TabIndex = 0;
            this.lbCatName.Text = "Category:";
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.dgvItem);
            this.gbItem.Location = new System.Drawing.Point(373, 176);
            this.gbItem.Margin = new System.Windows.Forms.Padding(4);
            this.gbItem.Name = "gbItem";
            this.gbItem.Padding = new System.Windows.Forms.Padding(4);
            this.gbItem.Size = new System.Drawing.Size(554, 402);
            this.gbItem.TabIndex = 2;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Item list";
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItem.Location = new System.Drawing.Point(4, 24);
            this.dgvItem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersWidth = 51;
            this.dgvItem.RowTemplate.Height = 25;
            this.dgvItem.Size = new System.Drawing.Size(546, 374);
            this.dgvItem.TabIndex = 0;
            // 
            // gbCategory
            // 
            this.gbCategory.AutoSize = true;
            this.gbCategory.Controls.Add(this.dgvCategory);
            this.gbCategory.Location = new System.Drawing.Point(373, 8);
            this.gbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Padding = new System.Windows.Forms.Padding(4);
            this.gbCategory.Size = new System.Drawing.Size(554, 160);
            this.gbCategory.TabIndex = 0;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Category";
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategory.Location = new System.Drawing.Point(4, 24);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.RowTemplate.Height = 25;
            this.dgvCategory.Size = new System.Drawing.Size(546, 132);
            this.dgvCategory.TabIndex = 0;
            // 
            // tpUser
            // 
            this.tpUser.Controls.Add(this.gbOrder);
            this.tpUser.Controls.Add(this.panel2);
            this.tpUser.Location = new System.Drawing.Point(4, 29);
            this.tpUser.Margin = new System.Windows.Forms.Padding(4);
            this.tpUser.Name = "tpUser";
            this.tpUser.Padding = new System.Windows.Forms.Padding(4);
            this.tpUser.Size = new System.Drawing.Size(931, 586);
            this.tpUser.TabIndex = 1;
            this.tpUser.Text = "Users";
            this.tpUser.UseVisualStyleBackColor = true;
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.dgvOrder);
            this.gbOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbOrder.Location = new System.Drawing.Point(4, 317);
            this.gbOrder.Margin = new System.Windows.Forms.Padding(4);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Padding = new System.Windows.Forms.Padding(4);
            this.gbOrder.Size = new System.Drawing.Size(923, 265);
            this.gbOrder.TabIndex = 1;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "User\'s Orders";
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrder.Location = new System.Drawing.Point(4, 28);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 25;
            this.dgvOrder.Size = new System.Drawing.Size(915, 233);
            this.dgvOrder.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.gbUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 305);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearUser);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.lbUserId);
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.txtUserPhone);
            this.panel1.Controls.Add(this.txtUserMail);
            this.panel1.Controls.Add(this.txtUserPass);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.btnSaveUser);
            this.panel1.Controls.Add(this.lbUserPhone);
            this.panel1.Controls.Add(this.lbUserEmail);
            this.panel1.Controls.Add(this.lbUserPass);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 305);
            this.panel1.TabIndex = 9;
            // 
            // btnClearUser
            // 
            this.btnClearUser.Location = new System.Drawing.Point(196, 27);
            this.btnClearUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(86, 31);
            this.btnClearUser.TabIndex = 10;
            this.btnClearUser.Text = "Clear";
            this.btnClearUser.UseVisualStyleBackColor = true;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(130, 27);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(55, 27);
            this.txtUserId.TabIndex = 9;
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(21, 31);
            this.lbUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(32, 20);
            this.lbUserId.TabIndex = 8;
            this.lbUserId.Text = "ID:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(46, 242);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(119, 31);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Location = new System.Drawing.Point(130, 188);
            this.txtUserPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPhone.Mask = "(999) 000-0000";
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(214, 27);
            this.txtUserPhone.TabIndex = 4;
            // 
            // txtUserMail
            // 
            this.txtUserMail.Location = new System.Drawing.Point(130, 150);
            this.txtUserMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(214, 27);
            this.txtUserMail.TabIndex = 3;
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(130, 108);
            this.txtUserPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(214, 27);
            this.txtUserPass.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(130, 68);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(214, 27);
            this.txtUserName.TabIndex = 1;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(209, 242);
            this.btnSaveUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(119, 31);
            this.btnSaveUser.TabIndex = 6;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            // 
            // lbUserPhone
            // 
            this.lbUserPhone.AutoSize = true;
            this.lbUserPhone.Location = new System.Drawing.Point(21, 192);
            this.lbUserPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserPhone.Name = "lbUserPhone";
            this.lbUserPhone.Size = new System.Drawing.Size(65, 20);
            this.lbUserPhone.TabIndex = 3;
            this.lbUserPhone.Text = "Phone:";
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.Location = new System.Drawing.Point(21, 154);
            this.lbUserEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(70, 20);
            this.lbUserEmail.TabIndex = 2;
            this.lbUserEmail.Text = "E-mail: ";
            // 
            // lbUserPass
            // 
            this.lbUserPass.AutoSize = true;
            this.lbUserPass.Location = new System.Drawing.Point(21, 112);
            this.lbUserPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserPass.Name = "lbUserPass";
            this.lbUserPass.Size = new System.Drawing.Size(95, 20);
            this.lbUserPass.TabIndex = 1;
            this.lbUserPass.Text = "Password:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(21, 72);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(98, 20);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Username:";
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.dgvUserList);
            this.gbUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbUser.Location = new System.Drawing.Point(377, 0);
            this.gbUser.Margin = new System.Windows.Forms.Padding(4);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(4);
            this.gbUser.Size = new System.Drawing.Size(546, 305);
            this.gbUser.TabIndex = 0;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Users";
            // 
            // dgvUserList
            // 
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserList.Location = new System.Drawing.Point(4, 24);
            this.dgvUserList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.RowHeadersWidth = 51;
            this.dgvUserList.RowTemplate.Height = 25;
            this.dgvUserList.Size = new System.Drawing.Size(538, 277);
            this.dgvUserList.TabIndex = 0;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 619);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.tabControl1.ResumeLayout(false);
            this.tpItemAndCat.ResumeLayout(false);
            this.tpItemAndCat.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.tpCategory.ResumeLayout(false);
            this.tpCategory.PerformLayout();
            this.gbItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.gbCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.tpUser.ResumeLayout(false);
            this.gbOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);

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