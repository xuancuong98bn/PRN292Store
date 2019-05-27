namespace Lab1_FormAdvanced
{
    partial class MyRandom
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.numInput = new System.Windows.Forms.NumericUpDown();
            this.btnPlay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Blue;
            this.lblResult.Location = new System.Drawing.Point(30, 37);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(206, 106);
            this.lblResult.TabIndex = 0;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(8, 240);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(162, 13);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "Chọn số sinh viên trong lớp";
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(176, 238);
            this.numInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(80, 20);
            this.numInput.TabIndex = 2;
            this.numInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInput.ValueChanged += new System.EventHandler(this.numInput_ValueChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(84, 175);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(92, 40);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.lblTittle);
            this.panel1.Controls.Add(this.numInput);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 271);
            this.panel1.TabIndex = 4;
            // 
            // MyRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 295);
            this.Controls.Add(this.panel1);
            this.Name = "MyRandom";
            this.Text = "MyRandom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyRandom_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.NumericUpDown numInput;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panel1;
    }
}