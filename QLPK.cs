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
    public partial class QLPK : Form
    {
        public QLPK()
        {
            InitializeComponent();
        }
        void Dong()
        {
            chkCaovoi.Enabled = false;
            chkTaytrang.Enabled = false;
            cbNhorang.Enabled = false;
            cbTramrang.Enabled = false;
            txtTongtien.Enabled = false;
        }
        void Mo()
        {
            chkCaovoi.Enabled = true;
            chkTaytrang.Enabled = true;
            cbNhorang.Enabled = true;
            cbTramrang.Enabled = true;
            txtTongtien.Enabled = true;
        }
        int[] manggiatri = { 100000, 150000, 150000, 200000 }; //Tạo mảng giá trị của các dịch vụ mục đích nếu có thay đổi giá sẽ dễ dàng hơn
        private void QLPK_Load(object sender, EventArgs e)
        {
            // Hiển thị giá của dịch vụ 
            lbCaovoi.Text = $"{manggiatri[0]} Đ";
            lbTaytrang.Text = $"{manggiatri[1]} Đ";
            lbNhorang.Text = $"{manggiatri[2]} Đ";
            lbTramrang.Text = $"{manggiatri[3]} Đ";
            Dong();
        }
        

        private void txtKH_TextChanged(object sender, EventArgs e)
        {
            if (txtKH.Text == "")
            {
                Dong();
            }
            else
            {
                Mo();
            }
        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            double thanhtoan=0;
            if (chkCaovoi.Checked == true)
            {
                thanhtoan += manggiatri[0];
            }
            
            if(chkTaytrang.Checked == true)
            {
                thanhtoan += manggiatri[1];
            }
            thanhtoan += double.Parse(cbNhorang.SelectedItem.ToString()) * manggiatri[2];
            thanhtoan += double.Parse(cbTramrang.SelectedItem.ToString()) * manggiatri[3];
            txtTongtien.Text = $"{ thanhtoan } Đ";
            MessageBox.Show($"Số tiền khách hàng {txtKH.Text} cần thanh toán là {thanhtoan} đồng","",MessageBoxButtons.OK);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKH.Text = "";
            txtKH.Focus();
            chkCaovoi.Checked = false;
            chkTaytrang.Checked = false;
            cbNhorang.Enabled = false;
            cbTramrang.Enabled = false;
            cbNhorang.Text = "";
            cbTramrang.Text = "";
            txtTongtien.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
