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
            int id, libelleCateg;
            string libelle, libelleCategorie;
            float prixHT;
            Produit unProduit;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<Produit> lesUtilisateurs = new List<Produit>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT lib_categ FROM Produit INNER JOIN Categorie_produit ON Produit.code_categ = Categorie_produit.code_categ";
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                libelleCategorie = monReader["lib_categ"].ToString();
                //unProduit = new Produit(id, libelle, prixHT, libelleCateg);
                unProduit = new Produit(0, "test", 0.25f, libelleCategorie);
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
            cmd.Parameters.Add(new SqlParameter("libellePro", unProduit.getLibelle()));
            cmd.Parameters.Add(new SqlParameter("prixHTPro", unProduit.getPrixHT()));
            cmd.Parameters.Add(new SqlParameter("codeCategPro", id));
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
            cmd.CommandText = "UPDATE Produit SET Nom_utilisateur = '" + unProduit.getLibelle() + "' WHERE Id_utilisateur = " + unProduit.getCode();
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static int DeleteProduit(int id)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM T_Identification WHERE Id_utilisateur = " + id;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
