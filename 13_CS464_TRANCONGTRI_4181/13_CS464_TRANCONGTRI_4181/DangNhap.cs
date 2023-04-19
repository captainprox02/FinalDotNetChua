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
	public partial class DangNhap : Form
	{

		private int soLanNhap = 0;
		Connection conn = new Connection();

		public DangNhap()
		{
			InitializeComponent();
		}

		private void btn_DangNhap_Click(object sender, EventArgs e)
		{
			String taiKhoan = txt_TaiKhoan.Text;
			String matKhau = txt_MatKhau.Text;

			try
			{
				conn.Connect();
				String sql = "SELECT * FROM ThongTinTaiKhoan WHERE TaiKhoan = '" + taiKhoan + "' AND MatKhau = '" + matKhau + "'";
				DataTable dt = conn.getData(sql);
				if (dt != null && dt.Rows.Count > 0)
				{
					MessageBox.Show("Đăng nhập thành công");
					this.Hide();
					frm_Main f = new frm_Main();
					f.ShowDialog();
					this.Close();
				}
				else
				{
					soLanNhap++;
					if (soLanNhap == 3)
					{
						MessageBox.Show("Bạn đã nhập sai 3 lần");
						this.Close();
					}
					MessageBox.Show("Bạn đã nhập sai " + soLanNhap + " lần!");
				}

			}
			catch (System.Exception)
			{
				throw new System.Exception("Lỗi kết nối");
			}
		}
	}
}
