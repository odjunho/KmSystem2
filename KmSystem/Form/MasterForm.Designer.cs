namespace KmSystem
{
    partial class MasterForm
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
            this.lbProductName = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lbProductNo = new System.Windows.Forms.Label();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(12, 36);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(82, 12);
            this.lbProductName.TabIndex = 14;
            this.lbProductName.Text = "ProductName";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(100, 33);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(170, 21);
            this.tbProductName.TabIndex = 13;
            // 
            // lbProductNo
            // 
            this.lbProductNo.AutoSize = true;
            this.lbProductNo.Location = new System.Drawing.Point(12, 9);
            this.lbProductNo.Name = "lbProductNo";
            this.lbProductNo.Size = new System.Drawing.Size(64, 12);
            this.lbProductNo.TabIndex = 12;
            this.lbProductNo.Text = "ProductNo";
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(100, 6);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(170, 21);
            this.tbProductNo.TabIndex = 11;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(14, 84);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 23;
            this.dgvProducts.Size = new System.Drawing.Size(776, 354);
            this.dgvProducts.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(713, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 48);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(276, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 48);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lbProductNo);
            this.Controls.Add(this.tbProductNo);
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lbProductNo;
        private System.Windows.Forms.TextBox tbProductNo;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
    }
}