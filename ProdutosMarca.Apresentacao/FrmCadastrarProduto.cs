using ProdutosMarca.Apresentacao.ViewModels;
using ProdutosMarca.Repositorio.Comum;
using ProdutosMarca.Repositorio.EF;
using ProdutosMarcas.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdutosMarca.Apresentacao
{
    public partial class FrmCadastrarProduto : Form
    {

        private Produto produtoASerAlterado;

        public FrmCadastrarProduto(Produto produto = null)
        {
            produtoASerAlterado = produto;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Produto> repositorioProduto = new RepositorioProduto();

            if (produtoASerAlterado == null)
            {
                Produto novoProduto = new Produto
                {
                    Nome = txbNomeProduto.Text.Trim(),
                    MarcaId = Convert.ToInt32(cmbMarcas.SelectedValue)
                };
                repositorioProduto.Inserir(novoProduto);
            }
            else
            {
                produtoASerAlterado.Nome = txbNomeProduto.Text;
                produtoASerAlterado.MarcaId = Convert.ToInt32(cmbMarcas.SelectedValue);
                repositorioProduto.Atualizar(produtoASerAlterado);
            }
            Close();
        }

        private async void FrmCadastrarProduto_Load(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorioMarca = new RepositorioMarca();
            List<Marca> marcas = await repositorioMarca.SelecionarTodos();
            List<MarcaViewModel> viewModels = new List<MarcaViewModel>();

            foreach (Marca marca in marcas)
            {
                MarcaViewModel viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                viewModels.Add(viewModel);
            }
            cmbMarcas.DataSource = viewModels;
            cmbMarcas.DisplayMember = "Nome";
            cmbMarcas.ValueMember = "Id";
            cmbMarcas.Refresh();
            if (produtoASerAlterado != null)
            {
                txbNomeProduto.Text = produtoASerAlterado.Nome;
                cmbMarcas.SelectedValue = produtoASerAlterado.MarcaId;
            }
            else
            {
                txbNomeProduto.Text = string.Empty;
            }
        }
    }
}
