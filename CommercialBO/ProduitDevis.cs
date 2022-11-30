using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBO
{
    internal class ProduitDevis
    {
        private Devis devis;
        private Produit produit;

        public ProduitDevis(Devis devis, Produit produit)
        {
            this.devis = devis;
            this.produit = produit;
        }

        public Devis Devis
        {
            get { return devis; }
            set { devis = value; }
        }

        public Produit Produit
        {
            get { return produit; }
            set { produit = value; }
        }
    }
}
