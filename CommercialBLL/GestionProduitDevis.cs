using CommercialBO;
using CommercialDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBLL
{
    public class GestionProduitDevis
    {
        public static List<ProduitDevis> getProduitDevis(){
            return DevisDAO.getProduitDevis();

    }
}
