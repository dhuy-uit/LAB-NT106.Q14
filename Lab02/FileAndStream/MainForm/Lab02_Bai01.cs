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
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("input1.txt");

            string fileContent = sr.ReadToEnd();

            rtbContent.Text = fileContent;

            sr.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string content = rtbContent.Text;

                string upperContent = content.ToUpper();

                using (StreamWriter sw = new StreamWriter("output1.txt"))
                {
                    sw.Write(upperContent);
                }

                MessageBox.Show($"Đã ghi nội dung IN HOA thành công vào file 'output1.txt'.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
