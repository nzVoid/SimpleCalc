using System.Data;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public static bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button5.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button20.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = new DataTable().Compute(richTextBox1.Text, null).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button23.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, (richTextBox1.Text.Length)-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button24.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "^2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "^";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += button2.Text;
        }
    }
}