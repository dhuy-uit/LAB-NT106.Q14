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
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName))
            {
                return;
            }

            try
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();

                rtbContent.Text = content;
                txtFileName.Text = ofd.SafeFileName;
                txtUrl.Text = fs.Name;
                txtSize.Text = fs.Length.ToString() + " bytes";

                txtCharCount.Text = content.Length.ToString();

                char[] delimiters = new char[] { ' ', '\r', '\n' };
                string[] words = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                txtWordCount.Text = words.Length.ToString();

                string[] lines = content.Split('\n');
                txtLineCount.Text = lines.Length.ToString();

                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
