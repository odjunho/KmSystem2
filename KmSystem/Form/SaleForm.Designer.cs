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
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.dgvScanProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScanProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(82, 12);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(170, 21);
            this.tbProductNo.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbProductNo
            // 
            this.lbProductNo.AutoSize = true;
            this.lbProductNo.Location = new System.Drawing.Point(12, 15);
            this.lbProductNo.Name = "lbProductNo";
            this.lbProductNo.Size = new System.Drawing.Size(64, 12);
            this.lbProductNo.TabIndex = 2;
            this.lbProductNo.Text = "ProductNo";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(12, 48);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(51, 12);
            this.lbQuantity.TabIndex = 3;
            this.lbQuantity.Text = "Quantity";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(82, 45);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(170, 21);
            this.tbQuantity.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(294, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 54);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(713, 12);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 54);
            this.btnSell.TabIndex = 6;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // dgvScanProducts
            // 
            this.dgvScanProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScanProducts.Location = new System.Drawing.Point(12, 72);
            this.dgvScanProducts.Name = "dgvScanProducts";
            this.dgvScanProducts.RowTemplate.Height = 23;
            this.dgvScanProducts.Size = new System.Drawing.Size(776, 378);
            this.dgvScanProducts.TabIndex = 7;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvScanProducts);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lbQuantity);
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
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.DataGridView dgvScanProducts;
    }
}