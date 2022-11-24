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
using System.Windows.Forms;
using CommercialBLL;
using CommercialBO;

namespace CommercialGUI
{
    public partial class FrmViewCustomer : Form
    {
        public FrmViewCustomer()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            GestionClients.SetchaineConnexion(ConfigurationManager.ConnectionStrings["gestion-commerciale"]);
            // Blocage de la génération automatique des colonnes
            dtgCustomer.AutoGenerateColumns = false;
            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn CodeColumn = new DataGridViewTextBoxColumn();
            CodeColumn.Name = "code";
            CodeColumn.DataPropertyName = "code";
            CodeColumn.HeaderText = "Code";
            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn nomColumn = new DataGridViewTextBoxColumn();
            nomColumn.Name = "nom";
            nomColumn.DataPropertyName = "nom";
            nomColumn.HeaderText = "nom";
            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn numTelColumn = new DataGridViewTextBoxColumn();
            numTelColumn.Name = "numTel";
            numTelColumn.DataPropertyName = "numeroTel";
            numTelColumn.HeaderText = "numTel";
            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn numFaxColumn = new DataGridViewTextBoxColumn();
            numFaxColumn.Name = "numFax";
            numFaxColumn.DataPropertyName = "numeroFax";
            numFaxColumn.HeaderText = "numFax";
            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn emailColumn = new DataGridViewTextBoxColumn();
            emailColumn.Name = "email";
            emailColumn.DataPropertyName = "email";
            emailColumn.HeaderText = "email";
            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn numAdresseLColumn = new DataGridViewTextBoxColumn();
            numAdresseLColumn.Name = "numAdresseLiv";
            numAdresseLColumn.DataPropertyName = "numAdresseLiv";
            numAdresseLColumn.HeaderText = "numAdresseLiv";
            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn numAdresseFColumn = new DataGridViewTextBoxColumn();
            numAdresseFColumn.Name = "numAdresseFact";
            numAdresseFColumn.DataPropertyName = "numAdresseFac";
            numAdresseFColumn.HeaderText = "numAdresseFact";
            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn rueAdresseLivColumn = new DataGridViewTextBoxColumn();
            rueAdresseLivColumn.Name = "rueAdresseLiv";
            rueAdresseLivColumn.DataPropertyName = "rueAdresseLiv";
            rueAdresseLivColumn.HeaderText = "rueAdresseLiv";
            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn rueAdresseFacColumn = new DataGridViewTextBoxColumn();
            rueAdresseFacColumn.Name = "rueAdresseFac";
            rueAdresseFacColumn.DataPropertyName = "rueAdresseFac";
            rueAdresseFacColumn.HeaderText = "rueAdresseFac";
            // Création d'une en-tête de colonne pour la colonne 10
            DataGridViewTextBoxColumn codePostalLivColumn = new DataGridViewTextBoxColumn();
            codePostalLivColumn.Name = "codePostalLiv";
            codePostalLivColumn.DataPropertyName = "codePostalAdresseLiv";
            codePostalLivColumn.HeaderText = "codePostalLiv";
            // Création d'une en-tête de colonne pour la colonne 11
            DataGridViewTextBoxColumn codePostalFacColumn = new DataGridViewTextBoxColumn();
            codePostalFacColumn.Name = "codePostalFact";
            codePostalFacColumn.DataPropertyName = "codePostalAdresseFac";
            codePostalFacColumn.HeaderText = "codePostalFact";
            // Création d'une en-tête de colonne pour la colonne 12
            DataGridViewTextBoxColumn villeLivColumn = new DataGridViewTextBoxColumn();
            villeLivColumn.Name = "villeLiv";
            villeLivColumn.DataPropertyName = "villeAdresseLiv";
            villeLivColumn.HeaderText = "villeLiv";
            // Création d'une en-tête de colonne pour la colonne 13
            DataGridViewTextBoxColumn villeFacColumn = new DataGridViewTextBoxColumn();
            villeFacColumn.Name = "villeFact";
            villeFacColumn.DataPropertyName = "villeAdresseFac";
            villeFacColumn.HeaderText = "villeFact";

