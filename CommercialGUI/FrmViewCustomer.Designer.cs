namespace CommercialGUI
{
    partial class FrmViewCustomer
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
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.lblFaxCli = new System.Windows.Forms.Label();
            this.txtNumFaX = new System.Windows.Forms.TextBox();
            this.lblMailCli = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblAdresseLivr = new System.Windows.Forms.Label();
            this.txtNumRue = new System.Windows.Forms.TextBox();
            this.lblNumRueLivr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomRueLivr = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.txtCodePostalLivr = new System.Windows.Forms.TextBox();
            this.lblVilleLivr = new System.Windows.Forms.Label();
            this.txtVilleLivr = new System.Windows.Forms.TextBox();
            this.txtVilleFact = new System.Windows.Forms.TextBox();
            this.lblVilleFact = new System.Windows.Forms.Label();
            this.txtCodePostalFact = new System.Windows.Forms.TextBox();
            this.lblCodePostalFact = new System.Windows.Forms.Label();
            this.txtNomRueFact = new System.Windows.Forms.TextBox();
            this.lblNomRue = new System.Windows.Forms.Label();
            this.lblNumRue = new System.Windows.Forms.Label();
            this.txtNumRueFact = new System.Windows.Forms.TextBox();
            this.lblAdresseFact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(11, 11);
            this.dtgCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 82;
            this.dtgCustomer.RowTemplate.Height = 33;
            this.dtgCustomer.Size = new System.Drawing.Size(1773, 448);
            this.dtgCustomer.TabIndex = 0;
            this.dtgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1588, 717);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.Location = new System.Drawing.Point(90, 513);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(94, 16);
            this.lblNomCli.TabIndex = 2;
            this.lblNomCli.Text = "Nom du client :";
            this.lblNomCli.Click += new System.EventHandler(this.lblNomCli_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(205, 510);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(194, 22);
            this.txtNom.TabIndex = 3;
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(239, 560);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(160, 22);
            this.txtNumTel.TabIndex = 4;
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Location = new System.Drawing.Point(90, 566);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(143, 16);
            this.lblNumTel.TabIndex = 5;
            this.lblNumTel.Text = "Numéro de téléphone :";
            // 
            // lblFaxCli
            // 
            this.lblFaxCli.AutoSize = true;
            this.lblFaxCli.Location = new System.Drawing.Point(90, 616);
            this.lblFaxCli.Name = "lblFaxCli";
            this.lblFaxCli.Size = new System.Drawing.Size(100, 16);
            this.lblFaxCli.TabIndex = 6;
            this.lblFaxCli.Text = "Numéro de fax :";
            // 
            // txtNumFaX
            // 
            this.txtNumFaX.Location = new System.Drawing.Point(239, 610);
            this.txtNumFaX.Name = "txtNumFaX";
            this.txtNumFaX.Size = new System.Drawing.Size(160, 22);
            this.txtNumFaX.TabIndex = 7;
            // 
            // lblMailCli
            // 
            this.lblMailCli.AutoSize = true;
            this.lblMailCli.Location = new System.Drawing.Point(90, 661);
            this.lblMailCli.Name = "lblMailCli";
            this.lblMailCli.Size = new System.Drawing.Size(99, 16);
            this.lblMailCli.TabIndex = 8;
            this.lblMailCli.Text = "adresse email :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(239, 661);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 22);
            this.textBox4.TabIndex = 9;
            // 
            // lblAdresseLivr
            // 
            this.lblAdresseLivr.AutoSize = true;
            this.lblAdresseLivr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdresseLivr.Location = new System.Drawing.Point(623, 473);
            this.lblAdresseLivr.Name = "lblAdresseLivr";
            this.lblAdresseLivr.Size = new System.Drawing.Size(130, 16);
            this.lblAdresseLivr.TabIndex = 10;
            this.lblAdresseLivr.Text = "Adresse de livraison";
            // 
            // txtNumRue
            // 
            this.txtNumRue.Location = new System.Drawing.Point(679, 513);
            this.txtNumRue.Name = "txtNumRue";
            this.txtNumRue.Size = new System.Drawing.Size(194, 22);
            this.txtNumRue.TabIndex = 11;
            // 
            // lblNumRueLivr
            // 
            this.lblNumRueLivr.AutoSize = true;
            this.lblNumRueLivr.Location = new System.Drawing.Point(535, 516);
            this.lblNumRueLivr.Name = "lblNumRueLivr";
            this.lblNumRueLivr.Size = new System.Drawing.Size(102, 16);
            this.lblNumRueLivr.TabIndex = 12;
            this.lblNumRueLivr.Text = "Numéro de rue :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom de la rue :";
            // 
            // txtNomRueLivr
            // 
            this.txtNomRueLivr.Location = new System.Drawing.Point(679, 560);
            this.txtNomRueLivr.Name = "txtNomRueLivr";
            this.txtNomRueLivr.Size = new System.Drawing.Size(194, 22);
            this.txtNomRueLivr.TabIndex = 14;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(535, 613);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(86, 16);
            this.lblCodePostal.TabIndex = 15;
            this.lblCodePostal.Text = "Code postal :";
            // 
            // txtCodePostalLivr
            // 
            this.txtCodePostalLivr.Location = new System.Drawing.Point(679, 607);
            this.txtCodePostalLivr.Name = "txtCodePostalLivr";
            this.txtCodePostalLivr.Size = new System.Drawing.Size(194, 22);
            this.txtCodePostalLivr.TabIndex = 16;
            this.txtCodePostalLivr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodePostalLivr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblVilleLivr
            // 
            this.lblVilleLivr.AutoSize = true;
            this.lblVilleLivr.Location = new System.Drawing.Point(535, 664);
            this.lblVilleLivr.Name = "lblVilleLivr";
            this.lblVilleLivr.Size = new System.Drawing.Size(39, 16);
            this.lblVilleLivr.TabIndex = 17;
            this.lblVilleLivr.Text = "Ville :";
            // 
            // txtVilleLivr
            // 
            this.txtVilleLivr.Location = new System.Drawing.Point(679, 655);
            this.txtVilleLivr.Name = "txtVilleLivr";
            this.txtVilleLivr.Size = new System.Drawing.Size(194, 22);
            this.txtVilleLivr.TabIndex = 18;
            this.txtVilleLivr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVilleFact
            // 
            this.txtVilleFact.Location = new System.Drawing.Point(1340, 658);
            this.txtVilleFact.Name = "txtVilleFact";
            this.txtVilleFact.Size = new System.Drawing.Size(194, 22);
            this.txtVilleFact.TabIndex = 26;
            this.txtVilleFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVilleFact
            // 
            this.lblVilleFact.AutoSize = true;
            this.lblVilleFact.Location = new System.Drawing.Point(1196, 667);
            this.lblVilleFact.Name = "lblVilleFact";
            this.lblVilleFact.Size = new System.Drawing.Size(39, 16);
            this.lblVilleFact.TabIndex = 25;
            this.lblVilleFact.Text = "Ville :";
            // 
            // txtCodePostalFact
            // 
            this.txtCodePostalFact.Location = new System.Drawing.Point(1340, 610);
            this.txtCodePostalFact.Name = "txtCodePostalFact";
            this.txtCodePostalFact.Size = new System.Drawing.Size(194, 22);
            this.txtCodePostalFact.TabIndex = 24;
            this.txtCodePostalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodePostalFact
            // 
            this.lblCodePostalFact.AutoSize = true;
            this.lblCodePostalFact.Location = new System.Drawing.Point(1196, 616);
            this.lblCodePostalFact.Name = "lblCodePostalFact";
            this.lblCodePostalFact.Size = new System.Drawing.Size(86, 16);
            this.lblCodePostalFact.TabIndex = 23;
            this.lblCodePostalFact.Text = "Code postal :";
            // 
            // txtNomRueFact
            // 
            this.txtNomRueFact.Location = new System.Drawing.Point(1340, 563);
            this.txtNomRueFact.Name = "txtNomRueFact";
            this.txtNomRueFact.Size = new System.Drawing.Size(194, 22);
            this.txtNomRueFact.TabIndex = 22;
            // 
            // lblNomRue
            // 
            this.lblNomRue.AutoSize = true;
            this.lblNomRue.Location = new System.Drawing.Point(1196, 566);
            this.lblNomRue.Name = "lblNomRue";
            this.lblNomRue.Size = new System.Drawing.Size(97, 16);
            this.lblNomRue.TabIndex = 21;
            this.lblNomRue.Text = "Nom de la rue :";
            // 
            // lblNumRue
            // 
            this.lblNumRue.AutoSize = true;
            this.lblNumRue.Location = new System.Drawing.Point(1196, 519);
            this.lblNumRue.Name = "lblNumRue";
            this.lblNumRue.Size = new System.Drawing.Size(102, 16);
            this.lblNumRue.TabIndex = 20;
            this.lblNumRue.Text = "Numéro de rue :";
            // 
            // txtNumRueFact
            // 
            this.txtNumRueFact.Location = new System.Drawing.Point(1340, 516);
            this.txtNumRueFact.Name = "txtNumRueFact";
            this.txtNumRueFact.Size = new System.Drawing.Size(194, 22);
            this.txtNumRueFact.TabIndex = 19;
            // 
            // lblAdresseFact
            // 
            this.lblAdresseFact.AutoSize = true;
            this.lblAdresseFact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdresseFact.Location = new System.Drawing.Point(1306, 473);
            this.lblAdresseFact.Name = "lblAdresseFact";
            this.lblAdresseFact.Size = new System.Drawing.Size(141, 16);
            this.lblAdresseFact.TabIndex = 27;
            this.lblAdresseFact.Text = "Adresse de facturation";
            // 
            // FrmViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 768);
            this.Controls.Add(this.lblAdresseFact);
            this.Controls.Add(this.txtVilleFact);
            this.Controls.Add(this.lblVilleFact);
            this.Controls.Add(this.txtCodePostalFact);
            this.Controls.Add(this.lblCodePostalFact);
            this.Controls.Add(this.txtNomRueFact);
            this.Controls.Add(this.lblNomRue);
            this.Controls.Add(this.lblNumRue);
            this.Controls.Add(this.txtNumRueFact);
            this.Controls.Add(this.txtVilleLivr);
            this.Controls.Add(this.lblVilleLivr);
            this.Controls.Add(this.txtCodePostalLivr);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.txtNomRueLivr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumRueLivr);
            this.Controls.Add(this.txtNumRue);
            this.Controls.Add(this.lblAdresseLivr);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblMailCli);
            this.Controls.Add(this.txtNumFaX);
            this.Controls.Add(this.lblFaxCli);
            this.Controls.Add(this.lblNumTel);
            this.Controls.Add(this.txtNumTel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNomCli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgCustomer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmViewCustomer";
            this.Text = "FrmViewCustomer";
            this.Load += new System.EventHandler(this.FrmViewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNomCli;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.Label lblNumTel;
        private System.Windows.Forms.Label lblFaxCli;
        private System.Windows.Forms.TextBox txtNumFaX;
        private System.Windows.Forms.Label lblMailCli;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblAdresseLivr;
        private System.Windows.Forms.TextBox txtNumRue;
        private System.Windows.Forms.Label lblNumRueLivr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomRueLivr;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.TextBox txtCodePostalLivr;
        private System.Windows.Forms.Label lblVilleLivr;
        private System.Windows.Forms.TextBox txtVilleLivr;
        private System.Windows.Forms.TextBox txtVilleFact;
        private System.Windows.Forms.Label lblVilleFact;
        private System.Windows.Forms.TextBox txtCodePostalFact;
        private System.Windows.Forms.Label lblCodePostalFact;
        private System.Windows.Forms.TextBox txtNomRueFact;
        private System.Windows.Forms.Label lblNomRue;
        private System.Windows.Forms.Label lblNumRue;
        private System.Windows.Forms.TextBox txtNumRueFact;
        private System.Windows.Forms.Label lblAdresseFact;
    }
}