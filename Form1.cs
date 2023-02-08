using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_yarışı_en_güncel_ve_en_son_hali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ilkatınsolu, ikinciatınsolu, üçüncüatınsolu, ilkatınboyu, ikinciatınboyu, üçüncüatınboyu;
        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(2, 22);
            pictureBox2.Location = new Point(2, 130);
            pictureBox3.Location = new Point(2, 241);
            timer1.Enabled = true; 
            button1.Text = "Tekrar Yarıştır";
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\erdem\\source\\repos\\At yarışı en güncel ve en son hali\\Şahbatur videosu\\Şahbatur Gülbatur.mp4";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ilkatınsolu = pictureBox1.Left;
            ikinciatınsolu = pictureBox2.Left;
            üçüncüatınsolu = pictureBox3.Left;
            ilkatınboyu = pictureBox1.Left + pictureBox1.Width;
            ikinciatınboyu = pictureBox2.Left + pictureBox2.Width;
            üçüncüatınboyu = pictureBox3.Left + pictureBox3.Width;
            pictureBox1.Left = ilkatınsolu    + rastgele.Next(5,12);
            pictureBox2.Left = ikinciatınsolu + rastgele.Next(5,12);
            pictureBox3.Left = üçüncüatınsolu + rastgele.Next(5,12);
            if (ilkatınboyu > ikinciatınboyu && ilkatınboyu > üçüncüatınboyu)
            {
                richTextBox1.Text = "1. at önde gidiyor";
            }
            if (ikinciatınboyu > ilkatınboyu && ikinciatınboyu > üçüncüatınboyu)
            {
                richTextBox1.Text = "2. at önde gidiyor";
            }
            if (üçüncüatınboyu > ikinciatınboyu && üçüncüatınboyu > ilkatınboyu)
            {
                richTextBox1.Text = "3. at önde gidiyor";
            }
            if(ilkatınboyu >= label5.Left)
            {
                timer1.Enabled = false;
                richTextBox1.Text = "1. at yarışın galibi";
            }
            if(ikinciatınboyu >= label5.Left)
            {
                timer1.Enabled = false;
                richTextBox1.Text = "2. at yarışın galibi ";
            }
            if(üçüncüatınboyu >= label5.Left)
            {
                timer1.Enabled = false;
                richTextBox1.Text = "3. at yarışın galibi";
            }
        }
    }
}
