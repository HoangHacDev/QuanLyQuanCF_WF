namespace QuanLyQuanCF
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        //Sự kiện click
        private void BtnLogin_Click_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng
            FTableManager fTableManager = new FTableManager();
            this.Hide();
            fTableManager.ShowDialog();
            this.Show();

        }

        private void BtnExit_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Sự kiện thoát chương trình
        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu người dùng ấn cancel thì tham số e của Lớp FormClosingEventArgs == true
            // Phương thức tĩnh Show của Lớp MessageBox, 3 tham số (Nội dung, tiêu đề, hiển thị 2 nút ok và cancel)
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo" , MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
