using System;
using System.Windows.Forms;

namespace TP_MODUL3_103022400062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        // tombol angka
        private void button1_Click(object sender, EventArgs e) { label1.Text += "1"; }
        private void button2_Click(object sender, EventArgs e) { label1.Text += "2"; }
        private void button3_Click(object sender, EventArgs e) { label1.Text += "3"; }
        private void button4_Click(object sender, EventArgs e) { label1.Text += "4"; }
        private void button5_Click(object sender, EventArgs e) { label1.Text += "5"; }
        private void button6_Click(object sender, EventArgs e) { label1.Text += "6"; }
        private void button7_Click(object sender, EventArgs e) { label1.Text += "7"; }
        private void button8_Click(object sender, EventArgs e) { label1.Text += "8"; }
        private void button9_Click(object sender, EventArgs e) { label1.Text += "9"; }
        private void button10_Click(object sender, EventArgs e) { label1.Text += "0"; }

        // tombol +
        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                label1.Text += " + ";
            }
        }

        // tombol =
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string[] angka = label1.Text.Split('+');

                int hasil = 0;

                foreach (string a in angka)
                {
                    if (a.Trim() != "")
                        hasil += int.Parse(a.Trim());
                }

                label1.Text = hasil.ToString();
            }
            catch
            {
                label1.Text = "Error";
            }
        }
    }
}