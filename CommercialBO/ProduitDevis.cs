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

<<<<<<< HEAD
        public ProduitDevis(int devis, int produit, float remise, int quantite)
        {
            this.codeDevis = devis;
            this.codeProduit = produit;
            this.remise = remise;
            this.quantite = quantite;
=======
        public ProduitDevis(int devis, int produit, int quantite, float remise)
        {
            this.codeDevis = devis;
            this.codeProduit = produit;
            this.quantite = quantite;
            this.Remise = remise;
>>>>>>> 5df54539d4304d83a9ee51d49930249b214c5757
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

<<<<<<< HEAD
        public float Remise
=======
        public float Remise { get => remise; set => remise = value; }

        public float sumProduitPrix(Devis unDevis)
>>>>>>> 5df54539d4304d83a9ee51d49930249b214c5757
        {
            get { return remise; }
            set { remise = value; }
        }


        
    }
}
