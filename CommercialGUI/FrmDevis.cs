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
    public partial class FrmDevis : Form
    {
        public FrmDevis()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionProduits.SetchaineConnexion(ConfigurationManager.ConnectionStrings["gestion-commerciale"]);
            // Blocage de la génération automatique des colonnes
            dtgDevis.AutoGenerateColumns = false;
            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn CodeColumn = new DataGridViewTextBoxColumn();
            CodeColumn.Name = "code";
            CodeColumn.DataPropertyName = "Code";
            CodeColumn.HeaderText = "Code";
            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn nomCliColumn = new DataGridViewTextBoxColumn();
            nomCliColumn.Name = "Nom client";
            nomCliColumn.DataPropertyName = "Nom client";
            nomCliColumn.HeaderText = "Nom client";
            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "Date";
            dateColumn.DataPropertyName = "Date";
            dateColumn.HeaderText = "Date";
            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn prixColumn = new DataGridViewTextBoxColumn();
            prixColumn.Name = "Prix";
            prixColumn.DataPropertyName = "Prix";
            prixColumn.HeaderText = "Prix";
            // Ajout des 4 en-têtes de colonne au datagridview
            dtgDevis.Columns.Add(CodeColumn);
            dtgDevis.Columns.Add(nomCliColumn);
            dtgDevis.Columns.Add(dateColumn);
            dtgDevis.Columns.Add(prixColumn);
            // Définition du style apporté au datagridview
            dtgDevis.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dtgDevis.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Produit> liste = new List<Produit>();
            liste = GestionProduits.GetProduits();
            // Rattachement de la List à la source de données du datagridview
            dtgDevis.DataSource = liste;



            // injection valeur combobox Client
            List<Client> listeClient = new List<Client>();
            listeClient = GestionClients.GetClients();

            cmbClient.DataSource = listeClient;
            cmbClient.DisplayMember = "nom";
            cmbClient.ValueMember = "code";

            // injection valeur combobox Produit
            List<Produit> listeProduit = new List<Produit>();
            listeProduit = GestionProduits.GetProduits();

            cmbAddProduit.DataSource = listeProduit;
            cmbAddProduit.DisplayMember = "libelle";
            cmbAddProduit.ValueMember = "code";

            // injection valeur combobox Statut
            List<StatusDevis> listeStatut = new List<StatusDevis>();
            listeStatut = GestionDevis.GetStatusDevis();

            cmbStatutDevis.DataSource = listeStatut;
            cmbStatutDevis.DisplayMember = "libelle";
            cmbStatutDevis.ValueMember = "id";
        }

        private void dtgDevis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAddProduit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpDevis_Enter(object sender, EventArgs e)
        {

        }

        private void dtpDateDevis_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
