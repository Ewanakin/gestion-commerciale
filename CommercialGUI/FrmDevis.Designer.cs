namespace CommercialGUI
{
    partial class FrmDevis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgDevis = new System.Windows.Forms.DataGridView();
            this.btnNewDevis = new System.Windows.Forms.Button();
            this.gpDevis = new System.Windows.Forms.GroupBox();
            this.lblErrorAdd = new System.Windows.Forms.Label();
            this.btnCancelDevis = new System.Windows.Forms.Button();
            this.btnAddDevis = new System.Windows.Forms.Button();
            this.lblMontantTTC = new System.Windows.Forms.Label();
            this.lblMontantTVA = new System.Windows.Forms.Label();
            this.lblMHTAR = new System.Windows.Forms.Label();
            this.lblMontantHorsRemise = new System.Windows.Forms.Label();
            this.lblTauxRemise = new System.Windows.Forms.Label();
            this.lblTauxTva = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtQuantité = new System.Windows.Forms.TextBox();
            this.lblQuantité = new System.Windows.Forms.Label();
            this.lblAddProduit = new System.Windows.Forms.Label();
            this.cmbAddProduit = new System.Windows.Forms.ComboBox();
            this.cmbStatutDevis = new System.Windows.Forms.ComboBox();
            this.lblStatut = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtMontantHTAR = new System.Windows.Forms.TextBox();
            this.txtMontantHTHR = new System.Windows.Forms.TextBox();
            this.txtMontantTtc = new System.Windows.Forms.TextBox();
            this.txtMontantTva = new System.Windows.Forms.TextBox();
            this.btnModifyDevis = new System.Windows.Forms.Button();
            this.btnSupDevis = new System.Windows.Forms.Button();
            this.dtgDevisModify = new System.Windows.Forms.DataGridView();
            this.txtTauxRemise = new System.Windows.Forms.TextBox();
            this.txtTauxTva = new System.Windows.Forms.TextBox();
            this.dtpDateDevis = new System.Windows.Forms.DateTimePicker();
            this.txtCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevis)).BeginInit();
            this.gpDevis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevisModify)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDevis
            // 
            this.dtgDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevis.Location = new System.Drawing.Point(13, 12);
            this.dtgDevis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgDevis.Name = "dtgDevis";
            this.dtgDevis.RowHeadersWidth = 51;
            this.dtgDevis.RowTemplate.Height = 24;
            this.dtgDevis.Size = new System.Drawing.Size(909, 573);
            this.dtgDevis.TabIndex = 0;
            this.dtgDevis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDevis_CellClick);
            this.dtgDevis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDevis_CellContentClick);
            // 
            // btnNewDevis
            // 
            this.btnNewDevis.Location = new System.Drawing.Point(1013, 12);
            this.btnNewDevis.Name = "btnNewDevis";
            this.btnNewDevis.Size = new System.Drawing.Size(149, 52);
            this.btnNewDevis.TabIndex = 1;
            this.btnNewDevis.Text = "Nouveau";
            this.btnNewDevis.UseVisualStyleBackColor = true;
            this.btnNewDevis.Click += new System.EventHandler(this.btnNewDevis_Click);
            // 
            // gpDevis
            // 
            this.gpDevis.Controls.Add(this.lblErrorAdd);
            this.gpDevis.Controls.Add(this.btnCancelDevis);
            this.gpDevis.Controls.Add(this.btnAddDevis);
            this.gpDevis.Controls.Add(this.lblMontantTTC);
            this.gpDevis.Controls.Add(this.lblMontantTVA);
            this.gpDevis.Controls.Add(this.lblMHTAR);
            this.gpDevis.Controls.Add(this.lblMontantHorsRemise);
            this.gpDevis.Controls.Add(this.lblTauxRemise);
            this.gpDevis.Controls.Add(this.lblTauxTva);
            this.gpDevis.Controls.Add(this.lblCode);
            this.gpDevis.Controls.Add(this.lblDate);
            this.gpDevis.Controls.Add(this.btnAddProduct);
            this.gpDevis.Controls.Add(this.txtQuantité);
            this.gpDevis.Controls.Add(this.lblQuantité);
            this.gpDevis.Controls.Add(this.lblAddProduit);
            this.gpDevis.Controls.Add(this.cmbAddProduit);
            this.gpDevis.Controls.Add(this.cmbStatutDevis);
            this.gpDevis.Controls.Add(this.lblStatut);
            this.gpDevis.Controls.Add(this.cmbClient);
            this.gpDevis.Controls.Add(this.lblClient);
            this.gpDevis.Controls.Add(this.txtMontantHTAR);
            this.gpDevis.Controls.Add(this.txtMontantHTHR);
            this.gpDevis.Controls.Add(this.txtMontantTtc);
            this.gpDevis.Controls.Add(this.txtMontantTva);
            this.gpDevis.Controls.Add(this.btnModifyDevis);
            this.gpDevis.Controls.Add(this.btnSupDevis);
            this.gpDevis.Controls.Add(this.dtgDevisModify);
            this.gpDevis.Controls.Add(this.txtTauxRemise);
            this.gpDevis.Controls.Add(this.txtTauxTva);
            this.gpDevis.Controls.Add(this.dtpDateDevis);
            this.gpDevis.Controls.Add(this.txtCode);
            this.gpDevis.ForeColor = System.Drawing.Color.Black;
            this.gpDevis.Location = new System.Drawing.Point(1013, 100);
            this.gpDevis.Name = "gpDevis";
            this.gpDevis.Size = new System.Drawing.Size(669, 833);
            this.gpDevis.TabIndex = 2;
            this.gpDevis.TabStop = false;
            this.gpDevis.Text = "Details";
            this.gpDevis.Enter += new System.EventHandler(this.gpDevis_Enter);
            // 
            // lblErrorAdd
            // 
            this.lblErrorAdd.AutoSize = true;
            this.lblErrorAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblErrorAdd.Location = new System.Drawing.Point(93, 237);
            this.lblErrorAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorAdd.Name = "lblErrorAdd";
            this.lblErrorAdd.Size = new System.Drawing.Size(0, 16);
            this.lblErrorAdd.TabIndex = 30;
            // 
            // btnCancelDevis
            // 
            this.btnCancelDevis.Location = new System.Drawing.Point(304, 765);
            this.btnCancelDevis.Name = "btnCancelDevis";
            this.btnCancelDevis.Size = new System.Drawing.Size(149, 52);
            this.btnCancelDevis.TabIndex = 29;
            this.btnCancelDevis.Text = "Annuler";
            this.btnCancelDevis.UseVisualStyleBackColor = true;
            this.btnCancelDevis.Visible = false;
            // 
            // btnAddDevis
            // 
            this.btnAddDevis.Location = new System.Drawing.Point(128, 765);
            this.btnAddDevis.Name = "btnAddDevis";
            this.btnAddDevis.Size = new System.Drawing.Size(149, 52);
            this.btnAddDevis.TabIndex = 28;
            this.btnAddDevis.Text = "Enregistrer";
            this.btnAddDevis.UseVisualStyleBackColor = true;
            this.btnAddDevis.Visible = false;
            this.btnAddDevis.Click += new System.EventHandler(this.btnAddDevis_Click);
            // 
            // lblMontantTTC
            // 
            this.lblMontantTTC.AutoSize = true;
            this.lblMontantTTC.Location = new System.Drawing.Point(259, 627);
            this.lblMontantTTC.Name = "lblMontantTTC";
            this.lblMontantTTC.Size = new System.Drawing.Size(84, 16);
            this.lblMontantTTC.TabIndex = 27;
            this.lblMontantTTC.Text = "Montant TTC";
            // 
            // lblMontantTVA
            // 
            this.lblMontantTVA.AutoSize = true;
            this.lblMontantTVA.Location = new System.Drawing.Point(15, 627);
            this.lblMontantTVA.Name = "lblMontantTVA";
            this.lblMontantTVA.Size = new System.Drawing.Size(84, 16);
            this.lblMontantTVA.TabIndex = 26;
            this.lblMontantTVA.Text = "Montant TVA";
            // 
            // lblMHTAR
            // 
            this.lblMHTAR.AutoSize = true;
            this.lblMHTAR.Location = new System.Drawing.Point(259, 576);
            this.lblMHTAR.Name = "lblMHTAR";
            this.lblMHTAR.Size = new System.Drawing.Size(153, 16);
            this.lblMHTAR.TabIndex = 25;
            this.lblMHTAR.Text = "Montant HT avec remise";
            // 
            // lblMontantHorsRemise
            // 
            this.lblMontantHorsRemise.AutoSize = true;
            this.lblMontantHorsRemise.Location = new System.Drawing.Point(15, 576);
            this.lblMontantHorsRemise.Name = "lblMontantHorsRemise";
            this.lblMontantHorsRemise.Size = new System.Drawing.Size(158, 16);
            this.lblMontantHorsRemise.TabIndex = 24;
            this.lblMontantHorsRemise.Text = "Montant HT Hors Remise";
            // 
            // lblTauxRemise
            // 
            this.lblTauxRemise.AutoSize = true;
            this.lblTauxRemise.Location = new System.Drawing.Point(339, 172);
            this.lblTauxRemise.Name = "lblTauxRemise";
            this.lblTauxRemise.Size = new System.Drawing.Size(87, 16);
            this.lblTauxRemise.TabIndex = 23;
            this.lblTauxRemise.Text = "Taux Remise";
            // 
            // lblTauxTva
            // 
            this.lblTauxTva.AutoSize = true;
            this.lblTauxTva.Location = new System.Drawing.Point(15, 120);
            this.lblTauxTva.Name = "lblTauxTva";
            this.lblTauxTva.Size = new System.Drawing.Size(67, 16);
            this.lblTauxTva.TabIndex = 22;
            this.lblTauxTva.Text = "Taux TVA";
            // 
            // lblCode
            // 
            this.lblCode.AccessibleName = "";
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(15, 24);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 16);
            this.lblCode.TabIndex = 21;
            this.lblCode.Text = "Code";
            // 
            // lblDate
            // 
            this.lblDate.AccessibleName = "";
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(280, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 16);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Date";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(449, 225);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(104, 28);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Ajouter";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtQuantité
            // 
            this.txtQuantité.Location = new System.Drawing.Point(240, 202);
            this.txtQuantité.Name = "txtQuantité";
            this.txtQuantité.Size = new System.Drawing.Size(91, 22);
            this.txtQuantité.TabIndex = 19;
            // 
            // lblQuantité
            // 
            this.lblQuantité.AutoSize = true;
            this.lblQuantité.Location = new System.Drawing.Point(237, 172);
            this.lblQuantité.Name = "lblQuantité";
            this.lblQuantité.Size = new System.Drawing.Size(54, 16);
            this.lblQuantité.TabIndex = 18;
            this.lblQuantité.Text = "quantité";
            // 
            // lblAddProduit
            // 
            this.lblAddProduit.AutoSize = true;
            this.lblAddProduit.Location = new System.Drawing.Point(15, 172);
            this.lblAddProduit.Name = "lblAddProduit";
            this.lblAddProduit.Size = new System.Drawing.Size(110, 16);
            this.lblAddProduit.TabIndex = 17;
            this.lblAddProduit.Text = "Ajouter un produit";
            // 
            // cmbAddProduit
            // 
            this.cmbAddProduit.FormattingEnabled = true;
            this.cmbAddProduit.Location = new System.Drawing.Point(19, 200);
            this.cmbAddProduit.Name = "cmbAddProduit";
            this.cmbAddProduit.Size = new System.Drawing.Size(201, 24);
            this.cmbAddProduit.TabIndex = 16;
            // 
            // cmbStatutDevis
            // 
            this.cmbStatutDevis.AccessibleName = "lblStatus";
            this.cmbStatutDevis.FormattingEnabled = true;
            this.cmbStatutDevis.Location = new System.Drawing.Point(284, 90);
            this.cmbStatutDevis.Name = "cmbStatutDevis";
            this.cmbStatutDevis.Size = new System.Drawing.Size(135, 24);
            this.cmbStatutDevis.TabIndex = 15;
            // 
            // lblStatut
            // 
            this.lblStatut.AccessibleName = "";
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(280, 72);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(40, 16);
            this.lblStatut.TabIndex = 14;
            this.lblStatut.Text = "Statut";
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(19, 90);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(132, 24);
            this.cmbClient.TabIndex = 13;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(15, 72);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(40, 16);
            this.lblClient.TabIndex = 12;
            this.lblClient.Text = "Client";
            // 
            // txtMontantHTAR
            // 
            this.txtMontantHTAR.Location = new System.Drawing.Point(263, 595);
            this.txtMontantHTAR.Name = "txtMontantHTAR";
            this.txtMontantHTAR.Size = new System.Drawing.Size(169, 22);
            this.txtMontantHTAR.TabIndex = 10;
            // 
            // txtMontantHTHR
            // 
            this.txtMontantHTHR.Location = new System.Drawing.Point(19, 595);
            this.txtMontantHTHR.Name = "txtMontantHTHR";
            this.txtMontantHTHR.Size = new System.Drawing.Size(183, 22);
            this.txtMontantHTHR.TabIndex = 9;
            // 
            // txtMontantTtc
            // 
            this.txtMontantTtc.Location = new System.Drawing.Point(263, 644);
            this.txtMontantTtc.Name = "txtMontantTtc";
            this.txtMontantTtc.Size = new System.Drawing.Size(169, 22);
            this.txtMontantTtc.TabIndex = 8;
            // 
            // txtMontantTva
            // 
            this.txtMontantTva.Location = new System.Drawing.Point(19, 644);
            this.txtMontantTva.Name = "txtMontantTva";
            this.txtMontantTva.Size = new System.Drawing.Size(183, 22);
            this.txtMontantTva.TabIndex = 7;
            // 
            // btnModifyDevis
            // 
            this.btnModifyDevis.Location = new System.Drawing.Point(128, 696);
            this.btnModifyDevis.Name = "btnModifyDevis";
            this.btnModifyDevis.Size = new System.Drawing.Size(149, 52);
            this.btnModifyDevis.TabIndex = 6;
            this.btnModifyDevis.Text = "Modifier";
            this.btnModifyDevis.UseVisualStyleBackColor = true;
            // 
            // btnSupDevis
            // 
            this.btnSupDevis.Location = new System.Drawing.Point(304, 696);
            this.btnSupDevis.Name = "btnSupDevis";
            this.btnSupDevis.Size = new System.Drawing.Size(149, 52);
            this.btnSupDevis.TabIndex = 3;
            this.btnSupDevis.Text = "Supprimer";
            this.btnSupDevis.UseVisualStyleBackColor = true;
            this.btnSupDevis.Click += new System.EventHandler(this.btnSupDevis_Click);
            // 
            // dtgDevisModify
            // 
            this.dtgDevisModify.AllowUserToOrderColumns = true;
            this.dtgDevisModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevisModify.Location = new System.Drawing.Point(5, 268);
            this.dtgDevisModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgDevisModify.Name = "dtgDevisModify";
            this.dtgDevisModify.RowHeadersWidth = 51;
            this.dtgDevisModify.RowTemplate.Height = 24;
            this.dtgDevisModify.Size = new System.Drawing.Size(659, 300);
            this.dtgDevisModify.TabIndex = 3;
            this.dtgDevisModify.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDevis_CellContentClick);
            this.dtgDevisModify.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDevisModify_CellContentClick);
            this.dtgDevisModify.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduitDevis_CellValueChanged);
            // 
            // txtTauxRemise
            // 
            this.txtTauxRemise.Location = new System.Drawing.Point(341, 200);
            this.txtTauxRemise.Name = "txtTauxRemise";
            this.txtTauxRemise.Size = new System.Drawing.Size(132, 22);
            this.txtTauxRemise.TabIndex = 5;
            // 
            // txtTauxTva
            // 
            this.txtTauxTva.Location = new System.Drawing.Point(19, 139);
            this.txtTauxTva.Name = "txtTauxTva";
            this.txtTauxTva.Size = new System.Drawing.Size(132, 22);
            this.txtTauxTva.TabIndex = 4;
            // 
            // dtpDateDevis
            // 
            this.dtpDateDevis.Location = new System.Drawing.Point(284, 42);
            this.dtpDateDevis.Name = "dtpDateDevis";
            this.dtpDateDevis.Size = new System.Drawing.Size(135, 22);
            this.dtpDateDevis.TabIndex = 1;
            this.dtpDateDevis.ValueChanged += new System.EventHandler(this.dtpDateDevis_ValueChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(19, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(132, 22);
            this.txtCode.TabIndex = 0;
            // 
            // FrmDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 675);
            this.Controls.Add(this.gpDevis);
            this.Controls.Add(this.btnNewDevis);
            this.Controls.Add(this.dtgDevis);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDevis";
            this.Text = "Devis form";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevis)).EndInit();
            this.gpDevis.ResumeLayout(false);
            this.gpDevis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevisModify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDevis;
        private System.Windows.Forms.Button btnNewDevis;
        private System.Windows.Forms.GroupBox gpDevis;
        private System.Windows.Forms.TextBox txtTauxTva;
        private System.Windows.Forms.DateTimePicker dtpDateDevis;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtMontantHTAR;
        private System.Windows.Forms.TextBox txtMontantHTHR;
        private System.Windows.Forms.TextBox txtMontantTtc;
        private System.Windows.Forms.TextBox txtMontantTva;
        private System.Windows.Forms.Button btnModifyDevis;
        private System.Windows.Forms.Button btnSupDevis;
        private System.Windows.Forms.DataGridView dtgDevisModify;
        private System.Windows.Forms.TextBox txtTauxRemise;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbStatutDevis;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtQuantité;
        private System.Windows.Forms.Label lblQuantité;
        private System.Windows.Forms.Label lblAddProduit;
        private System.Windows.Forms.ComboBox cmbAddProduit;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTauxRemise;
        private System.Windows.Forms.Label lblTauxTva;
        private System.Windows.Forms.Label lblMontantHorsRemise;
        private System.Windows.Forms.Label lblMontantTTC;
        private System.Windows.Forms.Label lblMontantTVA;
        private System.Windows.Forms.Label lblMHTAR;
        private System.Windows.Forms.Button btnCancelDevis;
        private System.Windows.Forms.Button btnAddDevis;
        private System.Windows.Forms.Label lblErrorAdd;
    }
}