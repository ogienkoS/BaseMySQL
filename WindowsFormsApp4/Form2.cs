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
namespace BaseSQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string query_name = "INSERT INTO `name` (`name`, `model`) VALUES ('"+ textBox1.Text + "', '" + textBox2.Text + "')";
            string query_engine = "INSERT INTO `engine` (`engine`, `hp`) VALUES ('" + textBox3.Text + "', '" + numericUpDown1.Value + "')";
            MySqlCommand command_name = new MySqlCommand(query_name, DataBase.connect);
            MySqlCommand command_engine = new MySqlCommand(query_engine, DataBase.connect);
            command_name.ExecuteNonQuery();
            command_engine.ExecuteNonQuery();
            richTextBox1.Text = (query_name + query_engine);
            

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
            
        }

       
    }
}
