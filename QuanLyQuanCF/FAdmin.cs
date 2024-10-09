using Microsoft.Data.SqlClient;
using QuanLyQuanCF.DAO;
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
            // câu truy vấn query
            //string query = "SELECT DisplayName as [Tên hiển thị] FROM dbo.Account";
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";
            // Khởi tạo đối tượng từ lớp DataProvider
            DataProvider provider = new DataProvider();
            // Hiển thị dữ liệu dựa trên câu truy vấn , gán vô view
            DtgvShowUser_Ad.DataSource = provider.ExecuteQuery(query, new object[] {"staff"});
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
