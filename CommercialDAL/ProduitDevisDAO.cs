using CommercialBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialDAL
{
    public class ProduitDevisDAO
    {
        public static void addUnProduitDevis(ProduitDevis unProduitDevis)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO ProduitDevis(qtt_produit, remise_produit, code_pro, code_devis) VALUES (@quantité, @remise, @codeProduit, @codeDevis)";
            cmd.Parameters.Add(new SqlParameter("@codeDevis", unProduitDevis.CodeDevis));
            cmd.Parameters.Add(new SqlParameter("@codeProduit", unProduitDevis.CodeProduit));
            cmd.Parameters.Add(new SqlParameter("@quantité", unProduitDevis.Quantite));
            cmd.Parameters.Add(new SqlParameter("@remise", unProduitDevis.Remise));
            cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close(); 
        }

        public static void DeleteAllProduits(int id)
        {
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE * from ProduitDevis where code_devis = @codeDevis";
            cmd.Parameters.Add(new SqlParameter("@codeDevis", id));
            cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
        }
    }
}
