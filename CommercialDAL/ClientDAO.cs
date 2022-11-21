using CommercialBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialDAL
{
    public class ClientDAO
    {
        public static List<Client> GetClients()
        {
            int code;
            string nom;
            int numeroTel;
            int numeroFax;
            string email;
            int numAdresseLiv;
            int numAdresseFac;
            string rueAdresseLiv;
            string rueAdresseFac;
            int codePostalAdresseLiv;
            int codePostalAdresseFac;
            string villeAdresseLiv;
            string villeAdresseFac;
            Client unClient;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<Client> lesClients = new List<Client>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Client";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_cli"].ToString());
                nom = monReader["num_cli"].ToString();
                numeroTel = Int32.Parse(monReader["num_tel_cli"].ToString());
                numeroFax = Int32.Parse(monReader["num_fax_cli"].ToString());
                email = monReader["adresse_mail_cli"].ToString();
                numAdresseLiv = Int32.Parse(monReader["num_adresse_fact_cli"].ToString());
                numAdresseFac = Int32.Parse(monReader["num_adresse_livr_cli"].ToString());
                rueAdresseLiv = monReader["rue_adresse_liv_cli"].ToString();
                rueAdresseFac = monReader["rue_adresse_fact_cli"].ToString();
                codePostalAdresseLiv = Int32.Parse(monReader["code_postal_fact_cli"].ToString());
                codePostalAdresseFac = Int32.Parse(monReader["code_postal_livr_cli"].ToString());
                villeAdresseLiv = monReader["ville_adresse_livr_cli"].ToString();
                villeAdresseFac = monReader["ville_adresse_fact_cli"].ToString();
                unClient = new Client(code, nom, numeroTel, numeroFax, email, numAdresseLiv, numAdresseFac, rueAdresseLiv, rueAdresseFac, codePostalAdresseLiv, codePostalAdresseFac, villeAdresseLiv, villeAdresseFac);
                lesClients.Add(unClient);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesClients;
        }
    }
}
