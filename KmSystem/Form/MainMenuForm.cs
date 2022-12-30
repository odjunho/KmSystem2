﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KmSystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void Master_Click(object sender, EventArgs e)
        {
            MasterForm master = new MasterForm();
            master.Show();
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            SaleForm sale = new SaleForm();
            sale.Show();

        }

        private void Return_Click(object sender, EventArgs e)
        {

        }

        private void Arrival_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Show();
        }
    }
}
