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


        public static List<Devis> getDevis()
        {
            return DevisDAO.GetDevis();
        }

        public static int AjoutDevis(Devis unDevis)
        {
            return DevisDAO.AjoutDevis(unDevis);
        }

        public static void AjoutProduitDansDevis(ProduitDevis unProduitDevis)
        {
            ProduitDevisDAO.addUnProduitDevis(unProduitDevis);
        }
        // Méthode qui supprime un devis en BD
        public static string SupprimerDevis(int id)
        {
            return DevisDAO.DeleteDevis(id);

        }

        public static void UpdateDevis(Devis unDevis)
        {
            DevisDAO.UpdateDevis(unDevis);
        }

        public static Devis GetUnDevis(List<Devis> lesDevis, int code)
        {
            int i = 0;
            Devis devis = null;
            for (i = 0; i< lesDevis.Count; i++)
            {
                if (lesDevis[i].Id == code)
                {
                    devis = lesDevis[i];
                }
            }
            return devis;
        }
    }
}
