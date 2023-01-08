namespace KmSystem
{
    partial class MainMenuForm
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
            this.Sale = new System.Windows.Forms.Button();
            this.Master = new System.Windows.Forms.Button();
            this.Arrival = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sale
            // 
            this.Sale.Location = new System.Drawing.Point(279, 120);
            this.Sale.Name = "Sale";
            this.Sale.Size = new System.Drawing.Size(252, 42);
            this.Sale.TabIndex = 1;
            this.Sale.Text = "Sale";
            this.Sale.UseVisualStyleBackColor = true;
            this.Sale.Click += new System.EventHandler(this.Sale_Click);
            // 
            // Master
            // 
            this.Master.Location = new System.Drawing.Point(279, 72);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(252, 42);
            this.Master.TabIndex = 0;
            this.Master.Text = "Master";
            this.Master.UseVisualStyleBackColor = true;
            this.Master.Click += new System.EventHandler(this.Master_Click);
            // 
            // Arrival
            // 
            this.Arrival.Location = new System.Drawing.Point(278, 216);
            this.Arrival.Name = "Arrival";
            this.Arrival.Size = new System.Drawing.Size(253, 42);
            this.Arrival.TabIndex = 2;
            this.Arrival.Text = "Arrival";
            this.Arrival.UseVisualStyleBackColor = true;
            this.Arrival.Click += new System.EventHandler(this.Arrival_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(279, 168);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(252, 42);
            this.Return.TabIndex = 3;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(279, 312);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(253, 42);
            this.Settings.TabIndex = 4;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(279, 264);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(253, 42);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Arrival);
            this.Controls.Add(this.Sale);
            this.Controls.Add(this.Master);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Sale;
        private System.Windows.Forms.Button Master;
        private System.Windows.Forms.Button Arrival;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button btnInventory;
    }
}

