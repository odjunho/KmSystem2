using Dapper;
using KmSystem.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace KmSystem
{
    public partial class SaleForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public SaleForm()
        {
            InitializeComponent();
            InitializeScanProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbProductNo.Text.Length == 0)
                {
                    MessageBox.Show("상품번호를 입력해주세요");
                    return;
                }

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var sql = @"select p.ProductId, p.ProductNo, p.ProductName, pp.ProductPrice
                                from Product p
                                inner join ProductPrice pp on p.ProductNo = pp.ProductNo
                                where p.ProductNo = @ProductNo ";

                    var product = connection.Query<Product>(sql, new
                    {
                        ProductNo = tbProductNo.Text,
                    }).FirstOrDefault();

                    var row = new string[] 
                    { 
                        product.ProductNo,
                        product.ProductName,
                        string.Format("{0:#,##0}", double.Parse(product.ProductPrice.ToString())),
                        "1",
                        string.Format("{0:#,##0}", double.Parse(product.ProductPrice.ToString())),
                    };

                    dgvScanProducts.Rows.Add(row);

                    tbTotalPrice.Text = GetTotalPrice();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbProductNo.Text = "";
            }
        }

        private void InitializeScanProducts()
        {
            dgvScanProducts.ColumnCount = 5;

            // カラム名を指定
            dgvScanProducts.Columns[0].HeaderText = "상품번호";
            dgvScanProducts.Columns[1].HeaderText = "상품명";
            dgvScanProducts.Columns[2].HeaderText = "가격";
            dgvScanProducts.Columns[3].HeaderText = "수량";
            dgvScanProducts.Columns[4].HeaderText = "총 가격";

            CreateButton("+");
            CreateButton("-");
            CreateButton("X");
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            //Insert DB
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    var sql = @"insert into SalesMain (BuyDate)
                                    OUTPUT Inserted.SalesMainId
                                    values (@BuyDate);";

                    var salesMainId = connection.ExecuteScalar<int>(sql, new
                    {
                        BuyDate = DateTime.Now,
                    }, transaction);

                    foreach (DataGridViewRow row in dgvScanProducts.Rows)
                    {
                        sql = @"insert into SalesDetail (SalesMainId, ProductNo, UnitPrice, Quantity, TotalPrice)
                                values (@SalesMainId, @ProductNo, @UnitPrice, @Quantity, @TotalPrice) ";

                        connection.Execute(sql, new
                        {
                            SalesMainId = salesMainId,
                            ProductNo = row.Cells[0].Value,
                            UnitPrice = row.Cells[2].Value.ToString().Replace(",", ""),
                            Quantity = row.Cells[3].Value,
                            TotalPrice = row.Cells[4].Value.ToString().Replace(",", ""),
                        }, transaction);
                    }

                    transaction.Commit();

                    MessageBox.Show("판매 완료");
                    dgvScanProducts.Rows.Clear();
                    tbTotalPrice.Text = "";
                }
            }
        }

        private void dgvScanProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; } //列ヘッダーをクリックした場合などにキャンセルする。			

            var dgv = (DataGridView)sender;

            if (this.dgvScanProducts.Rows.Count > 0)
            {
                var quantity = int.Parse(dgv.Rows[e.RowIndex].Cells[3].Value.ToString());
                var unitPrice = int.Parse(dgv.Rows[e.RowIndex].Cells[2].Value.ToString().Replace(",", ""));

                switch (dgv.Columns[e.ColumnIndex].Name)
                {
                    case "+":
                        quantity += 1;
                        dgv.Rows[e.RowIndex].Cells[3].Value = quantity.ToString();
                        dgv.Rows[e.RowIndex].Cells[4].Value = string.Format("{0:#,##0}", double.Parse((quantity * unitPrice).ToString()));
                        break;
                    case "-":
                        if (quantity == 1) break;
                        quantity -= 1;
                        dgv.Rows[e.RowIndex].Cells[3].Value = quantity.ToString();
                        dgv.Rows[e.RowIndex].Cells[4].Value = string.Format("{0:#,##0}", double.Parse((quantity * unitPrice).ToString()));
                        break;
                    case "X":
                        dgvScanProducts.Rows.RemoveAt(e.RowIndex);
                        break;
                }
            }

            tbTotalPrice.Text = GetTotalPrice();
        }

        private void CreateButton(string buttonName)
        {
            var column = new DataGridViewButtonColumn();

            column.Name = buttonName;
            column.Text = buttonName;
            column.UseColumnTextForButtonValue = true;
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            column.Width = 30;
            
            dgvScanProducts.Columns.Add(column);
        }

        private string GetTotalPrice()
        {
            int totalPrice = 0;

            foreach(DataGridViewRow row in dgvScanProducts.Rows)
            {
                var price = row.Cells[4].Value.ToString().Replace(",", "");

                totalPrice += int.Parse(price);
            }

            return string.Format("{0:#,##0}", double.Parse(totalPrice.ToString()));
        }

        private void tbProductNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
        }
    }
}
