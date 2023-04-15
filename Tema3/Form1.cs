namespace Tema3
{

    public partial class Form1 : Form
    {
        private double numar1 = 0, numar2 = 0;
        int operatie, virgula = 0, zecimale = 1;//1 = + ;2 = - ; 3 = * ; 4 = /

        public Form1()
        {
            InitializeComponent();
            label1.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {

            String s = (sender as Button).Text;
            textBox1.Text = textBox1.Text + s;
            numar1 = numar1 * 10 + double.Parse(s);
            if (virgula == 1)
                zecimale++;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double rezultat = 0;
            numar1 = numar1 / Math.Pow(10, zecimale - 1);
            switch (operatie)
            {
                case 1: rezultat = numar1 + numar2; break;
                case 2: rezultat = numar2 - numar1; break;
                case 3: rezultat = numar1 * numar2; break;
                case 4: rezultat = numar2 / numar1; break;
            }
            label1.Text = textBox1.Text + "=";
            label1.Show();
            textBox1.Text = rezultat.ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if (s.Equals("+"))
                operatie = 1;
            else if (s.Equals("-"))
                operatie = 2;
            else if (s.Equals("*"))
                operatie = 3;
            else operatie = 4;

            textBox1.Text = textBox1.Text + s;

            numar2 = numar1 / Math.Pow(10, zecimale - 1);
            virgula = 0;
            zecimale = 1;
            numar1 = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            textBox1.Text = textBox1.Text + s;
            virgula = 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            virgula = 0;
            zecimale = 1;
            numar1 = 0;
            label1.Hide();
        }
    }
}