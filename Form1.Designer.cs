namespace Aula31
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProduto = new MaterialSkin.Controls.MaterialTextBox();
            this.lblProduto = new MaterialSkin.Controls.MaterialLabel();
            this.txtPreco = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPreco = new MaterialSkin.Controls.MaterialLabel();
            this.btnLancar = new MaterialSkin.Controls.MaterialButton();
            this.btnRemover = new MaterialSkin.Controls.MaterialButton();
            this.ltbProdutos = new MaterialSkin.Controls.MaterialListBox();
            this.ltbPrecos = new MaterialSkin.Controls.MaterialListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrecoTotal = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.AnimateReadOnly = false;
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduto.Depth = 0;
            this.txtProduto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProduto.LeadingIcon = null;
            this.txtProduto.Location = new System.Drawing.Point(22, 116);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProduto.MaxLength = 50;
            this.txtProduto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProduto.Multiline = false;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(243, 50);
            this.txtProduto.TabIndex = 0;
            this.txtProduto.Text = "";
            this.txtProduto.TrailingIcon = null;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Depth = 0;
            this.lblProduto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProduto.Location = new System.Drawing.Point(20, 84);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(57, 19);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            // 
            // txtPreco
            // 
            this.txtPreco.AnimateReadOnly = false;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.Depth = 0;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPreco.LeadingIcon = null;
            this.txtPreco.Location = new System.Drawing.Point(22, 224);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreco.MaxLength = 50;
            this.txtPreco.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPreco.Multiline = false;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(243, 50);
            this.txtPreco.TabIndex = 0;
            this.txtPreco.Text = "";
            this.txtPreco.TrailingIcon = null;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Depth = 0;
            this.lblPreco.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPreco.Location = new System.Drawing.Point(20, 191);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreco.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(41, 19);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço";
            this.lblPreco.Click += new System.EventHandler(this.lblPreco_Click);
            // 
            // btnLancar
            // 
            this.btnLancar.AutoSize = false;
            this.btnLancar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLancar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLancar.Depth = 0;
            this.btnLancar.HighEmphasis = true;
            this.btnLancar.Icon = null;
            this.btnLancar.Location = new System.Drawing.Point(22, 292);
            this.btnLancar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLancar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLancar.Size = new System.Drawing.Size(83, 40);
            this.btnLancar.TabIndex = 2;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLancar.UseAccentColor = false;
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSize = false;
            this.btnRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemover.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemover.Depth = 0;
            this.btnRemover.HighEmphasis = true;
            this.btnRemover.Icon = null;
            this.btnRemover.Location = new System.Drawing.Point(165, 292);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemover.Size = new System.Drawing.Size(83, 40);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemover.UseAccentColor = false;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // ltbProdutos
            // 
            this.ltbProdutos.BackColor = System.Drawing.Color.White;
            this.ltbProdutos.BorderColor = System.Drawing.Color.LightGray;
            this.ltbProdutos.Depth = 0;
            this.ltbProdutos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ltbProdutos.Location = new System.Drawing.Point(336, 116);
            this.ltbProdutos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ltbProdutos.MouseState = MaterialSkin.MouseState.HOVER;
            this.ltbProdutos.Name = "ltbProdutos";
            this.ltbProdutos.SelectedIndex = -1;
            this.ltbProdutos.SelectedItem = null;
            this.ltbProdutos.Size = new System.Drawing.Size(202, 276);
            this.ltbProdutos.TabIndex = 3;
            this.ltbProdutos.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.ltbProdutos_SelectedIndexChanged);
            // 
            // ltbPrecos
            // 
            this.ltbPrecos.BackColor = System.Drawing.Color.White;
            this.ltbPrecos.BorderColor = System.Drawing.Color.LightGray;
            this.ltbPrecos.Depth = 0;
            this.ltbPrecos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ltbPrecos.Location = new System.Drawing.Point(576, 116);
            this.ltbPrecos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ltbPrecos.MouseState = MaterialSkin.MouseState.HOVER;
            this.ltbPrecos.Name = "ltbPrecos";
            this.ltbPrecos.SelectedIndex = -1;
            this.ltbPrecos.SelectedItem = null;
            this.ltbPrecos.Size = new System.Drawing.Size(221, 276);
            this.ltbPrecos.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(342, 95);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Produtos";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(582, 95);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Preços";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(23, 373);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Preço Total";
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Depth = 0;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecoTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblPrecoTotal.Location = new System.Drawing.Point(16, 427);
            this.lblPrecoTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(1, 0);
            this.lblPrecoTotal.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 523);
            this.Controls.Add(this.lblPrecoTotal);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.ltbPrecos);
            this.Controls.Add(this.ltbProdutos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLancar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtProduto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtProduto;
        private MaterialSkin.Controls.MaterialLabel lblProduto;
        private MaterialSkin.Controls.MaterialTextBox txtPreco;
        private MaterialSkin.Controls.MaterialLabel lblPreco;
        private MaterialSkin.Controls.MaterialButton btnLancar;
        private MaterialSkin.Controls.MaterialButton btnRemover;
        private MaterialSkin.Controls.MaterialListBox ltbProdutos;
        private MaterialSkin.Controls.MaterialListBox ltbPrecos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblPrecoTotal;
    }
}

