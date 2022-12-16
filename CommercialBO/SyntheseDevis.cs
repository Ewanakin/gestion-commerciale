using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBO
{
    public class SyntheseDevis
    {
        int codeCli;
        int nbDevis;
        int nbDevisAcceptes;
        float pourcentageDevisAcceptes;
        float pourcentageDevisEnAttente;
        float montantTotal;
        string nomCli;

        public SyntheseDevis(int codeCli, string nomCli, int nbDevis, int nbDevisAcceptes, float pourcentageDevisAcceptes, float pourcentageDevisEnAttente, float montantTotal)
        {
            this.CodeCli = codeCli;
            this.NomCli = nomCli;
            this.NbDevis = nbDevis;
            this.NbDevisAcceptes = nbDevisAcceptes;
            this.PourcentageDevisAcceptes = pourcentageDevisAcceptes;
            this.PourcentageDevisEnAttente = pourcentageDevisEnAttente;
            this.MontantTotal = montantTotal;
        }

        public int CodeCli { get => codeCli; set => codeCli = value; }
        public string NomCli { get => nomCli; set => nomCli = value; }
        public int NbDevis { get => nbDevis; set => nbDevis = value; }
        public int NbDevisAcceptes { get => nbDevisAcceptes; set => nbDevisAcceptes = value; }
        public float PourcentageDevisAcceptes { get => pourcentageDevisAcceptes; set => pourcentageDevisAcceptes = value; }
        public float PourcentageDevisEnAttente { get => pourcentageDevisEnAttente; set => pourcentageDevisEnAttente = value; }
        public float MontantTotal { get => montantTotal; set => montantTotal = value; }
    }
}
