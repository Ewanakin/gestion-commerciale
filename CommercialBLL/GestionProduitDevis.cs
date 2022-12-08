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
        public static List<ProduitDevis> getProduitDevis()
        {
            return DevisDAO.getProduitDevis();
        }

        public static Produit getProduitPourDevis(List<Produit> lesProduits, ProduitDevis produitDevis)
        {
            int ind = 0;
            Produit unProduit = null;
            for (ind = 0; ind < lesProduits.Count; ind++)
            {
                if (produitDevis.CodeProduit == lesProduits[ind].Code) 
                {
                    unProduit =  lesProduits[ind];
                }
                
            }
            return unProduit;
        }

        public static List<Devis> sumProduitPrix(List<Devis> lesDevis, List<ProduitDevis> lesProduitDevis, List<Produit> lesProduits)
        {
            int i, y;
            Produit unProduit;
            for (i = 0; i < lesDevis.Count; i++)
            {
                float produitRemiseEtQtt = 0;
                for (y = 0; y < lesProduitDevis.Count; y++)
                {
                    if (lesDevis[i].Id == lesProduitDevis[y].CodeDevis)
                    {
                        unProduit = GestionProduitDevis.getProduitPourDevis(lesProduits, lesProduitDevis[y]);
                        if(unProduit != null)
                        {
                            produitRemiseEtQtt = unProduit.PrixHT * lesProduitDevis[y].Quantite * lesProduitDevis[y].Remise;
                        }
                    }
                }
                lesDevis[i].PrixTotal = produitRemiseEtQtt;
                lesDevis[i].getPrixAvecTva();
            }
            return lesDevis; 

        }

    }
}
