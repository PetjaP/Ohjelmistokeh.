using System.Reflection.Metadata.Ecma335;

namespace Roomalaiset
{
    public partial class RoomalaisiksiForm : Form
    {
        public RoomalaisiksiForm()
        {
            InitializeComponent();
        }

        private void MuutaBT_Click(object sender, EventArgs e)
        {
            int luku1, luku2, luku3, luku4;
            string vastaus = "";
            if (TekstiTB.Text.Length > 3) // Tarkistetaan annetun luvun pituus, ja jos yli 3 niin kysesssä on tuhatluku
            {
                luku1 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); //Tuhannet
                luku2 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1)); // Sataset
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(2, 1)); // Kympit
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(3, 1)); // Ykköset
                if (luku1 % 3 == 0)
                {
                    vastaus += "MMM";
                }
                else if (luku1 % 2 == 0)
                {
                    vastaus += "MM";
                }
                else if (luku1 % 1 == 0)
                {
                    vastaus += "M";
                }
                else
                {
                    vastaus += "";
                }
                vastaus += sataset(luku2, vastaus); // Tällä haetaan sataset
                vastaus += kympit(luku3, vastaus);  // Tällä haetaan kympit
                vastaus += ykkoset(luku4, vastaus); // Tällä haetaan ykköset
            }
            else if (TekstiTB.Text.Length > 2) // Tarkistetaan annetun luvun pituus. Jos yli 2 niin kyseessä on sataluku
            {
                luku2 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); // Sataset
                luku3 = Convert.ToInt32(TekstiTB.Text.Substring(1, 1)); // Kympit
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(2, 1)); // Ykköset
                vastaus += sataset(luku2, vastaus); 
                vastaus += kympit(luku3, vastaus);
                vastaus += ykkoset(luku4, vastaus);
            }
            else if (TekstiTB.Text.Length > 0) // Kyseessä on ykkösluku
            {
                luku4 = Convert.ToInt32(TekstiTB.Text.Substring(0, 1)); // Ykköset
                vastaus += ykkoset(luku4, vastaus); // Tällä haetaan ykköset
            }
            VastausLB.Text = vastaus;
            VastausLB.Visible = true;
        }
        private string sataset(int luku2, string vastaus) // Palauttaa satasten arvon
        {
            if(luku2 % 9 == 0 && luku2 != 0)
            {
                return "CM";
            }
            else if(luku2 % 8 == 0 && luku2 != 0)
            {
                return "DCCC";
            }
            else if(luku2 % 7 == 0 && luku2 != 0)
            {
                return "DCC";
            }
            else if (luku2 % 6 == 0 && luku2 != 0)
            {
                return "DC";
            }
            else if (luku2 % 5 == 0 && luku2 != 0)
            {
                return "D";
            }
            else if (luku2 % 4 == 0 && luku2 != 0)
            {
                return "CD";
            }
            else if (luku2 % 3 == 0 && luku2 != 0)
            {
                return "CCC";
            }
            else if (luku2 % 2 == 0 && luku2 != 0)
            {
                return "CC";
            }
            else if (luku2 % 1 == 0 && luku2 != 0)
            {
                return "C";
            }
            else
            {
                return "";
            }
        }
        private string kympit(int luku3, string vastaus)
        {
            if (luku3 % 9 && luku3 != 0)
            {
                return "XC";
            }
            else if (luku3 % 8 && luku3 != 0)
            {
                return "LXXX";
            }
            else if (luku3 % 7 && luku3 != 0)
            {
                return "LXX";
            }
            else if (luku3 % 6 && luku3 != 0)
            {
                return "LX";
            }
            else if (luku3 % 4 && luku3 != 0)
            {
                return "XL";
            }
            else if (luku3 % 3 && luku3 != 0)
            {
                return "XXX";
            }
            else if (luku3 % 2 && luku3 != 0)
            {
                return "XX";
            }
            else if (luku3 % 1 && luku3 != 0)
            {
                return "X";
            }
            else
            {
                return "";
            }
        }
        private string ykkoset(int luku4, string vastaus)
        {
            if (luku4 % 9 && luku4 != 0)
            {
                return "IX";
            }
            else if (luku4 % 8 && luku4 != 0)
            {
                return "VIII";
            }
            else if (luku4 % 7 && luku4 != 0)
            {
                return "VII";
            }
            else if (luku4 % 6 && luku4 != 0)
            {
                return "VI";
            }
            else if (luku4 % 5 && luku4 != 0)
            {
                return "V";
            }
            else if (luku4 % 4 && luku4 != 0)
            {
                return "IV";
            }
            else if (luku4 % 3  && luku4 != 0)
            {
                return "III";
            }
            else if (luku4 % 2 && luku4 != 0)
            {
                return "II";
            }
            else if (luku4 % 1 && luku4 != 0)
            {
                return "I";
            }
            else
            {
                return "";
            }

        }

     }
    
    
}