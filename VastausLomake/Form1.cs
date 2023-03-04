namespace VastausLomake
{
    public partial class VastauslomakeForm : Form
    { //Taulukoiden m‰‰rittely
        string[] vastaukset = new string[11]; // Taulukon m‰‰rittely.
        string[] oikeat = new string[] {"", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" }; // Oikeat vastaukset
        int laskuri = 0; // Laskuri kysymyksi‰ varten
        int oikein = 0; // Oikein vastausten laskuri
        public VastauslomakeForm()
        { // Tapahtumank‰sittelij‰!
            InitializeComponent();
            VastausARB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausBRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausDRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
        }

        private void VastauslomakeForm_Load(object sender, EventArgs e)
        {

        }
        private void radiobutton_CheckedChanged(object sender, EventArgs e) //Kuuntelee painiketta
        {
            if (sender is RadioButton && laskuri <= 10) //Tarkistetaan ett‰ radiobuttoneilta tuli jotakin sek‰ ettei laskuri mennyt yli!
            {

                RadioButton radioButton = (RadioButton)sender; // Uusi radiobutton!
                vastaukset[laskuri] = radioButton.Text; // Syˆtt‰‰ taulukkoon
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen"; // Vaihtaa tekstin 1.> 2.> 3. jne.
                laskuri++; //Lis‰‰ laskuriin
            }
            else // Poistaa radiobuttonit k‰ytˆst‰ ja tyhjent‰‰ vastausLabelin
            {
                VastausLB.Text = "";
                VastausARB.Enabled= false;
                VastausBRB.Enabled= false;
                VastausCRB.Enabled= false;
                VastausDRB.Enabled= false;
                for (int j = 1; j <= 10; j++) // Vertaa kuinka moni annettu vastaus vastaa oikeaa vastausta!
                {
                    if (vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }

                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible= true;
            }
            Tyhjaavastaus(); // Kutsutaan tyhj‰‰ vastaus funktiota!
        }
        private void Tyhjaavastaus() // Tyhj‰‰ vastaus funktio!
        {
            if (VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--;
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }

        }
    }
}