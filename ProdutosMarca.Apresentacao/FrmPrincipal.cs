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

        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.ShowDialog();
            PreencherDataGridViewMarcasAsync();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto frmCadastrarProduto = new FrmCadastrarProduto();
            frmCadastrarProduto.ShowDialog();
            PreencherDataGridViewProdutoAsync();
        }

        private void btnAlterarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0 )
            {
                int idMarcaSelecionada = Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Marca> repositorioMarca = new RepositorioMarca();

                Marca marcaASerAlterada = repositorioMarca.SelecionarPorId(idMarcaSelecionada);
                FrmMarca frmMarca = new FrmMarca(marcaASerAlterada);
                frmMarca.ShowDialog();
                PreencherDataGridViewMarcasAsync();
                PreencherDataGridViewProdutoAsync();
            }
            else
            {
                MessageBox.Show("Selecione uma marca para alteração", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int idProutoSelecionado = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Produto> repositorioProduto = new RepositorioProduto();

                Produto produtoASerAlterado = repositorioProduto.SelecionarPorId(idProutoSelecionado);
                FrmCadastrarProduto frmCadastrarProduto = new FrmCadastrarProduto(produtoASerAlterado);
                frmCadastrarProduto.ShowDialog();
                PreencherDataGridViewProdutoAsync();
            }
            else
            {
                MessageBox.Show("Selecione um produto para alteração", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMarcas.SelectedRows.Count > 0)
                {
                    int idMarcaSelecionada = Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value);
                    IRepositorioGenerico<Marca> repositorioMarca = new RepositorioMarca();

                    Marca marcaASerExcluida = repositorioMarca.SelecionarPorId(idMarcaSelecionada);
                    repositorioMarca.Excluir(marcaASerExcluida);
                    PreencherDataGridViewMarcasAsync();
                    PreencherDataGridViewProdutoAsync();
                }
                else
                {
                    MessageBox.Show("Selecione uma marca para alteração", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Existe produtos vinculados a essa marca, para exclui-la primeiro é necessário excluir os produtos relacionados ou desvincular a marca de quaisquer produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int idProutoSelecionado = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Produto> repositorioProduto = new RepositorioProduto();

                Produto produtoASerExcluido = repositorioProduto.SelecionarPorId(idProutoSelecionado);
                repositorioProduto.Excluir(produtoASerExcluido);
                PreencherDataGridViewProdutoAsync();
            }
            else
            {
                MessageBox.Show("Selecione um produto para alteração", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
