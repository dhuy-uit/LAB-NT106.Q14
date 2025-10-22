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

namespace Lab02
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private double EvaluateSimple(string expression)
        {
            string formattedExpression = expression.Replace("-", "+-");

            string[] parts = formattedExpression.Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);

            double result = 0;

            foreach (string part in parts)
            {
                try
                {
                    result += double.Parse(part);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Phát hiện biểu thức không hợp lệ: " + part, "Lỗi Định Dạng");
                }
            }

            return result;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName))
            {
                return;
            }

            string inputFilePath = ofd.FileName;
            string outputFilePath = "output3.txt"; 

            try
            {
                string inputFileContent = File.ReadAllText(inputFilePath);
                rtbInput.Text = inputFileContent;

                StreamReader sr = new StreamReader(inputFilePath);
                StreamWriter sw = new StreamWriter(outputFilePath);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        double result = EvaluateSimple(line);

                        sw.WriteLine(line + "=" + result.ToString());
                    }
                }

                sr.Close();
                sw.Close();

                MessageBox.Show("Đã tính toán và ghi kết quả vào file 'output3.txt' thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                rtbOutput.Text = File.ReadAllText(outputFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
