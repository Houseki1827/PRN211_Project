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
            lbStatus = new Label();
            lbID = new Label();
            dgvOrderDetails = new DataGridView();
            tabPage2 = new TabPage();
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
            tableLayoutPanel2 = new TableLayoutPanel();
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
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(482, 492);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pHeader);
            tabPage1.Controls.Add(fpContainer);
            tabPage1.Controls.Add(dgvOrderDetails);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(474, 464);
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
            pHeader.Location = new Point(3, 3);
            pHeader.Name = "pHeader";
            pHeader.Size = new Size(468, 106);
            pHeader.TabIndex = 4;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(182, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(113, 21);
            lbTitle.TabIndex = 3;
            lbTitle.Text = "Order History";
            // 
            // tbHeader
            // 
            tbHeader.ColumnCount = 5;
            tbHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.3577976F));
            tbHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.6422043F));
            tbHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            tbHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tbHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tbHeader.Controls.Add(label7, 3, 0);
            tbHeader.Controls.Add(label8, 0, 0);
            tbHeader.Controls.Add(label9, 2, 0);
            tbHeader.Controls.Add(label10, 1, 0);
            tbHeader.Dock = DockStyle.Bottom;
            tbHeader.Location = new Point(0, 73);
            tbHeader.Name = "tbHeader";
            tbHeader.RowCount = 1;
            tbHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbHeader.Size = new Size(468, 33);
            tbHeader.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(291, 9);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 3;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(4, 9);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 0;
            label8.Text = "OrderID";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(209, 9);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 2;
            label9.Text = "Status";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(102, 9);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 1;
            label10.Text = "Phone";
            // 
            // cbSort
            // 
            cbSort.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSort.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbSort.FormattingEnabled = true;
            cbSort.Items.AddRange(new object[] { "(none)", "ID ↑", "ID ↓", "Total ↑", "Total ↓" });
            cbSort.Location = new Point(344, 44);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(121, 23);
            cbSort.TabIndex = 2;
            cbSort.Text = "(none)";
            cbSort.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // fpContainer
            // 
            fpContainer.AutoScroll = true;
            fpContainer.Controls.Add(tbOrder);
            fpContainer.Dock = DockStyle.Bottom;
            fpContainer.Location = new Point(3, 115);
            fpContainer.Margin = new Padding(3, 3, 15, 3);
            fpContainer.Name = "fpContainer";
            fpContainer.Padding = new Padding(0, 0, 10, 0);
            fpContainer.Size = new Size(468, 173);
            fpContainer.TabIndex = 1;
            fpContainer.WrapContents = false;
            // 
            // tbOrder
            // 
            tbOrder.ColumnCount = 5;
            tbOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.158844F));
            tbOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.841156F));
            tbOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tbOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tbOrder.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tbOrder.Controls.Add(lbTotal, 3, 0);
            tbOrder.Controls.Add(lbPhone, 1, 0);
            tbOrder.Controls.Add(btnView, 4, 0);
            tbOrder.Controls.Add(lbStatus, 2, 0);
            tbOrder.Controls.Add(lbID, 0, 0);
            fpContainer.SetFlowBreak(tbOrder, true);
            tbOrder.Location = new Point(3, 3);
            tbOrder.Name = "tbOrder";
            tbOrder.RowCount = 1;
            tbOrder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tbOrder.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbOrder.Size = new Size(431, 32);
            tbOrder.TabIndex = 1;
            // 
            // lbTotal
            // 
            lbTotal.Anchor = AnchorStyles.Left;
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(268, 8);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(40, 15);
            lbTotal.TabIndex = 3;
            lbTotal.Text = "$33.00";
            // 
            // lbPhone
            // 
            lbPhone.Anchor = AnchorStyles.Left;
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(55, 8);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(77, 15);
            lbPhone.TabIndex = 1;
            lbPhone.Text = "0123-456-789";
            // 
            // btnView
            // 
            btnView.Anchor = AnchorStyles.Left;
            btnView.Location = new Point(347, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(75, 23);
            btnView.TabIndex = 4;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // lbStatus
            // 
            lbStatus.Anchor = AnchorStyles.Left;
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbStatus.ForeColor = Color.Firebrick;
            lbStatus.Location = new Point(189, 8);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(30, 15);
            lbStatus.TabIndex = 2;
            lbStatus.Text = "Paid";
            // 
            // lbID
            // 
            lbID.Anchor = AnchorStyles.None;
            lbID.AutoSize = true;
            lbID.Location = new Point(19, 8);
            lbID.Name = "lbID";
            lbID.Size = new Size(13, 15);
            lbID.TabIndex = 0;
            lbID.Text = "1";
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Dock = DockStyle.Bottom;
            dgvOrderDetails.Location = new Point(3, 288);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.RowTemplate.Height = 25;
            dgvOrderDetails.Size = new Size(468, 173);
            dgvOrderDetails.TabIndex = 0;
            // 
            // tabPage2
            // 
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(10);
            tabPage2.Size = new Size(474, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Profile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbTitle_2
            // 
            lbTitle_2.Anchor = AnchorStyles.Top;
            lbTitle_2.AutoSize = true;
            lbTitle_2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle_2.Location = new Point(198, 25);
            lbTitle_2.Name = "lbTitle_2";
            lbTitle_2.Size = new Size(90, 32);
            lbTitle_2.TabIndex = 13;
            lbTitle_2.Text = "Profile";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(139, 278);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(287, 278);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(186, 231);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(188, 23);
            txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(186, 193);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtConfirm
            // 
            txtConfirm.Enabled = false;
            txtConfirm.Location = new Point(186, 156);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.PlaceholderText = "**********";
            txtConfirm.Size = new Size(188, 23);
            txtConfirm.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(186, 122);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "**********";
            txtPass.Size = new Size(188, 23);
            txtPass.TabIndex = 1;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(186, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 23);
            txtName.TabIndex = 0;
            // 
            // lbPhone_Pf
            // 
            lbPhone_Pf.AutoSize = true;
            lbPhone_Pf.Location = new Point(71, 234);
            lbPhone_Pf.Name = "lbPhone_Pf";
            lbPhone_Pf.Size = new Size(44, 15);
            lbPhone_Pf.TabIndex = 5;
            lbPhone_Pf.Text = "Phone:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(71, 196);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(44, 15);
            lbEmail.TabIndex = 4;
            lbEmail.Text = "E-mail:";
            // 
            // lbCPass
            // 
            lbCPass.AutoSize = true;
            lbCPass.Location = new Point(71, 159);
            lbCPass.Name = "lbCPass";
            lbCPass.Size = new Size(107, 15);
            lbCPass.TabIndex = 3;
            lbCPass.Text = "Confirm password:";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(71, 125);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(60, 15);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(71, 89);
            lbName.Name = "lbName";
            lbName.Size = new Size(63, 15);
            lbName.TabIndex = 1;
            lbName.Text = "Username:";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(10, 413);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(454, 41);
            btnLogout.TabIndex = 99;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.158844F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.841156F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLayoutPanel2.Controls.Add(label5, 3, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(110, 42);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 492);
            Controls.Add(tabControl1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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