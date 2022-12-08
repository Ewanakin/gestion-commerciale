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

        public static int ajoutDevis(Devis unDevis)
        {
            return DevisDAO.AjoutDevis(unDevis);
        }

        public static void ajoutProduitDansDevis(ProduitDevis unProduitDevis)
        {
            ProduitDevisDAO.addUnProduitDevis(unProduitDevis);
        }
    }
}
