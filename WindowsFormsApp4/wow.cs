using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Components;
using MetroFramework;

namespace BaseSQL
{
    public partial class wow : MetroForm
    {


        public wow()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void wow_Load(object sender, EventArgs e)
        {
            CheckConnection();
        }

        private void CheckConnection()
        {
            try
            {
                string query_Test = "SELECT 1";
                MySqlCommand command_Test = new MySqlCommand(query_Test, DataBase.connect);
                command_Test.ExecuteNonQuery();
                MetroStyleManager.Default.Style = MetroColorStyle.Green;
                label1.ForeColor = Color.Green;
                label1.Text = "Online";
            }
            catch
            {
                MetroStyleManager.Default.Style = MetroColorStyle.Red;
                label1.ForeColor = Color.Red;
                label1.Text = "Offline";
            }
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {

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

            try
            {

                string query_namebase = "INSERT INTO `account_access` (`id`, `gmlevel`) VALUES ('" + metroTextBox2.Text + "','" + metroTextBox3.Text + "')";
                MySqlCommand command = new MySqlCommand(query_namebase, DataBase.connect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                /*ndingSource bindingSorce = new BindingSource();
                if (dataset.Tables.Count == 1)
                {
                    bindingSorce.DataSource = dataset.Tables[0];
                    dataGridView1.DataSource = bindingSorce;
                }*/
                //if ((metroTextBox2.Text.Equals("")) || ((metroTextBox3.Text.Equals(""))))
                //{
                //    metroLabel3.Text = " Заполните все поля!";
                //    return;
                //}

                AddLog("Аккаунт: " + metroTextBox1.Text + " успешно получил ГМ доступ " + metroTextBox3.Text + " уровня!", false);



            }
            catch
            {
                AddLog("Аккаунт " + metroTextBox1.Text + " не существует.", true);
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
            this.Refresh();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckConnection();
        }
    }

}
