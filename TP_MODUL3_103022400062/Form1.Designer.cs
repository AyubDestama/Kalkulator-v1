namespace TP_MODUL3_103022400062
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            label1 = new Label();
            SuspendLayout();

            // button1
            button1.Location = new Point(93, 125);
            button1.Size = new Size(47, 29);
            button1.Text = "1";
            button1.Click += button1_Click;

            // button2
            button2.Location = new Point(146, 125);
            button2.Size = new Size(47, 29);
            button2.Text = "2";
            button2.Click += button2_Click;

            // button3
            button3.Location = new Point(199, 125);
            button3.Size = new Size(47, 29);
            button3.Text = "3";
            button3.Click += button3_Click;

            // button4
            button4.Location = new Point(93, 160);
            button4.Size = new Size(47, 29);
            button4.Text = "4";
            button4.Click += button4_Click;

            // button5
            button5.Location = new Point(146, 160);
            button5.Size = new Size(47, 29);
            button5.Text = "5";
            button5.Click += button5_Click;

            // button6
            button6.Location = new Point(199, 160);
            button6.Size = new Size(47, 29);
            button6.Text = "6";
            button6.Click += button6_Click;

            // button7
            button7.Location = new Point(93, 195);
            button7.Size = new Size(47, 29);
            button7.Text = "7";
            button7.Click += button7_Click;

            // button8
            button8.Location = new Point(146, 195);
            button8.Size = new Size(47, 29);
            button8.Text = "8";
            button8.Click += button8_Click;

            // button9
            button9.Location = new Point(199, 195);
            button9.Size = new Size(47, 29);
            button9.Text = "9";
            button9.Click += button9_Click;

            // button10
            button10.Location = new Point(146, 230);
            button10.Size = new Size(47, 29);
            button10.Text = "0";
            button10.Click += button10_Click;

            // button11 (+)
            button11.Location = new Point(93, 230);
            button11.Size = new Size(47, 29);
            button11.Text = "+";
            button11.Click += button11_Click;

            // button12 (=)
            button12.Location = new Point(199, 230);
            button12.Size = new Size(47, 29);
            button12.Text = "=";
            button12.Click += button12_Click;

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(113, 81);
            label1.Text = "0";

            // Form
            ClientSize = new Size(365, 297);
            Controls.Add(label1);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);

            Text = "Kalkulator";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Label label1;
    }
}