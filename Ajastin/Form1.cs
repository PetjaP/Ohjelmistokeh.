
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
            pysaytaBT.Enabled = false; // T�m� poistaa pys�yt� napin k�yt�st�!
            for (int i=0; i < 60; i++) 
            {
                minuutitCB.Items.Add(i.ToString()); // Lis�� minuutteihin 0-59
                sekunnitCB.Items.Add(i.ToString()); // Lis�� sekunteihin 0-59
            }
            minuutitCB.SelectedIndex = 30; // M��rittelee, ett� oletus on 30
            sekunnitCB.SelectedIndex = 0; // M��rittelee, ett� oletus on 0
        }

        private void KaynnistaBT_Click(object sender, EventArgs e)
        {
            kaynnistaBT.Enabled = false; // Poistetaan painike k�yt�st�
            pysaytaBT.Enabled = true; // Ottaa pys�yt� napin k�ytt��n
            // Allaolevalla lasketaan kokonaisaika sekunteina
            int minuutit = int.Parse(minuutitCB.SelectedItem.ToString()); // Hakee valitut minuutit
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString()); // Hakee valitut sekunnit
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTM.Enabled= true; // Asettaa timerin toimintaan
        }

        private void PysaytaBT_Click(object sender, EventArgs e)
        {
            kaynnistaBT.Enabled = true; // Ottaa K�ynnist� napin k�ytt��n
            pysaytaBT.Enabled = false; // Ottaa pys�yt� napin pois k�yt�st�
            kokonaisaika = 0;
            ajastinTM.Enabled = false; // Ottaa timerin pois k�yt�st�
            ajastinLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0) 
            {
                kokonaisaika--; // Kokonaisaika v�henee yhdell�
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