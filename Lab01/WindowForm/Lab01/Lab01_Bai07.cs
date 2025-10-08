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
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();

            this.AcceptButton = btnCheck;
            this.Shown += (s, e) => this.ActiveControl = btnCheck;

            btnCheck.Click += btnCheck_Click;
            btnBack.Click += (s, e) => this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var d = dtpBirth.Value.Day;
            var m = dtpBirth.Value.Month;

            var zodiac = GetZodiac(d, m);
            txtResult.Text =
    $@"{zodiac.Name}";
        }
        private (string Name, string Range) GetZodiac(int day, int month)
        {
            switch (month)
            {
                case 3: return (day >= 21) ? ("Bạch Dương", "21/03 – 20/04") : ("Song Ngư", "20/02 – 20/03");
                case 4: return (day <= 20) ? ("Bạch Dương", "21/03 – 20/04") : ("Kim Ngưu", "21/04 – 21/05");
                case 5: return (day <= 21) ? ("Kim Ngưu", "21/04 – 21/05") : ("Song Tử", "22/05 – 21/06");
                case 6: return (day <= 21) ? ("Song Tử", "22/05 – 21/06") : ("Cự Giải", "22/06 – 22/07");
                case 7: return (day <= 22) ? ("Cự Giải", "22/06 – 22/07") : ("Sư Tử", "23/07 – 22/08");
                case 8: return (day <= 22) ? ("Sư Tử", "23/07 – 22/08") : ("Xử Nữ", "23/08 – 23/09");
                case 9: return (day <= 23) ? ("Xử Nữ", "23/08 – 23/09") : ("Thiên Bình", "24/09 – 23/10");
                case 10: return (day <= 23) ? ("Thiên Bình", "24/09 – 23/10") : ("Thần Nông", "24/10 – 22/11");
                case 11: return (day <= 22) ? ("Thần Nông", "24/10 – 22/11") : ("Nhân Mã", "23/11 – 21/12");
                case 12: return (day <= 21) ? ("Nhân Mã", "23/11 – 21/12") : ("Ma Kết", "22/12 – 20/01");
                case 1: return (day <= 20) ? ("Ma Kết", "22/12 – 20/01") : ("Bảo Bình", "21/01 – 19/02");
                default: return (day <= 19) ? ("Bảo Bình", "21/01 – 19/02") : ("Song Ngư", "20/02 – 20/03");
            }
        }
    }
}
