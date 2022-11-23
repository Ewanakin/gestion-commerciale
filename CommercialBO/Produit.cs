using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBO
{
    public class Produit
    {
        private int code;
        private string libelle, libCat;
        private float prixHT;
        private int libelleCategorie;
        CategorieProduit categPro;
        public Produit(int code, string libelle, float prixHT, CategorieProduit categPro)
        {
            this.code = code;
            this.libelle = libelle;
            this.prixHT = prixHT;
            this.categPro = categPro;
        }
        // set get code
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        // set get libelle
        public string Libelle
        {
            get { return libelle; }
            set { libelle = value; }
        }
        // set get prixHT
        public float PrixHT
        {
            get { return prixHT; }
            set { prixHT = value; }
        }

        // set get prixHT
        public int LibelleCategorie
        {
            get { return libelleCategorie; }
            set { libelleCategorie = value; }
        }

        // set get prixHT
        public string LibCat
        {
            get { return libCat; }
            set { libCat = value; }
        }
        public CategorieProduit CategPro
        {
            get { return categPro; }
            set { categPro = value; }
        }
    }
}
