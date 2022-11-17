using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialBO;
using CommercialDAL;

namespace CommercialDAL
{
    public class ProduitDAO
    {
        private static ProduitDAO unProduitDAO;
        // Accesseur en lecture, renvoi une instance
        public static ProduitDAO GetunUtilisateurDAO()
        {
            if (unProduitDAO == null)
            {
                unProduitDAO = new ProduitDAO();
            }
            return unProduitDAO;
        }
        // Cette méthode retourne une List contenant les objets Utilisateurs
        // contenus dans la table Identification
        public static List<Produit> GetProduits()
        {
            int code;
            string libelle, libelleCategorie;
            float prixHT;
            Produit unProduit;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<Produit> lesUtilisateurs = new List<Produit>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM Produit INNER JOIN Categorie_produit ON Produit.code_categ = Categorie_produit.code_categ";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_pro"].ToString());
                libelle = monReader["lib_pro"].ToString();
                float.TryParse(monReader["prix_vente_ht_pro"].ToString(), out prixHT);
                libelleCategorie = monReader["lib_categ"].ToString();
                //unProduit = new Produit(id, libelle, prixHT, libelleCateg);
                unProduit = new Produit(code, libelle,prixHT, libelleCategorie);
                lesUtilisateurs.Add(unProduit);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesUtilisateurs;
        }

        // Cette méthode insert un nouveau Produit passé en paramètre dans la BD
        public static int AjoutProduit(Produit unProduit)
        {
            int id = 0;
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmdLibelle = new SqlCommand("SELECT code_categ FROM Categorie_produit WHERE lib_categ LIKE '" + unProduit.LibCat + "'", maConnexion);
            SqlDataReader monReader = cmdLibelle.ExecuteReader();
            while (monReader.Read())
            {
                // récupération du code produit
                id = Int32.Parse(monReader["code_categ"].ToString());
            }
            monReader.Close();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Produit(lib_pro, prix_vente_ht_pro, code_categ) VALUES(@libellePro, @prixHTPro, @codeCategPro)";
            cmd.Parameters.Add(new SqlParameter("libellePro", unProduit.Libelle));
            cmd.Parameters.Add(new SqlParameter("prixHTPro", unProduit.PrixHT));
            cmd.Parameters.Add(new SqlParameter("codeCategPro", unProduit.LibelleCategorie));
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int UpdateProduit(Produit unProduit)
        {
            int nbEnr = 0;
            //Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Produit SET lib_pro = '" + unProduit.Libelle + "', prix_vente_ht_pro = '" + unProduit.PrixHT + "', code_categ = '" + unProduit.LibelleCategorie + "' WHERE  code_pro = '" + unProduit.Code + "'";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static string DeleteProduit(int id)
        {
            int nbEnr;
            int result;
            string valid = "";
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand sql = new SqlCommand();           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ProduitDevis WHERE code_pro = " + id;
            result= cmd.ExecuteNonQuery();
            if(result > 0)
            {
                cmd.Connection = maConnexion;
                cmd.CommandText = "DELETE FROM Produit WHERE code_pro = " + id;
                nbEnr = cmd.ExecuteNonQuery();
                valid = "Le produit a bien été supprimé.";
            }
            else
            {
                valid = "Le produit ne peut pas être supprimé car correspond à un devis.";
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return valid;
        }
    }
}
