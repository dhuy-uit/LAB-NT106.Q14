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
    public partial class Lab02_Bai06 : Form
    {
        public Lab02_Bai06()
        {
            InitializeComponent();
            Database.InitializeDatabase(); 
            LoadDataToListView();
        }

        private void LoadDataToListView()
        {
            listViewMonAn.Items.Clear();
            List<MonAn> danhSach = Database.GetAllMonAn();

            foreach (MonAn mon in danhSach)
            {
                ListViewItem item = new ListViewItem(mon.IDMA.ToString());
                item.SubItems.Add(mon.TenMonAn);
                item.SubItems.Add(mon.NguoiDongGop);
                item.SubItems.Add(mon.HinhAnh);
                listViewMonAn.Items.Add(item);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            MonAn monAn = Database.GetRandomMonAn();
            if (monAn != null)
            {
                txtResultFood.Text = monAn.TenMonAn;
                txtResultContributor.Text = monAn.NguoiDongGop;

                try
                {
                    pictureBoxResult.ImageLocation = monAn.HinhAnh;
                }
                catch
                {
                    pictureBoxResult.Image = null; 
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu món ăn trong database!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataToListView();
        }
    }
}
