using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBO
{
    public class Client
    {
        private int code;
        private string nom;
        private int numeroTel;
        private int numeroFax;
        private string email;
        private int numAdresseLiv;
        private int numAdresseFac;
        private string rueAdresseLiv;
        private string rueAdresseFac;
        private int codePostalAdresseLiv;
        private int codePostalAdresseFac;
        private string villeAdresseLiv;
        private string villeAdresseFac;

        public Client(int code, string nom, int numeroTel, int numeroFax, string email, int numAdresseLiv, int numAdresseFac, string rueAdresseLiv, string rueAdresseFac, int codePostalAdresseLiv, int codePostalAdresseFac, string villeAdresseLiv, string villeAdresseFac)
        {
            this.code = code;
            this.nom = nom;
            this.numeroTel = numeroTel;
            this.numeroFax = numeroFax;
            this.email = email;
            this.numAdresseLiv = numAdresseLiv;
            this.numAdresseFac = numAdresseFac;
            this.rueAdresseLiv = rueAdresseLiv;
            this.rueAdresseFac = rueAdresseFac;
            this.codePostalAdresseLiv = codePostalAdresseLiv;
            this.codePostalAdresseFac = codePostalAdresseFac;
            this.villeAdresseLiv = villeAdresseLiv;
            this.villeAdresseFac = villeAdresseFac;
        }

        public Client(int code)
        {
            this.code = code;        
        }

        public int Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public int NumeroTel { get => numeroTel; set => numeroTel = value; }
        public int NumeroFax { get => numeroFax; set => numeroFax = value; }
        public string Email { get => email; set => email = value; }
        public int NumAdresseLiv { get => numAdresseLiv; set => numAdresseLiv = value; }
        public int NumAdresseFac { get => numAdresseFac; set => numAdresseFac = value; }
        public string RueAdresseLiv { get => rueAdresseLiv; set => rueAdresseLiv = value; }
        public string RueAdresseFac { get => rueAdresseFac; set => rueAdresseFac = value; }
        public int CodePostalAdresseLiv { get => codePostalAdresseLiv; set => codePostalAdresseLiv = value; }
        public int CodePostalAdresseFac { get => codePostalAdresseFac; set => codePostalAdresseFac = value; }
        public string VilleAdresseLiv { get => villeAdresseLiv; set => villeAdresseLiv = value; }
        public string VilleAdresseFac { get => villeAdresseFac; set => villeAdresseFac = value; }
    }
}
