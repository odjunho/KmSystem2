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
            this.ConnectingTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectingTest
            // 
            this.ConnectingTest.Location = new System.Drawing.Point(319, 90);
            this.ConnectingTest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectingTest.Name = "ConnectingTest";
            this.ConnectingTest.Size = new System.Drawing.Size(288, 52);
            this.ConnectingTest.TabIndex = 1;
            this.ConnectingTest.Text = "Connection Test";
            this.ConnectingTest.UseVisualStyleBackColor = true;
            this.ConnectingTest.Click += new System.EventHandler(this.ConnectingTest_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.ConnectingTest);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ConnectingTest;
    }
}