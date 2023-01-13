using Dapper;
using KmSystem.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KmSystem
{
    public partial class MasterForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public MasterForm()
        {
            InitializeComponent();
            InitializeProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MasterAddForm masterAdd = new MasterAddForm();

            masterAdd.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.Rows.Clear();

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var sql = @"select p.ProductId, p.ProductNo, p.ProductName, pp.ProductPrice, p.Location, isnull(ad.Quantity, 0) - isnull(sd.Quantity, 0) as Inventory
                                from Product p
                                inner join ProductPrice pp on p.ProductNo = pp.ProductNo
                                left join (select ProductNo, sum(Quantity) as Quantity from ArrivalDetail group by ProductNo) ad on p.ProductNo = ad.ProductNo
                                left join (select ProductNo, sum(Quantity) as Quantity from SalesDetail group by ProductNo) sd on p.ProductNo = sd.ProductNo
                                where p.IsDeleted = 0 ";

                    if (tbProductNo.Text.Length > 0)
                    {
                        sql += $"and p.ProductNo like '%{tbProductNo.Text}%'";
                    }

                    if (tbProductName.Text.Length > 0)
                    {
                        sql += $@"and p.ProductName like '%{tbProductName.Text}%'";
                    }

                    var productList = connection.Query<Product>(sql);

                    foreach (var product in productList)
                    {
                        var row = new string[]
                        {
                            product.ProductNo,
                            product.ProductName,
                            string.Format("{0:#,##0}", double.Parse(product.ProductPrice.ToString())),
                            product.Location,
                            product.Inventory.ToString(),
                        };

                        dgvProducts.Rows.Add(row);
                    }
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

        private void InitializeProducts()
        {
            dgvProducts.ColumnCount = 5;

            // カラム名を指定
            dgvProducts.Columns[0].HeaderText = "상품번호";
            dgvProducts.Columns[1].HeaderText = "상품명";
            dgvProducts.Columns[2].HeaderText = "가격";
            dgvProducts.Columns[3].HeaderText = "위치";
            dgvProducts.Columns[4].HeaderText = "재고";
        }

        private void tbProductNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }
    }
}
