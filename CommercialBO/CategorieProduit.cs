using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBO
{
    public class CategorieProduit
    {
        private int code;
        private string libelle;

        public CategorieProduit(int code, string libelle)
        {
            this.code = code;
            this.libelle = libelle;
        }

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
    }
}
