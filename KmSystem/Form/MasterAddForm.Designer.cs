namespace KmSystem
{
    partial class MasterAddForm
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
            this.lbProductNo = new System.Windows.Forms.Label();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            this.lbProductName = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbProductPrice = new System.Windows.Forms.Label();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbProductNo
            // 
            this.lbProductNo.AutoSize = true;
            this.lbProductNo.Location = new System.Drawing.Point(12, 9);
            this.lbProductNo.Name = "lbProductNo";
            this.lbProductNo.Size = new System.Drawing.Size(64, 12);
            this.lbProductNo.TabIndex = 6;
            this.lbProductNo.Text = "ProductNo";
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(100, 6);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(170, 21);
            this.tbProductNo.TabIndex = 5;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(12, 36);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(82, 12);
            this.lbProductName.TabIndex = 10;
            this.lbProductName.Text = "ProductName";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(100, 33);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(170, 21);
            this.tbProductName.TabIndex = 9;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(12, 91);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(53, 12);
            this.lbLocation.TabIndex = 12;
            this.lbLocation.Text = "Location";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(100, 88);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(170, 21);
            this.tbLocation.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 54);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.AutoSize = true;
            this.lbProductPrice.Location = new System.Drawing.Point(12, 63);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(77, 12);
            this.lbProductPrice.TabIndex = 15;
            this.lbProductPrice.Text = "ProductPrice";
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(100, 60);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(170, 21);
            this.tbProductPrice.TabIndex = 14;
            // 
            // MasterAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbProductPrice);
            this.Controls.Add(this.tbProductPrice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lbProductNo);
            this.Controls.Add(this.tbProductNo);
            this.Name = "MasterAddForm";
            this.Text = "Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbProductNo;
        private System.Windows.Forms.TextBox tbProductNo;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbProductPrice;
        private System.Windows.Forms.TextBox tbProductPrice;
    }
}