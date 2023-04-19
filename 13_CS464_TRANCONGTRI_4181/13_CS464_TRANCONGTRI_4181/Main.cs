using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _13_CS464_TRANCONGTRI_4181
{
	public partial class Main : Form
	{
		Connection lopchung = new Connection();
		string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Resources\";
		public Main()
		{
			InitializeComponent();
		}

		public void LoadNV()
		{
			string sql = "Select * from KHACHHANG";
			DataTable table = lopchung.getData(sql);
			dataGridView1.DataSource = table;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Title = "Hãy chọn ảnh khách hàng";
			open.Filter = "Tất cả ảnh|*.*|JPEG|*.JPEG|PNG|*.PNG|JPG|*.JPG|BMP|*.bmp";
			if (open.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(open.FileName);
			}
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			string sql = "Insert into KHACHHANG values(N'" + txt_MaKhachHang.Text + "',N'"
+ txt_HoVaTen.Text + "',N'" + txt_Tuoi.Text + "',N'" + txt_HinhAnh.Text + "')";
            int ketqua = lopchung.setData(sql);
            if (ketqua >= 1)
            {
                MessageBox.Show("Thêm thành công");
                pictureBox1.Image.Save(duongdan + txt_HinhAnh.Text);
            }
            else MessageBox.Show("Thêm thất bại");
            LoadNV();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadNV();
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			string sql = "Delete from KHACHHANG where MaKH = N'" + txt_MaKhachHang.Text + "'";
			int ketqua = lopchung.setData(sql);
			if (ketqua >= 1)
			{
				MessageBox.Show("Xóa thành công");
			}
			else MessageBox.Show("Xóa thất bại");
			LoadNV();
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			string sql = "Update KHACHHANG set HoTen = N'" + txt_HoVaTen.Text + "',Tuoi = N'" + txt_Tuoi.Text + "',HinhAnh = N'" + txt_HinhAnh.Text + "' where MaKH = N'" + txt_MaKhachHang.Text + "'";
			int ketqua = lopchung.setData(sql);
			if (ketqua >= 1)
			{
				MessageBox.Show("Sửa thành công");
				pictureBox1.Image.Save(duongdan + txt_HinhAnh.Text);
			}
			else MessageBox.Show("Sửa thất bại");
			LoadNV();
		}

		private void rdo_TangDan_CheckedChanged(object sender, EventArgs e)
		{
			dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);

		}

		private void rdo_GiamDan_CheckedChanged(object sender, EventArgs e)
		{
			dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			string sql = "Select * from KHACHHANG where MaKH like N'%" + textBox3.Text + "%'";
			DataTable table = lopchung.getData(sql);
			dataGridView1.DataSource = table;
		}

		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Object[] row = new Object[dataGridView1.ColumnCount];
			for (int i = 0; i < dataGridView1.ColumnCount; i++)
			{
				row[i] = dataGridView1.Rows[e.RowIndex].Cells[i].Value;
			}
			txt_MaKhachHang.Text = row[0].ToString();
			txt_HoVaTen.Text = row[1].ToString();
			txt_Tuoi.Text = row[2].ToString();
			txt_HinhAnh.Text = row[3].ToString();
			pictureBox1.Image = Image.FromFile(duongdan + txt_HinhAnh.Text);
			
		}
	}
}
