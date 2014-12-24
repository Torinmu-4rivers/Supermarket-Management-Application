using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmMainNhanVien : Form
    {
        public frmMainNhanVien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBanHang a = new frmBanHang();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCustomers1 b = new frmCustomers1();
            b.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProducts c = new frmProducts();
            c.Show();

        }
    }
}
