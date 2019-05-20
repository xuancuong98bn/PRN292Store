namespace WinFormDemo_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCal = new System.Windows.Forms.ComboBox();
            this.btnExe = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CACULATOR";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnExe);
            this.panel1.Controls.Add(this.cmbCal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtResult);
            this.panel1.Controls.Add(this.txtB);
            this.panel1.Controls.Add(this.txtA);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(51, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 205);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Caculator";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(104, 42);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(121, 20);
            this.txtA.TabIndex = 0;
            this.txtA.Enter += new System.EventHandler(this.txtA_Enter);
            this.txtA.Leave += new System.EventHandler(this.txtA_Leave);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(104, 73);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(121, 20);
            this.txtB.TabIndex = 1;
            this.txtB.Enter += new System.EventHandler(this.txtB_Enter);
            this.txtB.Leave += new System.EventHandler(this.txtB_Leave);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.HideSelection = false;
            this.txtResult.Location = new System.Drawing.Point(104, 137);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(121, 20);
            this.txtResult.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Result";
            // 
            // cmbCal
            // 
            this.cmbCal.FormattingEnabled = true;
            this.cmbCal.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbCal.Location = new System.Drawing.Point(104, 107);
            this.cmbCal.Name = "cmbCal";
            this.cmbCal.Size = new System.Drawing.Size(121, 21);
            this.cmbCal.TabIndex = 2;
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(25, 174);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(75, 23);
            this.btnExe.TabIndex = 4;
            this.btnExe.Text = "Execute";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(106, 174);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(187, 174);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 267);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Caculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExe;
    }
}

