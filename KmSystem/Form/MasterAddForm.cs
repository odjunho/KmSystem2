using Dapper;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KmSystem
{
    public partial class MasterAddForm : Form
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public MasterAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SetProduct();
                SetProductPrice();

                MessageBox.Show("상품 등록 성공");

                InitializeTextBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetProduct()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var sql = @"insert into Product (ProductNo, ProductName, Location)
                            values (@ProductNo, @ProductName, @Location) ";

                connection.Execute(sql, new
                {
                    ProductNo = tbProductNo.Text,
                    ProductName = tbProductName.Text,
                    Location = tbLocation.Text,
                });
            }
        }

        private void SetProductPrice()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var sql = @"insert into ProductPrice (ProductNo, ProductPrice, StartDate, EndDate)
                            values (@ProductNo, @ProductPrice, @StartDate, '9999-12-31') ";

                connection.Execute(sql, new
                {
                    ProductNo = tbProductNo.Text,
                    ProductPrice = tbProductPrice.Text,
                    StartDate = DateTime.Now.Date,
                });
            }
        }

        private void InitializeTextBox()
        {
            tbProductNo.Text = "";
            tbProductName.Text = "";
            tbProductPrice.Text = "";
            tbLocation.Text = "";
        }
    }
}
