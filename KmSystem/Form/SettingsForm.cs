using System;
using System.Configuration;
using System.Data.SqlClient;
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

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void ConnectingTest_Click(object sender, EventArgs e)
        {
            using(var connection = new SqlConnection(connectionString))
            {

            }
        }
    }
}
