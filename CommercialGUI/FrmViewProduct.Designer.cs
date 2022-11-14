﻿namespace CommercialGUI
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
            this.lstCategProduct = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Location = new System.Drawing.Point(641, 83);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(138, 23);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.Text = "Nouveau";
            this.btnNewProduct.UseVisualStyleBackColor = true;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // dtgProducts
            // 
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Location = new System.Drawing.Point(164, 173);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.Size = new System.Drawing.Size(240, 150);
            this.dtgProducts.TabIndex = 1;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(777, 173);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(47, 16);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Libelle";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            // 
            // txtLabelProduct
            // 
            this.txtLabelProduct.Location = new System.Drawing.Point(780, 206);
            this.txtLabelProduct.Name = "txtLabelProduct";
            this.txtLabelProduct.Size = new System.Drawing.Size(100, 22);
            this.txtLabelProduct.TabIndex = 4;
            // 
            // lblPrixHTProduct
            // 
            this.lblPrixHTProduct.AutoSize = true;
            this.lblPrixHTProduct.Location = new System.Drawing.Point(618, 173);
            this.lblPrixHTProduct.Name = "lblPrixHTProduct";
            this.lblPrixHTProduct.Size = new System.Drawing.Size(51, 16);
            this.lblPrixHTProduct.TabIndex = 6;
            this.lblPrixHTProduct.Text = "Prix HT";
            // 
            // txtPrixHTProduct
            // 
            this.txtPrixHTProduct.Location = new System.Drawing.Point(621, 206);
            this.txtPrixHTProduct.Name = "txtPrixHTProduct";
            this.txtPrixHTProduct.Size = new System.Drawing.Size(100, 22);
            this.txtPrixHTProduct.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(780, 253);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 23);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Ajouter";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // lstCategProduct
            // 
            this.lstCategProduct.FormattingEnabled = true;
            this.lstCategProduct.ItemHeight = 16;
            this.lstCategProduct.Location = new System.Drawing.Point(621, 253);
            this.lstCategProduct.Name = "lstCategProduct";
            this.lstCategProduct.Size = new System.Drawing.Size(100, 68);
            this.lstCategProduct.TabIndex = 9;
            this.lstCategProduct.SelectedIndexChanged += new System.EventHandler(this.lstCategProduct_SelectedIndexChanged);
            // 
            // FrmViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 587);
            this.Controls.Add(this.lstCategProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtPrixHTProduct);
            this.Controls.Add(this.lblPrixHTProduct);
            this.Controls.Add(this.txtLabelProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.dtgProducts);
            this.Controls.Add(this.btnNewProduct);
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
        private System.Windows.Forms.ListBox lstCategProduct;
    }
}