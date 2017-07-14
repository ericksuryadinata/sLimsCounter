using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sLimsCounter
{
    public partial class MainForm : Form
    {
        MySqlCommand Command;
        MySqlConnection MysqlConn;
        MySqlDataReader DbReader;
        private string LibraryName,LibrarySubName, InstitutionName;
        private string[] SchoolName = { "MI", "SD", "MTS", "SMP", "SMPK", "MA", "SMA", "SMAK", "SMK", "STM" };
        List<string> result = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=slims;";
            MysqlConn = new MySqlConnection(connection);
            MysqlConn.Open();
            string query = "SELECT setting_value FROM setting WHERE setting_id=2 or setting_id=1;";
            Command = new MySqlCommand(query, MysqlConn);
            DbReader = Command.ExecuteReader();

            while (DbReader.Read())
            {
                result.Add(DbReader.GetString(0));
            }
            DbReader.Close();

            /* 
             * CEK NAMA SEKOLAH
             * format dari database adalah s:1:"a";
             * dimana angka 1 merupakan panjang kalimat (a)
             * jika dihitung maka posisi dari angka 1, selalu tetap di index ke 2
             * sedangkan angka 1 akan selalu berubah sesuai dengan panjang kalimat
             * index awal kalimat merupakan banyaknya karakter sebelum kalimat + 1
             */

            LibraryName = result.ElementAt(0);
            LibrarySubName = result.ElementAt(1);

            CheckSchoolName(LibraryName, out string LibName, out string LibLevel);

            if (IsSchoolLevel(LibLevel) == true) 
            {
                InstitutionName = LibName;
            }
            else
            {
                CheckSchoolName(LibrarySubName, out string LibSubName, out string LibSubLevel);
                if(IsSchoolLevel(LibSubLevel) == true)
                {
                    InstitutionName = LibSubName;
                }
                else
                {
                    InstitutionName = LibName;
                }
            }

            /*
             * TO DO :
             * Membuat institution_name center bersamaan dengan welcome_message
             * serta place, semuanya didapatkan dari hasil bagi institution_name yang dibagi dua
             * sama kalo bisa pada waktu form_onload kasih loading animation
             */

            institution_name.Text = InstitutionName.ToUpper();

            // get the system_date
            var lang = new System.Globalization.CultureInfo("id-ID");
            var day = lang.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            var month = lang.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            string today = DateTime.Now.Day.ToString();
            string year = DateTime.Now.Year.ToString();
            system_date.Text = day + ", " + today + " " + month + " " + year;

            //set header panel
            HeaderPanel.Width = Width - HeaderPanel.Left - 40;
            HeaderPanel.Top = Img.Top;
            

            // set the statistic panel position
            StatisticTablePanel.Width = 400;
            StatisticTablePanel.Top = HeaderPanel.Height + HeaderPanel.Top + 20;
            StatisticTablePanel.Height = Height - StatisticTablePanel.Top - 200;
            StatisticTablePanel.Left = Width - StatisticTablePanel.Width - 40;

            // set the system_clock and date / input panel
            InputPanel.Top = StatisticTablePanel.Top;
            InputPanel.Width = StatisticTablePanel.Left - 52;
            InputPanel.Height = StatisticTablePanel.Height;
            system_clock.Font = system_date.Font = new Font("Calibri", 36);
            ValidatePanel.Left = HeaderPanel.Left;
            ValidatePanel.Top = system_date.Top + 2 * system_date.Height + 30;
            ValidatePanel.Width = InputPanel.Width - 2 * ValidatePanel.Left;
            ValidatePanel.Height = InputPanel.Height - ValidatePanel.Top - 20;
            InputMessage.Font = new Font("Times New Roman", 24);
            InputMessage.Height = 40;
            InputIDTxt.Top = InputMessage.Top + InputMessage.Height + 20;
            InputIDTxt.Left = 10;
            InputIDTxt.Width = ValidatePanel.Width - 2 * InputIDTxt.Left;
            InputIDTxt.MaxLength = 10;
            InputNote.Font = InputNote1.Font = new Font("Arial", 8);
            InputNote.Left = InputIDTxt.Left + ((InputIDTxt.Width - InputNote.Width) / 2);
            InputNote1.Left = InputIDTxt.Left + ((InputIDTxt.Width - InputNote1.Width) / 2);
            InputNote.Top = InputIDTxt.Top + InputIDTxt.Height + 5;
            InputNote1.Top = InputNote.Top + 20;

            // Copyright position
            Copyright.Left = Img.Left;
            Copyright.Top = Height - 70;
            RepoLink.Top = Copyright.Top;
            RepoLink.Left = Copyright.Left + Copyright.Width + 10;

            // set footer panel position
            FooterPanel.Width = HeaderPanel.Left + HeaderPanel.Width - 26;
            FooterPanel.Left = Img.Left;
            FooterPanel.Top = StatisticTablePanel.Top + StatisticTablePanel.Height + 10;
            FooterPanel.Height = Height - FooterPanel.Top - (Height - Copyright.Top + 10);
            

            // set counter font and position
            Today.Font = Month.Font = Year.Font = Total.Font = Pnc1.Font = Pnc2.Font 
                = Pnc3.Font = Pnc4.Font = TodayTotal.Font = MonthTotal.Font 
                = YearTotal.Font = AllTotal.Font = new Font("Times new roman", 25);

            Today.Left = Month.Left = Year.Left = Total.Left = 10;
            Pnc1.Left = Pnc2.Left = Pnc3.Left = Pnc4.Left = Year.Width + 20;
            TodayTotal.Left = MonthTotal.Left = YearTotal.Left = 
                AllTotal.Left = Pnc1.Left + 20;

            Today.Top = Pnc1.Top = TodayTotal.Top = StatisticHeader.Height + 50;
            Month.Top = Pnc2.Top = MonthTotal.Top = Today.Top + 50;
            Year.Top = Pnc3.Top = YearTotal.Top = Month.Top + 50;
            Total.Top = Pnc4.Top = AllTotal.Top = Year.Top + 50;
            ViewTotal();

        }

        private void InitLoad()
        {

        }


        private void CheckSchoolName(string ValLibName, out string NameSchool, out string LevelSchool)
        {
            string NS = "", LS = "";
            int ValLength = ValLibName.Length;
            if (ValLength <= 16)
            {
                GetSchoolLevel(ValLibName, 2, 5, out string SchoolName, out string SchoolLevel);
                LS = SchoolLevel;
                NS = SchoolName;

            }
            else if (ValLength > 16 && ValLength <= 100)
            {
                GetSchoolLevel(ValLibName, 2, 6, out string SchoolName, out string SchoolLevel);
                LS = SchoolLevel;
                NS = SchoolName;
            }

            NameSchool = NS;
            LevelSchool = LS;
        }

        private bool IsSchoolLevel(string Level)
        {
            bool Value = false;
            foreach (string Check in SchoolName)
            {
                if (Check == Level)
                {
                    Value = true;
                }
            }

            return Value;
        }

        private void GetSchoolLevel(string ValLibName, int Num1, int Num2, out string TrueName, out string SchoolLevel)
        {
            string Index = ValLibName.Substring(2, Num1);
            TrueName = ValLibName.Substring(Num2, Convert.ToInt16(Index));
            string[] ArrTrueName = TrueName.Split();
            SchoolLevel = ArrTrueName[0].ToUpper();
        }

        private void ServerTime_Tick(object sender, EventArgs e)
        {
            int Hours = DateTime.Now.Hour;
            int Minutes = DateTime.Now.Minute;
            int Seconds = DateTime.Now.Second;

            string Time = "";

            if (Hours <10)
            {
                Time += "0" + Hours;
            }
            else
            {
                Time += Hours;
            }

            Time += ":";

            if (Minutes < 10)
            {
                Time += "0" + Minutes;
            }
            else
            {
                Time += Minutes;
            }

            Time += ":";

            if (Seconds < 10)
            {
                Time += "0" + Seconds;
            }
            else
            {
                Time += Seconds;
            }

            system_clock.Text = Time;
        }

        private void InputIDTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(InputIDTxt.Text)){
                    InsertNonMember();
                }
                else if(IsFound(InputIDTxt.Text) == true)
                {
                    InsertMember(InputIDTxt.Text);
                }
                else
                {
                    MessageBox.Show("ID yang dimasukkan tidak valid");
                    InputIDTxt.Text = "";
                }
                ViewTotal();
            }

            if(e.KeyCode == Keys.Escape)
            {
                InputIDTxt.Text = "";
            }
        }

        private bool IsFound(string text)
        {
            bool Value = false;
            string query = "SELECT * FROM member WHERE member_id=" + text ;
            Command = new MySqlCommand(query, MysqlConn);
            using(DbReader = Command.ExecuteReader())
            {
                while (DbReader.Read())
                {
                    if (text == DbReader.GetInt16(0).ToString()) return Value=true;
                    else return Value=false;
                }
                DbReader.Close();
            }

            return Value;
        }

        private void InsertMember(string text)
        {
            int member_id=0;
            string member_name="", institution="";
            string query = "SELECT * FROM member WHERE member_id=" + text;
            Command = new MySqlCommand(query, MysqlConn);
            using(DbReader = Command.ExecuteReader())
            {
                while (DbReader.Read())
                {
                    member_id = DbReader.GetInt16(0);
                    member_name = DbReader.GetString(1);
                    institution = DbReader.GetString(9);
                }
                DbReader.Close();
            }

            try
            { 
                query = "INSERT INTO visitor_count (member_id, member_name, institution," +
                    "checkin_date) VALUES (" + member_id + ",'" + member_name + "','" + institution + "', NOW());";
                MessageBox.Show(query);
                Command = new MySqlCommand(query, MysqlConn);
                DbReader = Command.ExecuteReader();
                DbReader.Close();
                MessageBox.Show("TERIMA KASIH");
                InputIDTxt.Text = "";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void InsertNonMember()
        {
            try
            {
                string id = GetID().ToString();
                string member_id = "NonMember" + id;
                string query = "INSERT INTO visitor_count (member_id," +
                    "checkin_date) VALUES (" + "'" + member_id + "'," + "NOW()" + ");";
                MessageBox.Show(query);
                Command = new MySqlCommand(query, MysqlConn);
                DbReader = Command.ExecuteReader();
                DbReader.Close();
                MessageBox.Show("TERIMA KASIH");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private int GetID()
        {
            int id = 0;
            string query = "SELECT max(visitor_id) FROM visitor_count;";
            Command = new MySqlCommand(query, MysqlConn);
            using (DbReader = Command.ExecuteReader())
            {
                while (DbReader.Read())
                {
                    id = DbReader.GetInt16(0);
                }
                DbReader.Close();
            }
            return id+1;
        }

        private void ViewTotal()
        {
            string Day = DateTime.Now.Day.ToString();
            string Month = DateTime.Now.Month.ToString("d2");
            string Year = DateTime.Now.Year.ToString();
            string QDay = Year + "-" + Month + "-" + Day;
            string QMonth = Year + "-" + Month;
            string QYear = Year;
            string nothing = "";
            TodayTotal.Text = GetTotal(QDay,false).ToString();
            MonthTotal.Text = GetTotal(QMonth,false).ToString();
            YearTotal.Text = GetTotal(QYear,false).ToString();
            AllTotal.Text = GetTotal(nothing, true).ToString();

        }

        private int GetTotal(string text, bool Value)
        {
            int Total = 0;
            string query = "";
            if (Value == false)
            {
                query = "SELECT COUNT(visitor_id) AS vtotal FROM visitor_count WHERE checkin_date LIKE '" + text + "%';";
            }
            else
            {
                query = "SELECT COUNT(visitor_id) AS vtotal FROM visitor_count ;";
            }
            
            Command = new MySqlCommand(query, MysqlConn);
            using (DbReader = Command.ExecuteReader())
            {
                while (DbReader.Read())
                {
                    Total = DbReader.GetInt16(0);
                }
            }
            DbReader.Close();
            return Total;
        }

    }
}
