using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialBO;

namespace CommercialDAL
{
    public class DevisDAO
    {
        public static List<Devis> GetDevis()
        {
            int code, codeCli, codeStatut, numeroTel, numeroFax, numAdresseLiv, numAdresseFac, codePostalAdresseLiv, codePostalAdresseFac;
            float tx_tva;
            string nom, email, rueAdresseLiv, rueAdresseFac, villeAdresseLiv, villeAdresseFac, libStatut;
            Client unClient;
            StatusDevis unStatut;
            Devis unDevis;
            DateTime dt;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<Devis> lesDevis = new List<Devis>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Devis, Client, Statut_devis WHERE Devis.code_cli =  Client.code_cli AND Devis.code_statut = Statut_devis.code_statut";
            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_devis"].ToString());
                codeStatut = Int32.Parse(monReader["code_statut"].ToString());
                codeCli = Int32.Parse(monReader["code_statut"].ToString());
                float.TryParse(monReader["tx_tva_devis"].ToString(), out tx_tva);
                DateTime.TryParse(monReader["date_devis"].ToString(), out dt);
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
                unClient = new Client(codeCli, nom, numeroTel, numeroFax, email, numAdresseLiv, numAdresseFac, rueAdresseLiv, rueAdresseFac, codePostalAdresseLiv, codePostalAdresseFac, villeAdresseLiv, villeAdresseFac);
                libStatut = monReader["lib_statut"].ToString();
                unStatut = new StatusDevis(codeStatut, libStatut);
                unDevis = new Devis(code, tx_tva, dt, unClient, unStatut);
                lesDevis.Add(unDevis);
            }
            maConnexion.Close();
            return lesDevis;
        }

        public static List<ProduitDevis> getProduitDevis()
        {
            int codeDevis, codeProduit, quantite;
            float remise;

            ProduitDevis unProduitDevis;
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<ProduitDevis> lesProduitDevis = new List<ProduitDevis>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ProduitDevis";
            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {             
                codeDevis = Int32.Parse(monReader["code_devis"].ToString());
                codeProduit = Int32.Parse(monReader["code_pro"].ToString());
                quantite = Int32.Parse(monReader["qtt_produit"].ToString());
                float.TryParse(monReader["remise_produit"].ToString(), out remise);
                unProduitDevis = new ProduitDevis(codeDevis, codeProduit, remise,  quantite);

                lesProduitDevis.Add(unProduitDevis);
            }
            maConnexion.Close();
            return lesProduitDevis;
        }

        public static List<StatusDevis> getStatusDevis()
        {
            int codeStatus;
            string libelleStatus;
            StatusDevis unStatus;
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<StatusDevis> lesStatusDevis = new List<StatusDevis>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Statut_devis";
            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                codeStatus = Int32.Parse(monReader["code_statut"].ToString());
                libelleStatus = monReader["lib_statut"].ToString();
                unStatus = new StatusDevis(codeStatus, libelleStatus);
                lesStatusDevis.Add(unStatus);
            }
            maConnexion.Close();
            return lesStatusDevis;

        }

        public static int AjoutDevis(Devis unDevis)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Devis(tx_tva_devis, date_devis, code_cli, code_statut)" +
                "values(@TVA, @date, @fk_code_stat, @fk_code_cli)",
                maConnexion
            );
            cmd.Parameters.AddWithValue("@TVA", unDevis.Tx_tva);
            cmd.Parameters.AddWithValue("@date", unDevis.Date);
            cmd.Parameters.AddWithValue("@fk_code_stat", unDevis.Client.Code);
            cmd.Parameters.AddWithValue("@fk_code_cli", unDevis.Status.Id);
            /* Exécution de la requête */
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
        // Cette méthode supprime en BD un devis
        public static string DeleteDevis(int id)
        {
            string valid = "";
            SqlConnection maConnexionDel = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmdDelProduitDevis = new SqlCommand();
            cmdDelProduitDevis.Connection = maConnexionDel;
            cmdDelProduitDevis.CommandText = "DELETE FROM ProduitDevis WHERE code_devis = @codeDevis";
            cmdDelProduitDevis.Parameters.Add(new SqlParameter("codeDevis", id));
            cmdDelProduitDevis.ExecuteNonQuery();
            SqlCommand cmdDel = new SqlCommand();
            cmdDel.Connection = maConnexionDel;
            cmdDel.CommandText = "DELETE FROM Devis WHERE code_devis = @codeDevis";
            cmdDel.Parameters.Add(new SqlParameter("codeDevis", id));
            cmdDel.ExecuteNonQuery();
            valid = "Le devis a bien été supprimé.";
            maConnexionDel.Close();
            // Fermeture de la connexion
            return valid;
        }
        // Cette méthode update devis
        public static void UpdateDevis(Devis unDevis)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmdUpdateProduitDevis = new SqlCommand();
            cmdUpdateProduitDevis.Connection = maConnexion;
            cmdUpdateProduitDevis.CommandText = "INSERT INTO Devis(tx_tva_devis, date_devis, code_cli, code_statut) VALUES (@tva, @date, @cli, @statut) WHERE code_devis = @codeDevis";
            cmdUpdateProduitDevis.Parameters.Add(new SqlParameter("tva", unDevis.Tx_tva));
            cmdUpdateProduitDevis.Parameters.Add(new SqlParameter("date", unDevis.Date));
            cmdUpdateProduitDevis.Parameters.Add(new SqlParameter("cli", unDevis.Client.Code));
            cmdUpdateProduitDevis.Parameters.Add(new SqlParameter("statut", unDevis.IdStatus));
            cmdUpdateProduitDevis.Parameters.Add(new SqlParameter("codeDevis", unDevis.IdClient));
            cmdUpdateProduitDevis.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
        }
    }
        
}
