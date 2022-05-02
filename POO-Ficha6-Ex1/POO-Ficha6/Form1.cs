namespace POO_Ficha6
{
    public partial class CelConverter : Form
    {
        public CelConverter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBoxC.Text);
            double f = ((c * 9) / 5) + 32;
            string fs = Convert.ToString(f);
            textBoxF.Text = fs;
            double k = c + 273.15;
            string ks = Convert.ToString(k);
            textBoxK.Text = ks;
        }
    }
}
        