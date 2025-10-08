using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai05 : Form
    {
        class Movie
        {
            public string Name;
            public int BasePrice;        // giá vé chuẩn (VND)
            public int[] Rooms;          // các rạp (phòng) hợp lệ
            public override string ToString() => Name;
        }

        // Danh sách phim + giá + rạp hợp lệ
        readonly Dictionary<string, Movie> _movies = new Dictionary<string, Movie>
        {
            ["Đào, phở và piano"] = new Movie { Name = "Đào, phở và piano", BasePrice = 45000, Rooms = new[] { 1, 2, 3 } },
            ["Mai"] = new Movie { Name = "Mai", BasePrice = 100000, Rooms = new[] { 2, 3 } },
            ["Gặp lại chị bầu"] = new Movie { Name = "Gặp lại chị bầu", BasePrice = 70000, Rooms = new[] { 1 } },
            ["Tarot"] = new Movie { Name = "Tarot", BasePrice = 90000, Rooms = new[] { 3 } },
        };

        // Sơ đồ ghế: A1..A5, B1..B5, C1..C5
        static readonly string[] AllSeats = {
            "A1","A2","A3","A4","A5",
            "B1","B2","B3","B4","B5",
            "C1","C2","C3","C4","C5"
        };

        // Phân hạng ghế: vớt = 1/4, VIP = x2, còn lại = thường
        readonly HashSet<string> _vot = new HashSet<string> { "A1", "A5", "C1", "C5" };
        readonly HashSet<string> _vip = new HashSet<string> { "B2", "B3", "B4" };

        // Lưu ghế đã bán theo khóa "Movie|Room"
        static readonly Dictionary<string, HashSet<string>> _sold = new Dictionary<string, HashSet<string>>();
        public Lab01_Bai05()
        {
            InitializeComponent();
            this.Shown += (s, e) => this.ActiveControl = btnBook;
            this.AcceptButton = btnBook;

            // ComboBox kiểu chỉ chọn
            cbxMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxRoom.DropDownStyle = ComboBoxStyle.DropDownList;

            // Nạp phim
            cbxMovie.Items.AddRange(_movies.Keys.ToArray());
            if (cbxMovie.Items.Count > 0) cbxMovie.SelectedIndex = 0;

            // Sự kiện
            cbxMovie.SelectedIndexChanged += (s, e) => LoadRooms();
            cbxRoom.SelectedIndexChanged += (s, e) => LoadSeats();
            btnBook.Click += (s, e) => Book();
            btnBack.Click += (s, e) => this.Close();

            // Chặn SĐT chỉ nhận số (9–11 số)
            txtPhone.KeyPress += (s, e) =>
            {
                if (char.IsControl(e.KeyChar)) return;
                if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            };
        }

        // ====== Helper ======
        string Key(string movie, string room) => movie + "|" + room;

        void LoadRooms()
        {
            cbxRoom.Items.Clear();
            checkedListBox1.Items.Clear();

            if (cbxMovie.SelectedItem is string mv && _movies.TryGetValue(mv, out var m))
            {
                foreach (var r in m.Rooms) cbxRoom.Items.Add(r.ToString());
                if (cbxRoom.Items.Count > 0) cbxRoom.SelectedIndex = 0;
            }
        }

        void LoadSeats()
        {
            checkedListBox1.Items.Clear();
            if (!(cbxMovie.SelectedItem is string mv) || cbxRoom.SelectedItem == null) return;

            var room = cbxRoom.SelectedItem.ToString();
            var key = Key(mv, room);

            if (!_sold.TryGetValue(key, out var soldSet))
            {
                soldSet = new HashSet<string>();
                _sold[key] = soldSet;
            }

            // Chỉ hiện ghế chưa bán
            foreach (var seat in AllSeats)
                if (!soldSet.Contains(seat))
                    checkedListBox1.Items.Add(seat);
        }

        decimal Multiplier(string seat)
        {
            if (_vot.Contains(seat)) return 0.25m; // vớt
            if (_vip.Contains(seat)) return 2m;    // VIP
            return 1m;                              // thường
        }

        bool IsValidPhone(string p) => Regex.IsMatch(p, @"^\d{9,11}$");

        // ====== Đặt vé ======
        void Book()
        {
            // Validate cơ bản
            var name = txtName.Text.Trim();
            var phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thiếu thông tin");
                txtName.Focus(); return;
            }
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("SĐT chỉ gồm 9–11 chữ số.", "Sai định dạng");
                txtPhone.Focus(); txtPhone.SelectAll(); return;
            }
            if (!(cbxMovie.SelectedItem is string mv) || !_movies.TryGetValue(mv, out var movie))
            {
                MessageBox.Show("Hãy chọn phim.", "Thiếu thông tin"); return;
            }
            if (cbxRoom.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn rạp (phòng).", "Thiếu thông tin"); return;
            }
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn ít nhất một ghế.", "Thiếu thông tin"); return;
            }

            var room = cbxRoom.SelectedItem.ToString();
            var key = Key(mv, room);
            if (!_sold.TryGetValue(key, out var soldSet))
            {
                soldSet = new HashSet<string>();
                _sold[key] = soldSet;
            }

            // Tính tiền & kiểm tra trùng ghế
            var picked = new List<string>();
            decimal total = 0;

            foreach (var it in checkedListBox1.CheckedItems)
            {
                var seat = it.ToString();
                if (soldSet.Contains(seat))
                {
                    MessageBox.Show($"Ghế {seat} đã bán rồi!", "Lỗi");
                    return;
                }
                picked.Add(seat);
                total += movie.BasePrice * Multiplier(seat);
            }

            // Ghi nhận đã bán
            foreach (var seat in picked) soldSet.Add(seat);

            // Làm sạch danh sách ghế để tránh tick sót
            LoadSeats();

            // ====== THÔNG BÁO THÔNG TIN VÉ ======
            string seats = string.Join(", ", picked);
            string msg =
$@"ĐẶT VÉ THÀNH CÔNG ✅

Khách       : {name}
SĐT         : {phone}
Phim        : {movie.Name}
Rạp (phòng) : {room}
Ghế         : {seats}
Giá chuẩn   : {movie.BasePrice:#,0} đ
Thành tiền  : {total:#,0} đ

Vui lòng đọc số điện thoại để nhận vé tại quầy.";

            MessageBox.Show(msg, "Thông tin vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
