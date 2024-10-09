using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCF
{
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadAccountList()
        {
            string connectString = "Data Source=DESKTOP-24HNE0N;Initial Catalog=QuanLyQuanCaffe;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectString);
            string query = "SELECT * FROM dbo.Account";
            SqlCommand command = new SqlCommand(query);
        }            

        private void TpFood_Click(object sender, EventArgs e)
        {

        }

        private void TxbUsername_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
