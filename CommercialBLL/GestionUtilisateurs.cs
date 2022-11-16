using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using CommercialBO;
using CommercialDAL;

namespace CommercialBLL
{
    public class GestionUtilisateurs
    {
        private static GestionUtilisateurs uneGestionUtilisateurs; // objet BLL

        // Accesseur en lecture
        public static GestionUtilisateurs GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new GestionUtilisateurs();
            }
            return uneGestionUtilisateurs;
        }
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetChaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        public static bool CheckUtilisateur(Utilisateur ut)
        {
            return UtilisateurDAO.CheckUtilisateur(ut);
        }

    }
}
