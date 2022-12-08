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
        
        public static List<ProduitDevis> getLesProduitsDevisEnRelation(List<Produit> lesProduits, List<ProduitDevis> produitsDevis, Devis unDevis)
        {
            List<ProduitDevis> list = new List<ProduitDevis>();
            for (int i = 0; i < lesProduits.Count; i++)
            {
                for (int j = 0; j < produitsDevis.Count; j++)
                {
                    if(unDevis.Id == produitsDevis[j].CodeDevis)
                    {
                        if (produitsDevis[j].CodeProduit == lesProduits[i].Code)
                        {
                            list.Add(produitsDevis[j]);
                        }
                    }
                }
            }
            return list;
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

        public static List<Produit> getProduitsPourUnDevis(List<Produit> lesProduits, List<ProduitDevis> produitDevis, Devis devis)
        {
            int i = 0;
            int y = 0;
            List<Produit> list = new List<Produit>();
            for (i = 0; i<produitDevis.Count; i++)
            {
                if(devis.Id == produitDevis[i].CodeDevis)
                {
                    for(y = 0; y < lesProduits.Count; y++)
                    {
                        if (lesProduits[y].Code == produitDevis[i].CodeProduit)
                        {
                            list.Add(lesProduits[y]);
                        }
                    }
                }
            }
            return list;
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
                            produitRemiseEtQtt = unProduit.PrixHT * lesProduitDevis[y].Quantite * (1 - lesProduitDevis[y].Remise);
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
