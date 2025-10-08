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
    public partial class Lab01_Bai09 : Form
    {
        private string _favoriteDishes =
            "Cơm tấm, Bún bò, Phở bò, Hủ tiếu, Bánh mì, Cơm gà, Bún chả, Bún đậu mắm tôm, Mì quảng";

        private readonly Random _rng = new Random();
        public Lab01_Bai09()
        {
            InitializeComponent();

            this.Shown += (s, e) => this.ActiveControl = btnPick;
            this.AcceptButton = btnPick;

            btnAdd.Click += (s, e) => AddDish();
            btnPick.Click += (s, e) => PickDish();
            btnBack.Click += (s, e) => this.Close();

            ReloadList();
        }

        private List<string> GetDishList()
        {
            return _favoriteDishes
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .Where(s => s.Length > 0)
                .GroupBy(s => s.ToLowerInvariant())
                .Select(g => g.First())
                .ToList();
        }

        private void SetDishList(IEnumerable<string> dishes)
        {
            _favoriteDishes = string.Join(", ", dishes);
        }

        private void ReloadList()
        {
            var list = GetDishList();
            lstDishes.Items.Clear();
            foreach (var d in list) lstDishes.Items.Add(d);
        }

        private void AddDish()
        {
            var newDish = (txtNewDish.Text ?? "").Trim();
            if (newDish.Length == 0)
            {
                MessageBox.Show("Nhập tên món trước khi thêm nhé!", "Thiếu dữ liệu");
                txtNewDish.Focus();
                return;
            }

            var list = GetDishList();
            bool exists = list.Any(x => x.Equals(newDish, StringComparison.InvariantCultureIgnoreCase));
            if (!exists)
            {
                list.Add(newDish);
                SetDishList(list);
                ReloadList();
                txtNewDish.Clear();
                txtNewDish.Focus();
            }
            else
            {
                MessageBox.Show($"Món \"{newDish}\" đã có sẵn rồi!", "Thông báo");
                txtNewDish.SelectAll();
                txtNewDish.Focus();
            }
        }

        private void PickDish()
        {
            var list = GetDishList();
            if (list.Count == 0)
            {
                MessageBox.Show("Danh sách món đang trống. Hãy thêm ít nhất 1 món!", "Chưa có dữ liệu");
                txtNewDish.Focus();
                return;
            }

            int i = _rng.Next(list.Count);
            string choice = list[i];

            txtToday.Text = $"{choice} 😋";

            lstDishes.SelectedIndex = i;
            lstDishes.TopIndex = Math.Max(0, i - 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNewDish.Clear();
            txtNewDish.Focus();
        }
    }
}
