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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
            this.Shown += (s, e) => this.ActiveControl = null;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text, out int a))
            {
                MessageBox.Show("A không phải số nguyên!", "Lỗi nhập liệu");
                txtA.Focus();
                txtA.SelectAll();
                return;
            }
            if(!int.TryParse(txtB.Text, out int b)) {
                MessageBox.Show("B không phải số nguyên!", "Lỗi nhập liệu");
                txtB.Focus();
                txtB.SelectAll();
                return;
            }
            if (!int.TryParse(txtC.Text, out int c))
            {
                MessageBox.Show("C không phải số nguyên!", "Lỗi nhập liệu");
                txtC.Focus();
                txtC.SelectAll();
                return;
            }

            int max = a, min = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (b < min) min = b;
            if (c < min) min = c;
            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtMax.Clear();
            txtMin.Clear();
            txtA.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
