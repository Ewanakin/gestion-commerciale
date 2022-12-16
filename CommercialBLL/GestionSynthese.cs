using CommercialBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBLL
{
    internal class GestionSynthese
    {
        public List<Client> ClientDevis(List<Client> lesClients, List<Devis> lesDevis)
        {
            for (int i = 0; i < lesClients.Count; i++)
            {
                for(int j = 0; j < lesDevis.Count; j++)
                {
                    if (lesClients[i].Code == lesDevis[i].Client.Code)
                    {
                        lesClients[i].addDevis(lesDevis[i]);
                    }
                }
            }
            return lesClients;
        }

        public List<Client> DevisParDate(List<Client> lesClients,  DateTime dateMin, DateTime dateMax)
        {
            List<Client> result = new List<Client>();
            for (int i = 0; i < lesClients.Count; i++)
            {
                List<Devis> lesDevisDuCli = lesClients[i].LesDevis;
                lesClients[i].LesDevis = new List<Devis>();

                foreach(Devis devis in lesDevisDuCli)
                {
                    int compareMin = DateTime.Compare(devis.Date, dateMin);
                    if (compareMin == 0 || compareMin > 0)
                    {
                        lesClients[i].addDevis(devis);
                    }
                    int compareMax = DateTime.Compare(devis.Date, dateMax);
                    if(compareMax == 0 || compareMax > 0)
                    {
                        lesClients[i].addDevis(devis);
                    }
                }
                result.Add(lesClients[i]);
            }
            return result;
        }
    }
}
