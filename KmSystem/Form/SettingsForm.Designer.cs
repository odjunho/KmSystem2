namespace KmSystem
{
    partial class SettingsForm
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
            this.Home = new System.Windows.Forms.Button();
            this.ConnectingTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(12, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(53, 53);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // ConnectingTest
            // 
            this.ConnectingTest.Location = new System.Drawing.Point(279, 72);
            this.ConnectingTest.Name = "ConnectingTest";
            this.ConnectingTest.Size = new System.Drawing.Size(252, 42);
            this.ConnectingTest.TabIndex = 1;
            this.ConnectingTest.Text = "Connection Test";
            this.ConnectingTest.UseVisualStyleBackColor = true;
            this.ConnectingTest.Click += new System.EventHandler(this.ConnectingTest_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConnectingTest);
            this.Controls.Add(this.Home);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button ConnectingTest;
    }
}