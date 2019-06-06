namespace Lab2_Shopping
{
    partial class MainForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mitemSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemUpdateData = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemShoppingSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemSystem,
            this.mitemUpdateData,
            this.mitemShoppingSolution,
            this.mitemReport,
            this.mitemHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // mitemSystem
            // 
            this.mitemSystem.Name = "mitemSystem";
            this.mitemSystem.Size = new System.Drawing.Size(69, 20);
            this.mitemSystem.Text = "Hệ thống";
            // 
            // mitemUpdateData
            // 
            this.mitemUpdateData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemUpdateCustomer,
            this.mitemUpdateProduct});
            this.mitemUpdateData.Name = "mitemUpdateData";
            this.mitemUpdateData.Size = new System.Drawing.Size(106, 20);
            this.mitemUpdateData.Text = "Cập nhật dữ liệu";
            // 
            // mitemUpdateCustomer
            // 
            this.mitemUpdateCustomer.Name = "mitemUpdateCustomer";
            this.mitemUpdateCustomer.Size = new System.Drawing.Size(187, 22);
            this.mitemUpdateCustomer.Text = "Cập nhật khách hàng";
            this.mitemUpdateCustomer.Click += new System.EventHandler(this.mitemUpdateCustomer_Click);
            // 
            // mitemUpdateProduct
            // 
            this.mitemUpdateProduct.Name = "mitemUpdateProduct";
            this.mitemUpdateProduct.Size = new System.Drawing.Size(187, 22);
            this.mitemUpdateProduct.Text = "Cập nhật hàng hóa";
            this.mitemUpdateProduct.Click += new System.EventHandler(this.mitemUpdateProduct_Click);
            // 
            // mitemShoppingSolution
            // 
            this.mitemShoppingSolution.Name = "mitemShoppingSolution";
            this.mitemShoppingSolution.Size = new System.Drawing.Size(95, 20);
            this.mitemShoppingSolution.Text = "Xử lí bán hàng";
            this.mitemShoppingSolution.Click += new System.EventHandler(this.mitemShoppingSolution_Click);
            // 
            // mitemReport
            // 
            this.mitemReport.Name = "mitemReport";
            this.mitemReport.Size = new System.Drawing.Size(61, 20);
            this.mitemReport.Text = "Báo cáo";
            this.mitemReport.Click += new System.EventHandler(this.mitemReport_Click);
            // 
            // mitemHelp
            // 
            this.mitemHelp.Name = "mitemHelp";
            this.mitemHelp.Size = new System.Drawing.Size(63, 20);
            this.mitemHelp.Text = "Trợ giúp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Chương trình quản lý mua và bán hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mitemSystem;
        private System.Windows.Forms.ToolStripMenuItem mitemUpdateData;
        private System.Windows.Forms.ToolStripMenuItem mitemShoppingSolution;
        private System.Windows.Forms.ToolStripMenuItem mitemReport;
        private System.Windows.Forms.ToolStripMenuItem mitemHelp;
        private System.Windows.Forms.ToolStripMenuItem mitemUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mitemUpdateProduct;
    }
}