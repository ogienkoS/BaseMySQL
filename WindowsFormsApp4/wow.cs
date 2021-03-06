﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Components;
using MetroFramework;
using System.Threading;
using System.Media;

namespace BaseSQL
{
    public partial class wow : MetroForm
    {


        public wow()
        {
            InitializeComponent();
            
        }
        Thread potok;
        private void wow_Load(object sender, EventArgs e)
        {
            potok = new Thread(CheckConnection);
            potok.Start();
            timer2.Enabled = true;
            
            
        }

        void CheckConnection()
        {
            while (true)
            {
                if(DataBase.CheckDB())
                {
                    BeginInvoke(new Action(delegate ()
                    {
                        
                        MetroStyleManager.Default.Style = MetroColorStyle.Green;
                        label1.ForeColor = Color.Green;
                        label1.Text = "Online";
                        check_btn.Enabled = true;
                        metroButton2.Enabled = true;
                        metroTextBox1.Enabled = true;
                        metroTextBox2.Enabled = true;
                        metroTextBox3.Enabled = true;

                    }));

                }
                else
                {
                    BeginInvoke(new Action(delegate ()
                    {
                        
                        MetroStyleManager.Default.Style = MetroColorStyle.Red;
                        label1.ForeColor = Color.Red;
                        label1.Text = "Offline";
                        check_btn.Enabled = false;
                        metroButton2.Enabled = false;
                        metroButton3.Enabled = false;
                        metroTextBox1.Enabled = false;
                        metroTextBox2.Enabled = false;
                        metroTextBox3.Enabled = false;
                    }));
                    DataBase.connectDB();
                }
                Thread.Sleep(500);

            }
            
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            Notifi();
            metroLabel5.Text = "";
            metroLabel1.Text = "";
            try
            {

                string query_namebase = "SELECT id from account where username = '" + metroTextBox1.Text + "'";
                MySqlCommand command = new MySqlCommand(query_namebase, DataBase.connect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                BindingSource bindingSorce = new BindingSource();
                if (dataset.Tables.Count == 1)
                {
                    bindingSorce.DataSource = dataset.Tables[0];
                    dataGridView1.DataSource = bindingSorce;
                }

                UInt32 reg = (UInt32)command.ExecuteScalar();
                metroLabel1.Text = "ID аккаунта: " + command.ExecuteScalar().ToString();

                AddLog("ID аккаунта: " + metroTextBox1.Text + " успешно получен!", false);

                string check_admin = string.Format("SELECT gmlevel from account_access where id = '" + command.ExecuteScalar().ToString() + "'");
                MySqlCommand query_check_admin = new MySqlCommand(check_admin, DataBase.connect);
                query_check_admin.Prepare();
                query_check_admin.ExecuteNonQuery();
                if (query_check_admin.ExecuteScalar() == null)
                {
                    metroLabel5.Text = " 0";
                }
                else
                {
                    metroLabel5.Text = query_check_admin.ExecuteScalar().ToString();
                }

            }
            catch
            {
                AddLog("Аккаунта с именем " + metroTextBox1.Text + " не существует.", true);

            }

        }

        private void AddLog(string log, bool error)
        {
            string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            richTextBox1.Text = log + " \r\n";
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectionLength = log.Length;
            if (error)
                richTextBox1.SelectionColor = Color.Red;
            else
                richTextBox1.SelectionColor = Color.Green;
            string _log = string.Format("[{0}] {1}\r\n", datetime, log);
            System.IO.File.AppendAllText("Log.txt", _log);


        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

            if ((metroTextBox2.Text.Equals("")) || ((metroTextBox3.Text.Equals(""))))
            {
                label2.Text = "Заполните поля ID и Гм-LvL";
                label2.ForeColor = Color.Red;
                return;
            }
            try
            {
                
                string query_namebase = "INSERT INTO `account_access` (`id`, `gmlevel`) VALUES ('" + metroTextBox2.Text + "','" + metroTextBox3.Text + "')";
                MySqlCommand command = new MySqlCommand(query_namebase, DataBase.connect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);


                

                AddLog("Аккаунт: " + metroTextBox1.Text + " успешно получил ГМ доступ " + metroTextBox3.Text + " уровня!", false);



            }
            catch
            {
                AddLog("Аккаунт " + metroTextBox1.Text + " не существует.", true);
            }
            if (metroLabel1.Text == null)
            {
                metroLabel5.Text = "ошибка";

            }
            else
            {
                string update_gm = string.Format("UPDATE `account_access` SET `gmlevel`='" + metroTextBox3.Text + "' WHERE (`id`='" + metroTextBox2.Text + "')");
                MySqlCommand query_update_gm = new MySqlCommand(update_gm, DataBase.connect);
                query_update_gm.Prepare();
                query_update_gm.ExecuteNonQuery();
                AddLog("Аккаунт: " + metroTextBox1.Text + " успешно обновил ГМ доступ до " + metroTextBox3.Text + " уровня!", false);
            }
           
        }

        private void metroTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void metroTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Online")
            {
                Notifi_On();
            }
            else
            {
                Notifi_Off();
            }
            this.Refresh();
            
        }
        private NotifyIcon NI = new NotifyIcon();
        Icon myIcon = new Icon("notify.ico");
        public void Notifi()
        {
            NI.Icon = myIcon;
            NI.BalloonTipText = "Запрос успешно выполнен!";
            NI.BalloonTipTitle = "WoW Mode ";
            NI.BalloonTipIcon = ToolTipIcon.None; //тут тип ошибка инфа и т.д
            NI.Icon = this.Icon;
            NI.Visible = true;
            NI.ShowBalloonTip(1000);
        }
        public void Notifi_On()
        {
            NI.Icon = myIcon;
            NI.BalloonTipText = "Подключение установлено";
            NI.BalloonTipTitle = "WoW Mode ";
            NI.BalloonTipIcon = ToolTipIcon.None; //тут тип ошибка инфа и т.д
            NI.Icon = this.Icon;
            NI.Visible = true;
            NI.ShowBalloonTip(1000);
        }
        public void Notifi_Off()
        {
            NI.Icon = myIcon;
            NI.BalloonTipText = "Подключение разорвано";
            NI.BalloonTipTitle = "WoW Mode ";
            NI.BalloonTipIcon = ToolTipIcon.None; //тут тип ошибка инфа и т.д
            NI.Icon = this.Icon;
            NI.Visible = true;
            NI.ShowBalloonTip(1000);
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if(label1.Text == "Online")
            {
                System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();
                System.Net.NetworkInformation.PingReply pingReply = ping.Send(DataBase._host);
                System.Net.IPAddress addres = pingReply.Address;
                label3.Text = pingReply.RoundtripTime.ToString("00 мс");
                int PingResult;
                PingResult = Convert.ToInt16(pingReply.RoundtripTime);
                if (PingResult >= 100)
                {
                    label3.ForeColor = Color.Red;
                }
                else
                {
                    label3.ForeColor = Color.Green;
                }

                if (PingResult == 0)
                {
                    label3.Text = "localhost";

                }

            }
            else
            {
                timer2.Enabled = false;
                label3.Enabled = false;
            }
            
        }

        

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string delete_gm = ("DELETE FROM account_access WHERE (id = '" + metroTextBox2.Text + "')");
                MySqlCommand query_delete_gm = new MySqlCommand(delete_gm, DataBase.connect);
                query_delete_gm.Prepare();
                query_delete_gm.ExecuteNonQuery();
                AddLog("Аккаунт с ID = " + metroTextBox2.Text + " удален из таблицы account_access.", false);
            }
            catch (Exception ex)
            {
                AddLog(ex.Message, false);
            }
        }

       
        private void metroButton3_MouseDown(object sender, MouseEventArgs e)
        {
            AddLog("3", false);
        }

       
    }

}
