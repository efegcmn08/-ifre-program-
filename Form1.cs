namespace şifre_programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                this.Hide();
                Form2 link = new Form2();
                link.Show();
            }
            else
            {
                Form3 hata = new Form3();
                hata.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}