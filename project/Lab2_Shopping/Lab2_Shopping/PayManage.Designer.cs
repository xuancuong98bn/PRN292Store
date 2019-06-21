namespace Lab2_Shopping
{
    partial class PayManage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPayAll = new System.Windows.Forms.Button();
            this.btnPayProduct = new System.Windows.Forms.Button();
            this.groupBoxInfor = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radPaidAProduct = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtDateBuy = new System.Windows.Forms.TextBox();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblBillCode = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.comProductName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.dataGridBill = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblListView = new System.Windows.Forms.Label();
            this.groupBoxInfor.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(306, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THANH TOÁN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(140, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Quay lại";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPayAll
            // 
            this.btnPayAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnPayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayAll.ForeColor = System.Drawing.Color.Red;
            this.btnPayAll.Location = new System.Drawing.Point(113, 385);
            this.btnPayAll.Name = "btnPayAll";
            this.btnPayAll.Size = new System.Drawing.Size(163, 25);
            this.btnPayAll.TabIndex = 5;
            this.btnPayAll.Text = "Thanh toán toàn bộ";
            this.btnPayAll.UseVisualStyleBackColor = false;
            this.btnPayAll.Click += new System.EventHandler(this.btnPayAll_Click);
            // 
            // btnPayProduct
            // 
            this.btnPayProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnPayProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayProduct.ForeColor = System.Drawing.Color.Red;
            this.btnPayProduct.Location = new System.Drawing.Point(6, 336);
            this.btnPayProduct.Name = "btnPayProduct";
            this.btnPayProduct.Size = new System.Drawing.Size(177, 25);
            this.btnPayProduct.TabIndex = 4;
            this.btnPayProduct.Text = "Thanh toán mặt hàng này";
            this.btnPayProduct.UseVisualStyleBackColor = false;
            this.btnPayProduct.Click += new System.EventHandler(this.btnPayAProduct_Click);
            // 
            // groupBoxInfor
            // 
            this.groupBoxInfor.Controls.Add(this.panel1);
            this.groupBoxInfor.Controls.Add(this.txtAmount);
            this.groupBoxInfor.Controls.Add(this.lblAmount);
            this.groupBoxInfor.Controls.Add(this.txtDateBuy);
            this.groupBoxInfor.Controls.Add(this.btnPayProduct);
            this.groupBoxInfor.Controls.Add(this.txtBillCode);
            this.groupBoxInfor.Controls.Add(this.lblBillDate);
            this.groupBoxInfor.Controls.Add(this.lblBillCode);
            this.groupBoxInfor.Controls.Add(this.txtQuantity);
            this.groupBoxInfor.Controls.Add(this.lblQuantity);
            this.groupBoxInfor.Controls.Add(this.txtCustomerName);
            this.groupBoxInfor.Controls.Add(this.lblPrice);
            this.groupBoxInfor.Controls.Add(this.txtPrice);
            this.groupBoxInfor.Controls.Add(this.txtAddress);
            this.groupBoxInfor.Controls.Add(this.lblProduct);
            this.groupBoxInfor.Controls.Add(this.txtCustomerCode);
            this.groupBoxInfor.Controls.Add(this.comProductName);
            this.groupBoxInfor.Controls.Add(this.lblName);
            this.groupBoxInfor.Controls.Add(this.lblAddress);
            this.groupBoxInfor.Controls.Add(this.lblCode);
            this.groupBoxInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfor.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxInfor.Location = new System.Drawing.Point(16, 61);
            this.groupBoxInfor.Name = "groupBoxInfor";
            this.groupBoxInfor.Size = new System.Drawing.Size(340, 377);
            this.groupBoxInfor.TabIndex = 1;
            this.groupBoxInfor.TabStop = false;
            this.groupBoxInfor.Text = "Thông tin chi tiết đơn hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radPaidAProduct);
            this.panel1.Location = new System.Drawing.Point(205, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 34);
            this.panel1.TabIndex = 13;
            // 
            // radPaidAProduct
            // 
            this.radPaidAProduct.AutoSize = true;
            this.radPaidAProduct.Enabled = false;
            this.radPaidAProduct.Location = new System.Drawing.Point(1, 8);
            this.radPaidAProduct.Name = "radPaidAProduct";
            this.radPaidAProduct.Size = new System.Drawing.Size(106, 17);
            this.radPaidAProduct.TabIndex = 0;
            this.radPaidAProduct.TabStop = true;
            this.radPaidAProduct.Text = "Đã thanh toán";
            this.radPaidAProduct.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(115, 291);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(6, 292);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(75, 15);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Thành tiền";
            // 
            // txtDateBuy
            // 
            this.txtDateBuy.Location = new System.Drawing.Point(187, 160);
            this.txtDateBuy.Name = "txtDateBuy";
            this.txtDateBuy.ReadOnly = true;
            this.txtDateBuy.Size = new System.Drawing.Size(128, 20);
            this.txtDateBuy.TabIndex = 3;
            // 
            // txtBillCode
            // 
            this.txtBillCode.Location = new System.Drawing.Point(187, 128);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.ReadOnly = true;
            this.txtBillCode.Size = new System.Drawing.Size(128, 20);
            this.txtBillCode.TabIndex = 2;
            this.txtBillCode.TextChanged += new System.EventHandler(this.txtBillCode_TextChanged);
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.ForeColor = System.Drawing.Color.Black;
            this.lblBillDate.Location = new System.Drawing.Point(6, 163);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(95, 13);
            this.lblBillDate.TabIndex = 10;
            this.lblBillDate.Text = "Ngày đặt hàng:";
            // 
            // lblBillCode
            // 
            this.lblBillCode.AutoSize = true;
            this.lblBillCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillCode.ForeColor = System.Drawing.Color.Black;
            this.lblBillCode.Location = new System.Drawing.Point(6, 131);
            this.lblBillCode.Name = "lblBillCode";
            this.lblBillCode.Size = new System.Drawing.Size(79, 13);
            this.lblBillCode.TabIndex = 9;
            this.lblBillCode.Text = "Mã hóa đơn:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(187, 257);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(128, 20);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(6, 260);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 15);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Số lượng";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(115, 67);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(6, 224);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 15);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Giá";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(187, 224);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(128, 20);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(115, 98);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(6, 194);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(67, 15);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Mặt hàng";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCode.Location = new System.Drawing.Point(187, 37);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.ReadOnly = true;
            this.txtCustomerCode.Size = new System.Drawing.Size(128, 20);
            this.txtCustomerCode.TabIndex = 1;
            this.txtCustomerCode.TextChanged += new System.EventHandler(this.txtCustomerCode_TextChanged);
            // 
            // comProductName
            // 
            this.comProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comProductName.Enabled = false;
            this.comProductName.FormattingEnabled = true;
            this.comProductName.Location = new System.Drawing.Point(187, 191);
            this.comProductName.Name = "comProductName";
            this.comProductName.Size = new System.Drawing.Size(128, 21);
            this.comProductName.TabIndex = 6;
            this.comProductName.SelectedIndexChanged += new System.EventHandler(this.comProductName_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(6, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên khách hàng:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(6, 101);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(6, 40);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(100, 23);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Mã khách hàng:";
            // 
            // dataGridBill
            // 
            this.dataGridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBill.Location = new System.Drawing.Point(18, 37);
            this.dataGridBill.Name = "dataGridBill";
            this.dataGridBill.ReadOnly = true;
            this.dataGridBill.Size = new System.Drawing.Size(358, 308);
            this.dataGridBill.TabIndex = 11;
            this.dataGridBill.DataSourceChanged += new System.EventHandler(this.dataGridBill_DataSourceChanged);
            this.dataGridBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBill_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblListView);
            this.groupBox1.Controls.Add(this.dataGridBill);
            this.groupBox1.Controls.Add(this.btnPayAll);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(362, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 416);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mua hàng";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(204, 356);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(172, 21);
            this.txtTotal.TabIndex = 14;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(70, 359);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(111, 15);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Tổng thanh toán";
            // 
            // lblListView
            // 
            this.lblListView.AutoSize = true;
            this.lblListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListView.ForeColor = System.Drawing.Color.Black;
            this.lblListView.Location = new System.Drawing.Point(15, 17);
            this.lblListView.Name = "lblListView";
            this.lblListView.Size = new System.Drawing.Size(166, 17);
            this.lblListView.TabIndex = 11;
            this.lblListView.Text = "Danh sách hàng mua:";
            // 
            // PayManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(776, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInfor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Name = "PayManage";
            this.Text = "THANH TOÁN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BillManage_FormClosed);
            this.Load += new System.EventHandler(this.BillManage_Load);
            this.groupBoxInfor.ResumeLayout(false);
            this.groupBoxInfor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPayAll;
        private System.Windows.Forms.Button btnPayProduct;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DataGridView dataGridBill;
        private System.Windows.Forms.GroupBox groupBoxInfor;
        private System.Windows.Forms.TextBox txtDateBuy;
        private System.Windows.Forms.TextBox txtBillCode;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblBillCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comProductName;
        private System.Windows.Forms.Label lblListView;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radPaidAProduct;
    }
}