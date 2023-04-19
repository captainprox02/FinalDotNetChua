using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _13_CS464_TRANCONGTRI_4181
{
	class Connection
	{
		SqlConnection connect;

		public void Connect()
		{
			connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CS464H_TRANCONGTRI_4181_MIDTERM\CS464H_TRANCONGTRI_4181_MIDTERM\CS464H_TRANCONGTRI_4181_MIDTERM\DanhMucBanHang.mdf;Integrated Security=True");
			connect.Open();
		}

		public void close()
		{
			connect.Close();
		}

		public DataTable getData(string sql)
		{
			DataTable table = new DataTable();
			try
			{
				Connect();
				SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
				adapter.Fill(table);
			}
			catch
			{
				table = null;
			}
			finally
			{
				close();
			}

			return table;
		}

		public int setData(string sql)
		{
			try
			{
				Connect();
				SqlCommand command = new SqlCommand(sql, connect);
				return command.ExecuteNonQuery();
			}
			catch
			{
				return -1;
			}
			finally
			{
				close();
			}
		}
	}
}
