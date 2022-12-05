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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dtpDateDevis = new System.Windows.Forms.DateTimePicker();
            this.lbClient = new System.Windows.Forms.ListBox();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.txtTauxTva = new System.Windows.Forms.TextBox();
            this.txtTauxRemise = new System.Windows.Forms.TextBox();
            this.dtgDevisModify = new System.Windows.Forms.DataGridView();
            this.btnSupDevis = new System.Windows.Forms.Button();
            this.btnModifyDevis = new System.Windows.Forms.Button();
            this.txtMontantTva = new System.Windows.Forms.TextBox();
            this.txtMontantTtc = new System.Windows.Forms.TextBox();
            this.txtMontantHTHR = new System.Windows.Forms.TextBox();
            this.txtMontantHTAR = new System.Windows.Forms.TextBox();
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
            this.gpDevis.Controls.Add(this.txtMontantHTAR);
            this.gpDevis.Controls.Add(this.txtMontantHTHR);
            this.gpDevis.Controls.Add(this.txtMontantTtc);
            this.gpDevis.Controls.Add(this.txtMontantTva);
            this.gpDevis.Controls.Add(this.btnModifyDevis);
            this.gpDevis.Controls.Add(this.btnSupDevis);
            this.gpDevis.Controls.Add(this.dtgDevisModify);
            this.gpDevis.Controls.Add(this.txtTauxRemise);
            this.gpDevis.Controls.Add(this.txtTauxTva);
            this.gpDevis.Controls.Add(this.lbStatus);
            this.gpDevis.Controls.Add(this.lbClient);
            this.gpDevis.Controls.Add(this.dtpDateDevis);
            this.gpDevis.Controls.Add(this.txtCode);
            this.gpDevis.ForeColor = System.Drawing.Color.Coral;
            this.gpDevis.Location = new System.Drawing.Point(1519, 155);
            this.gpDevis.Name = "gpDevis";
            this.gpDevis.Size = new System.Drawing.Size(713, 994);
            this.gpDevis.TabIndex = 2;
            this.gpDevis.TabStop = false;
            this.gpDevis.Text = "Details";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(27, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(196, 31);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "Code";
            // 
            // dtpDateDevis
            // 
            this.dtpDateDevis.Location = new System.Drawing.Point(426, 42);
            this.dtpDateDevis.Name = "dtpDateDevis";
            this.dtpDateDevis.Size = new System.Drawing.Size(200, 31);
            this.dtpDateDevis.TabIndex = 1;
            // 
            // lbClient
            // 
            this.lbClient.FormattingEnabled = true;
            this.lbClient.ItemHeight = 25;
            this.lbClient.Location = new System.Drawing.Point(27, 106);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(196, 29);
            this.lbClient.TabIndex = 2;
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.ItemHeight = 25;
            this.lbStatus.Location = new System.Drawing.Point(426, 106);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(196, 29);
            this.lbStatus.TabIndex = 3;
            // 
            // txtTauxTva
            // 
            this.txtTauxTva.Location = new System.Drawing.Point(27, 160);
            this.txtTauxTva.Name = "txtTauxTva";
            this.txtTauxTva.Size = new System.Drawing.Size(196, 31);
            this.txtTauxTva.TabIndex = 4;
            this.txtTauxTva.Text = "Taux TVA";
            // 
            // txtTauxRemise
            // 
            this.txtTauxRemise.Location = new System.Drawing.Point(426, 160);
            this.txtTauxRemise.Name = "txtTauxRemise";
            this.txtTauxRemise.Size = new System.Drawing.Size(196, 31);
            this.txtTauxRemise.TabIndex = 5;
            this.txtTauxRemise.Text = "Taux remise";
            // 
            // dtgDevisModify
            // 
            this.dtgDevisModify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevisModify.Location = new System.Drawing.Point(27, 223);
            this.dtgDevisModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgDevisModify.Name = "dtgDevisModify";
            this.dtgDevisModify.RowHeadersWidth = 51;
            this.dtgDevisModify.RowTemplate.Height = 24;
            this.dtgDevisModify.Size = new System.Drawing.Size(651, 469);
            this.dtgDevisModify.TabIndex = 3;
            // 
            // btnSupDevis
            // 
            this.btnSupDevis.Location = new System.Drawing.Point(455, 891);
            this.btnSupDevis.Name = "btnSupDevis";
            this.btnSupDevis.Size = new System.Drawing.Size(223, 81);
            this.btnSupDevis.TabIndex = 3;
            this.btnSupDevis.Text = "Supprimer";
            this.btnSupDevis.UseVisualStyleBackColor = true;
            // 
            // btnModifyDevis
            // 
            this.btnModifyDevis.Location = new System.Drawing.Point(192, 891);
            this.btnModifyDevis.Name = "btnModifyDevis";
            this.btnModifyDevis.Size = new System.Drawing.Size(223, 81);
            this.btnModifyDevis.TabIndex = 6;
            this.btnModifyDevis.Text = "Modifier";
            this.btnModifyDevis.UseVisualStyleBackColor = true;
            // 
            // txtMontantTva
            // 
            this.txtMontantTva.Location = new System.Drawing.Point(27, 782);
            this.txtMontantTva.Name = "txtMontantTva";
            this.txtMontantTva.Size = new System.Drawing.Size(273, 31);
            this.txtMontantTva.TabIndex = 7;
            this.txtMontantTva.Text = "Montant TVA";
            // 
            // txtMontantTtc
            // 
            this.txtMontantTtc.Location = new System.Drawing.Point(394, 782);
            this.txtMontantTtc.Name = "txtMontantTtc";
            this.txtMontantTtc.Size = new System.Drawing.Size(252, 31);
            this.txtMontantTtc.TabIndex = 8;
            this.txtMontantTtc.Text = "Montant TTC";
            // 
            // txtMontantHTHR
            // 
            this.txtMontantHTHR.Location = new System.Drawing.Point(27, 731);
            this.txtMontantHTHR.Name = "txtMontantHTHR";
            this.txtMontantHTHR.Size = new System.Drawing.Size(273, 31);
            this.txtMontantHTHR.TabIndex = 9;
            this.txtMontantHTHR.Text = "Montant HT Hors Remise";
            // 
            // txtMontantHTAR
            // 
            this.txtMontantHTAR.Location = new System.Drawing.Point(394, 731);
            this.txtMontantHTAR.Name = "txtMontantHTAR";
            this.txtMontantHTAR.Size = new System.Drawing.Size(252, 31);
            this.txtMontantHTAR.TabIndex = 10;
            this.txtMontantHTAR.Text = "Montant HT avec remise";
            // 
            // FrmDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2552, 1196);
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
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.ListBox lbClient;
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
    }
}