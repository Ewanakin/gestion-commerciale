using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBO
{
    public class Devis
    {
        private int id;
        private float tx_tva;
        private DateTime date;
        private Client client;
        private StatusDevis status;
        private float prixTotal;

        public Devis(int id, float tx_tva, DateTime date, Client client, StatusDevis status)
        {
            this.id = id;
            this.tx_tva = tx_tva;
            this.date = date;
            this.client = client;
            this.status = status;
            this.prixTotal = 0;
        }

        public int Id
        {
            get { return id; }
        }

        public float Tx_tva
        {
            get { return tx_tva; }
            set { tx_tva = value; }
        }
        public string StatusDevisLib
        {
            get { return status.Libelle; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Client Client
        {
            get { return client; }
            set
            {
                client = value;
            }
        }

        public string ClientNom
        {
            get { return client.Nom; }
        }

        public StatusDevis Status
        {
            get { return status; }
            set
            {
                status = value;
            }
        }

        public float PrixTotal
        {
            get { return this.prixTotal; }
            set { this.prixTotal = value; }
        }

        public void SumPrix(float prixHT)
        {
            float prix = this.PrixTotal + prixHT;
            this.PrixTotal = prix;
        }

        public float getPrixAvecTva()
        {
            return this.prixTotal = this.prixTotal * this.tx_tva;
        }


    }
}
