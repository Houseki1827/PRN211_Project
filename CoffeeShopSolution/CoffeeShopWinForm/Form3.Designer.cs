namespace CoffeeShopWinForm {
    partial class Form3 {
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
            panel1 = new Panel();
            label1 = new Label();
            rbCoffee = new RadioButton();
            rbDessert = new RadioButton();
            picture = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            cbSelect = new ComboBox();
            tbPrice = new TextBox();
            numericQuantity = new NumericUpDown();
            tbTotal = new TextBox();
            dgvCart = new DataGridView();
            label6 = new Label();
            tbAmount = new TextBox();
            btnClear = new Button();
            btnSave = new Button();
            btnForm4 = new Button();
            tbItemId = new TextBox();
            lb2 = new Label();
            lbUsername = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 107);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(363, 25);
            label1.Name = "label1";
            label1.Size = new Size(292, 44);
            label1.TabIndex = 0;
            label1.Text = "COFFEE SHOP";
            // 
            // rbCoffee
            // 
            rbCoffee.AutoSize = true;
            rbCoffee.Location = new Point(55, 137);
            rbCoffee.Name = "rbCoffee";
            rbCoffee.Size = new Size(80, 20);
            rbCoffee.TabIndex = 1;
            rbCoffee.TabStop = true;
            rbCoffee.Text = "COFFEE";
            rbCoffee.UseVisualStyleBackColor = true;
            rbCoffee.CheckedChanged += rbCoffee_CheckedChanged;
            // 
            // rbDessert
            // 
            rbDessert.AutoSize = true;
            rbDessert.Location = new Point(203, 137);
            rbDessert.Name = "rbDessert";
            rbDessert.Size = new Size(90, 20);
            rbDessert.TabIndex = 2;
            rbDessert.TabStop = true;
            rbDessert.Text = "DESSERT";
            rbDessert.UseVisualStyleBackColor = true;
            rbDessert.CheckedChanged += rbDessert_CheckedChanged;
            // 
            // picture
            // 
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.Location = new Point(33, 187);
            picture.Name = "picture";
            picture.Size = new Size(300, 300);
            picture.SizeMode = PictureBoxSizeMode.CenterImage;
            picture.TabIndex = 3;
            picture.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 519);
            label2.Name = "label2";
            label2.Size = new Size(90, 16);
            label2.TabIndex = 4;
            label2.Text = "Select Items";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 564);
            label3.Name = "label3";
            label3.Size = new Size(50, 16);
            label3.TabIndex = 5;
            label3.Text = "Prices";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 607);
            label4.Name = "label4";
            label4.Size = new Size(64, 16);
            label4.TabIndex = 6;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 650);
            label5.Name = "label5";
            label5.Size = new Size(41, 16);
            label5.TabIndex = 7;
            label5.Text = "Total";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 709);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 40);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Items";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(203, 709);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 40);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Items";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbSelect
            // 
            cbSelect.FormattingEnabled = true;
            cbSelect.Location = new Point(149, 516);
            cbSelect.Name = "cbSelect";
            cbSelect.Size = new Size(184, 24);
            cbSelect.TabIndex = 10;
            cbSelect.SelectedIndexChanged += cbSelect_SelectedIndexChanged;
            // 
            // tbPrice
            // 
            tbPrice.BackColor = SystemColors.ButtonHighlight;
            tbPrice.Location = new Point(149, 561);
            tbPrice.Name = "tbPrice";
            tbPrice.ReadOnly = true;
            tbPrice.Size = new Size(184, 23);
            tbPrice.TabIndex = 11;
            // 
            // numericQuantity
            // 
            numericQuantity.Location = new Point(149, 605);
            numericQuantity.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(184, 23);
            numericQuantity.TabIndex = 12;
            numericQuantity.ValueChanged += numericQuantity_ValueChanged;
            // 
            // tbTotal
            // 
            tbTotal.BackColor = Color.White;
            tbTotal.Cursor = Cursors.IBeam;
            tbTotal.Location = new Point(149, 647);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(184, 23);
            tbTotal.TabIndex = 13;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(364, 187);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.RowTemplate.Height = 29;
            dgvCart.Size = new Size(662, 445);
            dgvCart.TabIndex = 15;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(908, 678);
            label6.Name = "label6";
            label6.Size = new Size(96, 16);
            label6.TabIndex = 16;
            label6.Text = "Total Amount";
            // 
            // tbAmount
            // 
            tbAmount.Cursor = Cursors.IBeam;
            tbAmount.ForeColor = Color.FromArgb(128, 64, 0);
            tbAmount.Location = new Point(908, 716);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(118, 23);
            tbAmount.TabIndex = 17;
            tbAmount.Text = "0";
            tbAmount.TextChanged += tbAmount_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(491, 709);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 40);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(674, 709);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 19;
            btnSave.Text = "Order";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnForm4
            // 
            btnForm4.Location = new Point(932, 129);
            btnForm4.Name = "btnForm4";
            btnForm4.Size = new Size(94, 40);
            btnForm4.TabIndex = 21;
            btnForm4.Text = "User";
            btnForm4.UseVisualStyleBackColor = true;
            btnForm4.Click += btnForm4_Click;
            // 
            // tbItemId
            // 
            tbItemId.BackColor = SystemColors.Control;
            tbItemId.Location = new Point(365, 647);
            tbItemId.Name = "tbItemId";
            tbItemId.Size = new Size(184, 23);
            tbItemId.TabIndex = 23;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(365, 139);
            lb2.Name = "lb2";
            lb2.Size = new Size(30, 16);
            lb2.TabIndex = 24;
            lb2.Text = "Hi, ";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbUsername.Location = new Point(391, 139);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(43, 17);
            lbUsername.TabIndex = 25;
            lbUsername.Text = "User";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 781);
            Controls.Add(lbUsername);
            Controls.Add(lb2);
            Controls.Add(tbItemId);
            Controls.Add(btnForm4);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(tbAmount);
            Controls.Add(label6);
            Controls.Add(dgvCart);
            Controls.Add(tbTotal);
            Controls.Add(numericQuantity);
            Controls.Add(tbPrice);
            Controls.Add(cbSelect);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(picture);
            Controls.Add(rbDessert);
            Controls.Add(rbCoffee);
            Controls.Add(panel1);
            Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RadioButton rbCoffee;
        private RadioButton rbDessert;
        private PictureBox picture;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Button btnDelete;
        private ComboBox cbSelect;
        private TextBox tbPrice;
        private NumericUpDown numericQuantity;
        private TextBox tbTotal;
        private DataGridView dgvCart;
        private Label label6;
        private TextBox tbAmount;
        private Button btnClear;
        private Button btnSave;
        private Button btnForm4;
        private TextBox tbItemId;
        private Label lb2;
        private Label lbUsername;
    }
}