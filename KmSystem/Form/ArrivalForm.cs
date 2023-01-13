using Dapper;
using KmSystem.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace KmSystem
{
    public partial class ArrivalForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public ArrivalForm()
        {
            InitializeComponent();
            InitializeScanProducts();
        }

        private void InitializeScanProducts()
        {
            dgvScanProducts.ColumnCount = 3;

            // カラム名を指定
            dgvScanProducts.Columns[0].HeaderText = "상품번호";
            dgvScanProducts.Columns[1].HeaderText = "상품명";
            dgvScanProducts.Columns[2].HeaderText = "수량";

            CreateButton("+");
            CreateButton("-");
            CreateButton("X");
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbProductNo.Text.Length == 0)
                {
                    MessageBox.Show("상품번호를 입력해주세요");
                    return;
                }

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var sql = @"select p.ProductId, p.ProductNo, p.ProductName
                                from Product p
                                where p.ProductNo = @ProductNo ";

                    var product = connection.Query<Product>(sql, new
                    {
                        ProductNo = tbProductNo.Text,
                    }).FirstOrDefault();

                    var row = new string[]
                    {
                        product.ProductNo,
                        product.ProductName,
                        "1",
                    };

                    dgvScanProducts.Rows.Add(row);
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

        private void dgvScanProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; } //列ヘッダーをクリックした場合などにキャンセルする。			

            var dgv = (DataGridView)sender;

            if (this.dgvScanProducts.Rows.Count > 0)
            {
                var quantity = int.Parse(dgv.Rows[e.RowIndex].Cells[2].Value.ToString());

                switch (dgv.Columns[e.ColumnIndex].Name)
                {
                    case "+":
                        quantity += 1;
                        dgv.Rows[e.RowIndex].Cells[2].Value = quantity.ToString();
                        break;
                    case "-":
                        if (quantity == 1) break;
                        quantity -= 1;
                        dgv.Rows[e.RowIndex].Cells[2].Value = quantity.ToString();
                        break;
                    case "X":
                        dgvScanProducts.Rows.RemoveAt(e.RowIndex);
                        break;
                }
            }
        }

        private void btnArrival_Click(object sender, EventArgs e)
        {
            //Insert DB
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    var sql = @"insert into ArrivalMain (ArrivalDate)
                                    OUTPUT Inserted.ArrivalMainId
                                    values (@ArrivalDate);";

                    var arrivalMainId = connection.ExecuteScalar<int>(sql, new
                    {
                        ArrivalDate = DateTime.Now,
                    }, transaction);

                    foreach (DataGridViewRow row in dgvScanProducts.Rows)
                    {
                        sql = @"insert into ArrivalDetail (ArrivalMainId, ProductNo, Quantity)
                                values (@ArrivalMainId, @ProductNo, @Quantity) ";

                        connection.Execute(sql, new
                        {
                            ArrivalMainId = arrivalMainId,
                            ProductNo = row.Cells[0].Value,
                            Quantity = row.Cells[2].Value,
                        }, transaction);
                    }

                    transaction.Commit();

                    MessageBox.Show("입고 완료");
                    dgvScanProducts.Rows.Clear();
                }
            }
        }

        private void tbProductNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd.PerformClick();
        }
    }
}
