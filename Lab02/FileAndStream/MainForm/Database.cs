using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab02
{
    internal class Database
    {
        private static string dbFile = "Lab02_Bai06.sqlite";
        private static string connectionString = $"Data Source={dbFile};Version=3;";
      
        public static void InitializeDatabase()
        {
            if (File.Exists(dbFile))
            {
                return; 
            }

            try
            {
                SQLiteConnection.CreateFile(dbFile);

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    string sql = "CREATE TABLE NguoiDung (IDNCC INTEGER PRIMARY KEY AUTOINCREMENT, HoVaTen TEXT, QuyenHan TEXT)";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    sql = "CREATE TABLE MonAn (IDMA INTEGER PRIMARY KEY AUTOINCREMENT, TenMonAn TEXT, HinhAnh TEXT, IDNCC INTEGER, FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC))";
                    cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO NguoiDung(HoVaTen, QuyenHan) VALUES ('Nguyễn Văn A', 'Admin')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO NguoiDung(HoVaTen, QuyenHan) VALUES ('Trần Thị B', 'User')";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO MonAn(TenMonAn, HinhAnh, IDNCC) VALUES ('Cơm Tấm', 'comtam.jpg', 1)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO MonAn(TenMonAn, HinhAnh, IDNCC) VALUES ('Phở Bò', 'phobo.jpg', 1)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO MonAn(TenMonAn, HinhAnh, IDNCC) VALUES ('Bún Chả', 'buncha.jpg', 2)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO MonAn(TenMonAn, HinhAnh, IDNCC) VALUES ('Bánh Mì', 'banhmi.jpg', 2)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo database: " + ex.Message);
            }
        }

        public static List<MonAn> GetAllMonAn()
        {
            List<MonAn> list = new List<MonAn>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT m.IDMA, m.TenMonAn, m.HinhAnh, n.HoVaTen " +
                                 "FROM MonAn m " +
                                 "JOIN NguoiDung n ON m.IDNCC = n.IDNCC";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(new MonAn
                        {
                            IDMA = Convert.ToInt32(reader["IDMA"]),
                            TenMonAn = reader["TenMonAn"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            NguoiDongGop = reader["HoVaTen"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy danh sách món ăn: " + ex.Message);
            }
            return list;
        }

        public static MonAn GetRandomMonAn()
        {
            MonAn monAn = null;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT m.IDMA, m.TenMonAn, m.HinhAnh, n.HoVaTen " +
                                 "FROM MonAn m " +
                                 "JOIN NguoiDung n ON m.IDNCC = n.IDNCC " +
                                 "ORDER BY RANDOM() LIMIT 1";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        monAn = new MonAn
                        {
                            IDMA = Convert.ToInt32(reader["IDMA"]),
                            TenMonAn = reader["TenMonAn"].ToString(),
                            HinhAnh = reader["HinhAnh"].ToString(),
                            NguoiDongGop = reader["HoVaTen"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy món ăn ngẫu nhiên: " + ex.Message);
            }
            return monAn;
        }
    }
}
