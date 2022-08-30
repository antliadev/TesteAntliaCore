using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MovimentosManuais.ApplicationCore.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterId(int Id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado);
        void Remover(TEntity entity);
    }
}
