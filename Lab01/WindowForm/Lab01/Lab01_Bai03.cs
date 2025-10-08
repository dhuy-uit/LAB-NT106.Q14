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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
            this.Shown += (s, e) => this.ActiveControl = null;
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text, out int n))
            {
                MessageBox.Show("N không phải số nguyên!", "Lỗi nhập liệu");
                txtN.Focus();
                txtN.SelectAll();
                return;
            }

            if (n < 0 || n > 9)
            {
                MessageBox.Show("N không nằm trong đoạn [0-9]!", "Lỗi nhập liệu");
                txtN.Focus();
                txtN.SelectAll();
                return;
            }

            string s;
            switch (n)
            {
                case 0: s = "Không"; break;
                case 1: s = "Một"; break;
                case 2: s = "Hai"; break;
                case 3: s = "Ba"; break;
                case 4: s = "Bốn"; break;
                case 5: s = "Năm"; break;
                case 6: s = "Sáu"; break;
                case 7: s = "Bảy"; break;
                case 8: s = "Tám"; break;
                case 9: s = "Chín"; break;
                default: s = ""; break;
            }
            txtText.Text = s;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtText.Clear();
            txtN.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
