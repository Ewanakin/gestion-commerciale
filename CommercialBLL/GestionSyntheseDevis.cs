using CommercialBO;
using CommercialDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBLL
{
    public class GestionSyntheseDevis
    {
        public static SyntheseDevis GetSyntheseDevis(int codeCli)
        {
            return SyntheseDevisDAO.GetSyntheseDevis(0);
        }
    }
}
