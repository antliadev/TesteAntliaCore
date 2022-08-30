using MovimentosManuais.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MovimentosManuais.ApplicationCore.Interfaces.Services
{
    public interface IProdutoService
    {
        Produto Adicionar(Produto entity);
        void Atualizar(Produto entity);
        IEnumerable<Produto> ObterTodos();
        Produto ObterId(int Id);
        IEnumerable<Produto> Buscar(Expression<Func<Produto, bool>> predicado);
        void Remover(Produto entity);
    }
}
