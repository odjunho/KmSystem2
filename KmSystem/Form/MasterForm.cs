using Dapper;
using KmSystem.Model;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

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

                    var sql = @"select p.ProductId, p.ProductNo, p.ProductName, pp.ProductPrice, p.Location
                                from Product p
                                inner join ProductPrice pp on p.ProductNo = pp.ProductNo
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
                            product.ProductPrice.ToString(),
                            product.Location,
                        };

                        dgvProducts.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeProducts()
        {
            dgvProducts.ColumnCount = 4;

            // カラム名を指定
            dgvProducts.Columns[0].HeaderText = "ProductNo";
            dgvProducts.Columns[1].HeaderText = "ProductName";
            dgvProducts.Columns[2].HeaderText = "ProductPrice";
            dgvProducts.Columns[3].HeaderText = "Location";

            //// Delete Button
            //var column = new DataGridViewButtonColumn();
            ////列の名前を設定
            ////column.Name = "EDIT";
            ////全てのボタンに"詳細閲覧"と表示する
            //column.UseColumnTextForButtonValue = true;
            //column.Text = "EDIT";
            ////DataGridViewに追加する
            //dgvProducts.Columns.Add(column);
        }
    }
}
