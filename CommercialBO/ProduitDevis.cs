using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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


        public ProduitDevis(int devis, int produit, float remise, int quantite)
        {
            this.codeDevis = devis;
            this.codeProduit = produit;
            this.remise = remise;
            this.quantite = quantite;
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
        
    }
}
