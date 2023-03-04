namespace CelsiusToFahrenheit
{
    public partial class AstemuunninForm : Form
    {
        public AstemuunninForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus; // Haetaan vastaus
            double asteet = Convert.ToDouble(AsteetTB.Text); // Haetaan vastaus ja muunnetaan vastaus.
            if(CelsiusRB.Checked) 
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + " Fahrenheitia on " + vastaus + " Celsius astetta";
                VastausLB.Visible = true;
            }
            else if (FahrenheitRB.Checked) 
            {
                vastaus = (asteet - 32) / 1.8;
                VastausLB.Text = asteet + " Celsiusta on " + vastaus + " Fahrenheit astetta.";
            }
            else
            {
                VastausLB.Text = "Et valinnut muunnettavaa astetta tai antanut oikeaa luku!";
                VastausLB.Visible = true;
            }
        }
    }
}