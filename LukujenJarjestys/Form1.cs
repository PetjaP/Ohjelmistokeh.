using System.Drawing.Text;

namespace LukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        public LukujenJarjestys()
        {
            InitializeComponent();
        }
        List<int> jono = new List<int>();
        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (uusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach (var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                        
                    }
                    
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(uusiLukuTB.Text));
                    uusiLukuTB.Text = "";
                }
                if (e.KeyChar == (char)Keys.Escape)
                {
                    TyhjaaLomake();
                }
  
            }
        }
        private void TyhjaaLomake()
        {
            uusiLukuTB.Text = "";
        }

        private void VastausLB_Click(object sender, EventArgs e)
        {

        }
    }
}