            // Ajout des 13 en-têtes de colonne au datagridview
            dtgCustomer.Columns.Add(CodeColumn);
            dtgCustomer.Columns.Add(nomColumn);
            dtgCustomer.Columns.Add(numTelColumn);
            dtgCustomer.Columns.Add(numFaxColumn);
            dtgCustomer.Columns.Add(emailColumn);
            dtgCustomer.Columns.Add(numAdresseLColumn);
            dtgCustomer.Columns.Add(rueAdresseLivColumn);
            dtgCustomer.Columns.Add(codePostalLivColumn);
            dtgCustomer.Columns.Add(villeLivColumn);
            dtgCustomer.Columns.Add(numAdresseFColumn);
            dtgCustomer.Columns.Add(rueAdresseFacColumn);
            dtgCustomer.Columns.Add(codePostalFacColumn);
            dtgCustomer.Columns.Add(villeFacColumn);
            // Définition du style apporté au datagridview
            dtgCustomer.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dtgCustomer.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Client> liste = new List<Client>();
            liste = GestionClients.GetClients();
            // Rattachement de la List à la source de données du datagridview
            dtgCustomer.DataSource = liste;

            txtNom.Text = string.Empty;

        }

        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgCustomer.CurrentRow.Selected = true;
            txtCodeCli.Text = dtgCustomer.Rows[e.RowIndex].Cells["code"].Value.ToString();
            txtNom.Text = dtgCustomer.Rows[e.RowIndex].Cells["nom"].Value.ToString();
            txtNumTel.Text = dtgCustomer.Rows[e.RowIndex].Cells["numTel"].Value.ToString();
            txtNumFax.Text = dtgCustomer.Rows[e.RowIndex].Cells["numFax"].Value.ToString();
            txtEmail.Text = dtgCustomer.Rows[e.RowIndex].Cells["email"].Value.ToString();
            //livraison
            txtNumRue.Text = dtgCustomer.Rows[e.RowIndex].Cells["numAdresseLiv"].Value.ToString();
            txtNomRueLivr.Text = dtgCustomer.Rows[e.RowIndex].Cells["rueAdresseLiv"].Value.ToString();
            txtCodePostalLivr.Text = dtgCustomer.Rows[e.RowIndex].Cells["codePostalLiv"].Value.ToString();
            txtVilleLivr.Text = dtgCustomer.Rows[e.RowIndex].Cells["villeLiv"].Value.ToString();
            //facturation
            txtNumRueFact.Text = dtgCustomer.Rows[e.RowIndex].Cells["numAdresseFact"].Value.ToString();
            txtNomRueFact.Text = dtgCustomer.Rows[e.RowIndex].Cells["rueAdresseFac"].Value.ToString();
            txtCodePostalFact.Text = dtgCustomer.Rows[e.RowIndex].Cells["codePostalFact"].Value.ToString();
            txtVilleFact.Text = dtgCustomer.Rows[e.RowIndex].Cells["villeFact"].Value.ToString();
            btnAjouter.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmViewProduct viewProduct = new FrmViewProduct();
            viewProduct.ShowDialog(); // ouverture du formulaire*
        }

        private void FrmViewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void lblNomCli_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            string boxMessageDel = "Etes-vous certain de vouloir supprimer ce Client ";
            string boxTitleDel = "Supprimer";
            string validMessage;
            if (string.IsNullOrEmpty(txtCodeCli.Text))
            {
                lblStatus.Text = "Aucun client est selectionné";
                return;
            }
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(boxMessageDel, boxTitleDel, buttons);
            if (result == DialogResult.Yes)
            {
                int codeCli;
                int.TryParse(txtCodeCli.Text, out codeCli);
                validMessage = GestionClients.SupprimerClient(codeCli);
                lblStatus.Text = validMessage;
                List<Client> liste = new List<Client>();
                liste = GestionClients.GetClients();
                // Rattachement de la List à la source de données du datagridview
                dtgCustomer.DataSource = liste;
                btnAjouter.Visible = true;
                // reset input
                txtCodeCli.Text = string.Empty;
                txtNom.Text = string.Empty;
                txtNumTel.Text = string.Empty;
                txtNumFax.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtNumRue.Text = string.Empty;
                txtNomRueLivr.Text = string.Empty;
                txtCodePostalLivr.Text = string.Empty;
                txtVilleLivr.Text = string.Empty;
                txtNumRueFact.Text = string.Empty;
                txtNomRueFact.Text = string.Empty;
                txtCodePostalFact.Text = string.Empty;
                txtVilleFact.Text = string.Empty;
            }
            else
            {
                lblStatus.Text = "suppresion annulée";
            }
        }

        private void lblCodeCli_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string generalMessage;
            int codePostalLivr;
            int codePostalFact;
            int numTel;
            int numFax;
            int numRueFact;
            int numRueLivr;
            if (txtNom.Text.Length <= 0 || txtNumTel.Text.Length <=0 || txtNumFax.Text.Length <=0 || txtEmail.Text.Length <=0
                || txtNumRue.Text.Length <=0 ||txtNomRueLivr.Text.Length <= 0 || txtCodePostalLivr.Text.Length <= 0 || txtVilleLivr.Text.Length <= 0
                || txtNumRueFact.Text.Length <= 0 || txtNomRueFact.Text.Length <= 0 || txtCodePostalFact.Text.Length <= 0 || txtVilleFact.Text.Length <= 0)
            {
                generalMessage = "Veuillez remplir tous les champs avant de valider";
                lblGeneralMessage.Text = generalMessage;
            }
            else
            {
                int.TryParse(txtCodePostalLivr.Text, out codePostalLivr);
                int.TryParse(txtCodePostalFact.Text, out codePostalFact);
                int.TryParse(txtNumTel.Text, out numTel);
                int.TryParse(txtNumFax.Text, out numFax);
                int.TryParse(txtNumRueFact.Text, out numRueFact);
                int.TryParse(txtNumRue.Text, out numRueLivr);
                Client unClient = new Client(0, txtNom.Text, numTel, numFax, txtEmail.Text, numRueLivr, numRueFact, txtNomRueLivr.Text, txtNomRueFact.Text, codePostalLivr, codePostalFact, txtVilleLivr.Text, txtVilleFact.Text);
                GestionClients.AjouterClient(unClient);
                generalMessage = "Ajout du client réussie";
                lblGeneralMessage.Text = generalMessage;
                List<Client> liste = new List<Client>();
                liste = GestionClients.GetClients();
                // Rattachement de la List à la source de données du datagridview
                dtgCustomer.DataSource = liste;
                btnAjouter.Visible = true;
                // reset input
                txtCodeCli.Text = string.Empty;
                txtNom.Text = string.Empty;
                txtNumTel.Text = string.Empty;
                txtNumFax.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtNumRue.Text = string.Empty;
                txtNomRueLivr.Text = string.Empty;
                txtCodePostalLivr.Text = string.Empty;
                txtVilleLivr.Text = string.Empty;
                txtNumRueFact.Text = string.Empty;
                txtNomRueFact.Text = string.Empty;
                txtCodePostalFact.Text = string.Empty;
                txtVilleFact.Text = string.Empty;
            }


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string generalMessage;
            int codeCli, codePostalLivr, codePostalFact, numTel, numFax, numRueFact, numRueLivr;
            if (txtNom.Text.Length <= 0 || txtNumTel.Text.Length <= 0 || txtNumFax.Text.Length <= 0 || txtEmail.Text.Length <= 0
                || txtNumRue.Text.Length <= 0 || txtNomRueLivr.Text.Length <= 0 || txtCodePostalLivr.Text.Length <= 0 || txtVilleLivr.Text.Length <= 0
                || txtNumRueFact.Text.Length <= 0 || txtNomRueFact.Text.Length <= 0 || txtCodePostalFact.Text.Length <= 0 || txtVilleFact.Text.Length <= 0)
            {
                generalMessage = "Veuillez remplir tous les champs avant de valider";
                lblGeneralMessage.Text = generalMessage;
            }
            else
            {
                int.TryParse(txtCodeCli.Text, out codeCli);
                int.TryParse(txtCodePostalLivr.Text, out codePostalLivr);
                int.TryParse(txtCodePostalFact.Text, out codePostalFact);
                int.TryParse(txtNumTel.Text, out numTel);
                int.TryParse(txtNumFax.Text, out numFax);
                int.TryParse(txtNumRueFact.Text, out numRueFact);
                int.TryParse(txtNumRue.Text, out numRueLivr);
                Client unClient = new Client(codeCli, txtNom.Text, numTel, numFax, txtEmail.Text, numRueLivr, numRueFact, txtNomRueLivr.Text, txtNomRueFact.Text, codePostalLivr, codePostalFact, txtVilleLivr.Text, txtVilleFact.Text);
                GestionClients.ModifierClient(unClient);
                generalMessage = "Modification du client réussie";
                lblGeneralMessage.Text = generalMessage;
                List<Client> liste = new List<Client>();
                liste = GestionClients.GetClients();
                // Rattachement de la List à la source de données du datagridview
                dtgCustomer.DataSource = liste;
                btnAjouter.Visible = true;
                // reset input
                txtCodeCli.Text = string.Empty;
                txtNom.Text = string.Empty;
                txtNumTel.Text = string.Empty;
                txtNumFax.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtNumRue.Text = string.Empty;
                txtNomRueLivr.Text = string.Empty;
                txtCodePostalLivr.Text = string.Empty;
                txtVilleLivr.Text = string.Empty;
                txtNumRueFact.Text = string.Empty;
                txtNomRueFact.Text = string.Empty;
                txtCodePostalFact.Text = string.Empty;
                txtVilleFact.Text = string.Empty;
            }
        }
    }
}
