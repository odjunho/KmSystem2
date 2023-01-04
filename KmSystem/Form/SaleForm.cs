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
            var row = new string[] { dgvScanProducts.Rows.Count.ToString(), "Product 1", "1000" };
            dgvScanProducts.Rows.Add(row);
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

            // Delete Button
            var column = new DataGridViewButtonColumn();
            //列の名前を設定
            column.Name = "DELETE";
            //全てのボタンに"詳細閲覧"と表示する
            column.UseColumnTextForButtonValue = true;
            column.Text = "X";
            //DataGridViewに追加する
            dgvScanProducts.Columns.Add(column);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            //Insert DB
        }

        private void dgvScanProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; } //列ヘッダーをクリックした場合などにキャンセルする。			

            var dgv = (DataGridView)sender;
            
            if (dgv.Columns[e.ColumnIndex].Name != "DELETE") { return; }

            if (this.dgvScanProducts.Rows.Count > 0)
            {
                dgvScanProducts.Rows.RemoveAt(e.RowIndex);
            }

            //MessageBox.Show("ボタン列をクリックしました。");
        }
    }
}
