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

namespace CommercialGUI
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
            GestionUtilisateurs.SetChaineConnexion(ConfigurationManager.ConnectionStrings["gestion-commerciale"]);
        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
        private void btnSubmitCo_Click(object sender, EventArgs e)
        {
            string errorMsg = "";
            if (txtUser.Text.Length <= 0 || txtPassword.Text.Length <= 0)
            {
                errorMsg = "Merci de renseigner tout les champs \n";
            }
            Utilisateur uti = new Utilisateur(txtUser.Text, txtPassword.Text);
            bool isValid = GestionUtilisateurs.CheckUtilisateur(uti);
            if (isValid == false)
            {
                errorMsg = errorMsg + "Mauvais couple E-mail/Mot de passe";
                lblError.Text = errorMsg;
            }
            else
            {
                this.Hide();
                FrmViewProduct viewProduct = new FrmViewProduct();
                viewProduct.ShowDialog(); // ouverture du formulaire*
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
