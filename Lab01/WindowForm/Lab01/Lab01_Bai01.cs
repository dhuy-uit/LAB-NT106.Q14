using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text, out int a) || !int.TryParse(txtB.Text, out int b))
            {
                MessageBox.Show("Vui lòng nhập SỐ NGUYÊN hợp lệ!", "Lỗi");
                return;
            }
            txtSum.Text = (a + b).ToString();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtSum.Clear();
            txtA.Focus();
        }
    }
}
