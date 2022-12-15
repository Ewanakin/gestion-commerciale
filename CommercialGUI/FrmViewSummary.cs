using CommercialBLL;
using CommercialBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialGUI
{
    public partial class FrmViewSummary : Form
    {
        public FrmViewSummary()
        {
            InitializeComponent();
            // Blocage de la génération automatique des colonnes
            dgvSummary.AutoGenerateColumns = false;

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionProduits.SetchaineConnexion(ConfigurationManager.ConnectionStrings["gestion-commerciale"]);
            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn nomCliColumn = new DataGridViewTextBoxColumn();
            nomCliColumn.Name = "Nom Client";
            nomCliColumn.DataPropertyName = "ClientNom";
            nomCliColumn.HeaderText = "Nom Client";
            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn nbDevisColumn = new DataGridViewTextBoxColumn();
            nbDevisColumn.Name = "nombreDevis";
            nbDevisColumn.DataPropertyName = "nombreDevis";
            nbDevisColumn.HeaderText = "Nombre Devis";
            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn nbDevisAcceptésColumn = new DataGridViewTextBoxColumn();
            nbDevisAcceptésColumn.Name = "Nombre Devis Accepté";
            nbDevisAcceptésColumn.DataPropertyName = "nbDevisAccepté";
            nbDevisAcceptésColumn.HeaderText = "Nombre Devis Accepté";
            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn pourcentageAcceptéColumn = new DataGridViewTextBoxColumn();
            pourcentageAcceptéColumn.Name = "Pourcentage Devis Accepté";
            pourcentageAcceptéColumn.DataPropertyName = "pourcentageAccepté";
            pourcentageAcceptéColumn.HeaderText = "Pourcentage Devis Accepté";
            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn pourcentageAttenteColumn = new DataGridViewTextBoxColumn();
            pourcentageAttenteColumn.Name = "Pourcentage Devis Attente";
            pourcentageAttenteColumn.DataPropertyName = "pourcentaDevisAttente";
            pourcentageAttenteColumn.HeaderText = "Pourcentage Devis Attente";
            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn montantTotalHTColumn = new DataGridViewTextBoxColumn();
            montantTotalHTColumn.Name = "montant Total facturé HT";
            montantTotalHTColumn.DataPropertyName = "montantTotalHT";
            montantTotalHTColumn.HeaderText = "montant Total facturé HT";
            // Ajout des 6 en-têtes de colonne au datagridview
            dgvSummary.Columns.Add(nomCliColumn);
            dgvSummary.Columns.Add(nbDevisColumn);
            dgvSummary.Columns.Add(nbDevisAcceptésColumn);
            dgvSummary.Columns.Add(pourcentageAcceptéColumn);
            dgvSummary.Columns.Add(pourcentageAttenteColumn);
            dgvSummary.Columns.Add(montantTotalHTColumn);

            //Declation de la liste & injection des valeurs
            List<int> lesClientsId = GestionClients.GetClientsId();
            List<SyntheseDevis> lesSyntheseDevis = new List<SyntheseDevis>();

            foreach (int unCli in lesClientsId)
            {
                lesSyntheseDevis.Add(GestionSyntheseDevis.GetSyntheseDevis(unCli));
            }
            //dgvSummary.DataSource = 

        }

        private void dgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
