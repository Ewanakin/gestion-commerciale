using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialBO
{
    internal class Devis
    {
        private int id;
        private float tx_tva;
        private DateTime date;
        private Client client;
        private StatusDevis status;

        public Devis(int id, float tx_tva, DateTime date, Client client, StatusDevis status)
        {
            this.id = id;
            this.tx_tva = tx_tva;
            this.date = date;
            this.client = client;
            this.status = status;
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

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private Client Client
        {
            get { return client; }
            set
            {
                client = value;
            }
        }

        public StatusDevis Status
        {
            get { return status; }
            set
            {
                status = value;
            }
        }


    }
}
