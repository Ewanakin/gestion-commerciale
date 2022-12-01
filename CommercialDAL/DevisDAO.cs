using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialBO;

namespace CommercialDAL
{
    internal class DevisDAO
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
                DateTime.TryParse(monReader["DateOnlyColumn"].ToString(), out dt);
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
            int codeDevis, codeProduit;
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
                codeProduit = Int32.Parse(monReader["code_statut"].ToString());
                unProduitDevis = new ProduitDevis(codeDevis, codeProduit);
                lesProduitDevis.Add(unProduitDevis);
            }
            return lesProduitDevis;
        }
    }
        
}
