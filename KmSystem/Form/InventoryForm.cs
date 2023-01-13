using Dapper;
using KmSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KmSystem
{
    public partial class InventoryForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public InventoryForm()
        {
            InitializeComponent();
            InitializeProducts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(tbProductNo.Text.Length == 0 && tbProductName.Text.Length == 0)
                {
                    MessageBox.Show("상품 정보를 입력해주세요");
                    return;
                }

                dgvProducts.Rows.Clear();

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var sql = @"select a.Date, a.ProductNo, p.ProductName, p.Location, a.Type, a.Quantity
                                from 
                                (
                                	select '판매' as Type, sm.BuyDate as Date, sd.ProductNo, sd.Quantity * -1 as Quantity from SalesDetail sd
                                	inner join SalesMain sm on sd.SalesMainId = sm.SalesMainId

                                	UNION ALL

                                	select '입고', am.ArrivalDate, ad.ProductNo, ad.Quantity from ArrivalDetail ad
                                	inner join ArrivalMain am on ad.ArrivalMainId = am.ArrivalMainId
                                ) a
                                inner join product p on a.ProductNo = p.ProductNo
                                where p.IsDeleted = 0 ";

                    if (tbProductNo.Text.Length > 0)
                    {
                        sql += $" and p.ProductNo = @ProductNo";
                    }

                    if (tbProductName.Text.Length > 0)
                    {
                        sql += $@" and p.ProductName = @ProductName";
                    }

                    sql += " order by Date ";

                    var inventoryList = connection.Query<Inventory>(sql, new
                    {
                        ProductNo = tbProductNo.Text,
                        ProductName = tbProductName.Text,
                    });

                    tbTotalQuantity.Text = inventoryList.Sum(i => i.Quantity).ToString();

                    foreach (var inventory in inventoryList)
                    {
                        var row = new string[]
                        {
                            inventory.ProductNo,
                            inventory.ProductName,
                            inventory.Location,
                            inventory.Type,
                            inventory.Date.ToString(),
                            inventory.Quantity.ToString(),
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
            dgvProducts.ColumnCount = 6;

            // カラム名を指定
            dgvProducts.Columns[0].HeaderText = "상품번호";
            dgvProducts.Columns[1].HeaderText = "상품명";
            dgvProducts.Columns[2].HeaderText = "위치";
            dgvProducts.Columns[3].HeaderText = "타입";
            dgvProducts.Columns[4].HeaderText = "날짜";
            dgvProducts.Columns[5].HeaderText = "수량";

            dgvProducts.Columns[1].Width = 140;
            dgvProducts.Columns[4].Width = 170;
        }

        private void tbProductNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }
    }
}
