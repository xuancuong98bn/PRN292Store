namespace Lab2_Shopping
{
    partial class CustormerManage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBoxInfor = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.lblListView = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxInfor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Location = new System.Drawing.Point(148, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(77, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(416, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(335, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 25);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Red;
            this.btnUpdate.Location = new System.Drawing.Point(254, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 25);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.Control;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.Red;
            this.btnModify.Location = new System.Drawing.Point(173, 6);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 25);
            this.btnModify.TabIndex = 8;
            this.btnModify.Text = "Sửa";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(91, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Red;
            this.btnNew.Location = new System.Drawing.Point(10, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 25);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBoxInfor
            // 
            this.groupBoxInfor.Controls.Add(this.panel2);
            this.groupBoxInfor.Controls.Add(this.txtName);
            this.groupBoxInfor.Controls.Add(this.txtAddress);
            this.groupBoxInfor.Controls.Add(this.txtDOB);
            this.groupBoxInfor.Controls.Add(this.txtCode);
            this.groupBoxInfor.Controls.Add(this.lblGender);
            this.groupBoxInfor.Controls.Add(this.lblName);
            this.groupBoxInfor.Controls.Add(this.lblAddress);
            this.groupBoxInfor.Controls.Add(this.lblDOB);
            this.groupBoxInfor.Controls.Add(this.lblCode);
            this.groupBoxInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfor.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxInfor.Location = new System.Drawing.Point(16, 61);
            this.groupBoxInfor.Name = "groupBoxInfor";
            this.groupBoxInfor.Size = new System.Drawing.Size(628, 132);
            this.groupBoxInfor.TabIndex = 1;
            this.groupBoxInfor.TabStop = false;
            this.groupBoxInfor.Text = "Thông tin khách hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radFemale);
            this.panel2.Controls.Add(this.radMale);
            this.panel2.Location = new System.Drawing.Point(394, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 23);
            this.panel2.TabIndex = 9;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.ForeColor = System.Drawing.Color.Black;
            this.radFemale.Location = new System.Drawing.Point(108, 3);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(41, 17);
            this.radFemale.TabIndex = 4;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.ForeColor = System.Drawing.Color.Black;
            this.radMale.Location = new System.Drawing.Point(26, 3);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(50, 17);
            this.radMale.TabIndex = 4;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(394, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(102, 94);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(339, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtDOB
            // 
            this.txtDOB.Enabled = false;
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(102, 64);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(153, 20);
            this.txtDOB.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(102, 33);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(284, 67);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Giới tính:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(284, 36);
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
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(6, 67);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(67, 13);
            this.lblDOB.TabIndex = 1;
            this.lblDOB.Text = "Ngày sinh:";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridCustomer);
            this.panel3.Controls.Add(this.lblListView);
            this.panel3.Location = new System.Drawing.Point(16, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 219);
            this.panel3.TabIndex = 3;
            // 
            // dataGridCustomer
            // 
            this.dataGridCustomer.AllowUserToAddRows = false;
            this.dataGridCustomer.AllowUserToDeleteRows = false;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Location = new System.Drawing.Point(36, 39);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.ReadOnly = true;
            this.dataGridCustomer.Size = new System.Drawing.Size(558, 168);
            this.dataGridCustomer.TabIndex = 12;
            this.dataGridCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellClick);
            // 
            // lblListView
            // 
            this.lblListView.AutoSize = true;
            this.lblListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListView.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblListView.Location = new System.Drawing.Point(6, 12);
            this.lblListView.Name = "lblListView";
            this.lblListView.Size = new System.Drawing.Size(157, 15);
            this.lblListView.TabIndex = 0;
            this.lblListView.Text = "Danh sách khách hàng:";
            // 
            // CustormerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(661, 489);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBoxInfor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Name = "CustormerManage";
            this.Text = "KHÁCH HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustormerManage_FormClosed);
            this.Load += new System.EventHandler(this.CustormerManage_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxInfor.ResumeLayout(false);
            this.groupBoxInfor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridCustomer;
        private System.Windows.Forms.Label lblListView;
        private System.Windows.Forms.GroupBox groupBoxInfor;
    }
}