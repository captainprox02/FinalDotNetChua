using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_CS464_TRANCONGTRI_4181
{
    public partial class frm_DanhMucHang : Form
    {

        Connection conn = new Connection();

        public frm_DanhMucHang()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string MaHnag = txt_MaHang.Text;
            string TenHang = txt_TenHang.Text;
            string MaNhaCungCap = cb_NhaCungCap.SelectedValue.ToString();
			string DonViTinh = cb_DonViTinh.Text;
			
            try
            {
                string sql = "INSERT INTO DANHMUCHANG(ma_hang, ten_hang, ma_nhacc, don_vi_tinh) VALUES (N'" + MaHnag + "', N'" + TenHang + "', N'" + MaNhaCungCap + "', N'" + DonViTinh + "')";

                conn.Connect();
				int ketqua = conn.setData(sql);

				if (ketqua > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDanhMucHang();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
				conn.close();

			}
            catch (System.Exception)
            {

                throw new System.Exception("Lỗi kết nối");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string MaHnag = txt_MaHang.Text;
            string TenHang = txt_TenHang.Text;
            string MaNhaCungCap = cb_NhaCungCap.SelectedValue.ToString();
            string DonViTinh = cb_DonViTinh.Text; ;

            string sql = "UPDATE DANHMUCHANG SET ten_hang = N'" + TenHang + "', ma_nhacc = N'" + MaNhaCungCap + "', don_vi_tinh = N'" + DonViTinh + "' WHERE ma_hang = N'" + MaHnag + "'";

            conn.Connect();
            if (conn.setData(sql) > 0)
            {
                MessageBox.Show("Sửa thành công");
                LoadDanhMucHang();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            conn.close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string MaHnag = txt_MaHang.Text;

            string sql = "DELETE FROM DANHMUCHANG WHERE ma_hang = N'" + MaHnag + "'";

            conn.Connect();
			int ketqua = conn.setData(sql);
            if (ketqua > 0)
            {
                MessageBox.Show("Xóa thành công");
                LoadDanhMucHang();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            conn.close();
        }

        private void LoadDanhMucHang()
        {
            string sql = "SELECT * FROM DANHMUCHANG";
            conn.Connect();
            DataTable dt = conn.getData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            conn.close();
        }

        private void LoadNhaCungCap()
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            conn.Connect();
            DataTable dt = conn.getData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                cb_NhaCungCap.DataSource = dt;
                cb_NhaCungCap.DisplayMember = "ten_nhacc";
                cb_NhaCungCap.ValueMember = "ma_nhacc";
            }
            conn.close();
        }

        private void frm_DanhMucHang_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            cb_DonViTinh.SelectedIndex = 0;
            LoadDanhMucHang();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(("Bạn muốn đóng chứ ?"), "Đóng", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0)
			{
				string MaNhaCungCap = dataGridView1.Rows[index].Cells[2].Value.ToString();
				txt_MaHang.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
				txt_TenHang.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
				cb_NhaCungCap.SelectedValue = MaNhaCungCap;
				cb_DonViTinh.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
			}
		}
	}
}
