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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void danhMucHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DanhMucHang danhMucHang = new frm_DanhMucHang();
            danhMucHang.MdiParent = this;
            danhMucHang.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(("Bạn muốn đóng chứ ?"), "Đóng", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
