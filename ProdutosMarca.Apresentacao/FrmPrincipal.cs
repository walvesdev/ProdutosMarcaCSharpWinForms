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

        }

        private void PreencherDataGridViewMarcas()
        {
            IRepositorioGenerico<Marca> repositorioMarca = new RepositorioMarca();
            List<Marca> marcas = repositorioMarca.SelecionarTodos();
        }
    }
}
