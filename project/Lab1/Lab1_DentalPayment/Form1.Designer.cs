namespace Lab1_DentalPayment
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblFilling = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCleanCost = new System.Windows.Forms.Label();
            this.lblWhiteningCost = new System.Windows.Forms.Label();
            this.lblXRayCost = new System.Windows.Forms.Label();
            this.ckbClean = new System.Windows.Forms.CheckBox();
            this.ckbWhitening = new System.Windows.Forms.CheckBox();
            this.ckbXRay = new System.Windows.Forms.CheckBox();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFillCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(57, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dental Payment Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên khách hàng";
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.Location = new System.Drawing.Point(13, 123);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(55, 13);
            this.lblFilling.TabIndex = 2;
            this.lblFilling.Text = "Trám răng";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(124, 262);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // lblCleanCost
            // 
            this.lblCleanCost.AutoSize = true;
            this.lblCleanCost.Location = new System.Drawing.Point(210, 22);
            this.lblCleanCost.Name = "lblCleanCost";
            this.lblCleanCost.Size = new System.Drawing.Size(52, 13);
            this.lblCleanCost.TabIndex = 4;
            this.lblCleanCost.Text = "$100.000";
            // 
            // lblWhiteningCost
            // 
            this.lblWhiteningCost.AutoSize = true;
            this.lblWhiteningCost.Location = new System.Drawing.Point(201, 55);
            this.lblWhiteningCost.Name = "lblWhiteningCost";
            this.lblWhiteningCost.Size = new System.Drawing.Size(61, 13);
            this.lblWhiteningCost.TabIndex = 5;
            this.lblWhiteningCost.Text = "$1.200.000";
            // 
            // lblXRayCost
            // 
            this.lblXRayCost.AutoSize = true;
            this.lblXRayCost.Location = new System.Drawing.Point(210, 86);
            this.lblXRayCost.Name = "lblXRayCost";
            this.lblXRayCost.Size = new System.Drawing.Size(52, 13);
            this.lblXRayCost.TabIndex = 6;
            this.lblXRayCost.Text = "$200.000";
            // 
            // ckbClean
            // 
            this.ckbClean.AutoSize = true;
            this.ckbClean.Location = new System.Drawing.Point(16, 22);
            this.ckbClean.Name = "ckbClean";
            this.ckbClean.Size = new System.Drawing.Size(62, 17);
            this.ckbClean.TabIndex = 7;
            this.ckbClean.Text = "Cạo vôi";
            this.ckbClean.UseVisualStyleBackColor = true;
            // 
            // ckbWhitening
            // 
            this.ckbWhitening.AutoSize = true;
            this.ckbWhitening.Location = new System.Drawing.Point(16, 54);
            this.ckbWhitening.Name = "ckbWhitening";
            this.ckbWhitening.Size = new System.Drawing.Size(71, 17);
            this.ckbWhitening.TabIndex = 8;
            this.ckbWhitening.Text = "Tẩy trắng";
            this.ckbWhitening.UseVisualStyleBackColor = true;
            // 
            // ckbXRay
            // 
            this.ckbXRay.AutoSize = true;
            this.ckbXRay.Location = new System.Drawing.Point(16, 86);
            this.ckbXRay.Name = "ckbXRay";
            this.ckbXRay.Size = new System.Drawing.Size(98, 17);
            this.ckbXRay.TabIndex = 9;
            this.ckbXRay.Text = "Chụp hình răng";
            this.ckbXRay.UseVisualStyleBackColor = true;
            // 
            // numFilling
            // 
            this.numFilling.Location = new System.Drawing.Point(103, 121);
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(54, 20);
            this.numFilling.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Red;
            this.txtName.Location = new System.Drawing.Point(127, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(186, 262);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(50, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(211, 306);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "Tính tiền";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 352);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblWhiteningCost);
            this.panel2.Controls.Add(this.lblFillCost);
            this.panel2.Controls.Add(this.ckbClean);
            this.panel2.Controls.Add(this.lblXRayCost);
            this.panel2.Controls.Add(this.ckbWhitening);
            this.panel2.Controls.Add(this.ckbXRay);
            this.panel2.Controls.Add(this.lblCleanCost);
            this.panel2.Controls.Add(this.numFilling);
            this.panel2.Controls.Add(this.lblFilling);
            this.panel2.Location = new System.Drawing.Point(24, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 153);
            this.panel2.TabIndex = 16;
            // 
            // lblFillCost
            // 
            this.lblFillCost.AutoSize = true;
            this.lblFillCost.Location = new System.Drawing.Point(197, 123);
            this.lblFillCost.Name = "lblFillCost";
            this.lblFillCost.Size = new System.Drawing.Size(65, 13);
            this.lblFillCost.TabIndex = 15;
            this.lblFillCost.Text = "$80.000/cái";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 375);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Dental Payment Application";
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFilling;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCleanCost;
        private System.Windows.Forms.Label lblWhiteningCost;
        private System.Windows.Forms.Label lblXRayCost;
        private System.Windows.Forms.CheckBox ckbClean;
        private System.Windows.Forms.CheckBox ckbWhitening;
        private System.Windows.Forms.CheckBox ckbXRay;
        private System.Windows.Forms.NumericUpDown numFilling;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFillCost;
        private System.Windows.Forms.Panel panel2;
    }
}

