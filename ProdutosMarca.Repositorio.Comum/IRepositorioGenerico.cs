using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosMarca.Repositorio.Comum
{
    public interface IRepositorioGenerico<T>
    {
        List<T> SelecionarTodos();
        T SelecionarPorId(T id);
        void Inserir(T entidade);
        void Atualizar(T entidade);
        void Excluir(T entidade);

    }
}
