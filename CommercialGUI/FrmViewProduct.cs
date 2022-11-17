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
using Application = System.Windows.Forms.Application;

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
            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn LibelleColumn = new DataGridViewTextBoxColumn();
            LibelleColumn.DataPropertyName = "libelle";
            LibelleColumn.HeaderText = "Libelle";
            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn PrixHTColumn = new DataGridViewTextBoxColumn();
            PrixHTColumn.DataPropertyName = "prixHT";
            PrixHTColumn.HeaderText = "PrixHT";
            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn CodeLibelleCategColumn = new DataGridViewTextBoxColumn();
            CodeLibelleCategColumn.DataPropertyName = "libCat";
            CodeLibelleCategColumn.HeaderText = "Libelle cat";
            // Ajout des 4 en-têtes de colonne au datagridview
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
            cmbCategorieProduct.DisplayMember = "libelle";
            cmbCategorieProduct.ValueMember = "code";

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            float prixHT;
            float.TryParse(txtPrixHTProduct.Text, out prixHT);
            Produit unProduit = new Produit(0, txtLabelProduct.Text, prixHT, cmbCategorieProduct.Text);
            GestionProduits.CreerUtilisateur(unProduit);
        }

        private void lstCategProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmViewProduct_Load(object sender, EventArgs e)
        {

        }

        private void dtgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgProducts.Rows[e.RowIndex];
                txtLabelProduct.Text = row.Cells[1].Value.ToString();
                txtPrixHTProduct.Text = row.Cells[0].Value.ToString();
            }

        }
    }
}
