namespace Lab2_Shopping
{
    partial class BillManage
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBoxInfor = new System.Windows.Forms.GroupBox();
            this.txtDateBuy = new System.Windows.Forms.TextBox();
            this.txtBillCode = new System.Windows.Forms.TextBox();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblBillCode = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.dataGridBill = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblListView = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.comProductName = new System.Windows.Forms.ComboBox();
            this.groupBoxInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(271, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐƠN ĐẶT HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(149, 188);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(292, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "<<";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.Control;
            this.btnModify.Enabled = false;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.Red;
            this.btnModify.Location = new System.Drawing.Point(292, 47);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 25);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = ">>";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuy.Enabled = false;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.Red;
            this.btnBuy.Location = new System.Drawing.Point(602, 97);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(80, 25);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Đặt mua";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(497, 97);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 25);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Tạo mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBoxInfor
            // 
            this.groupBoxInfor.Controls.Add(this.txtDateBuy);
            this.groupBoxInfor.Controls.Add(this.txtBillCode);
            this.groupBoxInfor.Controls.Add(this.lblBillDate);
            this.groupBoxInfor.Controls.Add(this.lblBillCode);
            this.groupBoxInfor.Controls.Add(this.btnBuy);
            this.groupBoxInfor.Controls.Add(this.txtCustomerName);
            this.groupBoxInfor.Controls.Add(this.btnNew);
            this.groupBoxInfor.Controls.Add(this.txtAddress);
            this.groupBoxInfor.Controls.Add(this.txtCustomerCode);
            this.groupBoxInfor.Controls.Add(this.lblName);
            this.groupBoxInfor.Controls.Add(this.lblAddress);
            this.groupBoxInfor.Controls.Add(this.lblCode);
            this.groupBoxInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfor.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxInfor.Location = new System.Drawing.Point(16, 61);
            this.groupBoxInfor.Name = "groupBoxInfor";
            this.groupBoxInfor.Size = new System.Drawing.Size(721, 143);
            this.groupBoxInfor.TabIndex = 2;
            this.groupBoxInfor.TabStop = false;
            this.groupBoxInfor.Text = "Thông tin khách hàng";
            // 
            // txtDateBuy
            // 
            this.txtDateBuy.Location = new System.Drawing.Point(564, 67);
            this.txtDateBuy.Name = "txtDateBuy";
            this.txtDateBuy.Size = new System.Drawing.Size(137, 20);
            this.txtDateBuy.TabIndex = 12;
            // 
            // txtBillCode
            // 
            this.txtBillCode.Location = new System.Drawing.Point(564, 33);
            this.txtBillCode.Name = "txtBillCode";
            this.txtBillCode.Size = new System.Drawing.Size(137, 20);
            this.txtBillCode.TabIndex = 11;
            this.txtBillCode.TextChanged += new System.EventHandler(this.txtBillCode_TextChanged);
            // 
            // lblBillDate
            // 
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDate.ForeColor = System.Drawing.Color.Black;
            this.lblBillDate.Location = new System.Drawing.Point(463, 70);
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
            this.lblBillCode.Location = new System.Drawing.Point(463, 36);
            this.lblBillCode.Name = "lblBillCode";
            this.lblBillCode.Size = new System.Drawing.Size(79, 13);
            this.lblBillCode.TabIndex = 9;
            this.lblBillCode.Text = "Mã hóa đơn:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(115, 63);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(115, 94);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(317, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCode.Location = new System.Drawing.Point(115, 33);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerCode.TabIndex = 5;
            this.txtCustomerCode.TextChanged += new System.EventHandler(this.txtCustomerCode_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(6, 67);
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
            this.lblAddress.Location = new System.Drawing.Point(6, 97);
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
            this.lblCode.Location = new System.Drawing.Point(6, 36);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(100, 23);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Mã khách hàng:";
            // 
            // dataGridBill
            // 
            this.dataGridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBill.Location = new System.Drawing.Point(387, 47);
            this.dataGridBill.Name = "dataGridBill";
            this.dataGridBill.Size = new System.Drawing.Size(324, 166);
            this.dataGridBill.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblListView);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.comProductName);
            this.groupBox1.Controls.Add(this.dataGridBill);
            this.groupBox1.Controls.Add(this.btnModify);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(16, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mua hàng";
            // 
            // lblListView
            // 
            this.lblListView.AutoSize = true;
            this.lblListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListView.ForeColor = System.Drawing.Color.Black;
            this.lblListView.Location = new System.Drawing.Point(385, 29);
            this.lblListView.Name = "lblListView";
            this.lblListView.Size = new System.Drawing.Size(166, 17);
            this.lblListView.TabIndex = 11;
            this.lblListView.Text = "Danh sách hàng mua:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(6, 145);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 15);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Số lượng";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(6, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 15);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Giá";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(6, 52);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(67, 15);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "Mặt hàng";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(115, 142);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(157, 21);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(115, 97);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(157, 21);
            this.txtPrice.TabIndex = 5;
            // 
            // comProductName
            // 
            this.comProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comProductName.FormattingEnabled = true;
            this.comProductName.Location = new System.Drawing.Point(115, 49);
            this.comProductName.Name = "comProductName";
            this.comProductName.Size = new System.Drawing.Size(157, 23);
            this.comProductName.TabIndex = 4;
            this.comProductName.SelectedIndexChanged += new System.EventHandler(this.comProductName_SelectedIndexChanged);
            // 
            // BillManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(749, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInfor);
            this.Controls.Add(this.lblTitle);
            this.Name = "BillManage";
            this.Text = "KHÁCH HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BillManage_FormClosed);
            this.Load += new System.EventHandler(this.BillManage_Load);
            this.groupBoxInfor.ResumeLayout(false);
            this.groupBoxInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnNew;
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
    }
}