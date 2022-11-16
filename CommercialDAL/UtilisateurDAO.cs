using CommercialBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;


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
        public static bool CheckUtilisateur(Utilisateur unUtilisateur)
        {
            bool isValid = false;

            // Connexion à la BD
            SqlConnection maConnexion =
            ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Utilisateurs WHERE mail_uti = @Mail and mdp_uti = @Password";
            cmd.Parameters.Add(new SqlParameter("Mail", unUtilisateur.Mail));
            cmd.Parameters.Add(new SqlParameter("Password", unUtilisateur.Password));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int test = (Int32.Parse(reader["code_uti"].ToString()));
                if (test >= 0)
                {
                    isValid = true;
                }
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return isValid;
        }
    }
}
