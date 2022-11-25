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
            this.btnPro = new System.Windows.Forms.Button();
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
            this.dtgCustomer.Location = new System.Drawing.Point(11, 11);
            this.dtgCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.dtgCustomer.Size = new System.Drawing.Size(1773, 448);
            this.dtgCustomer.TabIndex = 0;
            this.dtgCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellContentClick);
            // 
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPro.ForeColor = System.Drawing.Color.Lime;
            this.btnPro.Location = new System.Drawing.Point(17, 742);
            this.btnPro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(195, 39);
            this.btnPro.TabIndex = 1;
            this.btnPro.Text = "vers produit >";
            this.btnPro.UseVisualStyleBackColor = false;
            this.btnPro.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.Location = new System.Drawing.Point(91, 513);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(94, 16);
            this.lblNomCli.TabIndex = 2;
            this.lblNomCli.Text = "Nom du client :";
            this.lblNomCli.Click += new System.EventHandler(this.lblNomCli_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(205, 510);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(193, 22);
            this.txtNom.TabIndex = 3;
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(239, 560);
            this.txtNumTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(160, 22);
            this.txtNumTel.TabIndex = 4;
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Location = new System.Drawing.Point(68, 560);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(143, 16);
            this.lblNumTel.TabIndex = 5;
            this.lblNumTel.Text = "Numéro de téléphone :";
            // 
            // lblFaxCli
            // 
            this.lblFaxCli.AutoSize = true;
            this.lblFaxCli.Location = new System.Drawing.Point(91, 615);
            this.lblFaxCli.Name = "lblFaxCli";
            this.lblFaxCli.Size = new System.Drawing.Size(100, 16);
            this.lblFaxCli.TabIndex = 6;
            this.lblFaxCli.Text = "Numéro de fax :";
            // 
            // txtNumFax
            // 
            this.txtNumFax.Location = new System.Drawing.Point(239, 610);
            this.txtNumFax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumFax.Name = "txtNumFax";
            this.txtNumFax.Size = new System.Drawing.Size(160, 22);
            this.txtNumFax.TabIndex = 7;
            // 
            // lblMailCli
            // 
            this.lblMailCli.AutoSize = true;
            this.lblMailCli.Location = new System.Drawing.Point(91, 661);
            this.lblMailCli.Name = "lblMailCli";
            this.lblMailCli.Size = new System.Drawing.Size(99, 16);
            this.lblMailCli.TabIndex = 8;
            this.lblMailCli.Text = "adresse email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(239, 661);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // lblAdresseLivr
            // 
            this.lblAdresseLivr.AutoSize = true;
            this.lblAdresseLivr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdresseLivr.Location = new System.Drawing.Point(623, 473);
            this.lblAdresseLivr.Name = "lblAdresseLivr";
            this.lblAdresseLivr.Size = new System.Drawing.Size(130, 16);
            this.lblAdresseLivr.TabIndex = 10;
            this.lblAdresseLivr.Text = "Adresse de livraison";
            // 
            // txtNumRue
            // 
            this.txtNumRue.Location = new System.Drawing.Point(679, 513);
            this.txtNumRue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumRue.Name = "txtNumRue";
            this.txtNumRue.Size = new System.Drawing.Size(193, 22);
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
            this.label1.Location = new System.Drawing.Point(535, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom de la rue :";
            // 
            // txtNomRueLivr
            // 
            this.txtNomRueLivr.Location = new System.Drawing.Point(679, 560);
            this.txtNomRueLivr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomRueLivr.Name = "txtNomRueLivr";
            this.txtNomRueLivr.Size = new System.Drawing.Size(193, 22);
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
            this.txtCodePostalLivr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodePostalLivr.Name = "txtCodePostalLivr";
            this.txtCodePostalLivr.Size = new System.Drawing.Size(193, 22);
            this.txtCodePostalLivr.TabIndex = 16;
            this.txtCodePostalLivr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodePostalLivr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblVilleLivr
            // 
            this.lblVilleLivr.AutoSize = true;
            this.lblVilleLivr.Location = new System.Drawing.Point(535, 665);
            this.lblVilleLivr.Name = "lblVilleLivr";
            this.lblVilleLivr.Size = new System.Drawing.Size(39, 16);
            this.lblVilleLivr.TabIndex = 17;
            this.lblVilleLivr.Text = "Ville :";
            // 
            // txtVilleLivr
            // 
            this.txtVilleLivr.Location = new System.Drawing.Point(679, 655);
            this.txtVilleLivr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVilleLivr.Name = "txtVilleLivr";
            this.txtVilleLivr.Size = new System.Drawing.Size(193, 22);
            this.txtVilleLivr.TabIndex = 18;
            this.txtVilleLivr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVilleFact
            // 
            this.txtVilleFact.Location = new System.Drawing.Point(1340, 658);
            this.txtVilleFact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVilleFact.Name = "txtVilleFact";
            this.txtVilleFact.Size = new System.Drawing.Size(193, 22);
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
            this.txtCodePostalFact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodePostalFact.Name = "txtCodePostalFact";
            this.txtCodePostalFact.Size = new System.Drawing.Size(193, 22);
            this.txtCodePostalFact.TabIndex = 24;
            this.txtCodePostalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodePostalFact
            // 
            this.lblCodePostalFact.AutoSize = true;
            this.lblCodePostalFact.Location = new System.Drawing.Point(1196, 615);
            this.lblCodePostalFact.Name = "lblCodePostalFact";
            this.lblCodePostalFact.Size = new System.Drawing.Size(86, 16);
            this.lblCodePostalFact.TabIndex = 23;
            this.lblCodePostalFact.Text = "Code postal :";
            // 
            // txtNomRueFact
            // 
            this.txtNomRueFact.Location = new System.Drawing.Point(1340, 562);
            this.txtNomRueFact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomRueFact.Name = "txtNomRueFact";
            this.txtNomRueFact.Size = new System.Drawing.Size(193, 22);
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
            this.txtNumRueFact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumRueFact.Name = "txtNumRueFact";
            this.txtNumRueFact.Size = new System.Drawing.Size(193, 22);
            this.txtNumRueFact.TabIndex = 19;
            // 
            // lblAdresseFact
            // 
            this.lblAdresseFact.AutoSize = true;
            this.lblAdresseFact.ForeColor = System.Drawing.Color.White;
            this.lblAdresseFact.Location = new System.Drawing.Point(1307, 473);
            this.lblAdresseFact.Name = "lblAdresseFact";
            this.lblAdresseFact.Size = new System.Drawing.Size(141, 16);
            this.lblAdresseFact.TabIndex = 27;
            this.lblAdresseFact.Text = "Adresse de facturation";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSupprimer.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimer.Location = new System.Drawing.Point(545, 722);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(155, 27);
            this.btnSupprimer.TabIndex = 28;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.SpringGreen;
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(747, 722);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(155, 27);
            this.btnModifier.TabIndex = 29;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(947, 722);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(155, 27);
            this.btnAjouter.TabIndex = 30;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblCodeCli
            // 
            this.lblCodeCli.AutoSize = true;
            this.lblCodeCli.Location = new System.Drawing.Point(88, 479);
            this.lblCodeCli.Name = "lblCodeCli";
            this.lblCodeCli.Size = new System.Drawing.Size(80, 16);
            this.lblCodeCli.TabIndex = 31;
            this.lblCodeCli.Text = "Code client :";
            this.lblCodeCli.Click += new System.EventHandler(this.lblCodeCli_Click);
            // 
            // txtCodeCli
            // 
            this.txtCodeCli.Location = new System.Drawing.Point(205, 475);
            this.txtCodeCli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodeCli.Name = "txtCodeCli";
            this.txtCodeCli.Size = new System.Drawing.Size(193, 22);
            this.txtCodeCli.TabIndex = 32;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1193, 722);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            this.lblStatus.TabIndex = 33;
            // 
            // generalMessage
            // 
            this.generalMessage.AutoSize = true;
            this.generalMessage.Location = new System.Drawing.Point(541, 772);
            this.generalMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.generalMessage.Name = "generalMessage";
            this.generalMessage.Size = new System.Drawing.Size(0, 16);
            this.generalMessage.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 35;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblGeneralMessage
            // 
            this.lblGeneralMessage.AutoSize = true;
            this.lblGeneralMessage.Location = new System.Drawing.Point(747, 772);
            this.lblGeneralMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneralMessage.Name = "lblGeneralMessage";
            this.lblGeneralMessage.Size = new System.Drawing.Size(0, 16);
            this.lblGeneralMessage.TabIndex = 36;
            // 
            // FrmViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1800, 783);
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
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.dtgCustomer);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmViewCustomer";
            this.Text = "FrmViewCustomer";
            this.Load += new System.EventHandler(this.FrmViewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button btnPro;
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