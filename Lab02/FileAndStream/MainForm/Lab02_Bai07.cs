using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai07 : Form
    {
        public Lab02_Bai07()
        {
            InitializeComponent();
        }

        private void Lab02_Bai07_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }

        private void LoadDrives()
        {
            treeViewDirectory.Nodes.Clear();
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                TreeNode driveNode = new TreeNode(drive);
                driveNode.Tag = drive;
                driveNode.Nodes.Add("...loading..."); 
                treeViewDirectory.Nodes.Add(driveNode);
            }
        }

        private void treeViewDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Nodes.Count == 1 && node.Nodes[0].Text == "...loading...")
            {
                node.Nodes.Clear();
                string path = node.Tag.ToString();
                try
                {
                    string[] directories = Directory.GetDirectories(path);
                    foreach (string dir in directories)
                    {
                        TreeNode dirNode = new TreeNode(Path.GetFileName(dir));
                        dirNode.Tag = dir;
                        dirNode.Nodes.Add("...loading...");
                        node.Nodes.Add(dirNode);
                    }

                    string[] files = Directory.GetFiles(path);
                    foreach (string file in files)
                    {
                        TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                        fileNode.Tag = file;
                        node.Nodes.Add(fileNode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi truy cập thư mục: " + ex.Message, "Lỗi");
                }
            }
        }

        private void treeViewDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string path = selectedNode.Tag.ToString();

            pictureBoxContent.Visible = false;
            richTextBoxContent.Visible = false;

            if (File.Exists(path))
            {
                try
                {
                    string extension = Path.GetExtension(path).ToLower();

                    if (extension == ".txt" || extension == ".cs" || extension == ".html" || extension == ".css")
                    {
                        richTextBoxContent.Text = File.ReadAllText(path);
                        richTextBoxContent.Visible = true;
                    }
                    else if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".gif")
                    {
                        pictureBoxContent.ImageLocation = path;
                        pictureBoxContent.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể đọc file: " + ex.Message, "Lỗi");
                }
            }
        }
    }
}
