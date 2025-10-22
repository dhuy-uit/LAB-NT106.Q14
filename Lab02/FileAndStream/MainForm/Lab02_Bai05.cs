using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Lab02_Bai05 : Form
    {
        private List<MovieSale> movieSalesData = new List<MovieSale>();
        public Lab02_Bai05()
        {
            InitializeComponent();
        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName)) return;

            try
            {
                StreamReader sr = new StreamReader(ofd.FileName);

                movieSalesData.Clear();
                rtbDisplayMovies.Clear();
                cbMovies.Items.Clear();

                while (!sr.EndOfStream)
                {
                    string tenPhim = sr.ReadLine();
                    if (string.IsNullOrEmpty(tenPhim)) break;

                    int giaVe = int.Parse(sr.ReadLine());
                    string phongChieuStr = sr.ReadLine(); 

                    int soPhong = phongChieuStr.Split(',').Length;
                    int tongSoGhe = soPhong * 100; 

                    MovieSale sale = new MovieSale
                    {
                        TenPhim = tenPhim,
                        GiaVeChuan = giaVe,
                        SoVeBanRa = 0, 
                        TongSoGhe = tongSoGhe
                    };

                    movieSalesData.Add(sale);
                    rtbDisplayMovies.Text += $"Phim: {tenPhim} (Giá: {giaVe})\n" +
                                             $"Phòng: {phongChieuStr} (Tổng số ghế: {tongSoGhe})\n---\n";
                    cbMovies.Items.Add(tenPhim);
                }

                sr.Close();

                if (cbMovies.Items.Count > 0)
                {
                    cbMovies.SelectedIndex = 0;
                }
                MessageBox.Show("Đã đọc file input và tải dữ liệu phim thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi");
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (cbMovies.SelectedIndex == -1 || movieSalesData.Count == 0)
            {
                MessageBox.Show("Vui lòng đọc file input và chọn phim trước.", "Lỗi");
                return;
            }

            string selectedMovieName = cbMovies.SelectedItem.ToString();
            int ticketsToBuy = (int)numTickets.Value;

            MovieSale movie = movieSalesData.FirstOrDefault(m => m.TenPhim == selectedMovieName);

            if (movie == null) return;

            int veConLai = movie.TongSoGhe - movie.SoVeBanRa;

            if (ticketsToBuy > veConLai)
            {
                MessageBox.Show($"Không đủ vé! Phim '{movie.TenPhim}' chỉ còn {veConLai} vé.", "Hết vé");
                return;
            }

            movie.SoVeBanRa += ticketsToBuy;
            double cost = ticketsToBuy * movie.GiaVeChuan;
            veConLai = movie.TongSoGhe - movie.SoVeBanRa;

            MessageBox.Show($"Bán thành công {ticketsToBuy} vé phim '{movie.TenPhim}'.\n" +
                            $"Tổng tiền: {cost} VND.\n" +
                            $"Số vé tồn: {veConLai}", "Giao dịch thành công");
        }

        private void btnExportStats_Click(object sender, EventArgs e)
        {
            if (movieSalesData.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để thống kê. Vui lòng đọc file input và bán vé.", "Lỗi");
                return;
            }

            List<MovieStat> stats = new List<MovieStat>();

            progressBar.Minimum = 0;
            progressBar.Maximum = movieSalesData.Count;
            progressBar.Value = 0;

            foreach (var movie in movieSalesData)
            {
                int veTon = movie.TongSoGhe - movie.SoVeBanRa;
                double doanhThu = (double)movie.SoVeBanRa * movie.GiaVeChuan;
                double tiLe = (movie.TongSoGhe > 0) ? ((double)movie.SoVeBanRa / movie.TongSoGhe) * 100 : 0;

                stats.Add(new MovieStat
                {
                    TenPhim = movie.TenPhim,
                    VeBanRa = movie.SoVeBanRa,
                    VeTon = veTon,
                    TiLeVeBanRa = Math.Round(tiLe, 2),
                    DoanhThu = doanhThu
                });

                progressBar.Value++;
                Thread.Sleep(50); 
                Application.DoEvents();
            }

            stats = stats.OrderByDescending(s => s.DoanhThu).ToList();

            try
            {
                StreamWriter sw = new StreamWriter("output5.txt");
                rtbStatistics.Clear();

                for (int i = 0; i < stats.Count; i++)
                {
                    MovieStat s = stats[i];
                    int xepHang = i + 1;

                    string line1 = $"Tên phim: {s.TenPhim}";
                    string line2 = $"Số lượng vé bán ra: {s.VeBanRa}";
                    string line3 = $"Số lượng vé tồn: {s.VeTon}";
                    string line4 = $"Tỉ lệ vé bán ra: {s.TiLeVeBanRa}%";
                    string line5 = $"Doanh thu: {s.DoanhThu} VND";
                    string line6 = $"Xếp hạng doanh thu: {xepHang}";
                    string separator = "----------------------------------------";

                    string output = $"{line1}\n{line2}\n{line3}\n{line4}\n{line5}\n{line6}\n{separator}\n";

                    sw.WriteLine(output);
                    rtbStatistics.Text += output;
                }

                sw.Close();
                progressBar.Value = 0;
                MessageBox.Show("Xuất file thống kê 'output5.txt' thành công!", "Hoàn tất");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file output: " + ex.Message, "Lỗi");
            }
        }
    }
}
