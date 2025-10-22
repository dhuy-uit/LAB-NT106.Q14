using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai04 : Form
    {
        private List<Student> listInputStudents = new List<Student>();
        private List<StudentOutput> listOutputStudents = new List<StudentOutput>();
        private int currentIndex = 0;
        public Lab02_Bai04()
        {
            InitializeComponent();
        }

        private bool IsValidID(string id)
        {
            return Regex.IsMatch(id, @"^\d{8}$");
        }

        private bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^0\d{9}$");
        }

        private bool IsValidScore(string scoreText, out float score)
        {
            if (float.TryParse(scoreText, out score))
            {
                return score >= 0 && score <= 10;
            }
            return false;
        }

        // --- LEFT PANEL (INPUT) ---

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidID(txtIDInput.Text))
            {
                MessageBox.Show("MSSV phải là 8 chữ số.", "Lỗi Validation");
                return;
            }

            if (!IsValidPhone(txtPhoneInput.Text))
            {
                MessageBox.Show("SĐT phải là 10 chữ số, bắt đầu bằng 0.", "Lỗi Validation");
                return;
            }

            float diem1, diem2, diem3;
            if (!IsValidScore(txtCourse1Input.Text, out diem1) ||
                !IsValidScore(txtCourse2Input.Text, out diem2) ||
                !IsValidScore(txtCourse3Input.Text, out diem3))
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10.", "Lỗi Validation");
                return;
            }

            Student st = new Student
            {
                HoTen = txtNameInput.Text,
                MSSV = txtIDInput.Text,
                DienThoai = txtPhoneInput.Text,
                DiemMon1 = diem1,
                DiemMon2 = diem2,
                DiemMon3 = diem3
            };

            listInputStudents.Add(st);
            UpdateInputDisplay();
            ClearInputFields();
        }

        private void UpdateInputDisplay()
        {
            rtbInputDisplay.Clear();
            foreach (var st in listInputStudents)
            {
                rtbInputDisplay.Text += $"{st.HoTen}\n{st.MSSV}\n{st.DienThoai}\n" +
                                        $"{st.DiemMon1}, {st.DiemMon2}, {st.DiemMon3}\n---\n";
            }
        }

        private void ClearInputFields()
        {
            txtNameInput.Clear();
            txtIDInput.Clear();
            txtPhoneInput.Clear();
            txtCourse1Input.Clear();
            txtCourse2Input.Clear();
            txtCourse3Input.Clear();
            txtNameInput.Focus();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(listInputStudents, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("input4.txt", jsonString);
                MessageBox.Show("Ghi file input4.txt thành công!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi");
            }
        }

        // --- RIGHT PANEL (OUTPUT) ---

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonString = File.ReadAllText("input4.txt");
                List<Student> studentsFromFile = JsonSerializer.Deserialize<List<Student>>(jsonString);

                listOutputStudents.Clear();
                foreach (var st in studentsFromFile)
                {
                    float avg = (st.DiemMon1 + st.DiemMon2 + st.DiemMon3) / 3;
                    listOutputStudents.Add(new StudentOutput
                    {
                        HoTen = st.HoTen,
                        MSSV = st.MSSV,
                        DienThoai = st.DienThoai,
                        DiemMon1 = st.DiemMon1,
                        DiemMon2 = st.DiemMon2,
                        DiemMon3 = st.DiemMon3,
                        DiemTrungBinh = (float)Math.Round(avg, 2)
                    });
                }

                WriteOutputFile();
                currentIndex = 0;
                DisplayStudent();
                MessageBox.Show("Đọc file và ghi output4.txt thành công!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi");
            }
        }

        private void WriteOutputFile()
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(listOutputStudents, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("output4.txt", jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file output4.txt: " + ex.Message, "Lỗi");
            }
        }

        private void DisplayStudent()
        {
            if (listOutputStudents.Count == 0 || currentIndex < 0 || currentIndex >= listOutputStudents.Count)
            {
                ClearOutputFields();
                return;
            }

            StudentOutput st = listOutputStudents[currentIndex];
            txtNameOutput.Text = st.HoTen;
            txtIDOutput.Text = st.MSSV;
            txtPhoneOutput.Text = st.DienThoai;
            txtCourse1Output.Text = st.DiemMon1.ToString();
            txtCourse2Output.Text = st.DiemMon2.ToString();
            txtCourse3Output.Text = st.DiemMon3.ToString();
            txtAverageOutput.Text = st.DiemTrungBinh.ToString();

            lblPageIndex.Text = (currentIndex + 1).ToString();
            btnBack.Enabled = (currentIndex > 0);
            btnNext.Enabled = (currentIndex < listOutputStudents.Count - 1);
        }

        private void ClearOutputFields()
        {
            txtNameOutput.Clear();
            txtIDOutput.Clear();
            txtPhoneOutput.Clear();
            txtCourse1Output.Clear();
            txtCourse2Output.Clear();
            txtCourse3Output.Clear();
            txtAverageOutput.Clear();
            lblPageIndex.Text = "0";
            btnBack.Enabled = false;
            btnNext.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < listOutputStudents.Count - 1)
            {
                currentIndex++;
                DisplayStudent();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayStudent();
            }
        }
    }
}
