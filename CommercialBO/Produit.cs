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
        private string libelle, libcat;
        private float prixHT;
        private int libelleCategorie;

        public Produit(int code, string libelle, float prixHT, int libelleCategorie)
        {
            this.code = code;
            this.libelle = libelle;
            this.prixHT = prixHT;
            this.libelleCategorie = libelleCategorie;
        }
        public Produit(int code, string libelle, float prixHT, string libcat)
        {
            this.code = code;
            this.libelle = libelle;
            this.prixHT = prixHT;
            this.libcat = libcat;
        }
        public int getCode() { return code; }
        public string getLibelle()
        {
            return this.libelle;
        }
        public float getPrixHT()
        {
            return this.prixHT;
        }
        public int getLibelleCategegorie()
        {
            return this.libelleCategorie;
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
        public string Libcat
        {
            get { return libcat; }
            set { libcat = value; }
        }
    }
}
