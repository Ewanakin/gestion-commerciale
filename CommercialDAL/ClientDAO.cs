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

        public static string addClient(Client unCli)
        {
            int nbre;
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Client(num_cli, num_tel_cli, num_fax_cli, adresse_mail_cli, num_adresse_fact_cli, num_adresse_livr_cli, rue_adresse_liv_cli, rue_adresse_fact_cli, code_postal_fact_cli,  code_postal_livr_cli, ville_adresse_livr_cli, ville_adresse_fact_cli)" +
                "VALUES( @num_cli, @num_tel,  @num_fax, @adresse_mail, @num_adr_fact, @num_adr_livr, @rue_adr_livr, @rue_adr_fact, @code_postal_fact, @code_postal_livr, @ville_adr_livr, @ville_adr_fact)";
            cmd.Parameters.Add(new SqlParameter("num_cli", unCli.Nom));
            cmd.Parameters.Add(new SqlParameter("num_tel", unCli.NumeroTel));
            cmd.Parameters.Add(new SqlParameter("num_fax", unCli.NumeroFax));
            cmd.Parameters.Add(new SqlParameter("adresse_mail", unCli.Email));
            cmd.Parameters.Add(new SqlParameter("num_adr_fact", unCli.NumAdresseFac));
            cmd.Parameters.Add(new SqlParameter("num_adr_livr", unCli.NumAdresseLiv));
            cmd.Parameters.Add(new SqlParameter("rue_adr_livr", unCli.RueAdresseLiv));
            cmd.Parameters.Add(new SqlParameter("rue_adr_fact", unCli.RueAdresseFac));
            cmd.Parameters.Add(new SqlParameter("code_postal_fact", unCli.CodePostalAdresseFac));
            cmd.Parameters.Add(new SqlParameter("code_postal_livr", unCli.CodePostalAdresseLiv));
            cmd.Parameters.Add(new SqlParameter("ville_adr_livr", unCli.VilleAdresseLiv));
            cmd.Parameters.Add(new SqlParameter("ville_adr_fact", unCli.VilleAdresseFac));
            nbre = cmd.ExecuteNonQuery();
            maConnexion.Close();
            if (nbre == 1)
            {
                return "Le client a bien été ajouté";
            }
            else
            {
                return "Un problème est survenue.";
            }
        }

        // Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static string DeleteClient(int id)
        {
            SqlDataReader result;
            string valid = "";
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Devis WHERE code_cli = @codeCli";
            cmd.Parameters.Add(new SqlParameter("codeCli", id));
            result = cmd.ExecuteReader();
            if (!result.HasRows)
            {
                maConnexion.Close();
                SqlConnection maConnexionDel = ConnexionBD.GetConnexionBD().GetSqlConnexion();
                SqlCommand cmdDel = new SqlCommand();
                cmdDel.Connection = maConnexionDel;
                cmdDel.CommandText = "DELETE FROM Client WHERE code_cli = @codeCli";
                cmdDel.Parameters.Add(new SqlParameter("codeCli", id));
                cmdDel.ExecuteNonQuery();
                valid = "Le client a bien été supprimé.";
                maConnexionDel.Close();
            }
            else
            {
                maConnexion.Close();
                valid = "Le Client ne peut pas être supprimé car il correspond à un devis.";
            }
            // Fermeture de la connexion
            return valid;
        }

        public static int UpdateClient(Client unCli)
        {
            int nbEnr = 0;
            //Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Client SET num_cli = @numCli, " +
                "num_tel_cli = @numTelCli, num_fax_cli = @numFaxCli, " +
                "adresse_mail_cli = @mailCli, num_adresse_fact_cli = @numAdresseFactCli, " +
                "num_adresse_livr_cli = @numAdresseLivrCli, rue_adresse_fact_cli = @rueAdresseFactCli, " +
                "rue_adresse_liv_cli = @rueAdresseLivrCli, code_postal_fact_cli = @codePostalFactCli, " +
                "code_postal_livr_cli = @codePostalLivrCli, ville_adresse_fact_cli = @villeAdresseFactCli, " +
                "ville_adresse_livr_cli = @villeAdresseLivrCli " +
                "WHERE code_cli = @codeCli";
            cmd.Parameters.Add(new SqlParameter("numCli", unCli.Nom));
            cmd.Parameters.Add(new SqlParameter("libellePro", unCli.Nom));
            cmd.Parameters.Add(new SqlParameter("numTelCli", unCli.NumeroTel));
            cmd.Parameters.Add(new SqlParameter("numFaxCli", unCli.NumeroFax));
            cmd.Parameters.Add(new SqlParameter("mailCli", unCli.Email));
            cmd.Parameters.Add(new SqlParameter("numAdresseFactCli", unCli.NumAdresseFac));
            cmd.Parameters.Add(new SqlParameter("numAdresseLivrCli", unCli.NumAdresseLiv));
            cmd.Parameters.Add(new SqlParameter("rueAdresseFactCli", unCli.RueAdresseFac));
            cmd.Parameters.Add(new SqlParameter("rueAdresseLivrCli", unCli.RueAdresseLiv));
            cmd.Parameters.Add(new SqlParameter("codePostalFactCli", unCli.CodePostalAdresseFac));
            cmd.Parameters.Add(new SqlParameter("codePostalLivrCli", unCli.CodePostalAdresseLiv));
            cmd.Parameters.Add(new SqlParameter("villeAdresseFactCli", unCli.VilleAdresseFac));
            cmd.Parameters.Add(new SqlParameter("villeAdresseLivrCli", unCli.VilleAdresseLiv));
            cmd.Parameters.Add(new SqlParameter("codeCli", unCli.Code));
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        public static List<int> GetClientsId()
        {
            int code;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<int> lesClientsId = new List<int>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT code_cli FROM Client";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_cli"].ToString());
                lesClientsId.Add(code);
            }
            // Fermeture de la connexion
            maConnexion.Close();

            return lesClientsId;
        }
    }
}
