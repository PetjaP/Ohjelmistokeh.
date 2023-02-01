namespace SalasananTarkistus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void SalasanaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KayttajaTB_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Petja" && SalasanaTB.Text == "virveli")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                VirheviestiLB.Visible = true;
            } 
        }

        private void SalasanaForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SalasanaOikeinPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalasanaTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}