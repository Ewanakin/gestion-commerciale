using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CommercialBO;
using CommercialBLL;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CommercialGUI
{
    public partial class FrmViewProduct : Form
    {
        public FrmViewProduct()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionProduits.SetchaineConnexion(ConfigurationManager.ConnectionStrings["gestion-commerciale"]);
            // Blocage de la génération automatique des colonnes
            dtgProducts.AutoGenerateColumns = false;
            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn CodeColumn = new DataGridViewTextBoxColumn();
            CodeColumn.Name = "code";
            CodeColumn.DataPropertyName = "Code";
            CodeColumn.HeaderText = "Code";
            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn LibelleColumn = new DataGridViewTextBoxColumn();
            LibelleColumn.Name = "libelle";
            LibelleColumn.DataPropertyName = "Libelle";
            LibelleColumn.HeaderText = "Libelle";
            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn PrixHTColumn = new DataGridViewTextBoxColumn();
            PrixHTColumn.Name = "prixHT";
            PrixHTColumn.DataPropertyName = "PrixHT";
            PrixHTColumn.HeaderText = "PrixHT";
            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn CodeLibelleCategColumn = new DataGridViewTextBoxColumn();
            CodeLibelleCategColumn.Name = "libCat";
            CodeLibelleCategColumn.DataPropertyName = "CategPro";
            CodeLibelleCategColumn.HeaderText = "Libelle cat";
            // Ajout des 4 en-têtes de colonne au datagridview
            dtgProducts.Columns.Add(CodeColumn);
            dtgProducts.Columns.Add(LibelleColumn);
            dtgProducts.Columns.Add(PrixHTColumn);
            dtgProducts.Columns.Add(CodeLibelleCategColumn);
            // Définition du style apporté au datagridview
            dtgProducts.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dtgProducts.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Produit> liste = new List<Produit>();
            liste = GestionProduits.GetProduits();
            // Rattachement de la List à la source de données du datagridview
            dtgProducts.DataSource = liste;


            List<CategorieProduit> listeCategPro = new List<CategorieProduit>();
            listeCategPro = GestionCategorieProduits.GetCategorieProduits();

            cmbCategorieProduct.DataSource = listeCategPro;
            cmbCategorieProduct.DisplayMember = "libCateg";
            cmbCategorieProduct.ValueMember = "code";


            txtLabelProduct.Text = string.Empty;
            txtPrixHTProduct.Text = string.Empty;
            txtCodeSupprPro.Text = string.Empty;

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            txtLabelProduct.Clear();
            txtPrixHTProduct.Clear();
        }

        private void lstCategProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmViewProduct_Load(object sender, EventArgs e)
        {

        }

        private void dtgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgProducts.CurrentRow.Selected = true;
            txtCodeSupprPro.Text = dtgProducts.Rows[e.RowIndex].Cells["code"].Value.ToString();
            txtLabelProduct.Text = dtgProducts.Rows[e.RowIndex].Cells["libelle"].Value.ToString();
            txtPrixHTProduct.Text = dtgProducts.Rows[e.RowIndex].Cells["prixHT"].Value.ToString();
            cmbCategorieProduct.Text = dtgProducts.Rows[e.RowIndex].Cells["libCat"].Value.ToString();
            btnAddProduct.Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int code;
            float prixHT;
            string errorMsg = "";
            
            if (txtLabelProduct.Text.Length <= 0 || txtLabelProduct.Text.Length <= 0)
            {
                errorMsg = "Merci de renseigner tout les champs \n";
                lblError.Visible = true;
                lblError.Text = errorMsg;
            }
            else
            {
                int.TryParse(cmbCategorieProduct.SelectedIndex.ToString(), out code);
                float.TryParse(txtPrixHTProduct.Text, out prixHT);
                if (prixHT != 0)
                {
                    int.TryParse(cmbCategorieProduct.SelectedIndex.ToString(), out code);
                   
                    Produit unProduit = new Produit(0, txtLabelProduct.Text, prixHT, GestionCategorieProduits.GetUneCategPro(code)[0]);
                    GestionProduits.CreerProduit(unProduit);
                    lblError.Visible = true;
                    errorMsg = "insertion réussie";
                    lblError.Text = errorMsg;
                    List<Produit> liste = new List<Produit>();
                    liste = GestionProduits.GetProduits();
                    // Rattachement de la List à la source de données du datagridview
                    dtgProducts.DataSource = liste;
                    lblError.Visible = false;
                    txtLabelProduct.Text = string.Empty;
                    txtPrixHTProduct.Text = string.Empty;
                }
                else
                {
                    lblError.Visible = true;
                    errorMsg = "vous ne pouvez pas ajouter le produit car le champ prixHT \n est une chaine de caractère \n ou égale à 0";
                    lblError.Text = errorMsg;
                }
            }
        }

        private void btnRefreshDTG_Click(object sender, EventArgs e)
        {

        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            string boxMessageDel = "Etes-vous certain de vouloir supprimer ce produit ";
            string boxTitleDel = "Supprimer";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(boxMessageDel, boxTitleDel, buttons);
            if (result == DialogResult.Yes)
            {
                int codePro;
                string validMessage;
                int.TryParse(txtCodeSupprPro.Text, out codePro); ;
                validMessage = GestionProduits.SupprimerProduit(codePro);
                lblValidationMessage.Text = validMessage;
                List<Produit> liste = new List<Produit>();
                liste = GestionProduits.GetProduits();
                // Rattachement de la List à la source de données du datagridview
                dtgProducts.DataSource = liste;
                lblError.Visible = false;
                txtLabelProduct.Text = string.Empty;
                txtPrixHTProduct.Text = string.Empty;
                btnAddProduct.Visible = true;
            }
            else
            {
                lblValidationMessage.Text = "Le produit n'a pas été supprimé";
            }
           
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (txtLabelProduct.Text.Length <= 0 || txtLabelProduct.Text.Length <= 0)
            {
                errorMsg = "Merci de renseigner tout les champs \n";
                lblError.Visible = true;
                lblError.Text = errorMsg;
            }
            else
            {
                int codeCateg;
                int codePro;
                float prixHT;
                int.TryParse(cmbCategorieProduct.SelectedIndex.ToString(), out codeCateg);
                int.TryParse(txtCodeSupprPro.Text, out codePro);
                float.TryParse(txtPrixHTProduct.Text, out prixHT);
                if (prixHT != 0)
                {
                    Produit updtProduit = new Produit(codePro, txtLabelProduct.Text, prixHT, GestionCategorieProduits.GetUneCategPro(codeCateg)[0]);
                    GestionProduits.ModifierUtilisateur(updtProduit);
                    lblError.Visible = true;
                    lblError.Text = "Modification réussie";
                    List<Produit> liste = new List<Produit>();
                    liste = GestionProduits.GetProduits();
                    // Rattachement de la List à la source de données du datagridview
                    dtgProducts.DataSource = liste;
                    lblError.Visible = false;
                    txtLabelProduct.Text = string.Empty;
                    txtPrixHTProduct.Text = string.Empty;
                    btnAddProduct.Visible = true;
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Vous ne pouvez pas modifier car le champ HT \n est égale à 0 ou c'est une chaine \n de caractère";
                }
            }

        }
    }
}
