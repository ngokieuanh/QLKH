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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }
        public bool login = false;

        public void ChangeLogin(bool isLogin)
        {
            login = isLogin;
            if (login == true)
            {
                quảnLýPhòngKhámToolStripMenuItem.Enabled = true;
                quảnLýSinhViênToolStripMenuItem.Enabled = true;
            }
            else
            {
                quảnLýPhòngKhámToolStripMenuItem.Enabled = false;
                quảnLýSinhViênToolStripMenuItem.Enabled = false;
            }
        }
        private void DangNhap_Click(object sender, EventArgs e)
        {
            GiaoDien f1 = new GiaoDien();
            f1.login = new GiaoDien.Login(ChangeLogin);
            f1.ShowDialog();
            // Form dn = new GiaoDien();
            // dn.ShowDialog(); // hiển thị form lên
        }

            private void MENU_Load(object sender, EventArgs e)
        {
            quảnLýPhòngKhámToolStripMenuItem.Enabled = false;
            quảnLýSinhViênToolStripMenuItem.Enabled = false;
        }

        private void quảnLýPhòngKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLPK QLPK = new QLPK();
            QLPK.MdiParent = this;
            QLPK.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKH QLKH = new QLKH();
            QLKH.MdiParent = this;
            QLKH.Show();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTNHOM TTNHOM=new TTNHOM();
            TTNHOM.MdiParent = this;
            TTNHOM.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
    }

