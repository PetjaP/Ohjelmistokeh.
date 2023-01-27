namespace Harjoitus_3
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

        private void laskeBT_Click(object sender, EventArgs e)
        {
            double luku1 = double.Parse(luku1TB.Text);
            double luku2 = double.Parse(luku2TB.Text);
            double vastaus = 0;
            string merkki = laskuToimitusCB.Text;

            switch (merkki)
            {
                case "+":
                    vastaus = luku1 + luku2;
                    break;
                case "-":
                    vastaus = luku1 - luku2;
                    break;
                case "*":
                    vastaus = luku1 * luku2;
                    break;
                case "/":
                    vastaus = luku1 / luku2;
                    break;
                default:
                    vastausLB.Text = "Virheelliset syötöt!";
                    break;
            }
            vastausLB.Text = vastaus.ToString();
            vastausLB.Visible= true;
        }
    }
}