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
using System.Media;
using MySql.Data.MySqlClient;
using WindowsFormsApp4;

namespace BaseSQL
{
    public partial class wow : MetroForm
    {
        public wow()
        {
            InitializeComponent();
        }

        private void wow_Load(object sender, EventArgs e)
        {

        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query_namebase = "SELECT id from account where username = '"+ metroTextBox1.Text +"'"; 
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
               
               AddLog("ID аккаунта: " + metroTextBox1.Text + " успешно получен!", false);
                //metroLabel1.Text = ;


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

                string query_namebase = "INSERT INTO `account_access` (`id`, `gmlevel`) VALUES ('"+metroTextBox2.Text+"','"+metroTextBox3.Text+"')";
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

                AddLog("Аккаунт: " + metroTextBox1.Text + " успешно получил ГМ доступ "+ metroTextBox3.Text+" уровня!", false);
                //metroLabel1.Text = bindingSorce;


            }
            catch
            {
                AddLog("Аккаунт " + metroTextBox1.Text + " не существует.", true);
            }

        }

        
    }
}
