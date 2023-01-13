namespace KmSystem
{
    partial class ArrivalForm
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
            this.dgvScanProducts = new System.Windows.Forms.DataGridView();
            this.btnArrival = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbProductNo = new System.Windows.Forms.Label();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScanProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScanProducts
            // 
            this.dgvScanProducts.AllowUserToAddRows = false;
            this.dgvScanProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvScanProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvScanProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScanProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvScanProducts.Location = new System.Drawing.Point(12, 102);
            this.dgvScanProducts.Name = "dgvScanProducts";
            this.dgvScanProducts.ReadOnly = true;
            this.dgvScanProducts.RowHeadersWidth = 51;
            this.dgvScanProducts.RowTemplate.Height = 23;
            this.dgvScanProducts.Size = new System.Drawing.Size(1068, 530);
            this.dgvScanProducts.TabIndex = 13;
            this.dgvScanProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScanProducts_CellContentClick);
            // 
            // btnArrival
            // 
            this.btnArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrival.Location = new System.Drawing.Point(981, 12);
            this.btnArrival.Name = "btnArrival";
            this.btnArrival.Size = new System.Drawing.Size(99, 73);
            this.btnArrival.TabIndex = 12;
            this.btnArrival.Text = "입고";
            this.btnArrival.UseVisualStyleBackColor = true;
            this.btnArrival.Click += new System.EventHandler(this.btnArrival_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(292, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 73);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbProductNo
            // 
            this.lbProductNo.AutoSize = true;
            this.lbProductNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductNo.Location = new System.Drawing.Point(12, 33);
            this.lbProductNo.Name = "lbProductNo";
            this.lbProductNo.Size = new System.Drawing.Size(98, 31);
            this.lbProductNo.TabIndex = 10;
            this.lbProductNo.Text = "상품번호";
            // 
            // tbProductNo
            // 
            this.tbProductNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductNo.Location = new System.Drawing.Point(116, 36);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(170, 30);
            this.tbProductNo.TabIndex = 9;
            this.tbProductNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbProductNo_KeyDown);
            // 
            // ArrivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 644);
            this.Controls.Add(this.dgvScanProducts);
            this.Controls.Add(this.btnArrival);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbProductNo);
            this.Controls.Add(this.tbProductNo);
            this.Name = "ArrivalForm";
            this.Text = "입고";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScanProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvScanProducts;
        private System.Windows.Forms.Button btnArrival;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbProductNo;
        private System.Windows.Forms.TextBox tbProductNo;
    }
}