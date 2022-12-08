using CommercialBLL;
using CommercialBO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CommercialGUI
{
    public partial class FrmDevis : Form
    {
        public FrmDevis()
        {
            InitializeComponent();
            dtgDevis.AutoGenerateColumns = false;

            List<Devis> listeDevis = new List<Devis>();
            listeDevis = GestionDevis.getDevis();
            List<ProduitDevis> produitDevis = new List<ProduitDevis>();
            produitDevis = GestionProduitDevis.getProduitDevis();
            List<Produit> produits = new List<Produit>();
            produits = GestionProduits.GetProduits();
            listeDevis = GestionProduitDevis.sumProduitPrix(listeDevis, produitDevis, produits);
            // Rattachement de la List à la source de données du datagridview
            dtgDevis.DataSource = listeDevis;
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

            // modif format dtpDateDevis
            dtpDateDevis.Format = DateTimePickerFormat.Custom;
            dtpDateDevis.CustomFormat = "MM-dd-yyyy";
        }
        private void dtgDevis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Récupérer l'index de la ligne sur laquelle l'utilisateur a cliqué
            int rowIndex = e.RowIndex;
            int cellIndex = e.ColumnIndex;
            // Fix Erreur du click colonne 
            if (rowIndex == -1)
                return;

            DataGridViewRow row = dtgDevisModify.Rows[rowIndex];

            if (row.IsNewRow)
            {
                lblErrorAdd.Text = "Veuillez ajouter un produit";
                return;
            }

            if (cellIndex == 5)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Confirmation", MessageBoxButtons.YesNo);

                // Vérifier la valeur retournée par la fenêtre de confirmation
                if (result == DialogResult.Yes)
                {
                    // L'utilisateur a choisi Oui, supprimer le produit
                    // Supprimer la ligne sélectionnée en utilisant l'index récupéré
                    lblErrorAdd.Text = "Suppression confirmé";
                    dtgDevisModify.Rows.RemoveAt(rowIndex);
                    refreshPrixDevis();
                }
                else
                {
                    // L'utilisateur a choisi Non, annuler la suppression du produit
                    lblErrorAdd.Text = "Suppression annulé";
                }

            }
        }
        // refresh prix devis sur l'event modif case
        private void dtgProduitDevis_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            refreshPrixDevis();
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

        //fonction qui gére l'ensemble des calculs de prix d'un devis
        private void refreshPrixDevis()
        {
            if (txtTauxTva.Text.Length == 0)
            {
                lblErrorAdd.Text = "Champ TVA non renseigné";
                return;
            } else
            {
                lblErrorAdd.Text = lblErrorAdd.Text;
            }

            DataGridView grid = dtgDevisModify;
            //gestion d'affichage des prix
            int columnPrixIndex = 3;
            int columnTauxRemiseIndex = 4;
            int columnQuantitéPro = 2;

            // Initialisation de la somme à 0
            decimal sumPrixHTHR = 0;
            decimal sumPrixHTAR = 0;

            // boucle pour le prix HT HR
            foreach (DataGridViewRow row in grid.Rows)
            {

                // Récupération de l'objet DataGridViewCell correspondant à la colonne
                DataGridViewCell cell = row.Cells[columnPrixIndex];
                DataGridViewCell cellQuantité = row.Cells[columnQuantitéPro];
                // Récupération de la valeur des cellules
                decimal prix = Convert.ToDecimal(cell.Value);
                decimal quantité = Convert.ToDecimal(cellQuantité.Value);
                // Calcul prix HT Hors Remise
                sumPrixHTHR += quantité * prix;
            }

            // boucle pour le prix HT Avec Rremise
            foreach (DataGridViewRow row in grid.Rows)
            {
                // Récupération de l'objet DataGridViewCell correspondant à la colonne
                DataGridViewCell cellPrix = row.Cells[columnPrixIndex];
                DataGridViewCell cellRemise = row.Cells[columnTauxRemiseIndex];
                DataGridViewCell cellQuantité = row.Cells[columnQuantitéPro];

                // Récupération de la valeur des cellules
                decimal prix = Convert.ToDecimal(cellPrix.Value);
                decimal taux = Convert.ToDecimal(cellRemise.Value);
                decimal quantité = Convert.ToDecimal(cellQuantité.Value);

                // Calcul prix hors taxe avec remise
                sumPrixHTAR += (quantité * prix) - ((quantité * prix) * (taux / 100));
            }

            // Calcul total tva d'un Devis
            decimal tauxTva = Convert.ToDecimal(txtTauxTva.Text);
            decimal totalTva = sumPrixHTAR * (tauxTva / 100);

            // Calcul Devis TTC 
            decimal prixTtc = sumPrixHTAR + totalTva;


            //injection des var dans les text box

            txtMontantHTAR.Text = sumPrixHTAR.ToString();
            txtMontantHTHR.Text = sumPrixHTHR.ToString();
            txtMontantTva.Text  = totalTva.ToString();
            txtMontantTtc.Text = prixTtc.ToString();
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
            lblErrorAdd.Text = "Produit ajouté au devis";
            refreshPrixDevis();
        }

        private void btnAddDevis_Click(object sender, EventArgs e)
        {
            Client unCli = new Client(cmbClient.SelectedIndex);
            StatusDevis unStatus = new StatusDevis(cmbStatutDevis.SelectedIndex);
            int codeDevis;
            int codePro;
            float remisePro;
            int quantitéPro;
            if (txtTauxTva.Text == "")
            {
                lblErrorAdd.Text= "renseigner le taux de tva";
                return;
            }
            // insert du devis 
            Devis unDevis = new Devis(0, float.Parse(txtTauxTva.Text), dtpDateDevis.Value, unCli, unStatus);
            int i = GestionDevis.ajoutDevis(unDevis);

            // ajout des produits dans un devis
            ProduitDevis unProduitDevis;

            foreach (DataGridViewRow row in dtgDevisModify.Rows)
            {
                codeDevis   = i;
                codePro     = Convert.ToInt32(row.Cells[0].Value);
                remisePro   = Convert.ToSingle(row.Cells[4].Value);
                quantitéPro = Convert.ToInt32(row.Cells[2].Value);
                unProduitDevis = new ProduitDevis(codeDevis, codePro, remisePro, quantitéPro);
                GestionDevis.ajoutProduitDansDevis(unProduitDevis);
            }
            clearRightForm();
            lblErrorAdd.Text = "Devis ajouté";
        }
        private void btnSupprimerDevis_Click(object sender, EventArgs e)
        {
            string boxMessageDel = "Etes-vous certain de vouloir supprimer ce Devis ";
            string boxTitleDel = "Supprimer";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(boxMessageDel, boxTitleDel, buttons);
            if (result == DialogResult.Yes)
            {
                int codePro;
                string validMessage;
                int.TryParse(txtCode.Text, out codePro); ;
                validMessage = GestionDevis.SupprimerDevis(codePro);
                lblErrorAdd.Text = validMessage;
                List<Produit> liste = new List<Produit>();
                liste = GestionProduits.GetProduits();
                // Rattachement de la List à la source de données du datagridview
                dtgDevis.DataSource = liste;
                lblErrorAdd.Visible = false;
                btnAddProduct.Visible = true;
            }
            else
            {
                lblErrorAdd.Text = "Le produit n'a pas été supprimé";
            }
        }
        private void btnSupDevis_Click(object sender, EventArgs e)
        {
            string boxMessageDel = "Etes-vous certain de vouloir supprimer ce Devis ";
            string boxTitleDel = "Supprimer";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(boxMessageDel, boxTitleDel, buttons);
            if (result == DialogResult.Yes)
            {
                int codePro;
                string validMessage;
                int.TryParse(txtCode.Text, out codePro); ;
                validMessage = GestionDevis.SupprimerDevis(codePro);
                lblErrorAdd.Text = validMessage;
                List<Produit> liste = new List<Produit>();
                liste = GestionProduits.GetProduits();
                // Rattachement de la List à la source de données du datagridview
                dtgDevis.DataSource = liste;
                lblErrorAdd.Visible = false;
                btnAddProduct.Visible = true;
            }
            else
            {
                lblErrorAdd.Text = "Le Devis n'a pas été supprimé";
            }
        }

        public void clearRightForm()
        {
            btnCancelDevis.Visible = false;
            btnAddDevis.Visible = false;
            btnModifyDevis.Visible = true;
            btnSupDevis.Visible = true;
            dtgDevisModify.Refresh();
            txtMontantHTAR.Text = "";
            dtgDevisModify.Rows.Clear();
            txtMontantHTHR.Text = "";
            txtMontantTtc.Text = "";
            txtMontantTva.Text = "";
            txtTauxTva.Text = "";
            lblCode.Visible = true;
        }
        private void btnCancelDevis_Click(object sender, EventArgs e)
        {
            string boxMessageDel = "Etes-vous certain de vouloir annuler ce nouveau Devis ";
            string boxTitleDel = "Annulation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(boxMessageDel, boxTitleDel, buttons);
            if (result == DialogResult.Yes)
            {
                clearRightForm();
            }
            else
            {
                lblErrorAdd.Text = "Action annulé";
            }
           
        }
        private void dtgDevisModify_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int cellIndex = e.ColumnIndex;
            // Fix Erreur du click colonne 
            if (rowIndex == -1)
                return;

            DataGridViewRow row = dtgDevisModify.Rows[rowIndex];

            if (row.IsNewRow)
            {
                lblErrorAdd.Text = "Veuillez ajouter un produit";
                return;
            }

            if (cellIndex == 5)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Confirmation", MessageBoxButtons.YesNo);

                // Vérifier la valeur retournée par la fenêtre de confirmation
                if (result == DialogResult.Yes)
                {
                    // L'utilisateur a choisi Oui, supprimer le produit
                    // Supprimer la ligne sélectionnée en utilisant l'index récupéré
                    lblErrorAdd.Text = "Suppression confirmé";
                    dtgDevisModify.Rows.RemoveAt(rowIndex);
                    refreshPrixDevis();
                }
                else
                {
                    // L'utilisateur a choisi Non, annuler la suppression du produit
                    lblErrorAdd.Text = "Suppression annulé";
                }

            }
        }



        private void dtgDevis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Récupérer l'index de la ligne sur laquelle l'utilisateur a cliqué
            int rowIndex = e.RowIndex;
            int cellIndex = e.ColumnIndex;
            List<Devis> listeDevis = new List<Devis>();
            listeDevis = GestionDevis.getDevis();
            // Fix Erreur du click colonne 
            if (rowIndex == -1)
                return;

            dtgDevis.CurrentRow.Selected = true;
            txtCode.Text = dtgDevis.Rows[rowIndex].Cells["code"].Value.ToString();
            txtMontantTtc.Text = dtgDevis.Rows[rowIndex].Cells["Prix"].Value.ToString();
            DateTime dt = (DateTime)dtgDevis.Rows[rowIndex].Cells["Date"].Value;
            dtpDateDevis.Value = dt;
            dtpDateDevis.CustomFormat = "MM-dd-yyyy";
            cmbClient.Text = dtgDevis.Rows[rowIndex].Cells["Nom client"].Value.ToString();
            string codeDevis = dtgDevis.Rows[rowIndex].Cells["code"].Value.ToString();
            int codeDevisParse;
            int.TryParse(codeDevis, out codeDevisParse);
            Devis unDevis = GestionDevis.getUnDevis(listeDevis, codeDevisParse);
            cmbStatutDevis.Text = unDevis.StatusDevisLib;
            txtTauxTva.Text = unDevis.Tx_tva.ToString();
        }

        private void dtpDateDevis_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

