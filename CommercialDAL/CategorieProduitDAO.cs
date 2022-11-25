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
    public class CategorieProduitDAO
    {
        private static CategorieProduitDAO uneCategorieProduitDAO;
        // Accesseur en lecture, renvoi une instance
        public static CategorieProduitDAO GetuneCategorieProduitDAO()
        {
            if (uneCategorieProduitDAO == null)
            {
                uneCategorieProduitDAO = new CategorieProduitDAO();
            }
            return uneCategorieProduitDAO;
        }
        // Cette méthode retourne une List contenant les objets Utilisateurs
        // contenus dans la table Identification
        public static CategorieProduit GetUneCategorieProduit(string libelleCateg)
        {
            int code;
            string libelle;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<CategorieProduit> lesCategoriesProduits = new List<CategorieProduit>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categorie_produit WHERE lib_categ LIKE @libCat", maConnexion);
            cmd.Parameters.Add(new SqlParameter("libCat", "Ecran"));
            SqlDataReader monReader = cmd.ExecuteReader();
            while(monReader.Read())
            {
                code = Int32.Parse(monReader["code_categ"].ToString());
                libelle = monReader["lib_categ"].ToString();
            }
            CategorieProduit newCategPro = new CategorieProduit(code, libelle);
            return newCategPro;
        }
        public static List<CategorieProduit> GetCategorieProduits()
        {
            int id;
            string libelle;
            CategorieProduit uneCategorieProduit;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets Produits
            List<CategorieProduit> lesCategoriesProduits = new List<CategorieProduit>();
            SqlCommand cmd = new SqlCommand(" SELECT * FROM Categorie_produit", maConnexion);
            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                // récupération du code produit
                id = Int32.Parse(monReader["code_categ"].ToString());
                // récupération du prixHT du produit
                if (monReader["lib_categ"] == DBNull.Value)
                {
                    libelle = default(string);
                }
                else
                {
                    libelle = monReader["lib_categ"].ToString();
                }
                uneCategorieProduit = new CategorieProduit(id, libelle);
                lesCategoriesProduits.Add(uneCategorieProduit);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesCategoriesProduits;
        }

        // Cette méthode insert un nouveau Produit passé en paramètre dans la BD
        public static int AjoutCategorieProduit(Produit unProduit)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Produit values('" + unProduit.Libelle + "'," +
                "                                           '" + unProduit.PrixHT + "'," +
                "                                           '" + unProduit.LibelleCategorie + "')";
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode modifie un utilisateur passé en paramètre dans la BD
        public static int UpdateCategorieProduit(Produit unProduit)
        {
            int nbEnr = 0;
            //Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE Produit SET Nom_utilisateur = '" + unProduit.Libelle + "' WHERE Id_utilisateur = " + unProduit.Code;
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }

        // Cette méthode supprime de la BD un utilisateur dont l'id est passé en paramètre
        public static int DeleteCategorieProduit(int id)
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