using System;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.Media;

namespace BaseSQL
{
    public partial class auth : MetroForm
    {
        public auth()
        {
            InitializeComponent();
            /*timer1.Interval = 3000;
            timer1.Start();*/
            MetroStyleManager.Default.Style = MetroColorStyle.Purple;
            MetroStyleManager.Default.Theme = MetroThemeStyle.Default;
        }

        /*int color = 0;
        private void ChangeColor()
        {
            switch (color)
            {
                case 0:
                    MetroStyleManager.Default.Style = MetroColorStyle.Orange;
                    break;
                case 1:
                    MetroStyleManager.Default.Style = MetroColorStyle.Red;
                    break;
                case 2:
                    MetroStyleManager.Default.Style = MetroColorStyle.Blue;
                    break;
                case 3:
                    MetroStyleManager.Default.Style = MetroColorStyle.Green;
                    break;
                case 4:
                    MetroStyleManager.Default.Style = MetroColorStyle.Yellow;
                    break;
                case 5:
                    MetroStyleManager.Default.Style = MetroColorStyle.Brown;
                    break;
            }
            color++;
            if (color >= 5)
                color = 0;
        }*/


        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            metroProgressSpinner1.Visible = true;

            if ((metroTextBox1.Text.Equals("")) || (metroTextBox2.Text.Equals("")) || (metroTextBox3.Text.Equals("")) || (metroTextBox4.Text.Equals("") || (metroTextBox5.Text.Equals(""))))
            {
                metroLabel1.Text = "     Данные не заполнены";
                return;
            }
            bool result = DataBase.connectDB(metroTextBox1.Text, int.Parse(metroTextBox5.Text), metroTextBox3.Text, metroTextBox4.Text, metroTextBox2.Text);
            if (metroCheckBox1.Checked == true)
            {
                wow frm = new wow();
                frm.Show();
                this.Hide();
                
            }
            if (result)
            {
                if (metroCheckBox1.Checked == true)
                {

                }
                else
                {
                    home frm = new home();
                    frm.Show();
                    this.Hide();
                    //SoundPlayer Pl = new SoundPlayer();
                    //Pl.SoundLocation = "C:\\WINDOWS\\Media\\notify.wav";
                    //Pl.Play();
                }

            }

            else
            {
                MetroStyleManager.Default.Style = MetroColorStyle.Red;
                //label1.ForeColor = Color.Red;
                metroLabel1.Text = "Ошибка подключения к базе";
                //label1.Text = "Ошибка подключения к базе";
                //SoundPlayer Pl = new SoundPlayer();
                //Pl.SoundLocation = "C:\\WINDOWS\\Media\\Windows Unlock.wav";
                //Pl.Play();

            }
            metroProgressSpinner1.Visible = false;

        }

      
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {

        }



        /*private void timer1_Tick(object sender, EventArgs e)
        {
            ChangeColor();
        }*/
    }
}
