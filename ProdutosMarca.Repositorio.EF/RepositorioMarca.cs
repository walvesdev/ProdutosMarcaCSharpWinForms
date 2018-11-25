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
    public class RepositorioMarca : IRepositorioGenerico<Marca>
    {
        public void Atualizar(Marca entidade)
        {
            using (ProdutosMarcasDbContext banco = new ProdutosMarcasDbContext())
            {
                banco.Marcas.Attach(entidade);
                banco.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                banco.SaveChanges();
            }
        }


        public void Excluir(Marca entidade)
        {
            using (ProdutosMarcasDbContext banco = new ProdutosMarcasDbContext())
            {
                banco.Marcas.Attach(entidade);
                banco.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                banco.SaveChanges();
            }
        }

        public void Inserir(Marca entidade)
        {
            using (ProdutosMarcasDbContext banco = new ProdutosMarcasDbContext())
            {
                banco.Marcas.Add(entidade);
                banco.SaveChanges();
            }
        }

        public Marca SelecionarPorId(int id)
        {
            using (ProdutosMarcasDbContext banco = new ProdutosMarcasDbContext())
            {
                return banco.Marcas.Find(id);
            }
        }

        public Task<List<Marca>> SelecionarTodos()
        {
            return Task.Run(() =>
            {
                using (ProdutosMarcasDbContext banco = new ProdutosMarcasDbContext())
                {
                    return banco.Marcas.ToList();
                }
            });
        }
    }
}
