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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.lblFaxCli = new System.Windows.Forms.Label();
            this.txtNumFax = new System.Windows.Forms.TextBox();
            this.lblMailCli = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblCodeCli = new System.Windows.Forms.Label();
            this.txtCodeCli = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.generalMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGeneralMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCustomer.GridColor = System.Drawing.Color.Black;
            this.dtgCustomer.Location = new System.Drawing.Point(8, 9);
            this.dtgCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCustomer.Name = "dtgCustomer";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCustomer.RowHeadersWidth = 82;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dtgCustomer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCustomer.RowTemplate.Height = 33;
            this.dtgCustomer.Size = new System.Drawing.Size(1330, 364);
            this.dtgCustomer.TabIndex = 0;
            this.dtgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellContentClick);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1099, 583);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.Location = new System.Drawing.Point(68, 417);
            this.lblNomCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(78, 13);
            this.lblNomCli.TabIndex = 2;
            this.lblNomCli.Text = "Nom du client :";
            this.lblNomCli.Click += new System.EventHandler(this.lblNomCli_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(154, 414);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(146, 20);
            this.txtNom.TabIndex = 3;
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(179, 455);
            this.txtNumTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(121, 20);
            this.txtNumTel.TabIndex = 4;
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Location = new System.Drawing.Point(51, 455);
            this.lblNumTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(115, 13);
            this.lblNumTel.TabIndex = 5;
            this.lblNumTel.Text = "Numéro de téléphone :";
            // 
            // lblFaxCli
            // 
            this.lblFaxCli.AutoSize = true;
            this.lblFaxCli.Location = new System.Drawing.Point(68, 500);
            this.lblFaxCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFaxCli.Name = "lblFaxCli";
            this.lblFaxCli.Size = new System.Drawing.Size(82, 13);
            this.lblFaxCli.TabIndex = 6;
            this.lblFaxCli.Text = "Numéro de fax :";
            // 
            // txtNumFax
            // 
            this.txtNumFax.Location = new System.Drawing.Point(179, 496);
            this.txtNumFax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumFax.Name = "txtNumFax";
            this.txtNumFax.Size = new System.Drawing.Size(121, 20);
            this.txtNumFax.TabIndex = 7;
            // 
            // lblMailCli
            // 
            this.lblMailCli.AutoSize = true;
            this.lblMailCli.Location = new System.Drawing.Point(68, 537);
            this.lblMailCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMailCli.Name = "lblMailCli";
            this.lblMailCli.Size = new System.Drawing.Size(77, 13);
            this.lblMailCli.TabIndex = 8;
            this.lblMailCli.Text = "adresse email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(179, 537);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblAdresseLivr
            // 
            this.lblAdresseLivr.AutoSize = true;
            this.lblAdresseLivr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdresseLivr.Location = new System.Drawing.Point(467, 384);
            this.lblAdresseLivr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresseLivr.Name = "lblAdresseLivr";
            this.lblAdresseLivr.Size = new System.Drawing.Size(101, 13);
            this.lblAdresseLivr.TabIndex = 10;
            this.lblAdresseLivr.Text = "Adresse de livraison";
            // 
            // txtNumRue
            // 
            this.txtNumRue.Location = new System.Drawing.Point(509, 417);
            this.txtNumRue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumRue.Name = "txtNumRue";
            this.txtNumRue.Size = new System.Drawing.Size(146, 20);
            this.txtNumRue.TabIndex = 11;
            // 
            // lblNumRueLivr
            // 
            this.lblNumRueLivr.AutoSize = true;
            this.lblNumRueLivr.Location = new System.Drawing.Point(401, 419);
            this.lblNumRueLivr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumRueLivr.Name = "lblNumRueLivr";
            this.lblNumRueLivr.Size = new System.Drawing.Size(83, 13);
            this.lblNumRueLivr.TabIndex = 12;
            this.lblNumRueLivr.Text = "Numéro de rue :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 457);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom de la rue :";
            // 
            // txtNomRueLivr
            // 
            this.txtNomRueLivr.Location = new System.Drawing.Point(509, 455);
            this.txtNomRueLivr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomRueLivr.Name = "txtNomRueLivr";
            this.txtNomRueLivr.Size = new System.Drawing.Size(146, 20);
            this.txtNomRueLivr.TabIndex = 14;
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(401, 498);
            this.lblCodePostal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(69, 13);
            this.lblCodePostal.TabIndex = 15;
            this.lblCodePostal.Text = "Code postal :";
            // 
            // txtCodePostalLivr
            // 
            this.txtCodePostalLivr.Location = new System.Drawing.Point(509, 493);
            this.txtCodePostalLivr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodePostalLivr.Name = "txtCodePostalLivr";
            this.txtCodePostalLivr.Size = new System.Drawing.Size(146, 20);
            this.txtCodePostalLivr.TabIndex = 16;
            this.txtCodePostalLivr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodePostalLivr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblVilleLivr
            // 
            this.lblVilleLivr.AutoSize = true;
            this.lblVilleLivr.Location = new System.Drawing.Point(401, 540);
            this.lblVilleLivr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVilleLivr.Name = "lblVilleLivr";
            this.lblVilleLivr.Size = new System.Drawing.Size(32, 13);
            this.lblVilleLivr.TabIndex = 17;
            this.lblVilleLivr.Text = "Ville :";
            // 
            // txtVilleLivr
            // 
            this.txtVilleLivr.Location = new System.Drawing.Point(509, 532);
            this.txtVilleLivr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVilleLivr.Name = "txtVilleLivr";
            this.txtVilleLivr.Size = new System.Drawing.Size(146, 20);
            this.txtVilleLivr.TabIndex = 18;
            this.txtVilleLivr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVilleFact
            // 
            this.txtVilleFact.Location = new System.Drawing.Point(1005, 535);
            this.txtVilleFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVilleFact.Name = "txtVilleFact";
            this.txtVilleFact.Size = new System.Drawing.Size(146, 20);
            this.txtVilleFact.TabIndex = 26;
            this.txtVilleFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVilleFact
            // 
            this.lblVilleFact.AutoSize = true;
            this.lblVilleFact.Location = new System.Drawing.Point(897, 542);
            this.lblVilleFact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVilleFact.Name = "lblVilleFact";
            this.lblVilleFact.Size = new System.Drawing.Size(32, 13);
            this.lblVilleFact.TabIndex = 25;
            this.lblVilleFact.Text = "Ville :";
            // 
            // txtCodePostalFact
            // 
            this.txtCodePostalFact.Location = new System.Drawing.Point(1005, 496);
            this.txtCodePostalFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodePostalFact.Name = "txtCodePostalFact";
            this.txtCodePostalFact.Size = new System.Drawing.Size(146, 20);
            this.txtCodePostalFact.TabIndex = 24;
            this.txtCodePostalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodePostalFact
            // 
            this.lblCodePostalFact.AutoSize = true;
            this.lblCodePostalFact.Location = new System.Drawing.Point(897, 500);
            this.lblCodePostalFact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodePostalFact.Name = "lblCodePostalFact";
            this.lblCodePostalFact.Size = new System.Drawing.Size(69, 13);
            this.lblCodePostalFact.TabIndex = 23;
            this.lblCodePostalFact.Text = "Code postal :";
            // 
            // txtNomRueFact
            // 
            this.txtNomRueFact.Location = new System.Drawing.Point(1005, 457);
            this.txtNomRueFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomRueFact.Name = "txtNomRueFact";
            this.txtNomRueFact.Size = new System.Drawing.Size(146, 20);
            this.txtNomRueFact.TabIndex = 22;
            // 
            // lblNomRue
            // 
            this.lblNomRue.AutoSize = true;
            this.lblNomRue.Location = new System.Drawing.Point(897, 460);
            this.lblNomRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomRue.Name = "lblNomRue";
            this.lblNomRue.Size = new System.Drawing.Size(79, 13);
            this.lblNomRue.TabIndex = 21;
            this.lblNomRue.Text = "Nom de la rue :";
            // 
            // lblNumRue
            // 
            this.lblNumRue.AutoSize = true;
            this.lblNumRue.Location = new System.Drawing.Point(897, 422);
            this.lblNumRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumRue.Name = "lblNumRue";
            this.lblNumRue.Size = new System.Drawing.Size(83, 13);
            this.lblNumRue.TabIndex = 20;
            this.lblNumRue.Text = "Numéro de rue :";
            // 
            // txtNumRueFact
            // 
            this.txtNumRueFact.Location = new System.Drawing.Point(1005, 419);
            this.txtNumRueFact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumRueFact.Name = "txtNumRueFact";
            this.txtNumRueFact.Size = new System.Drawing.Size(146, 20);
            this.txtNumRueFact.TabIndex = 19;
            // 
            // lblAdresseFact
            // 
            this.lblAdresseFact.AutoSize = true;
            this.lblAdresseFact.ForeColor = System.Drawing.Color.White;
            this.lblAdresseFact.Location = new System.Drawing.Point(980, 384);
            this.lblAdresseFact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresseFact.Name = "lblAdresseFact";
            this.lblAdresseFact.Size = new System.Drawing.Size(113, 13);
            this.lblAdresseFact.TabIndex = 27;
            this.lblAdresseFact.Text = "Adresse de facturation";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSupprimer.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimer.Location = new System.Drawing.Point(409, 587);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(116, 22);
            this.btnSupprimer.TabIndex = 28;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.SpringGreen;
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(560, 587);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(116, 22);
            this.btnModifier.TabIndex = 29;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(710, 587);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(116, 22);
            this.btnAjouter.TabIndex = 30;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblCodeCli
            // 
            this.lblCodeCli.AutoSize = true;
            this.lblCodeCli.Location = new System.Drawing.Point(66, 389);
            this.lblCodeCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeCli.Name = "lblCodeCli";
            this.lblCodeCli.Size = new System.Drawing.Size(66, 13);
            this.lblCodeCli.TabIndex = 31;
            this.lblCodeCli.Text = "Code client :";
            this.lblCodeCli.Click += new System.EventHandler(this.lblCodeCli_Click);
            // 
            // txtCodeCli
            // 
            this.txtCodeCli.Location = new System.Drawing.Point(154, 386);
            this.txtCodeCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodeCli.Name = "txtCodeCli";
            this.txtCodeCli.Size = new System.Drawing.Size(146, 20);
            this.txtCodeCli.TabIndex = 32;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(895, 587);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 33;
            // 
            // generalMessage
            // 
            this.generalMessage.AutoSize = true;
            this.generalMessage.Location = new System.Drawing.Point(406, 627);
            this.generalMessage.Name = "generalMessage";
            this.generalMessage.Size = new System.Drawing.Size(0, 13);
            this.generalMessage.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "label2";
            // 
            // lblGeneralMessage
            // 
            this.lblGeneralMessage.AutoSize = true;
            this.lblGeneralMessage.Location = new System.Drawing.Point(560, 627);
            this.lblGeneralMessage.Name = "lblGeneralMessage";
            this.lblGeneralMessage.Size = new System.Drawing.Size(0, 13);
            this.lblGeneralMessage.TabIndex = 36;
            // 
            // FrmViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1426, 649);
            this.Controls.Add(this.lblGeneralMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generalMessage);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCodeCli);
            this.Controls.Add(this.lblCodeCli);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
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
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblMailCli);
            this.Controls.Add(this.txtNumFax);
            this.Controls.Add(this.lblFaxCli);
            this.Controls.Add(this.lblNumTel);
            this.Controls.Add(this.txtNumTel);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNomCli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgCustomer);
            this.ForeColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.TextBox txtNumFax;
        private System.Windows.Forms.Label lblMailCli;
        private System.Windows.Forms.TextBox txtEmail;
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
        private System.Windows.Forms.Button btnSupprimer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblCodeCli;
        private System.Windows.Forms.TextBox txtCodeCli;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label generalMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGeneralMessage;
    }
}