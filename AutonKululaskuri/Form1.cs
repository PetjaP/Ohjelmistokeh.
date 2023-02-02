namespace AutonKululaskuri
{
    public partial class kuluLaskuri : Form
    {
        public kuluLaskuri()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void KilometritCB_SelectedIndexChanged(object sender, EventArgs e)
        {   //Tehd‰‰n muuttujat
            double laina, neste, vakuutus, kulu, polttoaine, pesu, huolto, renkaat, kilometrit, kustannukset;
            laina = Convert.ToDouble(LainaTB.Text);
            neste = Convert.ToDouble(NesteetTB.Text);
            vakuutus = Convert.ToDouble(NesteetTB.Text);
            kulu = Convert.ToDouble(KulutTB.Text);
            polttoaine = Convert.ToDouble(PolttoaineTB.Text);
            pesu = Convert.ToDouble(PesuTB.Text);
            huolto = Convert.ToDouble(HuoltoTB.Text);
            renkaat = Convert.ToDouble(RenkaatTB.Text);
            kilometrit = Convert.ToDouble(KilometritCB.Text);
            // Lasketaan kustannukset ja tulostetaan ne lomakkeelle
            kustannukset = (laina + neste + vakuutus + kulu + polttoaine + pesu + huolto + renkaat) / (kilometrit / 12);
            VastausLB.Text = "Kustannukset kilometri‰ kohden ovat: " + kustannukset + " euroa";
            VastausLB.Visible = true;
        }
}
}