using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BaseSQL
{
    public partial class home : MetroForm
    {
        public home()
        {
            InitializeComponent();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
            MetroStyleManager.Default.Style = MetroColorStyle.Purple;
            metroTabControl1.SelectedIndex = 0;
     
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query_namebase = "SELECT * FROM " + metroTextBox1.Text;
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
                AddLog("Запрос в таблицу: "+ metroTextBox1.Text+" успешно выполнен!", false);
            }
            catch
            {
                AddLog("Таблицы " + metroTextBox1.Text + " не существует.", true);
            }
            
            

        }

        internal static void AddLog(string v1, bool v2)
        {
            throw new NotImplementedException();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(metroTextBox2.Text, DataBase.connect);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                BindingSource bindingSorce = new BindingSource();
                if (dataset.Tables.Count == 1)
                {
                    bindingSorce.DataSource = dataset.Tables[0];
                    dataGridView1.DataSource = bindingSorce;
                }


                AddLogACC("Запрос успешно выполнен!", false);
                // richTextBox1.ForeColor = System.Drawing.Color.Green;
                // richTextBox1.SelectionColor               


            }
            catch (Exception err)
            {
                AddLogACC("Ошибка выполнения запроса! (" + err.Message + ")", true);
                // richTextBox1.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void AddLogACC(string log, bool error)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        bool size = true;
        private void button4_Click(object sender, EventArgs e)
        {
           
            if (size)
            {
                this.Width = 937;
                this.Height = 521;
            }
            else
            {
                this.Width = 528;
                this.Height = 521;
            }
            size = !size;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {


            string query_name = "INSERT INTO `name` (`name`, `model`, `price`,`hp`,`engine`) VALUES ('" + metroTextBox3.Text + "', '" + metroTextBox4.Text + "', '" + metroTextBox6.Text + "', '" + metroTrackBar1.Value + "', '" + metroTextBox5.Text + "')";
            //string query_engine = "INSERT INTO `engine` (`engine`, `hp`) VALUES ('" + metroTextBox5.Text + "', '" + metroTrackBar1.Value + "')";
            MySqlCommand command_name = new MySqlCommand(query_name, DataBase.connect);
            //MySqlCommand command_engine = new MySqlCommand(query_engine, DataBase.connect);
            command_name.ExecuteNonQuery();
            //command_engine.ExecuteNonQuery();
            richTextBox2.Text = (query_name /*+ query_engine*/);


        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            metroLabel1.Text = Convert.ToString(metroTrackBar1.Value) + " лс";
        }

       
        }
    }



