namespace Päiväkirja
{
    public partial class PaivakirjaForm : Form
    {
        public PaivakirjaForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C:\\Users\\roku8\\source\\repos\\PetjaP\\Ohjelmistokeh\\Päiväkirja\\demo.txt");
            SyöttöTB.Text  = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyöttöTB.Text;
            teksti += " " + DateTime.Now.ToString("dd:MM:yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\roku8\\source\\repos\\PetjaP\\Ohjelmistokeh\\Päiväkirja\\demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}