﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommercialBO;

namespace CommercialGUI
{
    public partial class FrmViewProduct : Form
    {
        public FrmViewProduct()
        {
            InitializeComponent();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            float prixHT;
            float.TryParse(txtPrixHTProduct.Text, out prixHT);
            this.Hide();
            Produit unProduit = new Produit(0, txtLabelProduct.Text, prixHT, lstCategProduct.Text);
        }

        private void lstCategProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmViewProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
