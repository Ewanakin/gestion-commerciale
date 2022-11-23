using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CommercialBO;
using CommercialDAL;

namespace CommercialBLL
{
    public class GestionCategorieProduits
    {
        private static GestionCategorieProduits uneGestionCategorieProduit; // objet BLL
                                                           // Accesseur en lecture
        public static GestionCategorieProduits GetGestionCategorieProduits()
        {
            if (uneGestionCategorieProduit == null)
            {
                uneGestionCategorieProduit = new GestionCategorieProduits();
            }
            return uneGestionCategorieProduit;
        }
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static CategorieProduit GetUneCategPro(string libelleCateg)
        {
            return CategorieProduitDAO.GetUneCategorieProduit(libelleCateg);
        }

        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<CategorieProduit> GetCategorieProduits()
        {
            return CategorieProduitDAO.GetCategorieProduits();
        }
        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerCategorieProduit(Produit pd)
        {
            return CategorieProduitDAO.AjoutCategorieProduit(pd);
        }
        // Méthode qui modifie un nouvel Utilisateur avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierUtilisateur(Produit pd)
        {
            return CategorieProduitDAO.UpdateCategorieProduit(pd);
        }
        // Méthode qui supprime un Utilisateur avec la méthode DeleteUtilisateur de la DAL
        public static int SupprimerProduit(int id)
        {
            return CategorieProduitDAO.DeleteCategorieProduit(id);
        }
    }
}
