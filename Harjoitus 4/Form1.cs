namespace Harjoitus_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void laskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = aikadTP.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            vuosiLB.Text = Math.Ceiling( erotus / 365.25) + " vuotta";
            kuukausiLB.Text = Math.Ceiling( erotus * 12 / 365.25) + " kuukautta";
            paivaLB.Text = erotus + " p‰iv‰‰";
            tuntiLB.Text = (erotus * 24) + " tuntia";
            minuuttiLB.Text = (erotus * 24 * 60) + " minuuttia";
            sekuntiLB.Text = (erotus * 24 * 3600) + " sekuntia";
            vuosiLB.Visible = true;
            kuukausiLB.Visible = true;
            paivaLB.Visible = true;
            tuntiLB.Visible = true;
            sekuntiLB.Visible = true;
        }

        private void aikadTP_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}