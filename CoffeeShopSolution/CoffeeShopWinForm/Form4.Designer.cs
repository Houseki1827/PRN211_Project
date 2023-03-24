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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbOrder = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pHeader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbHeader = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.fpContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbTitle_2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbPhone_Pf = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCPass = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbOrder.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.tbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbOrder);
            this.tabPage1.Controls.Add(this.pHeader);
            this.tabPage1.Controls.Add(this.fpContainer);
            this.tabPage1.Controls.Add(this.dgvOrderDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(628, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order history";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbOrder
            // 
            this.tbOrder.ColumnCount = 5;
            this.tbOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.35408F));
            this.tbOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.64592F));
            this.tbOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tbOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tbOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tbOrder.Controls.Add(this.lbTotal, 3, 0);
            this.tbOrder.Controls.Add(this.lbPhone, 1, 0);
            this.tbOrder.Controls.Add(this.btnView, 4, 0);
            this.tbOrder.Controls.Add(this.lbID, 0, 0);
            this.tbOrder.Controls.Add(this.lbStatus, 2, 0);
            this.tbOrder.Location = new System.Drawing.Point(3, 153);
            this.tbOrder.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.RowCount = 1;
            this.tbOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tbOrder.Size = new System.Drawing.Size(621, 49);
            this.tbOrder.TabIndex = 1;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(402, 14);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(64, 20);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "$33.00";
            // 
            // lbPhone
            // 
            this.lbPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(103, 14);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(121, 20);
            this.lbPhone.TabIndex = 1;
            this.lbPhone.Text = "0123-456-789";
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnView.Location = new System.Drawing.Point(529, 4);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(88, 41);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // lbID
            // 
            this.lbID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(40, 14);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(19, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "1";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.ForeColor = System.Drawing.Color.Firebrick;
            this.lbStatus.Location = new System.Drawing.Point(269, 12);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(49, 25);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Paid";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.lbTitle);
            this.pHeader.Controls.Add(this.tbHeader);
            this.pHeader.Controls.Add(this.cbSort);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(4, 4);
            this.pHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(620, 141);
            this.pHeader.TabIndex = 4;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(185, 25);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(240, 46);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Order History";
            // 
            // tbHeader
            // 
            this.tbHeader.ColumnCount = 5;
            this.tbHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.88546F));
            this.tbHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.11454F));
            this.tbHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tbHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tbHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tbHeader.Controls.Add(this.label7, 3, 0);
            this.tbHeader.Controls.Add(this.label8, 0, 0);
            this.tbHeader.Controls.Add(this.label9, 2, 0);
            this.tbHeader.Controls.Add(this.label10, 1, 0);
            this.tbHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbHeader.Location = new System.Drawing.Point(0, 97);
            this.tbHeader.Margin = new System.Windows.Forms.Padding(4);
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.RowCount = 1;
            this.tbHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbHeader.Size = new System.Drawing.Size(620, 44);
            this.tbHeader.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "OrderID";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Phone";
            // 
            // cbSort
            // 
            this.cbSort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "(none)",
            "ID ↑",
            "ID ↓",
            "Total ↑",
            "Total ↓"});
            this.cbSort.Location = new System.Drawing.Point(485, 61);
            this.cbSort.Margin = new System.Windows.Forms.Padding(4);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(135, 28);
            this.cbSort.TabIndex = 2;
            this.cbSort.Text = "(none)";
            // 
            // fpContainer
            // 
            this.fpContainer.AutoScroll = true;
            this.fpContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpContainer.Location = new System.Drawing.Point(4, 150);
            this.fpContainer.Margin = new System.Windows.Forms.Padding(4, 4, 23, 4);
            this.fpContainer.Name = "fpContainer";
            this.fpContainer.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.fpContainer.Size = new System.Drawing.Size(620, 231);
            this.fpContainer.TabIndex = 1;
            this.fpContainer.WrapContents = false;
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrderDetails.Location = new System.Drawing.Point(4, 381);
            this.dgvOrderDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 25;
            this.dgvOrderDetails.Size = new System.Drawing.Size(620, 243);
            this.dgvOrderDetails.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbTitle_2);
            this.tabPage2.Controls.Add(this.btnCancel);
            this.tabPage2.Controls.Add(this.btnSave);
            this.tabPage2.Controls.Add(this.txtPhone);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.txtConfirm);
            this.tabPage2.Controls.Add(this.txtPass);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.lbPhone_Pf);
            this.tabPage2.Controls.Add(this.lbEmail);
            this.tabPage2.Controls.Add(this.lbCPass);
            this.tabPage2.Controls.Add(this.lbPass);
            this.tabPage2.Controls.Add(this.lbName);
            this.tabPage2.Controls.Add(this.btnLogout);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(15, 13, 15, 13);
            this.tabPage2.Size = new System.Drawing.Size(628, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbTitle_2
            // 
            this.lbTitle_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle_2.AutoSize = true;
            this.lbTitle_2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle_2.Location = new System.Drawing.Point(245, 51);
            this.lbTitle_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle_2.Name = "lbTitle_2";
            this.lbTitle_2.Size = new System.Drawing.Size(138, 50);
            this.lbTitle_2.TabIndex = 13;
            this.lbTitle_2.Text = "Profile";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(127, 456);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(375, 456);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(269, 355);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(288, 28);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(269, 304);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 28);
            this.txtEmail.TabIndex = 3;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Enabled = false;
            this.txtConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirm.Location = new System.Drawing.Point(269, 255);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.PlaceholderText = "**********";
            this.txtConfirm.Size = new System.Drawing.Size(288, 28);
            this.txtConfirm.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(269, 206);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "**********";
            this.txtPass.Size = new System.Drawing.Size(288, 29);
            this.txtPass.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(269, 159);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(288, 29);
            this.txtName.TabIndex = 0;
            // 
            // lbPhone_Pf
            // 
            this.lbPhone_Pf.AutoSize = true;
            this.lbPhone_Pf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhone_Pf.Location = new System.Drawing.Point(65, 358);
            this.lbPhone_Pf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhone_Pf.Name = "lbPhone_Pf";
            this.lbPhone_Pf.Size = new System.Drawing.Size(73, 22);
            this.lbPhone_Pf.TabIndex = 5;
            this.lbPhone_Pf.Text = "Phone:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(65, 307);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(73, 22);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "E-mail:";
            // 
            // lbCPass
            // 
            this.lbCPass.AutoSize = true;
            this.lbCPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCPass.Location = new System.Drawing.Point(65, 256);
            this.lbCPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCPass.Name = "lbCPass";
            this.lbCPass.Size = new System.Drawing.Size(178, 21);
            this.lbCPass.TabIndex = 3;
            this.lbCPass.Text = "Confirm password:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPass.Location = new System.Drawing.Point(65, 207);
            this.lbPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(104, 21);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(65, 159);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(108, 21);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Username:";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(15, 558);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(598, 57);
            this.btnLogout.TabIndex = 99;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.15884F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.84116F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "OrderID";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 661);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbOrder.ResumeLayout(false);
            this.tbOrder.PerformLayout();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.tbHeader.ResumeLayout(false);
            this.tbHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

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
        private TableLayoutPanel tableLayoutPanel2;
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
    }
}