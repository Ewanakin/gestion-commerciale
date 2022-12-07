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

            // Blocage de la génération automatique des colonnes && création en-tete dtgModify Produit
            dtgDevisModify.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn idProduitColumn = new DataGridViewTextBoxColumn();
            idProduitColumn.Name = "idProduit";
            idProduitColumn.DataPropertyName = "idProduit";
            idProduitColumn.HeaderText = "idProduit";
            idProduitColumn.Visible = false;

            DataGridViewTextBoxColumn nomProduitColumn = new DataGridViewTextBoxColumn();
            nomProduitColumn.Name = "nomProduit";
            nomProduitColumn.DataPropertyName = "nomProduit";
            nomProduitColumn.HeaderText = "nomProduit";

            DataGridViewTextBoxColumn quantitéProduitColumn = new DataGridViewTextBoxColumn();
            quantitéProduitColumn.Name = "quantitéProduit";
            quantitéProduitColumn.DataPropertyName = "quantitéProduit";
            quantitéProduitColumn.HeaderText = "quantitéProduit";

            DataGridViewTextBoxColumn prixProduitColumn = new DataGridViewTextBoxColumn();
            prixProduitColumn.Name = "prixUnitaireProduit";
            prixProduitColumn.DataPropertyName = "prixUnitaireProduit";
            prixProduitColumn.HeaderText = "prixUnitaireProduit";

            DataGridViewTextBoxColumn remiseProduitColumn = new DataGridViewTextBoxColumn();
            remiseProduitColumn.Name = "remiseProduit";
            remiseProduitColumn.DataPropertyName = "remiseProduit";
            remiseProduitColumn.HeaderText = "remiseProduit";

            DataGridViewButtonColumn supprimerProduit = new DataGridViewButtonColumn();
            supprimerProduit.Name = "supprimerProduit";
            supprimerProduit.DataPropertyName = "supprimerProduit";
            supprimerProduit.HeaderText = "supprimerProduit";

            dtgDevisModify.Columns.Add(idProduitColumn);
            idProduitColumn.DisplayIndex = 0;
            dtgDevisModify.Columns.Add(nomProduitColumn);
            nomProduitColumn.DisplayIndex = 1;
            dtgDevisModify.Columns.Add(quantitéProduitColumn);
            quantitéProduitColumn.DisplayIndex = 2;
            dtgDevisModify.Columns.Add(prixProduitColumn);
            prixProduitColumn.DisplayIndex = 3;
            dtgDevisModify.Columns.Add(remiseProduitColumn);
            remiseProduitColumn.DisplayIndex = 4;
            dtgDevisModify.Columns.Add(supprimerProduit);
            supprimerProduit.DisplayIndex = 5;


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
            // Récupérer l'index de la ligne sur laquelle l'utilisateur a cliqué
            int rowIndex = e.RowIndex;
            int cellIndex = e.ColumnIndex;

            DataGridViewRow row = dtgDevisModify.Rows[rowIndex];

            if (cellIndex == 5)
            {
                // vérifier si la colonne cliquée est la colonne numéro 5
                if (row.IsNewRow)
                {
                    
                    lblErrorAdd.Text = "Le produit n'existe pas";
                    return;
                }


                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Confirmation", MessageBoxButtons.YesNo);

                // Vérifier la valeur retournée par la fenêtre de confirmation
                if (result == DialogResult.Yes)
                {
                    // L'utilisateur a choisi Oui, supprimer le produit
                    // Supprimer la ligne sélectionnée en utilisant l'index récupéré
                    dtgDevisModify.Rows.RemoveAt(rowIndex);
                    lblErrorAdd.Text = "Suppression confirmé";
                }
                else
                {
                    // L'utilisateur a choisi Non, annuler la suppression du produit
                    lblErrorAdd.Text = "Suppression annulé";
                }
            }
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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtMontantHTHR_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnNewDevis_Click(object sender, EventArgs e)
        {
            //btn modify / supp plus visible au click
            btnModifyDevis.Visible = false;
            btnSupDevis.Visible = false;
            //btn cancel / add devis visible au click
            btnAddDevis.Visible = true;
            btnCancelDevis.Visible = true;
            //champs code plus visible au click
            txtCode.Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtQuantité.Text.Length == 0 || txtTauxRemise.Text.Length == 0)
            {
                lblErrorAdd.Text = "Merci de renseigné tout les champs";
                return;
            }
            string id = cmbAddProduit.SelectedValue.ToString();
            int idI;
            int.TryParse(id, out idI);
            Produit unProduit = GestionProduits.getUnProduit(idI);

            int quantitéPro;
            int.TryParse(txtQuantité.Text, out quantitéPro);

            int tauxRemise;
            int.TryParse(txtTauxRemise.Text, out tauxRemise);

            if (quantitéPro < 1)
                quantitéPro = 1;
                
            dtgDevisModify.Rows.Add(unProduit.Code, unProduit.Libelle, quantitéPro, unProduit.PrixHT, tauxRemise);
            dtgDevisModify.Refresh();
        }

        private void dtgDevisModify_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            

        }
    }
}
