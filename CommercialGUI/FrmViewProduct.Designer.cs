namespace CommercialGUI
{
    partial class FrmViewProduct
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
            this.components = new System.ComponentModel.Container();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabelProduct = new System.Windows.Forms.TextBox();
            this.lblPrixHTProduct = new System.Windows.Forms.Label();
            this.txtPrixHTProduct = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbCategProduct = new System.Windows.Forms.ComboBox();
            this.gestion_commercialeDataSet = new CommercialGUI.gestion_commercialeDataSet();
            this.gestioncommercialeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_commercialeDataSet1 = new CommercialGUI.gestion_commercialeDataSet1();
            this.categorieproduitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categorie_produitTableAdapter = new CommercialGUI.gestion_commercialeDataSet1TableAdapters.Categorie_produitTableAdapter();
            this.gestion_commercialeDataSet3 = new CommercialGUI.gestion_commercialeDataSet3();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new CommercialGUI.gestion_commercialeDataSet3TableAdapters.ProduitTableAdapter();
            this.codeproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixventehtproDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codecategDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieproduitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(812, 116);
            this.btnNewProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(155, 29);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.Text = "Nouveau";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // dtgProducts
            // 
            this.dtgProducts.AutoGenerateColumns = false;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeproDataGridViewTextBoxColumn,
            this.libproDataGridViewTextBoxColumn,
            this.prixventehtproDataGridViewTextBoxColumn,
            this.codecategDataGridViewTextBoxColumn});
            this.dtgProducts.DataSource = this.produitBindingSource;
            this.dtgProducts.Location = new System.Drawing.Point(12, 94);
            this.dtgProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.Size = new System.Drawing.Size(657, 487);
            this.dtgProducts.TabIndex = 1;
            this.dtgProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProducts_CellContentClick);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(965, 228);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(54, 20);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Libelle";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 5;
            // 
            // txtLabelProduct
            // 
            this.txtLabelProduct.Location = new System.Drawing.Point(957, 270);
            this.txtLabelProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLabelProduct.Name = "txtLabelProduct";
            this.txtLabelProduct.Size = new System.Drawing.Size(124, 26);
            this.txtLabelProduct.TabIndex = 4;
            // 
            // lblPrixHTProduct
            // 
            this.lblPrixHTProduct.AutoSize = true;
            this.lblPrixHTProduct.Location = new System.Drawing.Point(786, 228);
            this.lblPrixHTProduct.Name = "lblPrixHTProduct";
            this.lblPrixHTProduct.Size = new System.Drawing.Size(59, 20);
            this.lblPrixHTProduct.TabIndex = 6;
            this.lblPrixHTProduct.Text = "Prix HT";
            // 
            // txtPrixHTProduct
            // 
            this.txtPrixHTProduct.Location = new System.Drawing.Point(765, 270);
            this.txtPrixHTProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrixHTProduct.Name = "txtPrixHTProduct";
            this.txtPrixHTProduct.Size = new System.Drawing.Size(162, 26);
            this.txtPrixHTProduct.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(802, 529);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(112, 29);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Ajouter";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // cmbCategProduct
            // 
            this.cmbCategProduct.DataSource = this.categorieproduitBindingSource;
            this.cmbCategProduct.DisplayMember = "lib_categ";
            this.cmbCategProduct.FormattingEnabled = true;
            this.cmbCategProduct.Location = new System.Drawing.Point(765, 349);
            this.cmbCategProduct.Name = "cmbCategProduct";
            this.cmbCategProduct.Size = new System.Drawing.Size(162, 28);
            this.cmbCategProduct.TabIndex = 9;
            this.cmbCategProduct.ValueMember = "code_categ";
            // 
            // gestion_commercialeDataSet
            // 
            this.gestion_commercialeDataSet.DataSetName = "gestion_commercialeDataSet";
            this.gestion_commercialeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestioncommercialeDataSetBindingSource
            // 
            this.gestioncommercialeDataSetBindingSource.DataSource = this.gestion_commercialeDataSet;
            this.gestioncommercialeDataSetBindingSource.Position = 0;
            // 
            // gestion_commercialeDataSet1
            // 
            this.gestion_commercialeDataSet1.DataSetName = "gestion_commercialeDataSet1";
            this.gestion_commercialeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categorieproduitBindingSource
            // 
            this.categorieproduitBindingSource.DataMember = "Categorie_produit";
            this.categorieproduitBindingSource.DataSource = this.gestion_commercialeDataSet1;
            // 
            // categorie_produitTableAdapter
            // 
            this.categorie_produitTableAdapter.ClearBeforeFill = true;
            // 
            // gestion_commercialeDataSet3
            // 
            this.gestion_commercialeDataSet3.DataSetName = "gestion_commercialeDataSet3";
            this.gestion_commercialeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.gestion_commercialeDataSet3;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // codeproDataGridViewTextBoxColumn
            // 
            this.codeproDataGridViewTextBoxColumn.DataPropertyName = "code_pro";
            this.codeproDataGridViewTextBoxColumn.HeaderText = "code Pro";
            this.codeproDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeproDataGridViewTextBoxColumn.Name = "codeproDataGridViewTextBoxColumn";
            this.codeproDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeproDataGridViewTextBoxColumn.Width = 150;
            // 
            // libproDataGridViewTextBoxColumn
            // 
            this.libproDataGridViewTextBoxColumn.DataPropertyName = "lib_pro";
            this.libproDataGridViewTextBoxColumn.HeaderText = "lib_pro";
            this.libproDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.libproDataGridViewTextBoxColumn.Name = "libproDataGridViewTextBoxColumn";
            this.libproDataGridViewTextBoxColumn.Width = 150;
            // 
            // prixventehtproDataGridViewTextBoxColumn
            // 
            this.prixventehtproDataGridViewTextBoxColumn.DataPropertyName = "prix_vente_ht_pro";
            this.prixventehtproDataGridViewTextBoxColumn.HeaderText = "prix_vente_ht_pro";
            this.prixventehtproDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.prixventehtproDataGridViewTextBoxColumn.Name = "prixventehtproDataGridViewTextBoxColumn";
            this.prixventehtproDataGridViewTextBoxColumn.Width = 150;
            // 
            // codecategDataGridViewTextBoxColumn
            // 
            this.codecategDataGridViewTextBoxColumn.DataPropertyName = "code_categ";
            this.codecategDataGridViewTextBoxColumn.HeaderText = "code_categ";
            this.codecategDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codecategDataGridViewTextBoxColumn.Name = "codecategDataGridViewTextBoxColumn";
            this.codecategDataGridViewTextBoxColumn.Width = 150;
            // 
            // FrmViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 734);
            this.Controls.Add(this.cmbCategProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtPrixHTProduct);
            this.Controls.Add(this.lblPrixHTProduct);
            this.Controls.Add(this.txtLabelProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.dtgProducts);
            this.Controls.Add(this.btnNewProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmViewProduct";
            this.Text = "FrmViewProduct";
            this.Load += new System.EventHandler(this.FrmViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioncommercialeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieproduitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_commercialeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLabelProduct;
        private System.Windows.Forms.Label lblPrixHTProduct;
        private System.Windows.Forms.TextBox txtPrixHTProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cmbCategProduct;
        private System.Windows.Forms.BindingSource gestioncommercialeDataSetBindingSource;
        private gestion_commercialeDataSet gestion_commercialeDataSet;
        private gestion_commercialeDataSet1 gestion_commercialeDataSet1;
        private System.Windows.Forms.BindingSource categorieproduitBindingSource;
        private gestion_commercialeDataSet1TableAdapters.Categorie_produitTableAdapter categorie_produitTableAdapter;
        private gestion_commercialeDataSet3 gestion_commercialeDataSet3;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private gestion_commercialeDataSet3TableAdapters.ProduitTableAdapter produitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libproDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixventehtproDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codecategDataGridViewTextBoxColumn;
    }
}