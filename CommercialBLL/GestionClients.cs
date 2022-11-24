using CommercialBO;
using CommercialDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBLL
{
    public class GestionClients
    {
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        public static List<Client> GetClients()
        {
            return ClientDAO.GetClients();
        }
        // Méthode qui supprime un Client avec la méthode DeleteClient de la DAL
        public static string SupprimerClient(int id)
        {
            return ClientDAO.DeleteClient(id);
        }

        public static string AjouterClient(Client unCli)
        {
            return ClientDAO.addClient(unCli);
        }
    }
}
