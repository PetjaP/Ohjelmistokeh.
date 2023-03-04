namespace NopanHeitto
{
    public partial class Nopanheitto : Form
    {
        public Nopanheitto()
        {
            InitializeComponent();
        }

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            piirraNoppa(Noppa01PB); // Haetaan allaolevasta koodista nopat, kun painetaan heit‰ nappia.
            piirraNoppa(Noppa02PB);
            // Lis‰‰m‰ll‰ piirraNoppa komentoja voidaan lis‰t‰ helposti noppia!!!!
        }
        private void piirraNoppa(PictureBox Noppabox)
        {
            Random satunnainen = new Random(); // Random luokalla tehd‰‰n satunnainen
            int noppa = satunnainen.Next(1, 7); // K‰ytet‰‰n satunnainen OLIOta ja Next funktiota ett‰ arvotaan luku 1-6 v‰lilt‰.
            switch (noppa) 
            {
                case 1:
                    Noppabox.Image = Properties.Resources.dice01; // T‰ll‰ haetaan nopan kuva.
                    break;
                case 2:
                    Noppabox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    Noppabox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    Noppabox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    Noppabox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    Noppabox.Image = Properties.Resources.dice06;
                    break;
            }
        }
    }
}