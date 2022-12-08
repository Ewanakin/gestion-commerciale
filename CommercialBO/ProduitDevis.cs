using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBO
{
    public class ProduitDevis
    {
        private int codeDevis;
        private int codeProduit;
        private int quantite;
        private float remise;

        public ProduitDevis(int devis, int produit, int quantite, float remise)
        {
            this.codeDevis = devis;
            this.codeProduit = produit;
            this.quantite = quantite;
            this.Remise = remise;
        }

        public int CodeDevis
        {
            get { return codeDevis; }
        }

        public int CodeProduit 
        {
            get { return codeProduit; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        public float Remise { get => remise; set => remise = value; }

        public float sumProduitPrix(Devis unDevis)
        {
            int num = 0;
            return num;
        }

        public List<Produit> getProduitPourDevis()
        {
            return new List<Produit>();
        }
    }
}
