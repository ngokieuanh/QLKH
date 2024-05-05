using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN1
{
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }
        public delegate void Login(bool isLogin);
        public Login login;

        private void Giao_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "MRTHO" && txtPass.Text == "123")
            {
                MessageBox.Show("Chào bạn " + txtUsername.Text + " Bạn đã đăng nhập thành công ", "Thông tin đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login(true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Lỗi đăng nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn có muốn thoát không?", "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (t == DialogResult.Yes)
                this.Close();
        }
    }
}
