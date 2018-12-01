using ProdutosMarca.Persistencia.EF.Context;
using ProdutosMarca.Repositorio.Comum;
using ProdutosMarcas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosMarca.Repositorio.EF
{
    public class RepositorioProduto : IRepositorioGenerico<Produto>
    {
        public void Atualizar(Produto entidade)
        {
            using (ProdutosMarcasDbContext banco = new ProdutosMarcasDbContext())
            {
                Marca marca = banco.Marcas.Find(entidade.MarcaId);
                entidade.Marca = marca;

                banco.Produtos.Attach(entidade);
                banco.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                banco.SaveChanges();
            }
        }

        public void Excluir(Produto entidade)
        {
            using (ProdutosMarcasDbContext banco = new ProdutosMarcasDbContext())
            {
                banco.Produtos.Attach(entidade);
                banco.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                banco.SaveChanges();
            }
        }

        public void Inserir(Produto entidade)
        {
            using (ProdutosMarcasDbContext banco = new ProdutosMarcasDbContext())
            {
                Marca marca = banco.Marcas.Find(entidade.Marca);
                entidade.Marca = marca;

                banco.Produtos.Add(entidade);
                banco.SaveChanges();
            }
        }

        public Produto SelecionarPorId(int id)
        {
            using (ProdutosMarcasDbContext banco = new ProdutosMarcasDbContext())
            {
                return banco.Produtos.Include("Marca").Single(s => s.Id == id);
            }
        }

        public Task<List<Produto>> SelecionarTodos()
        {
            return Task.Run(()=>{ 
            using (ProdutosMarcasDbContext banco = new ProdutosMarcasDbContext())
            {
                return banco.Produtos.Include("Marca").ToList();
            }
            });
        }
    }
}
