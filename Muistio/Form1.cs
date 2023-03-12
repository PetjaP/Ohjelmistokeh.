using System.IO;
namespace Muistio
{
    public partial class MuistioForm : Form
    {
        private OpenFileDialog openFileDialog; // Haetaan Systems.IO kirjastosta käyttön
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        public MuistioForm()
        {
            InitializeComponent();
        }
        private void UusiTiedosto()
        {
            try 
            {
                if(!string.IsNullOrEmpty(TekstiTB.Text)) // ! tarkoittaa, että jos tämä ei ole tyhjä/0
                {
                    MessageBox.Show("Sinun tulee tallentaa ensin!");
                }
                else // Mitä tapahtuu jos tämä onkin tyhjä!
                {
                    TekstiTB.Text = string.Empty;
                    Text = "Nimetön";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex); // ex on koneen antama virhe!!!
            }
            
        }

        private void TallennaTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    saveFileDialog= new SaveFileDialog(); // Jos ei ole tyhjä, niin tehdään uusi OLIO ( Tallennus )
                    saveFileDialog.Filter = "Tekstitiedosto (*.txt) | *.txt| Rikas tekstiformaatti (*.rtf) | *.rtf"; // TÄmä tulee tallentaessa muotokohtaan!!!
                    if(saveFileDialog.ShowDialog() == DialogResult.OK) // Jos näkyy niin...
                    {
                        File.WriteAllText(saveFileDialog.FileName, TekstiTB.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex); // ex on koneen antama virhe!!!
            }
        }

        private void AvaaTiedosto()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    TekstiTB.Text = File.ReadAllText(openFileDialog.FileName);
                    Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa" + ex); // ex on koneen antama virhe!!!
            }
        }

        

        private void MuistioForm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog(); // Uusi OLIO taas
        }

        private void uusiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UusiTiedosto(); // Kutsuu uutta tiedostoa!
        }

        private void avaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvaaTiedosto(); // Kutsuu toimintoa!
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaTiedosto();
        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    TallennaTiedosto(); // TÄmä kutsutaan jos ei ole tyhjä
                }
                else 
                {
                    this.Close(); // Lopeta toiminto jos tyhjä!
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa" + ex); // ex on koneen antama virhe!!!
            }
        }

        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                if (fontDialog.ShowDialog() == DialogResult.OK) 
                {
                    TekstiTB.Font = fontDialog.Font; // Muuttaa valituksi fontiksi
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe avattaessa tiedostoa" + ex); // ex on koneen antama virhe!!!
            }
        }
    }
}