
namespace Ajastin
{
    public partial class AjastinForm : Form
    {
        private int kokonaisaika;

        public AjastinForm()
        {
            InitializeComponent();
        }

        private void AjastinForm_Load(object sender, EventArgs e)
        {
            pysaytaBT.Enabled = false; // Tämä poistaa pysäytä napin käytöstä!
            for (int i=0; i < 60; i++) 
            {
                minuutitCB.Items.Add(i.ToString()); // Lisää minuutteihin 0-59
                sekunnitCB.Items.Add(i.ToString()); // Lisää sekunteihin 0-59
            }
            minuutitCB.SelectedIndex = 30; // Määrittelee, että oletus on 30
            sekunnitCB.SelectedIndex = 0; // Määrittelee, että oletus on 0
        }

        private void KaynnistaBT_Click(object sender, EventArgs e)
        {
            kaynnistaBT.Enabled = false; // Poistetaan painike käytöstä
            pysaytaBT.Enabled = true; // Ottaa pysäytä napin käyttöön
            // Allaolevalla lasketaan kokonaisaika sekunteina
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString()); // Hakee valitut minuutit
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString()); // Hakee valitut sekunnit
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTM.Enabled= true; // Asettaa timerin toimintaan
        }

        private void PysaytaBT_Click(object sender, EventArgs e)
        {
            kaynnistaBT.Enabled = true; // Ottaa Käynnistä napin käyttöön
            pysaytaBT.Enabled = false; // Ottaa pysäytä napin pois käytöstä
            kokonaisaika = 0;
            ajastinTM.Enabled = false; // Ottaa timerin pois käytöstä
            ajastinLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0) 
            {
                kokonaisaika--; // Kokonaisaika vähenee yhdellä
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                ajastinLB.Text = minuutit.ToString() + ":" + sekunnit.ToString(); 
            }
            else 
            {
                ajastinTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}