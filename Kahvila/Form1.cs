namespace Kahvila
{
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {
            InitializeComponent();
            meistaPL.Visible = true; // Alussa n‰ytet‰‰n meist‰ osio
        }

        private void ruokalistaForm_Load(object sender, EventArgs e) // teksti joka tulee kun avataan
        {
            meistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 v‰lituntisin \n";
            meistaLB.Text += "9:00 - 14:30 joka p‰iv‰ maanantaista torstaisin ja perjantaisin \n";
            meistaLB.Text += "9:00 - 12:30. \n\n Keudan oppilaskunnan kahvilasta saa l‰mpimien \n";
            meistaLB.Text += "juomien lis‰ksi virvokkeita sek‰ pient‰ purtavaa ja makeisia \n";
            meistaLB.Text += "Tervetuloa tutustumaan";
            meistaLB.Font = new Font("Arial", 12);
        }

        private void meistaBT_Click(object sender, EventArgs e) // Mit‰ n‰ytet‰‰n, kun painetaan meistaBT
        {
            meistaPL.Visible= true;
            ruuatPL.Visible= false;
            juomatPL.Visible= false;
            herkutPL.Visible= false;
            koriPL.Visible= false;
        }

        private void ruuatBT_Click(object sender, EventArgs e) // Mit‰ n‰ytet‰‰n, kun painetaan ruuatBT
		{
			meistaPL.Visible = false;
			ruuatPL.Visible = true;
			juomatPL.Visible = false;
			herkutPL.Visible = false;
			koriPL.Visible = false;
		}

        private void juomatBT_Click(object sender, EventArgs e)// Mit‰ n‰ytet‰‰n, kun painetaan juomatBT
		{
			meistaPL.Visible = false;
			ruuatPL.Visible = false;
			juomatPL.Visible = true;
			herkutPL.Visible = false;
			koriPL.Visible = false;
		}

        private void herkutBT_Click(object sender, EventArgs e) // Mit‰ n‰ytet‰‰n, kun painetaan herkutBT
		{
			meistaPL.Visible = false;
			ruuatPL.Visible = false;
			juomatPL.Visible = false;
			herkutPL.Visible = true;
			koriPL.Visible = false;
		}

        private void koriBT_Click(object sender, EventArgs e)// Mit‰ n‰ytet‰‰n, kun painetaan koriBT
		{
			meistaPL.Visible = false;
			ruuatPL.Visible = false;
			juomatPL.Visible = false;
			herkutPL.Visible = false;
			koriPL.Visible = true;
		}

        private void exitBT_Click(object sender, EventArgs e) // Sulje nappi!
		{
            Application.Exit();
        }
    }
}