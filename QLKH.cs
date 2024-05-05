using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTN1
{
    public partial class QLKH : Form
    {
        SqlCommand command;
        static String str = "Data Source=KIEU-ANH;Initial Catalog=QLKH;Integrated Security=True";
        SqlConnection conn = new SqlConnection(str);
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable(); // Tạo một table để đưa dữ liệu vào 
        void loaddata()
        {
            command = conn.CreateCommand();
            command.CommandText = "Select *from KhachHang"; // Câu lệnh SQL đến bảng cần hiển thị
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table); // Đổ dữ liệu vào table
            dgvKH.DataSource = table; 
        }
        void Dong() // Khởi tạo một 
        {
            txtmakh.Enabled = false;
            txthokh.Enabled = false;
            txttenkh.Enabled = false;
            dtngaydh.Enabled = false;
            cbgioitinh.Enabled = false;
            txtmadon.Enabled = false;
        }
        void Mo()
        {
            txtmakh.Enabled = true;
            txthokh.Enabled = true;
            txttenkh.Enabled = true;
            dtngaydh.Enabled = true;
            cbgioitinh.Enabled = true;
            txtmadon.Enabled = true;
        }
        public QLKH()
        {
            InitializeComponent();
        }
        private void QLSV_Load(object sender, EventArgs e) 
        {
            Dong();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                loaddata();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex) // Cố gắng catch không được sẽ hiển thị lỗi ra màn hình
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNhapmoi_Click(object sender, EventArgs e)
        {
            Mo();
            txtmakh.Focus();
            txtmakh.Text = "";
            txthokh.Text = "";
            txttenkh.Text = "";
            dtngaydh.Text = "";
            cbgioitinh.Text = "";
            txtmadon.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Mo();
            if (txtmakh.Equals(""))
            {
                MessageBox.Show("Không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                command = conn.CreateCommand();
                command.CommandText = "insert into KhachHang values ('" + txtmakh.Text + "',N'" + txthokh.Text + "',N'" + txttenkh.Text + "','" + dtngaydh.Value.ToString("yyyy/MM/dd") + "',N'" + cbgioitinh.Text + "',N'" + txtmadon.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSua_Click_1(object sender, EventArgs e) /* Khi đặt chuột vào bảng DGV tại vị trí cần chỉnh sửa rồi ấn sửa
                                                                   khi đó người dùng có quyền chỉnh sửa đối tượng đã chỉ định*/
        { 
            Mo();
            int i;
            i = dgvKH.CurrentRow.Index;
            txtmakh.Text = dgvKH.Rows[i].Cells[0].Value.ToString();
            txthokh.Text = dgvKH.Rows[i].Cells[1].Value.ToString();
            txttenkh.Text = dgvKH.Rows[i].Cells[2].Value.ToString();
            dtngaydh.Text = dgvKH.Rows[i].Cells[3].Value.ToString();
            cbgioitinh.Text = dgvKH.Rows[i].Cells[4].Value.ToString();
            txtmadon.Text = dgvKH.Rows[i].Cells[5].Value.ToString();
        }
        private void btnLuuchinhsua_Click(object sender, EventArgs e) 
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                command = conn.CreateCommand();
                command.CommandText = "update KhachHang set HoKH =N'" + txthokh.Text + "', TenKH = N'" + txttenkh.Text + "',NgayDatHang ='" + dtngaydh.Value.ToString("yyyy/MM/dd") + "',GioiTinh = N'" + cbgioitinh.Text + "', MaDonHang =N'" + txtmadon.Text + "' where MaKH ='" + txtmakh.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            Mo();
            int i;
            i = dgvKH.CurrentRow.Index;
            txtmakh.Text = dgvKH.Rows[i].Cells[0].Value.ToString();
            txthokh.Text = dgvKH.Rows[i].Cells[1].Value.ToString();
            txttenkh.Text = dgvKH.Rows[i].Cells[2].Value.ToString();
            dtngaydh.Text = dgvKH.Rows[i].Cells[3].Value.ToString();
            cbgioitinh.Text = dgvKH.Rows[i].Cells[4].Value.ToString();
            txtmadon.Text = dgvKH.Rows[i].Cells[5].Value.ToString();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                command = conn.CreateCommand();
                command.CommandText = "delete from KhachHang where MaKH = '" + txtmakh.Text + "' ";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            txtmakh.Text = "";
            txthokh.Text = "";
            txttenkh.Text = "";
            dtngaydh.Text = "";
            cbgioitinh.Text = "";
            txtmadon.Text = "";
            Dong();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát không?", "Thoát!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
