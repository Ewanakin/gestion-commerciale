namespace CommercialGUI
{
    partial class FrmViewSummary
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
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.btnRoutesDevis = new System.Windows.Forms.Button();
            this.btnRoutesCli = new System.Windows.Forms.Button();
            this.btnRoutesProduit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSummary
            // 
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Location = new System.Drawing.Point(204, 308);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.RowHeadersWidth = 82;
            this.dgvSummary.RowTemplate.Height = 33;
            this.dgvSummary.Size = new System.Drawing.Size(1862, 1044);
            this.dgvSummary.TabIndex = 0;
            this.dgvSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSummary_CellContentClick);
            // 
            // btnRoutesDevis
            // 
            this.btnRoutesDevis.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRoutesDevis.ForeColor = System.Drawing.Color.Lime;
            this.btnRoutesDevis.Location = new System.Drawing.Point(700, 1465);
            this.btnRoutesDevis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRoutesDevis.Name = "btnRoutesDevis";
            this.btnRoutesDevis.Size = new System.Drawing.Size(292, 61);
            this.btnRoutesDevis.TabIndex = 23;
            this.btnRoutesDevis.Text = "vers devis >";
            this.btnRoutesDevis.UseVisualStyleBackColor = false;
            this.btnRoutesDevis.Click += new System.EventHandler(this.btnRoutesDevis_Click);
            // 
            // btnRoutesCli
            // 
            this.btnRoutesCli.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRoutesCli.ForeColor = System.Drawing.Color.Lime;
            this.btnRoutesCli.Location = new System.Drawing.Point(1020, 1465);
            this.btnRoutesCli.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRoutesCli.Name = "btnRoutesCli";
            this.btnRoutesCli.Size = new System.Drawing.Size(292, 61);
            this.btnRoutesCli.TabIndex = 22;
            this.btnRoutesCli.Text = "vers client >";
            this.btnRoutesCli.UseVisualStyleBackColor = false;
            this.btnRoutesCli.Click += new System.EventHandler(this.btnRoutesCli_Click);
            // 
            // btnRoutesProduit
            // 
            this.btnRoutesProduit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRoutesProduit.ForeColor = System.Drawing.Color.Lime;
            this.btnRoutesProduit.Location = new System.Drawing.Point(1336, 1465);
            this.btnRoutesProduit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRoutesProduit.Name = "btnRoutesProduit";
            this.btnRoutesProduit.Size = new System.Drawing.Size(292, 61);
            this.btnRoutesProduit.TabIndex = 24;
            this.btnRoutesProduit.Text = "vers produit >";
            this.btnRoutesProduit.UseVisualStyleBackColor = false;
            this.btnRoutesProduit.Click += new System.EventHandler(this.btnRoutesProduit_Click);
            // 
            // FrmViewSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2265, 1615);
            this.Controls.Add(this.btnRoutesProduit);
            this.Controls.Add(this.btnRoutesDevis);
            this.Controls.Add(this.btnRoutesCli);
            this.Controls.Add(this.dgvSummary);
            this.Name = "FrmViewSummary";
            this.Text = "FrmViewSummary";
            this.Load += new System.EventHandler(this.FrmViewSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.Button btnRoutesDevis;
        private System.Windows.Forms.Button btnRoutesCli;
        private System.Windows.Forms.Button btnRoutesProduit;
    }
}