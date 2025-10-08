using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai08 : Form
    {
        public Lab01_Bai08()
        {
            InitializeComponent();

            this.AcceptButton = btnProcess;
            this.Shown += (s, e) => this.ActiveControl = btnProcess;

            btnProcess.Click += btnProcess_Click;
            btnBack.Click += (s, e) => this.Close();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string line = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(line))
            {
                MessageBox.Show("Nhập chuỗi: Họ tên, điểm1, điểm2, ...", "Thiếu dữ liệu");
                txtInput.Focus(); return;
            }

            string[] parts = line.Split(',')
                                 .Select(p => p.Trim())
                                 .Where(p => p.Length > 0)
                                 .ToArray();

            if (parts.Length < 2)
            {
                MessageBox.Show("Format sai. Cần: Họ tên, điểm1, điểm2, ...", "Sai định dạng");
                txtInput.Focus(); txtInput.SelectAll(); return;
            }

            string fullName = parts[0];
            var scores = parts.Skip(1)
                              .Select((s, idx) => new { s, idx })
                              .ToList();

            double[] nums = new double[scores.Count];
            for (int i = 0; i < scores.Count; i++)
            {
                if (!double.TryParse(scores[i].s, NumberStyles.Float, CultureInfo.InvariantCulture, out nums[i]))
                {
                    MessageBox.Show($"Điểm ở vị trí {i + 1} không hợp lệ: \"{scores[i].s}\" (dùng dấu chấm cho số lẻ).",
                        "Sai định dạng");
                    txtInput.Focus(); txtInput.SelectAll(); return;
                }
                if (nums[i] < 0 || nums[i] > 10)
                {
                    MessageBox.Show($"Điểm ở vị trí {i + 1} ngoài khoảng 0..10: {nums[i]}", "Giá trị không hợp lệ");
                    txtInput.Focus(); txtInput.SelectAll(); return;
                }
            }

            double avg = nums.Average();
            int idxMax = Array.IndexOf(nums, nums.Max());
            int idxMin = Array.IndexOf(nums, nums.Min());

            var passed = new System.Collections.Generic.List<string>();
            var failed = new System.Collections.Generic.List<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 5) passed.Add($"Môn {i + 1} ({nums[i]:0.##})");
                else failed.Add($"Môn {i + 1} ({nums[i]:0.##})");
            }

            var sb = new StringBuilder();
            sb.AppendLine($"Họ và tên: {fullName}");
            for (int i = 0; i < nums.Length; i++)
                sb.AppendLine($"Môn {i + 1}: {nums[i].ToString("0.##", CultureInfo.InvariantCulture)}");

            sb.AppendLine();
            sb.AppendLine($"Điểm trung bình: {avg.ToString("0.##", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Môn cao nhất : Môn {idxMax + 1} = {nums[idxMax].ToString("0.##", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Môn thấp nhất: Môn {idxMin + 1} = {nums[idxMin].ToString("0.##", CultureInfo.InvariantCulture)}");
            sb.AppendLine($"Số môn: {nums.Length}");
            sb.AppendLine($"Đậu (>5): {passed.Count}" + (passed.Count > 0 ? " -> " + string.Join(", ", passed) : ""));
            sb.AppendLine($"Rớt (<=5): {failed.Count}" + (failed.Count > 0 ? " -> " + string.Join(", ", failed) : ""));

            txtOutput.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtInput.Focus();
        }
    }
}
