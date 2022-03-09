namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = float.Parse(textBox3.Text);
            
            textBox4.Text =(Math.Pow(b, 2) -4 * a * c).ToString();

            float delta = float.Parse(textBox4.Text);


            if (delta > 0)
            {
                textBox5.Text = "dodatnia";
                textBox6.Text = (((b * (-1)) + (float)Math.Sqrt(delta)) / 2 * b).ToString();
                textBox7.Text = (((b * (-1)) - (float)Math.Sqrt(delta)) / 2 * b).ToString();
                textBox8.Text = "nie ma";
            }
            else if (delta < 0)
            {
                textBox5.Text = "ujemna";
                textBox6.Text = "nie ma";
                textBox7.Text = "nie ma";
            }
            else if(delta == 0)
            {
                textBox5.Text = "zero";
                textBox8.Text = (((b * (-1)) / 2 * b)).ToString();
                textBox6.Text = "nie ma";
                textBox7.Text = "nie ma";
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}