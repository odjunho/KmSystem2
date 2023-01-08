namespace KmSystem
{
    partial class SaleForm
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
            this.components = new System.ComponentModel.Container();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbProductNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.dgvScanProducts = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScanProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(82, 27);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(170, 21);
            this.tbProductNo.TabIndex = 0;
            this.tbProductNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductNo_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbProductNo
            // 
            this.lbProductNo.AutoSize = true;
            this.lbProductNo.Location = new System.Drawing.Point(12, 30);
            this.lbProductNo.Name = "lbProductNo";
            this.lbProductNo.Size = new System.Drawing.Size(64, 12);
            this.lbProductNo.TabIndex = 2;
            this.lbProductNo.Text = "ProductNo";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(258, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(733, 21);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(55, 36);
            this.btnSell.TabIndex = 6;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // dgvScanProducts
            // 
            this.dgvScanProducts.AllowUserToAddRows = false;
            this.dgvScanProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScanProducts.Location = new System.Drawing.Point(12, 63);
            this.dgvScanProducts.Name = "dgvScanProducts";
            this.dgvScanProducts.RowHeadersWidth = 51;
            this.dgvScanProducts.RowTemplate.Height = 23;
            this.dgvScanProducts.Size = new System.Drawing.Size(776, 387);
            this.dgvScanProducts.TabIndex = 7;
            this.dgvScanProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScanProducts_CellContentClick);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(416, 30);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(170, 21);
            this.tbTotalPrice.TabIndex = 8;
            this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.dgvScanProducts);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbProductNo);
            this.Controls.Add(this.tbProductNo);
            this.Name = "SaleForm";
            this.Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScanProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProductNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbProductNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.DataGridView dgvScanProducts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbTotalPrice;
    }
}