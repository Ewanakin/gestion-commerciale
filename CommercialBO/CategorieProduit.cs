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
        private string libCateg;

        public CategorieProduit(int code, string libelle)
        {
            this.code = code;
            this.libCateg = libelle;
        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        // set get libelle
        public string LibCateg
        {
            get { return libCateg; }
            set { libCateg = value; }
        }
    }
}
