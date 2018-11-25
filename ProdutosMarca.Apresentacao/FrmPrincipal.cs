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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewMarcasAsync();
            PreencherDataGridViewProdutoAsync();
        }

        private async void PreencherDataGridViewMarcasAsync()
        {
            IRepositorioGenerico<Marca> repositorioMarca = new RepositorioMarca();
            List<Marca> marcas = await repositorioMarca.SelecionarTodos();

            List<MarcaViewModel> marcaViewModels = new List<MarcaViewModel>();

            foreach (Marca marca in marcas)
            {
                MarcaViewModel viewModel = new MarcaViewModel
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                    
                    
                };
                marcaViewModels.Add(viewModel);
            }
            dgvMarcas.Invoke((MethodInvoker)delegate 
            {
                dgvMarcas.DataSource = marcaViewModels;
                dgvMarcas.Refresh();
            });
            
        }

        private async void PreencherDataGridViewProdutoAsync()
        {
            IRepositorioGenerico<Produto> repositorioProduto = new RepositorioProduto();
            List<Produto> produtos = await repositorioProduto.SelecionarTodos();

            List<ProdutoViewModel> produtoViewModels = new List<ProdutoViewModel>();

            foreach (Produto produto in produtos)
            {
                ProdutoViewModel viewModel = new ProdutoViewModel
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    MarcaId = produto.MarcaId,
                    Marca = produto.Marca.Nome
                };
                produtoViewModels.Add(viewModel);
            }
            dgvProdutos.Invoke((MethodInvoker)delegate
            {
                dgvProdutos.DataSource = produtoViewModels;
                dgvProdutos.Refresh();
            });

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
