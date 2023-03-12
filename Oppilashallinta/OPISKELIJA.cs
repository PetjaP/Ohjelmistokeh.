using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // MUISTA! Tämän luokan avulla luodaan yhteys mysql tietokantaan!!!
using System.Data;

namespace Oppilashallinta
{
    internal class OPISKELIJA
    {
        YHDISTA yhteys = new YHDISTA(); // Funktio jonka avulla lisätään uusi opiskelija

        public bool lisaaOpiskelija(string enimi, string snimi, string puh, string email, int onro) // Kun lisätään opiskelija!
        {
            MySqlCommand komento = new MySqlCommand();
            string lisayskysely = "INSERT INTO yhteystiedot " + // Mihin lisätään (taulukko)
                "(etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero) " + // Kentät mihin lisätään
                "VALUES (@enm, @snm, @puh, @eml, @ono"; ";  ;
                komento.CommandText= lisayskysely;
                komento.Connection = yhteys.otaYhteys();
                // @ktu,@enm,@snm,@oso,@pno,@ptp,@ssa
                komento.Parameters.Add("enm", MySqlDbType.VarChar).Value = enimi; // Kerrotaan minkä tyyppisiä tiedot ovat ( Määritetty MySQL:ssä )
                komento.Parameters.Add("snm", MySqlDbType.VarChar).Value= snimi;
                komento.Parameters.Add("puh", MySqlDbType.VarChar).Value = puh;
                komento.Parameters.Add("email", MySqlDbType.VarChar).Value = email;
                komento.Parameters.Add("ono", MySqlDbType.UInt32).Value = onro; // Huom määritetty INTIKSI MYSQL:ssä
            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1) // Jos tämä komento toimii
            {
                yhteys.suljeYhteys();
                return true;
            }
            else // JOs ei toimi!
            {
                yhteys.suljeYhteys();
                return false;
            }

        }
        public DataTable haeOpiskelijat() // Funktio opiskelijoiden hakemiseen
        {
            MySqlCommand komento = new MySqlCommand("SELECT oid, etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero, FROM yhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }
        // Funktio opiskelijan tietojen muokkaamiseksi
        public bool muokkaaOpiskelijaa(int oid, String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `yhteystiedot` SET `Etunimi`=@enm," +
                "`Sukunimi`= @snm, `puhelin`= @puh,`sahkoposti`= @eml,`opiskelijanumero`= @ono" +
                " WHERE oid = @oid";
            komento.CommandText= paivityskysely;
            komento.Connection = yhteys.otaYhteys();
            //@ktu, @enm, @snm, @oso,@pno, @ptp, @ssa
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else 
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public bool poistaOpiskelija(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM yhteystiedot WHERE oid = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();
            //ktu
            komento.Parameters.Add("@ktu", MySqlDbType.UInt32).Value = ktunnus;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else 
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
