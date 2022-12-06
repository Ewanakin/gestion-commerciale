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
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbStatutDevis = new System.Windows.Forms.ComboBox();
            this.lblStatut = new System.Windows.Forms.Label();
            this.cmbAddProduit = new System.Windows.Forms.ComboBox();
            this.lblAddProduit = new System.Windows.Forms.Label();
            this.lblQuantité = new System.Windows.Forms.Label();
            this.txtQuantité = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTauxTva = new System.Windows.Forms.Label();
            this.lblTauxRemise = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevis)).BeginInit();
            this.gpDevis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevisModify)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDevis
            // 
            this.dtgDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevis.Location = new System.Drawing.Point(20, 20);
            this.dtgDevis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgDevis.Name = "dtgDevis";
            this.dtgDevis.RowHeadersWidth = 51;
            this.dtgDevis.RowTemplate.Height = 24;
            this.dtgDevis.Size = new System.Drawing.Size(1364, 897);
            this.dtgDevis.TabIndex = 0;
            this.dtgDevis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDevis_CellContentClick);
            // 
            // btnNewDevis
            // 
            this.btnNewDevis.Location = new System.Drawing.Point(1519, 20);
            this.btnNewDevis.Name = "btnNewDevis";
            this.btnNewDevis.Size = new System.Drawing.Size(223, 81);
            this.btnNewDevis.TabIndex = 1;
            this.btnNewDevis.Text = "Nouveau";
            this.btnNewDevis.UseVisualStyleBackColor = true;
            // 
            // gpDevis
            // 
            this.gpDevis.Controls.Add(this.lblTauxRemise);
            this.gpDevis.Controls.Add(this.lblTauxTva);
            this.gpDevis.Controls.Add(this.lblCode);
            this.gpDevis.Controls.Add(this.lblDate);
            this.gpDevis.Controls.Add(this.button1);
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
            this.gpDevis.ForeColor = System.Drawing.Color.Coral;
            this.gpDevis.Location = new System.Drawing.Point(1519, 155);
            this.gpDevis.Name = "gpDevis";
            this.gpDevis.Size = new System.Drawing.Size(713, 1302);
            this.gpDevis.TabIndex = 2;
            this.gpDevis.TabStop = false;
            this.gpDevis.Text = "Details";
            this.gpDevis.Enter += new System.EventHandler(this.gpDevis_Enter);
            // 
            // txtMontantHTAR
            // 
            this.txtMontantHTAR.Location = new System.Drawing.Point(394, 928);
            this.txtMontantHTAR.Name = "txtMontantHTAR";
            this.txtMontantHTAR.Size = new System.Drawing.Size(252, 31);
            this.txtMontantHTAR.TabIndex = 10;
            this.txtMontantHTAR.Text = "Montant HT avec remise";
            // 
            // txtMontantHTHR
            // 
            this.txtMontantHTHR.Location = new System.Drawing.Point(27, 928);
            this.txtMontantHTHR.Name = "txtMontantHTHR";
            this.txtMontantHTHR.Size = new System.Drawing.Size(273, 31);
            this.txtMontantHTHR.TabIndex = 9;
            this.txtMontantHTHR.Text = "Montant HT Hors Remise";
            // 
            // txtMontantTtc
            // 
            this.txtMontantTtc.Location = new System.Drawing.Point(394, 979);
            this.txtMontantTtc.Name = "txtMontantTtc";
            this.txtMontantTtc.Size = new System.Drawing.Size(252, 31);
            this.txtMontantTtc.TabIndex = 8;
            this.txtMontantTtc.Text = "Montant TTC";
            // 
            // txtMontantTva
            // 
            this.txtMontantTva.Location = new System.Drawing.Point(27, 979);
            this.txtMontantTva.Name = "txtMontantTva";
            this.txtMontantTva.Size = new System.Drawing.Size(273, 31);
            this.txtMontantTva.TabIndex = 7;
            this.txtMontantTva.Text = "Montant TVA";
            // 
            // btnModifyDevis
            // 
            this.btnModifyDevis.Location = new System.Drawing.Point(192, 1088);
            this.btnModifyDevis.Name = "btnModifyDevis";
            this.btnModifyDevis.Size = new System.Drawing.Size(223, 81);
            this.btnModifyDevis.TabIndex = 6;
            this.btnModifyDevis.Text = "Modifier";
            this.btnModifyDevis.UseVisualStyleBackColor = true;
            // 
            // btnSupDevis
            // 
            this.btnSupDevis.Location = new System.Drawing.Point(455, 1088);
            this.btnSupDevis.Name = "btnSupDevis";
            this.btnSupDevis.Size = new System.Drawing.Size(223, 81);
            this.btnSupDevis.TabIndex = 3;
            this.btnSupDevis.Text = "Supprimer";
            this.btnSupDevis.UseVisualStyleBackColor = true;
            // 
            // dtgDevisModify
            // 
            this.dtgDevisModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevisModify.Location = new System.Drawing.Point(27, 420);
            this.dtgDevisModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgDevisModify.Name = "dtgDevisModify";
            this.dtgDevisModify.RowHeadersWidth = 51;
            this.dtgDevisModify.RowTemplate.Height = 24;
            this.dtgDevisModify.Size = new System.Drawing.Size(651, 469);
            this.dtgDevisModify.TabIndex = 3;
            // 
            // txtTauxRemise
            // 
            this.txtTauxRemise.Location = new System.Drawing.Point(426, 205);
            this.txtTauxRemise.Name = "txtTauxRemise";
            this.txtTauxRemise.Size = new System.Drawing.Size(196, 31);
            this.txtTauxRemise.TabIndex = 5;
            // 
            // txtTauxTva
            // 
            this.txtTauxTva.Location = new System.Drawing.Point(27, 205);
            this.txtTauxTva.Name = "txtTauxTva";
            this.txtTauxTva.Size = new System.Drawing.Size(196, 31);
            this.txtTauxTva.TabIndex = 4;
            // 
            // dtpDateDevis
            // 
            this.dtpDateDevis.Location = new System.Drawing.Point(426, 66);
            this.dtpDateDevis.Name = "dtpDateDevis";
            this.dtpDateDevis.Size = new System.Drawing.Size(200, 31);
            this.dtpDateDevis.TabIndex = 1;
            this.dtpDateDevis.ValueChanged += new System.EventHandler(this.dtpDateDevis_ValueChanged);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(27, 66);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(196, 31);
            this.txtCode.TabIndex = 0;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(22, 100);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(67, 25);
            this.lblClient.TabIndex = 12;
            this.lblClient.Text = "Client";
            this.lblClient.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(27, 128);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(196, 33);
            this.cmbClient.TabIndex = 13;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbStatutDevis
            // 
            this.cmbStatutDevis.AccessibleName = "lblStatus";
            this.cmbStatutDevis.FormattingEnabled = true;
            this.cmbStatutDevis.Location = new System.Drawing.Point(426, 128);
            this.cmbStatutDevis.Name = "cmbStatutDevis";
            this.cmbStatutDevis.Size = new System.Drawing.Size(200, 33);
            this.cmbStatutDevis.TabIndex = 15;
            this.cmbStatutDevis.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblStatut
            // 
            this.lblStatut.AccessibleName = "";
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(421, 100);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(68, 25);
            this.lblStatut.TabIndex = 14;
            this.lblStatut.Text = "Statut";
            this.lblStatut.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbAddProduit
            // 
            this.cmbAddProduit.FormattingEnabled = true;
            this.cmbAddProduit.Location = new System.Drawing.Point(27, 314);
            this.cmbAddProduit.Name = "cmbAddProduit";
            this.cmbAddProduit.Size = new System.Drawing.Size(299, 33);
            this.cmbAddProduit.TabIndex = 16;
            this.cmbAddProduit.SelectedIndexChanged += new System.EventHandler(this.cmbAddProduit_SelectedIndexChanged);
            // 
            // lblAddProduit
            // 
            this.lblAddProduit.AutoSize = true;
            this.lblAddProduit.Location = new System.Drawing.Point(22, 269);
            this.lblAddProduit.Name = "lblAddProduit";
            this.lblAddProduit.Size = new System.Drawing.Size(182, 25);
            this.lblAddProduit.TabIndex = 17;
            this.lblAddProduit.Text = "Ajouter un produit";
            // 
            // lblQuantité
            // 
            this.lblQuantité.AutoSize = true;
            this.lblQuantité.Location = new System.Drawing.Point(355, 269);
            this.lblQuantité.Name = "lblQuantité";
            this.lblQuantité.Size = new System.Drawing.Size(89, 25);
            this.lblQuantité.TabIndex = 18;
            this.lblQuantité.Text = "quantité";
            // 
            // txtQuantité
            // 
            this.txtQuantité.Location = new System.Drawing.Point(360, 316);
            this.txtQuantité.Name = "txtQuantité";
            this.txtQuantité.Size = new System.Drawing.Size(134, 31);
            this.txtQuantité.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AccessibleName = "";
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(421, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Date";
            // 
            // lblCode
            // 
            this.lblCode.AccessibleName = "";
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(22, 38);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(63, 25);
            this.lblCode.TabIndex = 21;
            this.lblCode.Text = "Code";
            // 
            // lblTauxTva
            // 
            this.lblTauxTva.AutoSize = true;
            this.lblTauxTva.Location = new System.Drawing.Point(22, 177);
            this.lblTauxTva.Name = "lblTauxTva";
            this.lblTauxTva.Size = new System.Drawing.Size(107, 25);
            this.lblTauxTva.TabIndex = 22;
            this.lblTauxTva.Text = "Taux TVA";
            // 
            // lblTauxRemise
            // 
            this.lblTauxRemise.AutoSize = true;
            this.lblTauxRemise.Location = new System.Drawing.Point(421, 177);
            this.lblTauxRemise.Name = "lblTauxRemise";
            this.lblTauxRemise.Size = new System.Drawing.Size(138, 25);
            this.lblTauxRemise.TabIndex = 23;
            this.lblTauxRemise.Text = "Taux Remise";
            // 
            // FrmDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2552, 1811);
            this.Controls.Add(this.gpDevis);
            this.Controls.Add(this.btnNewDevis);
            this.Controls.Add(this.dtgDevis);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtQuantité;
        private System.Windows.Forms.Label lblQuantité;
        private System.Windows.Forms.Label lblAddProduit;
        private System.Windows.Forms.ComboBox cmbAddProduit;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTauxRemise;
        private System.Windows.Forms.Label lblTauxTva;
    }
}