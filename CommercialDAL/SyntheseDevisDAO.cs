using CommercialBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialDAL
{
    public class SyntheseDevisDAO
    {
        public static SyntheseDevis GetSyntheseDevis(int codeCli)
        {
            List<int> listeCodeDevis = new List<int>();
            int nbDevis, codeDevis = 0;
            int nbDevisAcceptes, nbDevisAttente;
            float pourcentageDevisAcceptes;
            float pourcentageDevisEnAttente;
            float montantTotal= 0;
            float montantDevis = 0;
            string nomCli = "";
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // recup nom cli
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT num_cli FROM Client WHERE code_cli = @codeCli";
            cmd.Parameters.Add(new SqlParameter("@codeCli", codeCli));
            SqlDataReader readerNomCli = cmd.ExecuteReader();
            while (readerNomCli.Read())
            {
                nomCli = readerNomCli["num_cli"].ToString();
            }
            readerNomCli.Close();

            // récupération du nombre de devis
            SqlCommand cmdNbDevis = new SqlCommand();
            cmdNbDevis.Connection = maConnexion;
            cmdNbDevis.CommandText = "SELECT COUNT(code_devis) FROM Devis WHERE code_cli = @codeCli";
            cmdNbDevis.Parameters.Add(new SqlParameter("@codeCli", codeCli));
            nbDevis = (Int32)cmdNbDevis.ExecuteScalar();

            // récupération du nimbre de devis accept
            SqlCommand cmdNbDevisAcceptes = new SqlCommand();
            cmdNbDevisAcceptes.Connection = maConnexion;
            cmdNbDevisAcceptes.CommandText = "SELECT COUNT(code_statut) FROM Devis WHERE code_cli = @codeCli AND code_statut = 0";
            cmdNbDevisAcceptes.Parameters.Add(new SqlParameter("@codeCli", codeCli));
            nbDevisAcceptes = (Int32)cmdNbDevisAcceptes.ExecuteScalar();

            // récupération du nimbre de devis en attente
            SqlCommand cmdNbDevisAttente = new SqlCommand();
            cmdNbDevisAttente.Connection = maConnexion;
            cmdNbDevisAttente.CommandText = "SELECT COUNT(code_statut) FROM Devis WHERE code_cli = @codeCli AND code_statut = 2";
            cmdNbDevisAttente.Parameters.Add(new SqlParameter("@codeCli", codeCli));
            nbDevisAttente = (Int32)cmdNbDevisAttente.ExecuteScalar();

            // récupération des codes devis
            SqlCommand cmdDevis = new SqlCommand();
            cmdDevis.Connection = maConnexion;
            cmdDevis.CommandText = "SELECT * FROM Devis WHERE code_cli = @codeCli";
            cmdDevis.Parameters.Add(new SqlParameter("@codeCli", codeCli));
            SqlDataReader readerDevis = cmdDevis.ExecuteReader();
            while (readerDevis.Read())
            {
                listeCodeDevis.Add(Int32.Parse(readerDevis["code_devis"].ToString()));
            }
            readerDevis.Close();

            foreach(int unCodeDevis in listeCodeDevis)
            {
                // récupération des produits devis
                SqlCommand cmdProduitDevis = new SqlCommand();
                cmdProduitDevis.Connection = maConnexion;
                cmdProduitDevis.CommandText = "SELECT SUM((prix_vente_ht_pro*qtt_produit)-(prix_vente_ht_pro*qtt_produit)*remise_produit/100)  FROM Produit INNER JOIN ProduitDevis ON Produit.code_pro = ProduitDevis.code_pro AND ProduitDevis.code_devis = @codeDevis";
                cmdProduitDevis.Parameters.Add(new SqlParameter("@codeDevis", unCodeDevis));
                float.TryParse(cmdProduitDevis.ExecuteScalar().ToString(), out montantDevis);
                montantTotal += montantDevis; 
            }



            pourcentageDevisAcceptes = (nbDevisAcceptes / nbDevis) * 100;
            pourcentageDevisEnAttente = (nbDevisAttente/ nbDevis) * 100;

            SyntheseDevis uneSyntheseDevis = new SyntheseDevis(codeCli, nomCli, nbDevis, nbDevisAcceptes, pourcentageDevisAcceptes, pourcentageDevisEnAttente, montantTotal);
            // Fermeture de la connexion
            maConnexion.Close();
            return uneSyntheseDevis;
        }
    }
}
