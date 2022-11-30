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
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabelProduct = new System.Windows.Forms.TextBox();
            this.lblPrixHTProduct = new System.Windows.Forms.Label();
            this.txtPrixHTProduct = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbCategorieProduct = new System.Windows.Forms.ComboBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.txtCodeSupprPro = new System.Windows.Forms.TextBox();
            this.lblValidationMessage = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.btnCli = new System.Windows.Forms.Button();
=======
            this.btnPro = new System.Windows.Forms.Button();
>>>>>>> main
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProducts
            // 
            this.dtgProducts.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Location = new System.Drawing.Point(16, 117);
            this.dtgProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.Size = new System.Drawing.Size(876, 609);
            this.dtgProducts.TabIndex = 1;
            this.dtgProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProducts_CellContentClick);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(1240, 258);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(75, 25);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Libelle";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 5;
            // 
            // txtLabelProduct
            // 
            this.txtLabelProduct.Location = new System.Drawing.Point(1245, 288);
            this.txtLabelProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLabelProduct.Name = "txtLabelProduct";
            this.txtLabelProduct.Size = new System.Drawing.Size(164, 31);
            this.txtLabelProduct.TabIndex = 4;
            // 
            // lblPrixHTProduct
            // 
            this.lblPrixHTProduct.AutoSize = true;
            this.lblPrixHTProduct.ForeColor = System.Drawing.Color.White;
            this.lblPrixHTProduct.Location = new System.Drawing.Point(934, 258);
            this.lblPrixHTProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrixHTProduct.Name = "lblPrixHTProduct";
            this.lblPrixHTProduct.Size = new System.Drawing.Size(83, 25);
            this.lblPrixHTProduct.TabIndex = 6;
            this.lblPrixHTProduct.Text = "Prix HT";
            // 
            // txtPrixHTProduct
            // 
            this.txtPrixHTProduct.Location = new System.Drawing.Point(939, 288);
            this.txtPrixHTProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrixHTProduct.Name = "txtPrixHTProduct";
            this.txtPrixHTProduct.Size = new System.Drawing.Size(214, 31);
            this.txtPrixHTProduct.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddProduct.Location = new System.Drawing.Point(921, 459);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(168, 42);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Enregistrer";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbCategorieProduct
            // 
            this.cmbCategorieProduct.FormattingEnabled = true;
            this.cmbCategorieProduct.Location = new System.Drawing.Point(939, 384);
            this.cmbCategorieProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategorieProduct.Name = "cmbCategorieProduct";
            this.cmbCategorieProduct.Size = new System.Drawing.Size(214, 33);
            this.cmbCategorieProduct.TabIndex = 9;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdateProduct.Location = new System.Drawing.Point(1098, 456);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(158, 47);
            this.btnUpdateProduct.TabIndex = 11;
            this.btnUpdateProduct.Text = "Modifier";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDelProduct.Location = new System.Drawing.Point(1264, 456);
            this.btnDelProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(184, 47);
            this.btnDelProduct.TabIndex = 12;
            this.btnDelProduct.Text = "Supprimer";
            this.btnDelProduct.UseVisualStyleBackColor = false;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // txtCodeSupprPro
            // 
            this.txtCodeSupprPro.Location = new System.Drawing.Point(1245, 388);
            this.txtCodeSupprPro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodeSupprPro.Name = "txtCodeSupprPro";
            this.txtCodeSupprPro.Size = new System.Drawing.Size(164, 31);
            this.txtCodeSupprPro.TabIndex = 13;
            // 
            // lblValidationMessage
            // 
            this.lblValidationMessage.AutoSize = true;
            this.lblValidationMessage.Location = new System.Drawing.Point(1020, 56);
            this.lblValidationMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidationMessage.Name = "lblValidationMessage";
            this.lblValidationMessage.Size = new System.Drawing.Size(0, 25);
            this.lblValidationMessage.TabIndex = 14;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(1044, 548);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(70, 25);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "label2";
            this.lblError.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 36);
            this.label2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(934, 358);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Categorie Produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1240, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Code Produit";
            // 
<<<<<<< HEAD
            // btnCli
            // 
            this.btnCli.ForeColor = System.Drawing.Color.Black;
            this.btnCli.Location = new System.Drawing.Point(1143, 834);
            this.btnCli.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCli.Name = "btnCli";
            this.btnCli.Size = new System.Drawing.Size(292, 61);
            this.btnCli.TabIndex = 20;
            this.btnCli.Text = "Vers client >";
            this.btnCli.UseVisualStyleBackColor = true;
            this.btnCli.Click += new System.EventHandler(this.btnCli_Click);
=======
            // btnPro
            // 
            this.btnPro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPro.ForeColor = System.Drawing.Color.Lime;
            this.btnPro.Location = new System.Drawing.Point(1117, 814);
            this.btnPro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(292, 61);
            this.btnPro.TabIndex = 20;
            this.btnPro.Text = "vers client >";
            this.btnPro.UseVisualStyleBackColor = false;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
>>>>>>> main
            // 
            // FrmViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1461, 917);
<<<<<<< HEAD
            this.Controls.Add(this.btnCli);
=======
            this.Controls.Add(this.btnPro);
>>>>>>> main
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblValidationMessage);
            this.Controls.Add(this.txtCodeSupprPro);
            this.Controls.Add(this.btnDelProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.cmbCategorieProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtPrixHTProduct);
            this.Controls.Add(this.lblPrixHTProduct);
            this.Controls.Add(this.txtLabelProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.dtgProducts);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmViewProduct";
            this.Text = "FrmViewProduct";
            this.Load += new System.EventHandler(this.FrmViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLabelProduct;
        private System.Windows.Forms.Label lblPrixHTProduct;
        private System.Windows.Forms.TextBox txtPrixHTProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cmbCategorieProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.TextBox txtCodeSupprPro;
        private System.Windows.Forms.Label lblValidationMessage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnCli;
=======
        private System.Windows.Forms.Button btnPro;
>>>>>>> main
    }
}