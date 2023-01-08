using Dapper;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace KmSystem
{
    public partial class SettingsForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ConnectingTest_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    MessageBox.Show("Success connection");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
