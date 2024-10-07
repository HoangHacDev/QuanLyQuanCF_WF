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
    public partial class FTableManager : Form
    {
        public FTableManager()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAccountProfile fAccountProfile = new FAccountProfile();
            //this.Hide();
            fAccountProfile.ShowDialog();
            //this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin admin = new FAdmin();
            admin.ShowDialog();
        }
    }
}
