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

<<<<<<< HEAD
        public static List<Devis> getDevis()
        {
            return DevisDAO.GetDevis();
=======
        public static int ajoutDevis(Devis unDevis)
        {
            return DevisDAO.AjoutDevis(unDevis);
        }

        public static void ajoutProduitDansDevis(ProduitDevis unProduitDevis)
        {
            ProduitDevisDAO.addUnProduitDevis(unProduitDevis);
        }
        // Méthode qui supprime un devis en BD
        public static string SupprimerDevis(int id)
        {
            return DevisDAO.DeleteDevis(id);
>>>>>>> 5df54539d4304d83a9ee51d49930249b214c5757
        }
    }
}
