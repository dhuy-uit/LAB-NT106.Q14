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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text, out int N) || N < 1)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương hợp lệ cho N.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN.Focus();
                txtN.SelectAll();
                return;
            }

            string s = txtN.Text.Trim();

            long n = long.Parse(s);
            int b = (int)(n / 1_000_000_000);        // tỷ
            int m = (int)((n / 1_000_000) % 1000);   // triệu
            int k = (int)((n / 1_000) % 1000);       // ngàn
            int u = (int)(n % 1000);                 // đơn vị

            string result = JoinGroups(
                b > 0 ? Read3(b) + " tỷ" : null,
                m > 0 ? Read3(m) + " triệu" : null,
                k > 0 ? Read3(k) + " ngàn" : null,
                (u > 0) ? Read3(u, needZeroHundredsPrefix: (n >= 1000 && u < 100)) : null
            );

            txtText.Text = string.IsNullOrWhiteSpace(result) ? "Không" : NormalizeSpaces(result);
        }

        private string Read3(int num, bool needZeroHundredsPrefix = false)
        {
            string[] d = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            int tr = num / 100, ch = (num / 10) % 10, dv = num % 10;

            var parts = new System.Collections.Generic.List<string>();

            if (tr > 0) parts.Add(d[tr] + " trăm");
            else if (needZeroHundredsPrefix && (ch > 0 || dv > 0)) parts.Add("không trăm");

            if (ch > 1)
            {
                parts.Add(d[ch] + " mươi");
                if (dv == 1) parts.Add("mốt");
                else if (dv == 5) parts.Add("lăm");
                else if (dv != 0) parts.Add(d[dv]);
            }
            else if (ch == 1)
            {
                parts.Add("mười");
                if (dv == 5) parts.Add("lăm");
                else if (dv != 0) parts.Add(d[dv]);
            }
            else
            {
                if (dv != 0)
                {
                    if ((tr > 0) || needZeroHundredsPrefix) parts.Add("lẻ");
                    parts.Add(d[dv]);
                }
            }

            return string.Join(" ", parts);
        }

        private string JoinGroups(params string[] groups)
        {
            var arr = groups?.Where(s => !string.IsNullOrWhiteSpace(s)).ToArray() ?? Array.Empty<string>();
            if (arr.Length == 0) return "";
            string s = string.Join(", ", arr);
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private string NormalizeSpaces(string s) => System.Text.RegularExpressions.Regex.Replace(s, @"\s+", " ").Trim();

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
