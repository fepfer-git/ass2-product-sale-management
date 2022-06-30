
namespace SalesWinApp
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboSearchFilter = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListProducts = new System.Windows.Forms.DataGridView();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvListMember = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label223 = new System.Windows.Forms.Label();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnLoadMember = new System.Windows.Forms.Button();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnLoadOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtMemberOrderID = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.dgvListOrder = new System.Windows.Forms.DataGridView();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.lbTotalPriceAfterDiscount = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbTotalProduct = new System.Windows.Forms.Label();
            this.btnLoadStatistic = new System.Windows.Forms.Button();
            this.btnCancelStatistics = new System.Windows.Forms.Button();
            this.lbTotalOrder = new System.Windows.Forms.Label();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).BeginInit();
            this.tabMembers.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMember)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabOrder.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrder)).BeginInit();
            this.tabStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProducts);
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Controls.Add(this.tabOrder);
            this.tabControl1.Controls.Add(this.tabStatistics);
            this.tabControl1.Location = new System.Drawing.Point(15, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 699);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.panel2);
            this.tabProducts.Controls.Add(this.panel1);
            this.tabProducts.Location = new System.Drawing.Point(4, 29);
            this.tabProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabProducts.Size = new System.Drawing.Size(878, 666);
            this.tabProducts.TabIndex = 0;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtCategoryID);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cboSearchFilter);
            this.panel2.Controls.Add(this.txtSearchBox);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtProductID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtWeight);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(864, 331);
            this.panel2.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label22.Location = new System.Drawing.Point(271, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(320, 39);
            this.label22.TabIndex = 34;
            this.label22.Text = "Product Management";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(144, 141);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(275, 27);
            this.txtCategoryID.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(5, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 28);
            this.label14.TabIndex = 32;
            this.label14.Text = "Search By";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(458, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 28);
            this.label13.TabIndex = 31;
            this.label13.Text = "Search Box";
            // 
            // cboSearchFilter
            // 
            this.cboSearchFilter.FormattingEnabled = true;
            this.cboSearchFilter.Items.AddRange(new object[] {
            "ProductName",
            "ProductID",
            "Price",
            "Stock"});
            this.cboSearchFilter.Location = new System.Drawing.Point(144, 285);
            this.cboSearchFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSearchFilter.Name = "cboSearchFilter";
            this.cboSearchFilter.Size = new System.Drawing.Size(275, 28);
            this.cboSearchFilter.TabIndex = 30;
            this.cboSearchFilter.SelectedIndexChanged += new System.EventHandler(this.cboSearchFilter_SelectedIndexChanged);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(571, 285);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(275, 27);
            this.txtSearchBox.TabIndex = 28;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(333, 215);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 31);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(238, 215);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(143, 215);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 31);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClose.Location = new System.Drawing.Point(5, 215);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "CategoryId";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(144, 180);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(275, 27);
            this.txtProductName.TabIndex = 11;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(144, 101);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(275, 27);
            this.txtProductID.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "ProductId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(458, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(458, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(571, 173);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(275, 27);
            this.txtStock.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(571, 136);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(275, 27);
            this.txtPrice.TabIndex = 4;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(571, 97);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(275, 27);
            this.txtWeight.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(458, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListProducts);
            this.panel1.Location = new System.Drawing.Point(5, 343);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 315);
            this.panel1.TabIndex = 0;
            // 
            // dgvListProducts
            // 
            this.dgvListProducts.AllowUserToAddRows = false;
            this.dgvListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProducts.Location = new System.Drawing.Point(2, 4);
            this.dgvListProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListProducts.Name = "dgvListProducts";
            this.dgvListProducts.RowHeadersWidth = 51;
            this.dgvListProducts.RowTemplate.Height = 25;
            this.dgvListProducts.Size = new System.Drawing.Size(862, 307);
            this.dgvListProducts.TabIndex = 0;
            this.dgvListProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProducts_CellDoubleClick);
            // 
            // tabMembers
            // 
            this.tabMembers.Controls.Add(this.panel4);
            this.tabMembers.Controls.Add(this.panel3);
            this.tabMembers.Location = new System.Drawing.Point(4, 29);
            this.tabMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMembers.Size = new System.Drawing.Size(878, 666);
            this.tabMembers.TabIndex = 1;
            this.tabMembers.Text = "Members";
            this.tabMembers.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvListMember);
            this.panel4.Location = new System.Drawing.Point(11, 327);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(858, 327);
            this.panel4.TabIndex = 4;
            // 
            // dgvListMember
            // 
            this.dgvListMember.AllowUserToAddRows = false;
            this.dgvListMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMember.Location = new System.Drawing.Point(3, 4);
            this.dgvListMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListMember.Name = "dgvListMember";
            this.dgvListMember.RowHeadersWidth = 51;
            this.dgvListMember.RowTemplate.Height = 25;
            this.dgvListMember.Size = new System.Drawing.Size(851, 319);
            this.dgvListMember.TabIndex = 0;
            this.dgvListMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListMember_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label223);
            this.panel3.Controls.Add(this.btnNewMember);
            this.panel3.Controls.Add(this.btnDeleteMember);
            this.panel3.Controls.Add(this.btnLoadMember);
            this.panel3.Controls.Add(this.btnClose1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtMemberID);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtCompanyName);
            this.panel3.Controls.Add(this.txtCountry);
            this.panel3.Controls.Add(this.txtCity);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(11, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(858, 311);
            this.panel3.TabIndex = 3;
            // 
            // label223
            // 
            this.label223.AutoSize = true;
            this.label223.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label223.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label223.Location = new System.Drawing.Point(248, 36);
            this.label223.Name = "label223";
            this.label223.Size = new System.Drawing.Size(338, 39);
            this.label223.TabIndex = 19;
            this.label223.Text = "Member Mamagement";
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(155, 269);
            this.btnNewMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(86, 31);
            this.btnNewMember.TabIndex = 17;
            this.btnNewMember.Text = "New";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(248, 269);
            this.btnDeleteMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(86, 31);
            this.btnDeleteMember.TabIndex = 16;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnLoadMember
            // 
            this.btnLoadMember.Location = new System.Drawing.Point(341, 269);
            this.btnLoadMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadMember.Name = "btnLoadMember";
            this.btnLoadMember.Size = new System.Drawing.Size(86, 31);
            this.btnLoadMember.TabIndex = 15;
            this.btnLoadMember.Text = "Load";
            this.btnLoadMember.UseVisualStyleBackColor = true;
            this.btnLoadMember.Click += new System.EventHandler(this.btnLoadMember_Click);
            // 
            // btnClose1
            // 
            this.btnClose1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClose1.Location = new System.Drawing.Point(2, 269);
            this.btnClose1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(86, 31);
            this.btnClose1.TabIndex = 14;
            this.btnClose1.Text = "Close";
            this.btnClose1.UseVisualStyleBackColor = false;
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(446, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(446, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(597, 203);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(230, 27);
            this.txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(597, 164);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(230, 27);
            this.txtEmail.TabIndex = 10;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(597, 125);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(230, 27);
            this.txtMemberID.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(446, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "MemberID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Company Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(11, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Country";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(161, 201);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(230, 27);
            this.txtCompanyName.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(161, 163);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(230, 27);
            this.txtCountry.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(161, 123);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(230, 27);
            this.txtCity.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(11, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "City";
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.label21);
            this.tabOrder.Controls.Add(this.btnClose2);
            this.tabOrder.Controls.Add(this.panel6);
            this.tabOrder.Controls.Add(this.label20);
            this.tabOrder.Controls.Add(this.label19);
            this.tabOrder.Controls.Add(this.label18);
            this.tabOrder.Controls.Add(this.label17);
            this.tabOrder.Controls.Add(this.label16);
            this.tabOrder.Controls.Add(this.label15);
            this.tabOrder.Controls.Add(this.txtRequiredDate);
            this.tabOrder.Controls.Add(this.txtOrderDate);
            this.tabOrder.Controls.Add(this.txtFreight);
            this.tabOrder.Controls.Add(this.txtShippedDate);
            this.tabOrder.Controls.Add(this.txtMemberOrderID);
            this.tabOrder.Controls.Add(this.txtOrderID);
            this.tabOrder.Controls.Add(this.dgvListOrder);
            this.tabOrder.Location = new System.Drawing.Point(4, 29);
            this.tabOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabOrder.Size = new System.Drawing.Size(878, 666);
            this.tabOrder.TabIndex = 2;
            this.tabOrder.Text = "Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(283, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(292, 39);
            this.label21.TabIndex = 18;
            this.label21.Text = "Order Management";
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClose2.Location = new System.Drawing.Point(6, 305);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(94, 29);
            this.btnClose2.TabIndex = 16;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnUpdateOrder);
            this.panel6.Controls.Add(this.btnLoadOrder);
            this.panel6.Controls.Add(this.btnDeleteOrder);
            this.panel6.Controls.Add(this.btnAddOrder);
            this.panel6.Location = new System.Drawing.Point(141, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(395, 61);
            this.panel6.TabIndex = 17;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(200, 19);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(94, 29);
            this.btnUpdateOrder.TabIndex = 16;
            this.btnUpdateOrder.Text = "Update";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnLoadOrder
            // 
            this.btnLoadOrder.Location = new System.Drawing.Point(299, 19);
            this.btnLoadOrder.Name = "btnLoadOrder";
            this.btnLoadOrder.Size = new System.Drawing.Size(94, 29);
            this.btnLoadOrder.TabIndex = 15;
            this.btnLoadOrder.Text = "Load";
            this.btnLoadOrder.UseVisualStyleBackColor = true;
            this.btnLoadOrder.Click += new System.EventHandler(this.btnLoadOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(101, 19);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteOrder.TabIndex = 14;
            this.btnDeleteOrder.Text = "Delete";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(0, 19);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(94, 29);
            this.btnAddOrder.TabIndex = 13;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(482, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(132, 25);
            this.label20.TabIndex = 12;
            this.label20.Text = "Required Date";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(482, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 25);
            this.label19.TabIndex = 11;
            this.label19.Text = "Shipped Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(482, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 25);
            this.label18.TabIndex = 10;
            this.label18.Text = "Freight";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(6, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 25);
            this.label17.TabIndex = 9;
            this.label17.Text = "Order Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(5, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 25);
            this.label16.TabIndex = 8;
            this.label16.Text = "Member ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(6, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "Order ID";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(649, 120);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(223, 27);
            this.txtRequiredDate.TabIndex = 6;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(139, 227);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(223, 27);
            this.txtOrderDate.TabIndex = 5;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(650, 227);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(222, 27);
            this.txtFreight.TabIndex = 4;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(649, 172);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.ReadOnly = true;
            this.txtShippedDate.Size = new System.Drawing.Size(223, 27);
            this.txtShippedDate.TabIndex = 3;
            // 
            // txtMemberOrderID
            // 
            this.txtMemberOrderID.Location = new System.Drawing.Point(141, 172);
            this.txtMemberOrderID.Name = "txtMemberOrderID";
            this.txtMemberOrderID.ReadOnly = true;
            this.txtMemberOrderID.Size = new System.Drawing.Size(222, 27);
            this.txtMemberOrderID.TabIndex = 2;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(139, 120);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(223, 27);
            this.txtOrderID.TabIndex = 1;
            // 
            // dgvListOrder
            // 
            this.dgvListOrder.AllowUserToAddRows = false;
            this.dgvListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOrder.Location = new System.Drawing.Point(5, 355);
            this.dgvListOrder.Name = "dgvListOrder";
            this.dgvListOrder.RowHeadersWidth = 51;
            this.dgvListOrder.RowTemplate.Height = 29;
            this.dgvListOrder.Size = new System.Drawing.Size(871, 305);
            this.dgvListOrder.TabIndex = 0;
            this.dgvListOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListOrder_CellDoubleClick);
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.lbTotalPriceAfterDiscount);
            this.tabStatistics.Controls.Add(this.label25);
            this.tabStatistics.Controls.Add(this.label24);
            this.tabStatistics.Controls.Add(this.label23);
            this.tabStatistics.Controls.Add(this.dtpFrom);
            this.tabStatistics.Controls.Add(this.lbTotalPrice);
            this.tabStatistics.Controls.Add(this.lbTotalProduct);
            this.tabStatistics.Controls.Add(this.btnLoadStatistic);
            this.tabStatistics.Controls.Add(this.btnCancelStatistics);
            this.tabStatistics.Controls.Add(this.lbTotalOrder);
            this.tabStatistics.Controls.Add(this.dgvStatistic);
            this.tabStatistics.Controls.Add(this.dtpTo);
            this.tabStatistics.Location = new System.Drawing.Point(4, 29);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(878, 666);
            this.tabStatistics.TabIndex = 3;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // lbTotalPriceAfterDiscount
            // 
            this.lbTotalPriceAfterDiscount.AutoSize = true;
            this.lbTotalPriceAfterDiscount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalPriceAfterDiscount.Location = new System.Drawing.Point(475, 139);
            this.lbTotalPriceAfterDiscount.Name = "lbTotalPriceAfterDiscount";
            this.lbTotalPriceAfterDiscount.Size = new System.Drawing.Size(272, 31);
            this.lbTotalPriceAfterDiscount.TabIndex = 11;
            this.lbTotalPriceAfterDiscount.Text = "Total price after discount:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label25.Location = new System.Drawing.Point(199, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(540, 43);
            this.label25.TabIndex = 10;
            this.label25.Text = "Order statistics management";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(272, 276);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 28);
            this.label24.TabIndex = 9;
            this.label24.Text = "To:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(272, 244);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 28);
            this.label23.TabIndex = 8;
            this.label23.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(344, 244);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(256, 27);
            this.dtpFrom.TabIndex = 7;
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalPrice.Location = new System.Drawing.Point(475, 96);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(125, 31);
            this.lbTotalPrice.TabIndex = 6;
            this.lbTotalPrice.Text = "Total price:";
            // 
            // lbTotalProduct
            // 
            this.lbTotalProduct.AutoSize = true;
            this.lbTotalProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalProduct.Location = new System.Drawing.Point(166, 139);
            this.lbTotalProduct.Name = "lbTotalProduct";
            this.lbTotalProduct.Size = new System.Drawing.Size(165, 31);
            this.lbTotalProduct.TabIndex = 5;
            this.lbTotalProduct.Text = "Total products:";
            // 
            // btnLoadStatistic
            // 
            this.btnLoadStatistic.Location = new System.Drawing.Point(477, 310);
            this.btnLoadStatistic.Name = "btnLoadStatistic";
            this.btnLoadStatistic.Size = new System.Drawing.Size(94, 29);
            this.btnLoadStatistic.TabIndex = 4;
            this.btnLoadStatistic.Text = "Load";
            this.btnLoadStatistic.UseVisualStyleBackColor = true;
            this.btnLoadStatistic.Click += new System.EventHandler(this.btnLoadStatistic_Click);
            // 
            // btnCancelStatistics
            // 
            this.btnCancelStatistics.Location = new System.Drawing.Point(368, 310);
            this.btnCancelStatistics.Name = "btnCancelStatistics";
            this.btnCancelStatistics.Size = new System.Drawing.Size(94, 29);
            this.btnCancelStatistics.TabIndex = 3;
            this.btnCancelStatistics.Text = "Close";
            this.btnCancelStatistics.UseVisualStyleBackColor = true;
            this.btnCancelStatistics.Click += new System.EventHandler(this.btnCancelStatistics_Click);
            // 
            // lbTotalOrder
            // 
            this.lbTotalOrder.AutoSize = true;
            this.lbTotalOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalOrder.Location = new System.Drawing.Point(166, 96);
            this.lbTotalOrder.Name = "lbTotalOrder";
            this.lbTotalOrder.Size = new System.Drawing.Size(145, 31);
            this.lbTotalOrder.TabIndex = 2;
            this.lbTotalOrder.Text = "Total orders: ";
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Location = new System.Drawing.Point(6, 372);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.RowHeadersWidth = 51;
            this.dgvStatistic.RowTemplate.Height = 29;
            this.dgvStatistic.Size = new System.Drawing.Size(866, 288);
            this.dgvStatistic.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(344, 277);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(256, 27);
            this.dtpTo.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 732);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProducts)).EndInit();
            this.tabMembers.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMember)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrder)).EndInit();
            this.tabStatistics.ResumeLayout(false);
            this.tabStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListProducts;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboSearchFilter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvListMember;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnLoadMember;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLoadOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtMemberOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DataGridView dgvListOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label223;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbTotalProduct;
        private System.Windows.Forms.Button btnLoadStatistic;
        private System.Windows.Forms.Button btnCancelStatistics;
        private System.Windows.Forms.Label lbTotalOrder;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lbTotalPriceAfterDiscount;
    }
}