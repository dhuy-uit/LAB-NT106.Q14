using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();

            cboAction.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAction.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            cboAction.SelectedIndex = 0;

            this.AcceptButton = btnCalc;
            this.Shown += (s, e) => this.ActiveControl = btnCalc;

            btnCalc.Click += btnCalc_Click;
            btnClear.Click += (s, e) => { txtA.Clear(); txtB.Clear(); txtResult.Clear(); txtA.Focus(); };
            btnExit.Click += (s, e) => this.Close();

            txtA.KeyPress += IntegerAllowNegative_KeyPress;
            txtB.KeyPress += IntegerAllowNegative_KeyPress;
        }

        private void IntegerAllowNegative_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            var tb = sender as TextBox;
            if (e.KeyChar == '-' && tb.SelectionStart == 0 && !tb.Text.Contains("-")) return;
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text.Trim(), out int A) ||
                !int.TryParse(txtB.Text.Trim(), out int B))
            {
                MessageBox.Show("Vui lòng nhập A, B là SỐ NGUYÊN.", "Lỗi");
                return;
            }

            string action = cboAction.SelectedItem?.ToString() ?? "";
            if (action == "Bảng cửu chương")
            {
                int x = B - A;
                var sb = new StringBuilder();
                sb.AppendLine($"--- Bảng cửu chương của {x} ---");
                for (int j = 1; j <= 9; j++)
                    sb.AppendLine($"{x} x {j} = {x * j}");
                txtResult.Text = sb.ToString();
            }
            else 
            {
                int n = A - B;
                string fact = n < 0 ? "Không xác định (A - B < 0)" : FactorialBig(n).ToString();

                string sum;
                if (B <= 0) sum = "0";
                else
                {
                    BigInteger S = 0, pow = 1;
                    for (int k = 1; k <= B; k++) { pow *= A; S += pow; }
                    sum = S.ToString();
                }

                txtResult.Text =
    $@"KẾT QUẢ
(A - B)! = {fact}
S = A^1 + A^2 + ... + A^{B} = {sum}";
            }
        }

        private BigInteger FactorialBig(int n)
        {
            BigInteger res = 1;
            for (int i = 2; i <= n; i++) res *= i;
            return res;
        }
    }
}
