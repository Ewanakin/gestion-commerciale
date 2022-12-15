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
            int nomCli;
            int nbDevis;
            int nbDevisAcceptes;
            float pourcentageDevisAcceptes;
            float pourcentageDevisEnAttente;
            float montantTotal;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<SyntheseDevis> lesSyntheseDevis = new List<SyntheseDevis>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Client WHERE code_cli = @codeCli";
            cmd.Parameters.Add(new SqlParameter("@codeCli", codeCli));
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_pro"].ToString());
                codeCateg = Int32.Parse(monReader["code_categ"].ToString());
                libelle = monReader["lib_pro"].ToString();
                float.TryParse(monReader["prix_vente_ht_pro"].ToString(), out prixHT);
                libelleCategorie = monReader["lib_categ"].ToString();
                CategorieProduit uneCategPro = new CategorieProduit(codeCateg, libelleCategorie);
                Produit unProduit = new Produit(code, libelle, prixHT, uneCategPro);
                lesUtilisateurs.Add(unProduit);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesUtilisateurs;
        }
    }
}
