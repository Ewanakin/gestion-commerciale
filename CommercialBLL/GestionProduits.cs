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
    public class GestionProduits
    {
        private static GestionProduits uneGestionProduits; // objet BLL
                                                           // Accesseur en lecture
        public static GestionProduits GetGestionProduits()
        {
            if (uneGestionProduits == null)
            {
                uneGestionProduits = new GestionProduits();
            }
            return uneGestionProduits;
        }
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        // Méthode qui renvoit une List d'objets Utilisateur en faisant appel à la méthode GetUtilisateurs() de la DAL
        public static List<Produit> GetProduits()
        {
            return ProduitDAO.GetProduits();
        }
        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerUtilisateur(Produit pd)
        {
            return ProduitDAO.AjoutProduit(pd);
        }
        // Méthode qui modifie un nouvel Utilisateur avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierUtilisateur(Produit pd)
        {
            return ProduitDAO.UpdateProduit(pd);
        }
        // Méthode qui supprime un Utilisateur avec la méthode DeleteUtilisateur de la DAL
        public static int SupprimerProduit(int id)
        {
            return ProduitDAO.DeleteProduit(id);
        }
    }
}
