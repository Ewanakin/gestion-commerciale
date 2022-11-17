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
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabelProduct = new System.Windows.Forms.TextBox();
            this.lblPrixHTProduct = new System.Windows.Forms.Label();
            this.txtPrixHTProduct = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbCategorieProduct = new System.Windows.Forms.ComboBox();
            this.btnRefreshDTG = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.txtCodeSupprPro = new System.Windows.Forms.TextBox();
            this.lblValidationMessage = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.btnNewProduct.ForeColor = System.Drawing.Color.Black;
            this.btnNewProduct.Location = new System.Drawing.Point(765, 130);
            this.btnNewProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(155, 29);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.Text = "Nouveau";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // dtgProducts
            // 
            this.dtgProducts.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(953, 206);
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
            this.txtLabelProduct.Location = new System.Drawing.Point(957, 247);
            this.txtLabelProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLabelProduct.Name = "txtLabelProduct";
            this.txtLabelProduct.Size = new System.Drawing.Size(124, 26);
            this.txtLabelProduct.TabIndex = 4;
            // 
            // lblPrixHTProduct
            // 
            this.lblPrixHTProduct.AutoSize = true;
            this.lblPrixHTProduct.ForeColor = System.Drawing.Color.White;
            this.lblPrixHTProduct.Location = new System.Drawing.Point(761, 206);
            this.lblPrixHTProduct.Name = "lblPrixHTProduct";
            this.lblPrixHTProduct.Size = new System.Drawing.Size(59, 20);
            this.lblPrixHTProduct.TabIndex = 6;
            this.lblPrixHTProduct.Text = "Prix HT";
            // 
            // txtPrixHTProduct
            // 
            this.txtPrixHTProduct.Location = new System.Drawing.Point(765, 247);
            this.txtPrixHTProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrixHTProduct.Name = "txtPrixHTProduct";
            this.txtPrixHTProduct.Size = new System.Drawing.Size(162, 26);
            this.txtPrixHTProduct.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddProduct.Location = new System.Drawing.Point(777, 367);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(126, 34);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Enregistrer";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbCategorieProduct
            // 
            this.cmbCategorieProduct.FormattingEnabled = true;
            this.cmbCategorieProduct.Location = new System.Drawing.Point(765, 311);
            this.cmbCategorieProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategorieProduct.Name = "cmbCategorieProduct";
            this.cmbCategorieProduct.Size = new System.Drawing.Size(162, 28);
            this.cmbCategorieProduct.TabIndex = 9;
            // 
            // btnRefreshDTG
            // 
            this.btnRefreshDTG.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRefreshDTG.Location = new System.Drawing.Point(14, 45);
            this.btnRefreshDTG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshDTG.Name = "btnRefreshDTG";
            this.btnRefreshDTG.Size = new System.Drawing.Size(112, 29);
            this.btnRefreshDTG.TabIndex = 10;
            this.btnRefreshDTG.Text = "Refresh";
            this.btnRefreshDTG.UseVisualStyleBackColor = false;
            this.btnRefreshDTG.Click += new System.EventHandler(this.btnRefreshDTG_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdateProduct.Location = new System.Drawing.Point(940, 367);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(118, 38);
            this.btnUpdateProduct.TabIndex = 11;
            this.btnUpdateProduct.Text = "Modifier";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDelProduct.Location = new System.Drawing.Point(765, 544);
            this.btnDelProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(138, 38);
            this.btnDelProduct.TabIndex = 12;
            this.btnDelProduct.Text = "Supprimer";
            this.btnDelProduct.UseVisualStyleBackColor = false;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // txtCodeSupprPro
            // 
            this.txtCodeSupprPro.Location = new System.Drawing.Point(765, 490);
            this.txtCodeSupprPro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodeSupprPro.Name = "txtCodeSupprPro";
            this.txtCodeSupprPro.Size = new System.Drawing.Size(124, 26);
            this.txtCodeSupprPro.TabIndex = 13;
            // 
            // lblValidationMessage
            // 
            this.lblValidationMessage.AutoSize = true;
            this.lblValidationMessage.Location = new System.Drawing.Point(765, 45);
            this.lblValidationMessage.Name = "lblValidationMessage";
            this.lblValidationMessage.Size = new System.Drawing.Size(0, 20);
            this.lblValidationMessage.TabIndex = 14;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(799, 418);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(51, 20);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "label2";
            this.lblError.Visible = false;
            // 
            // FrmViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1096, 734);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblValidationMessage);
            this.Controls.Add(this.txtCodeSupprPro);
            this.Controls.Add(this.btnDelProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnRefreshDTG);
            this.Controls.Add(this.cmbCategorieProduct);
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
        private System.Windows.Forms.ComboBox cmbCategorieProduct;
        private System.Windows.Forms.Button btnRefreshDTG;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.TextBox txtCodeSupprPro;
        private System.Windows.Forms.Label lblValidationMessage;
        private System.Windows.Forms.Label lblError;
    }
}