namespace Lab1_FormAdvanced
{
    partial class Caculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caculator));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblRequiredB = new System.Windows.Forms.Label();
            this.lblRequiredA = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbOperator);
            this.panel3.Controls.Add(this.lblOperator);
            this.panel3.Controls.Add(this.lblRequiredB);
            this.panel3.Controls.Add(this.lblRequiredA);
            this.panel3.Controls.Add(this.txtB);
            this.panel3.Controls.Add(this.txtA);
            this.panel3.Controls.Add(this.lblB);
            this.panel3.Controls.Add(this.lblA);
            this.panel3.Location = new System.Drawing.Point(14, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 100);
            this.panel3.TabIndex = 2;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperator.Location = new System.Drawing.Point(168, 68);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(48, 21);
            this.cmbOperator.TabIndex = 7;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(4, 69);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(123, 17);
            this.lblOperator.TabIndex = 6;
            this.lblOperator.Text = "Chọn phép tính:";
            // 
            // lblRequiredB
            // 
            this.lblRequiredB.AutoSize = true;
            this.lblRequiredB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredB.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredB.Location = new System.Drawing.Point(312, 39);
            this.lblRequiredB.Name = "lblRequiredB";
            this.lblRequiredB.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredB.TabIndex = 5;
            this.lblRequiredB.Text = "*";
            // 
            // lblRequiredA
            // 
            this.lblRequiredA.AutoSize = true;
            this.lblRequiredA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredA.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredA.Location = new System.Drawing.Point(312, 11);
            this.lblRequiredA.Name = "lblRequiredA";
            this.lblRequiredA.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredA.TabIndex = 4;
            this.lblRequiredA.Text = "*";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(168, 38);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(138, 20);
            this.txtB.TabIndex = 3;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            this.txtB.Enter += new System.EventHandler(this.txtB_Enter);
            this.txtB.Leave += new System.EventHandler(this.txtB_Leave);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(168, 10);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(138, 20);
            this.txtA.TabIndex = 2;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            this.txtA.Enter += new System.EventHandler(this.txtA_Enter);
            this.txtA.Leave += new System.EventHandler(this.txtA_Leave);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(4, 42);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(65, 17);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Nhập b:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(4, 13);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(65, 17);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Nhập a:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Blue;
            this.lblTittle.Location = new System.Drawing.Point(75, 18);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(228, 25);
            this.lblTittle.TabIndex = 3;
            this.lblTittle.Text = "THỰC HIỆN PHÉP TÍNH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblTittle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 283);
            this.panel1.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtResult);
            this.panel4.Controls.Add(this.lblResult);
            this.panel4.Location = new System.Drawing.Point(14, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 39);
            this.panel4.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(168, 9);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(138, 20);
            this.txtResult.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(8, 10);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(90, 17);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "-->Kết quả:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnExecute);
            this.panel2.Location = new System.Drawing.Point(14, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 33);
            this.panel2.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Aquamarine;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(234, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "TIẾP THEO";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Aquamarine;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(129, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "LÀM MỚI";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.Aquamarine;
            this.btnExecute.Image = ((System.Drawing.Image)(resources.GetObject("btnExecute.Image")));
            this.btnExecute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecute.Location = new System.Drawing.Point(7, 4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(101, 23);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "THỰC HIỆN";
            this.btnExecute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // Caculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 305);
            this.Controls.Add(this.panel1);
            this.Name = "Caculator";
            this.Text = "Caculator";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRequiredB;
        private System.Windows.Forms.Label lblRequiredA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExecute;
    }
}