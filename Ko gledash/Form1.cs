using System;
using System.Diagnostics;

namespace Ko_gledash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult islem = MessageBox.Show("Do you want to exit the application?", "Elite FiveM Launcher", MessageBoxButtons.YesNo);
            if (islem == DialogResult.Yes)
            {
                MessageBox.Show("See you later! (^o^) ", "Thank you for using Elite Launcher", MessageBoxButtons.OK);
                Application.Exit();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer.exe", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer.exe", "https://discord.io/elitedevs");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer.exe", "fivem://connect/localhost:30120");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string message = "Developed by Elite Development#4277";
            string title = "FiveM Launcher";
            MessageBox.Show(message, title);
        }
    }
}