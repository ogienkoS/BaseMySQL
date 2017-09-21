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
using MetroFramework.Forms;
using MetroFramework.Fonts;
using MetroFramework.Components;
using MetroFramework.Interfaces;
using MySql.Data.MySqlClient;
using WindowsFormsApp4;
using System.Media;

namespace BaseSQL
{
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
            MetroStyleManager.Default.Style = MetroColorStyle.Purple;
            MetroStyleManager.Default.Theme = MetroThemeStyle.Dark;

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            
            if ((metroTextBox1.Text.Equals("")) || (metroTextBox2.Text.Equals("")) || (metroTextBox3.Text.Equals("")) || (metroTextBox4.Text.Equals("") || (metroTextBox5.Text.Equals(""))))
            {
                return;
            }


            
            bool result = DataBase.connectDB(metroTextBox1.Text/*ip сервака*/, int.Parse(metroTextBox2.Text)/*порт сервака*/, metroTextBox5.Text/*логин*/, metroTextBox4.Text/*название бд*/, metroTextBox3.Text/*пароль*/);
            if (result)
            {
                home frm = new home();
                frm.Show();
                this.Hide();
                SoundPlayer Pl = new SoundPlayer();
                Pl.SoundLocation = "C:\\WINDOWS\\Media\\notify.wav";
                Pl.Play();
            }
            else
            {
                //metroLabel1.ForeColor = Color.Red;
               // metroLabel1.ForeColor = System.Drawing.Color.Red;
                metroLabel1.ForeColor = Color.Red;//(R, G, B) (0, 0, 0 = black)


                metroLabel1.Text = "Ошибка подключения к базе";
                SoundPlayer Pl = new SoundPlayer();
                Pl.SoundLocation = "C:\\WINDOWS\\Media\\Windows Unlock.wav";
                Pl.Play();

            }


        }

        
    }
}
