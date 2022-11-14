using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialBO;


namespace CommercialDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO unUtilisateurDAO;
        public static UtilisateurDAO GetunUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new UtilisateurDAO();
            }
            return unUtilisateurDAO;
        }
        public static int CheckUtilisateur(Utilisateur unUtilisateur)
        {
            int nbEnr;
            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Utilisateur WHERE Username = @Name and Password = @Password";
            cmd.Parameters.Add(new SqlParameter("Name", unUtilisateur.Username1));
            cmd.Parameters.Add(new SqlParameter("Password", unUtilisateur.Password1));
            nbEnr = cmd.ExecuteNonQuery();
            // Fermeture de la connexion
            maConnexion.Close();
            return nbEnr;
        }
    }
}
