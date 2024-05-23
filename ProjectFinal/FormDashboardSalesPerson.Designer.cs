namespace ProjectFinal
{
    partial class FormDashboardSalesPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboardSalesPerson));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.btnConfirmCart = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.IId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IModelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IStockStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.pnlUpdateAmount = new System.Windows.Forms.Panel();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.lblExchange = new System.Windows.Forms.Label();
            this.btnEnterCart = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnEnteritem = new System.Windows.Forms.Button();
            this.txtEnterAmount = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblAvailableAmount = new System.Windows.Forms.Label();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblUserCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.lblInstruction6 = new System.Windows.Forms.Label();
            this.lblInstruction5 = new System.Windows.Forms.Label();
            this.lblInstruction4 = new System.Windows.Forms.Label();
            this.lblInstruction3 = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.pnlDesc = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowBills = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.pnlPrice.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlUpdateAmount.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDesc.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCart);
            this.panel1.Controls.Add(this.dgvItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 290);
            this.panel1.TabIndex = 0;
            // 
            // pnlCart
            // 
            this.pnlCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCart.Controls.Add(this.btnConfirmCart);
            this.pnlCart.Controls.Add(this.btnRemoveSelected);
            this.pnlCart.Controls.Add(this.btnUpdateSelected);
            this.pnlCart.Controls.Add(this.dgvCart);
            this.pnlCart.Controls.Add(this.label1);
            this.pnlCart.Location = new System.Drawing.Point(609, 6);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(471, 284);
            this.pnlCart.TabIndex = 1;
            // 
            // btnConfirmCart
            // 
            this.btnConfirmCart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCart.Location = new System.Drawing.Point(6, 244);
            this.btnConfirmCart.Name = "btnConfirmCart";
            this.btnConfirmCart.Size = new System.Drawing.Size(460, 35);
            this.btnConfirmCart.TabIndex = 5;
            this.btnConfirmCart.Text = "Confirm cart and send receipt";
            this.btnConfirmCart.UseVisualStyleBackColor = true;
            this.btnConfirmCart.Click += new System.EventHandler(this.btnConfirmCart_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.Location = new System.Drawing.Point(381, 132);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(84, 64);
            this.btnRemoveSelected.TabIndex = 4;
            this.btnRemoveSelected.Text = "Remove selected row";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSelected.Location = new System.Drawing.Point(381, 76);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(84, 50);
            this.btnUpdateSelected.TabIndex = 2;
            this.btnUpdateSelected.Text = "Add items to selected row";
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CartType,
            this.CartManufacturer,
            this.CartModel,
            this.CartAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.GridColor = System.Drawing.Color.Lime;
            this.dgvCart.Location = new System.Drawing.Point(6, 32);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvCart.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCart.Size = new System.Drawing.Size(370, 206);
            this.dgvCart.TabIndex = 1;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            this.dgvCart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Lime;
            this.Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id.HeaderText = "ItemId";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // CartType
            // 
            this.CartType.DataPropertyName = "Type";
            this.CartType.HeaderText = "Type";
            this.CartType.Name = "CartType";
            this.CartType.ReadOnly = true;
            this.CartType.Width = 60;
            // 
            // CartManufacturer
            // 
            this.CartManufacturer.DataPropertyName = "Manufacturer";
            this.CartManufacturer.HeaderText = "Manufacturer";
            this.CartManufacturer.Name = "CartManufacturer";
            this.CartManufacturer.ReadOnly = true;
            this.CartManufacturer.Width = 90;
            // 
            // CartModel
            // 
            this.CartModel.DataPropertyName = "Model";
            this.CartModel.HeaderText = "Model";
            this.CartModel.Name = "CartModel";
            this.CartModel.ReadOnly = true;
            this.CartModel.Width = 90;
            // 
            // CartAmount
            // 
            this.CartAmount.DataPropertyName = "Amount";
            this.CartAmount.HeaderText = "Amount";
            this.CartAmount.Name = "CartAmount";
            this.CartAmount.ReadOnly = true;
            this.CartAmount.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shopping Cart";
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.BackgroundColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IId,
            this.IType,
            this.IBrand,
            this.IModelNo,
            this.IPrice,
            this.IStockStatus});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvItem.GridColor = System.Drawing.Color.Yellow;
            this.dgvItem.Location = new System.Drawing.Point(0, 3);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersVisible = false;
            this.dgvItem.Size = new System.Drawing.Size(603, 284);
            this.dgvItem.TabIndex = 0;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            this.dgvItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellDoubleClick);
            this.dgvItem.Click += new System.EventHandler(this.dgvItem_Click);
            // 
            // IId
            // 
            this.IId.DataPropertyName = "IId";
            this.IId.HeaderText = "Item Id";
            this.IId.Name = "IId";
            this.IId.ReadOnly = true;
            this.IId.Width = 80;
            // 
            // IType
            // 
            this.IType.DataPropertyName = "IType";
            this.IType.HeaderText = "Type";
            this.IType.Name = "IType";
            this.IType.ReadOnly = true;
            this.IType.Width = 90;
            // 
            // IBrand
            // 
            this.IBrand.DataPropertyName = "IBrand";
            this.IBrand.HeaderText = "Manufacturer";
            this.IBrand.Name = "IBrand";
            this.IBrand.ReadOnly = true;
            // 
            // IModelNo
            // 
            this.IModelNo.DataPropertyName = "IModelNo";
            this.IModelNo.HeaderText = "Model";
            this.IModelNo.Name = "IModelNo";
            this.IModelNo.ReadOnly = true;
            this.IModelNo.Width = 120;
            // 
            // IPrice
            // 
            this.IPrice.DataPropertyName = "IPrice";
            this.IPrice.HeaderText = "Price (BDT)";
            this.IPrice.Name = "IPrice";
            this.IPrice.ReadOnly = true;
            this.IPrice.Width = 110;
            // 
            // IStockStatus
            // 
            this.IStockStatus.DataPropertyName = "IStockStatus";
            this.IStockStatus.HeaderText = "Amount";
            this.IStockStatus.Name = "IStockStatus";
            this.IStockStatus.ReadOnly = true;
            // 
            // pnlPrice
            // 
            this.pnlPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrice.Controls.Add(this.lblFinalPrice);
            this.pnlPrice.Controls.Add(this.txtDiscount);
            this.pnlPrice.Controls.Add(this.label4);
            this.pnlPrice.Controls.Add(this.lblTotalPrice);
            this.pnlPrice.Controls.Add(this.lblTotalItems);
            this.pnlPrice.Location = new System.Drawing.Point(609, 309);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(471, 70);
            this.pnlPrice.TabIndex = 3;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.Location = new System.Drawing.Point(231, 43);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(132, 19);
            this.lblFinalPrice.TabIndex = 4;
            this.lblFinalPrice.Text = "Final Price (BDT):";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(360, 13);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(101, 20);
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Discount (%):";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(2, 43);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(133, 19);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "Total Price (BDT):";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(2, 13);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(90, 19);
            this.lblTotalItems.TabIndex = 0;
            this.lblTotalItems.Text = "Total Items:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cbSearch);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Location = new System.Drawing.Point(4, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(599, 47);
            this.panel4.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(424, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "(Automated Searchbox)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Keyword:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Search by:";
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "itemId",
            "type",
            "brand",
            "model",
            "price"});
            this.cbSearch.Location = new System.Drawing.Point(94, 13);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(100, 21);
            this.cbSearch.TabIndex = 2;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(318, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction1.Location = new System.Drawing.Point(3, 49);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(305, 18);
            this.lblInstruction1.TabIndex = 0;
            this.lblInstruction1.Text = "-> Click on \'itemId\' column to add item to cart.";
            // 
            // pnlUpdateAmount
            // 
            this.pnlUpdateAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateAmount.Controls.Add(this.btnCancelUpdate);
            this.pnlUpdateAmount.Controls.Add(this.lblExchange);
            this.pnlUpdateAmount.Controls.Add(this.btnEnterCart);
            this.pnlUpdateAmount.Controls.Add(this.lblItem);
            this.pnlUpdateAmount.Controls.Add(this.btnEnteritem);
            this.pnlUpdateAmount.Controls.Add(this.txtEnterAmount);
            this.pnlUpdateAmount.Controls.Add(this.lblEnter);
            this.pnlUpdateAmount.Controls.Add(this.lblAvailableAmount);
            this.pnlUpdateAmount.Location = new System.Drawing.Point(333, 93);
            this.pnlUpdateAmount.Name = "pnlUpdateAmount";
            this.pnlUpdateAmount.Size = new System.Drawing.Size(326, 210);
            this.pnlUpdateAmount.TabIndex = 10;
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelUpdate.Location = new System.Drawing.Point(174, 151);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(100, 32);
            this.btnCancelUpdate.TabIndex = 7;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // lblExchange
            // 
            this.lblExchange.AutoSize = true;
            this.lblExchange.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchange.Location = new System.Drawing.Point(18, 4);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(130, 19);
            this.lblExchange.TabIndex = 6;
            this.lblExchange.Text = "Exchanging items ";
            // 
            // btnEnterCart
            // 
            this.btnEnterCart.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterCart.Location = new System.Drawing.Point(47, 151);
            this.btnEnterCart.Name = "btnEnterCart";
            this.btnEnterCart.Size = new System.Drawing.Size(100, 32);
            this.btnEnterCart.TabIndex = 5;
            this.btnEnterCart.Text = "Enter";
            this.btnEnterCart.UseVisualStyleBackColor = true;
            this.btnEnterCart.Click += new System.EventHandler(this.btnEnterCart_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(12, 46);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(49, 19);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item: ";
            // 
            // btnEnteritem
            // 
            this.btnEnteritem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEnteritem.Location = new System.Drawing.Point(47, 151);
            this.btnEnteritem.Name = "btnEnteritem";
            this.btnEnteritem.Size = new System.Drawing.Size(100, 32);
            this.btnEnteritem.TabIndex = 3;
            this.btnEnteritem.Text = "Enter";
            this.btnEnteritem.UseVisualStyleBackColor = true;
            this.btnEnteritem.Click += new System.EventHandler(this.btnEnterItem_Click);
            // 
            // txtEnterAmount
            // 
            this.txtEnterAmount.Location = new System.Drawing.Point(128, 110);
            this.txtEnterAmount.Name = "txtEnterAmount";
            this.txtEnterAmount.Size = new System.Drawing.Size(139, 20);
            this.txtEnterAmount.TabIndex = 2;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(12, 110);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(110, 19);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Enter Amount: ";
            // 
            // lblAvailableAmount
            // 
            this.lblAvailableAmount.AutoSize = true;
            this.lblAvailableAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableAmount.Location = new System.Drawing.Point(12, 78);
            this.lblAvailableAmount.Name = "lblAvailableAmount";
            this.lblAvailableAmount.Size = new System.Drawing.Size(133, 19);
            this.lblAvailableAmount.TabIndex = 0;
            this.lblAvailableAmount.Text = "Available amount: ";
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUserInfo.Controls.Add(this.btnShowBills);
            this.pnlUserInfo.Controls.Add(this.btnLogout);
            this.pnlUserInfo.Controls.Add(this.btnUpdatePassword);
            this.pnlUserInfo.Controls.Add(this.label3);
            this.pnlUserInfo.Controls.Add(this.label8);
            this.pnlUserInfo.Controls.Add(this.label9);
            this.pnlUserInfo.Controls.Add(this.label10);
            this.pnlUserInfo.Controls.Add(this.lblCurrentTime);
            this.pnlUserInfo.Controls.Add(this.lblUserCategory);
            this.pnlUserInfo.Controls.Add(this.lblName);
            this.pnlUserInfo.Controls.Add(this.lblId);
            this.pnlUserInfo.Controls.Add(this.label2);
            this.pnlUserInfo.Location = new System.Drawing.Point(4, 5);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(323, 298);
            this.pnlUserInfo.TabIndex = 11;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(102, 251);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 37);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(42, 208);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(112, 37);
            this.btnUpdatePassword.TabIndex = 9;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "User category:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "ID:";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(121, 163);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(47, 17);
            this.lblCurrentTime.TabIndex = 4;
            this.lblCurrentTime.Text = "label3";
            // 
            // lblUserCategory
            // 
            this.lblUserCategory.AutoSize = true;
            this.lblUserCategory.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCategory.Location = new System.Drawing.Point(121, 130);
            this.lblUserCategory.Name = "lblUserCategory";
            this.lblUserCategory.Size = new System.Drawing.Size(47, 17);
            this.lblUserCategory.TabIndex = 3;
            this.lblUserCategory.Text = "label3";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(121, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label3";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(121, 64);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(47, 17);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.lblInstruction6);
            this.panel2.Controls.Add(this.lblInstruction5);
            this.panel2.Controls.Add(this.lblInstruction4);
            this.panel2.Controls.Add(this.lblInstruction3);
            this.panel2.Controls.Add(this.lblInstruction2);
            this.panel2.Controls.Add(this.lblInstruction1);
            this.panel2.Location = new System.Drawing.Point(665, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 298);
            this.panel2.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Corbel", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(151, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 26);
            this.label18.TabIndex = 6;
            this.label18.Text = "Instructions";
            // 
            // lblInstruction6
            // 
            this.lblInstruction6.AutoSize = true;
            this.lblInstruction6.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction6.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction6.Location = new System.Drawing.Point(5, 237);
            this.lblInstruction6.Name = "lblInstruction6";
            this.lblInstruction6.Size = new System.Drawing.Size(413, 18);
            this.lblInstruction6.TabIndex = 5;
            this.lblInstruction6.Text = "After finalizing, press \'Confirm cart\' button to store transaction";
            // 
            // lblInstruction5
            // 
            this.lblInstruction5.AutoSize = true;
            this.lblInstruction5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction5.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction5.Location = new System.Drawing.Point(5, 209);
            this.lblInstruction5.Name = "lblInstruction5";
            this.lblInstruction5.Size = new System.Drawing.Size(386, 18);
            this.lblInstruction5.TabIndex = 4;
            this.lblInstruction5.Text = "Can apply discounts if applicable using the textfield below.";
            // 
            // lblInstruction4
            // 
            this.lblInstruction4.AutoSize = true;
            this.lblInstruction4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction4.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction4.Location = new System.Drawing.Point(5, 165);
            this.lblInstruction4.Name = "lblInstruction4";
            this.lblInstruction4.Size = new System.Drawing.Size(561, 18);
            this.lblInstruction4.TabIndex = 3;
            this.lblInstruction4.Text = "-> Double <br/> clicking \'itemId\' to add multiple amounts of an item back to inve" +
    "ntory.";
            // 
            // lblInstruction3
            // 
            this.lblInstruction3.AutoSize = true;
            this.lblInstruction3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction3.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction3.Location = new System.Drawing.Point(5, 123);
            this.lblInstruction3.Name = "lblInstruction3";
            this.lblInstruction3.Size = new System.Drawing.Size(563, 18);
            this.lblInstruction3.TabIndex = 2;
            this.lblInstruction3.Text = "Clicking on the \'itemId\' column of the cart will move the item back to inventory " +
    "1 by 1. ";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.ForeColor = System.Drawing.Color.Red;
            this.lblInstruction2.Location = new System.Drawing.Point(5, 80);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(488, 18);
            this.lblInstruction2.TabIndex = 1;
            this.lblInstruction2.Text = "-> Double <br/> clicking \'itemId\' to add multiple amounts of an item to cart";
            // 
            // pnlDesc
            // 
            this.pnlDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDesc.Controls.Add(this.lblDesc);
            this.pnlDesc.Location = new System.Drawing.Point(333, 5);
            this.pnlDesc.Name = "pnlDesc";
            this.pnlDesc.Size = new System.Drawing.Size(329, 82);
            this.pnlDesc.TabIndex = 13;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.Blue;
            this.lblDesc.Location = new System.Drawing.Point(43, 30);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(125, 23);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Salesperson";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Items List";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(184, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 21);
            this.panel3.TabIndex = 15;
            // 
            // btnShowBills
            // 
            this.btnShowBills.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBills.Location = new System.Drawing.Point(160, 208);
            this.btnShowBills.Name = "btnShowBills";
            this.btnShowBills.Size = new System.Drawing.Size(112, 37);
            this.btnShowBills.TabIndex = 11;
            this.btnShowBills.Text = "Show bills";
            this.btnShowBills.UseVisualStyleBackColor = true;
            this.btnShowBills.Click += new System.EventHandler(this.btnShowBills_Click);
            // 
            // FormDashboardSalesPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlDesc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.pnlUpdateAmount);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlPrice);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDashboardSalesPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesperson dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDashboardSalesPerson_FormClosed);
            this.Load += new System.EventHandler(this.FormDashboardSalesPerson_Load);
            this.panel1.ResumeLayout(false);
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.pnlPrice.ResumeLayout(false);
            this.pnlPrice.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlUpdateAmount.ResumeLayout(false);
            this.pnlUpdateAmount.PerformLayout();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDesc.ResumeLayout(false);
            this.pnlDesc.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnConfirmCart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlUpdateAmount;
        private System.Windows.Forms.Button btnEnteritem;
        private System.Windows.Forms.TextBox txtEnterAmount;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblAvailableAmount;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnEnterCart;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblUserCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblExchange;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Label lblInstruction3;
        private System.Windows.Forms.Label lblInstruction4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblInstruction6;
        private System.Windows.Forms.Label lblInstruction5;
        private System.Windows.Forms.Panel pnlDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IId;
        private System.Windows.Forms.DataGridViewTextBoxColumn IType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn IModelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn IStockStatus;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnShowBills;
    }
}

