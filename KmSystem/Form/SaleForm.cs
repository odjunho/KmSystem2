using System;
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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();

            InitializeScanProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void InitializeScanProducts()
        {
            dgvScanProducts.ColumnCount = 5;

            // カラム名を指定
            dgvScanProducts.Columns[0].HeaderText = "ProductNo";
            dgvScanProducts.Columns[1].HeaderText = "ProductName";
            dgvScanProducts.Columns[2].HeaderText = "ProductPrice";
            dgvScanProducts.Columns[3].HeaderText = "Quantity";
            dgvScanProducts.Columns[4].HeaderText = "TotalPrice";
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            //Insert DB
        }
    }
}
