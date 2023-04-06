using System.Windows.Forms;
using System.Diagnostics;
namespace Sekuntikello
{
    public partial class SekkariForm : Form
    {
        public SekkariForm() // OLIO joka toimii vain t�m�n sis�ll�!
        {
            InitializeComponent();
        }
        private Stopwatch sekkari = new Stopwatch();

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            aikaLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed); // T�m� muuntaa Labelin Timerin toimimaan!
        }

        private void KaynnistaBT_Click_1(object sender, EventArgs e)
        {
            sekkari.Start(); // K�ynnist� komento
        }

        private void LopetaBT_Click_1(object sender, EventArgs e)
        {
            sekkari.Stop(); // Pys�yt� komento
        }

        private void TyhjennaBT_Click_1(object sender, EventArgs e)

        {
            sekkari.Reset(); // Tyhjenn� komento
        }

        private void AjastinTM_Tick_1(object sender, EventArgs e)
        {
            aikaLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed); // T�m� muuntaa Labelin Timerin toimimaan!
        }
    }
}
