using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // MUISTA! Tämän luokan avulla luodaan yhteys mysql tietokantaan!!!

namespace Oppilashallinta
{
    internal class YHDISTA
    {
        public string yhteyslause()
        {
            return "datasource=localhost;port=3306;username=root;password=;database=hotelli";
        }
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=opiskelijat"); // Yhteyslauseke, sekä missä sijaitsee.
        // !!!HUOM! root käyttäjä ilman salasanaa vain harjoituksissa!!!
        // Luodaan funktio yhteyttä varten
        public MySqlConnection otaYhteys() // Palauttaa ylläolevan!
        {
            return yhteys;
        }
        // Luodaan funktio yhteyden avaamista varten - HUOMIO! System.Data kirjasto!
        public void avaaYhteys() // Avaa yhteyden
        {
            if (yhteys.State == ConnectionState.Closed) // Tarkistaa jos on suljettu
            {
                yhteys.Open(); // Avaa yhteyden
            }

        }
        // Luodaan funktio yhteyden sulkemista varten
        public void suljeYhteys() // Sulkee yhteyden
        {
            if (yhteys.State = ConnectionState.Open) // Tarkistaa jos on auki
            {
                yhteys.Close(); // Sulkee yhteyden!
            }
        }
    }
}
