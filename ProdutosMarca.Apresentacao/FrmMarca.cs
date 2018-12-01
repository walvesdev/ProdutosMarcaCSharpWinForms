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
    public partial class FrmMarca : Form
    {
        private Marca marcaAserAlterada;

        public FrmMarca(Marca marca = null)
        {
            marcaAserAlterada = marca;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorioMarca = new RepositorioMarca();

            if (marcaAserAlterada == null)
            {
                Marca novaMarca = new Marca
                {
                    Nome = txbNomeMarca.Text.Trim()
                };

                repositorioMarca.Inserir(novaMarca);
            }
            else
            {
                marcaAserAlterada.Nome = txbNomeMarca.Text.Trim();
                repositorioMarca.Atualizar(marcaAserAlterada);
            }
            Close();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            if (marcaAserAlterada != null)
            {
                txbNomeMarca.Text = marcaAserAlterada.Nome;
            }
            else
            {
                txbNomeMarca.Text = string.Empty;

            }
        }
    }
}
