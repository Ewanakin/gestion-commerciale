using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommercialBO;
using CommercialDAL;

namespace CommercialBLL
{
    public class GestionDevis
    {
        public static List<StatusDevis> GetStatusDevis()
        {
            return DevisDAO.getStatusDevis();
        }

        // Méthode qui supprime un devis en BD
        public static string SupprimerDevis(int id)
        {
            return DevisDAO.DeleteDevis(id);
        }
    }
}
