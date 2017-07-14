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
    public partial class SettingsForm : Form
    {
        private string ServerName, Port, DbName, UserName, Password;
        MySqlConnection MysqlConn;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            if (RememberCk.Checked == true)
            {
                DialogResult ConfirmNotChange = MessageBox.Show("Apakah anda ingin mengganti settings ?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(ConfirmNotChange == DialogResult.No)
                {
                    ServerTxt.Text = Properties.Settings.Default.ServerFill;
                    PortTxt.Text = Properties.Settings.Default.PortFill;
                    DbTxt.Text = Properties.Settings.Default.DbFill;
                    UserTxt.Text = Properties.Settings.Default.UserFill;
                    PassTxt.Text = Properties.Settings.Default.PasswordFill;
                    ProsesBtn.PerformClick();
                }
                else
                {
                    RememberCk.Checked = false;
                }
            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            RememberCk.Checked = Properties.Settings.Default.RememberChecked;
        }

        private void ProsesBtn_Click(object sender, EventArgs e)
        {
            ServerName = ServerTxt.Text;
            Port = PortTxt.Text;
            DbName = DbTxt.Text;
            UserName = UserTxt.Text;
            Password = PassTxt.Text;

            if (String.IsNullOrWhiteSpace(DbName) || String.IsNullOrWhiteSpace(UserName)
                || String.IsNullOrWhiteSpace(ServerName) || String.IsNullOrWhiteSpace(Port))
            {
                MessageBox.Show("Field isian tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(RememberCk.Checked == false)
                {
                    DialogResult dr = MessageBox.Show("Settings tidak akan tersimpan, lanjutkan ?", "INFO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(dr == DialogResult.Yes)
                    {
                        Properties.Settings.Default.RememberChecked = RememberCk.Checked;
                        Properties.Settings.Default.ServerFill = "";
                        Properties.Settings.Default.PortFill = "";
                        Properties.Settings.Default.DbFill = "";
                        Properties.Settings.Default.UserFill = "";
                        Properties.Settings.Default.PasswordFill = "";
                        Connect_DB();
                    }
                }
                else
                {
                    Properties.Settings.Default.ServerFill = ServerName;
                    Properties.Settings.Default.PortFill = Port;
                    Properties.Settings.Default.DbFill = DbName;
                    Properties.Settings.Default.UserFill = UserName;
                    Properties.Settings.Default.PasswordFill = Password;
                    Properties.Settings.Default.RememberChecked = RememberCk.Checked ;
                    Connect_DB();
                }
            }
        }
        

        private void Connect_DB()
        {
            try
            {
                string connection = "datasource=" + ServerName + ";port=" + Port + ";username=" + UserName + ";password=" + Password + ";database=" + DbName + ";";
                MysqlConn = new MySqlConnection(connection);
                MysqlConn.Open();
                if (MysqlConn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connected with information : " + connection);
                }
                else
                {
                    MessageBox.Show("error");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
