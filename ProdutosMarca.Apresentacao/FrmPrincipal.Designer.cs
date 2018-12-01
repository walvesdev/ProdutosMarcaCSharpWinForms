namespace ProdutosMarca.Apresentacao
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirMarca = new System.Windows.Forms.Button();
            this.btnAlterarMarca = new System.Windows.Forms.Button();
            this.btnCadastrarMarca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMarcaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMarcas);
            this.groupBox1.Controls.Add(this.btnExcluirMarca);
            this.groupBox1.Controls.Add(this.btnAlterarMarca);
            this.groupBox1.Controls.Add(this.btnCadastrarMarca);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marcas Cadastradas";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.AllowUserToAddRows = false;
            this.dgvMarcas.AllowUserToDeleteRows = false;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMarca,
            this.NomeMarca});
            this.dgvMarcas.Location = new System.Drawing.Point(12, 19);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.ReadOnly = true;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(614, 228);
            this.dgvMarcas.TabIndex = 0;
            // 
            // IdMarca
            // 
            this.IdMarca.DataPropertyName = "Id";
            this.IdMarca.HeaderText = "Id";
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.ReadOnly = true;
            this.IdMarca.Visible = false;
            this.IdMarca.Width = 300;
            // 
            // NomeMarca
            // 
            this.NomeMarca.DataPropertyName = "Nome";
            this.NomeMarca.HeaderText = "Nome";
            this.NomeMarca.Name = "NomeMarca";
            this.NomeMarca.ReadOnly = true;
            // 
            // btnExcluirMarca
            // 
            this.btnExcluirMarca.Location = new System.Drawing.Point(632, 77);
            this.btnExcluirMarca.Name = "btnExcluirMarca";
            this.btnExcluirMarca.Size = new System.Drawing.Size(132, 23);
            this.btnExcluirMarca.TabIndex = 3;
            this.btnExcluirMarca.Text = "Excluir Marca";
            this.btnExcluirMarca.UseVisualStyleBackColor = true;
            this.btnExcluirMarca.Click += new System.EventHandler(this.btnExcluirMarca_Click);
            // 
            // btnAlterarMarca
            // 
            this.btnAlterarMarca.Location = new System.Drawing.Point(632, 48);
            this.btnAlterarMarca.Name = "btnAlterarMarca";
            this.btnAlterarMarca.Size = new System.Drawing.Size(132, 23);
            this.btnAlterarMarca.TabIndex = 2;
            this.btnAlterarMarca.Text = "Aterar Marca";
            this.btnAlterarMarca.UseVisualStyleBackColor = true;
            this.btnAlterarMarca.Click += new System.EventHandler(this.btnAlterarMarca_Click);
            // 
            // btnCadastrarMarca
            // 
            this.btnCadastrarMarca.Location = new System.Drawing.Point(632, 19);
            this.btnCadastrarMarca.Name = "btnCadastrarMarca";
            this.btnCadastrarMarca.Size = new System.Drawing.Size(132, 23);
            this.btnCadastrarMarca.TabIndex = 1;
            this.btnCadastrarMarca.Text = "Cadastrar Marca";
            this.btnCadastrarMarca.UseVisualStyleBackColor = true;
            this.btnCadastrarMarca.Click += new System.EventHandler(this.btnCadastrarMarca_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluirProduto);
            this.groupBox2.Controls.Add(this.btnCadastrarProduto);
            this.groupBox2.Controls.Add(this.btnAlterarProduto);
            this.groupBox2.Controls.Add(this.dgvProdutos);
            this.groupBox2.Location = new System.Drawing.Point(5, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos Cadastrados";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(632, 78);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(132, 23);
            this.btnExcluirProduto.TabIndex = 11;
            this.btnExcluirProduto.Text = "Excluir Produto";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(632, 20);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(132, 23);
            this.btnCadastrarProduto.TabIndex = 9;
            this.btnCadastrarProduto.Text = "Cadastrar Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Location = new System.Drawing.Point(632, 49);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(132, 23);
            this.btnAlterarProduto.TabIndex = 10;
            this.btnAlterarProduto.Text = "Alterar Produto";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterarProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.IdMarcaProduto,
            this.NomeProduto,
            this.MarcaProduto});
            this.dgvProdutos.Location = new System.Drawing.Point(6, 19);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(620, 251);
            this.dgvProdutos.TabIndex = 0;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "Id";
            this.IdProduto.HeaderText = "Id";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Visible = false;
            // 
            // IdMarcaProduto
            // 
            this.IdMarcaProduto.DataPropertyName = "MarcaId";
            this.IdMarcaProduto.HeaderText = "Id Marca";
            this.IdMarcaProduto.Name = "IdMarcaProduto";
            this.IdMarcaProduto.ReadOnly = true;
            this.IdMarcaProduto.Visible = false;
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "Nome";
            this.NomeProduto.HeaderText = "Nome";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 300;
            // 
            // MarcaProduto
            // 
            this.MarcaProduto.DataPropertyName = "Marca";
            this.MarcaProduto.HeaderText = "Marca";
            this.MarcaProduto.Name = "MarcaProduto";
            this.MarcaProduto.ReadOnly = true;
            this.MarcaProduto.Width = 250;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de produtos  e marcas";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluirMarca;
        private System.Windows.Forms.Button btnAlterarMarca;
        private System.Windows.Forms.Button btnCadastrarMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMarca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarcaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaProduto;
    }
}

