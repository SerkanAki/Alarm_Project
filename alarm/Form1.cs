using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            suan();
            for (int i = 0; i < 24; i++)
            {
                cmbSaat.Items.Add(i);
            }
            for (int j = 0; j < 60; j++)
            {
                cmbDakika.Items.Add(j);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.Hour.ToString();
            lblDakika.Text = DateTime.Now.Minute.ToString();
            if (cmbSaat.Text == lblSaat.Text && cmbDakika.Text == lblDakika.Text)
            {
                timer1.Stop();
                axWindowsMediaPlayer1.settings.volume = 100;
                axWindowsMediaPlayer1.URL = Application.StartupPath + "/Alarm-Sesi.mp3";
                MessageBox.Show(textBox1.Text);
            }
        }

        private void btnAlarmKur_Click(object sender, EventArgs e)
        {
            suan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            suan();
            axWindowsMediaPlayer1.close();
            foreach (ComboBox cmbx in panel2.Controls.OfType<ComboBox>())
            {
                cmbx.Text = "";
            }
        }
        void suan()
        {
            timer1.Start();
            lblSaat.Text = DateTime.Now.Hour.ToString();
            lblDakika.Text = DateTime.Now.Minute.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
