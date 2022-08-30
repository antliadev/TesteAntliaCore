using Microsoft.EntityFrameworkCore;
using MovimentosManuais.ApplicationCore.Interfaces.Repository;
using MovimentosManuais.InfraStruture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MovimentosManuais.InfraStruture.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MovimentosManuaisContext _dbContext;

        public EFRepository(MovimentosManuaisContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Adicionar(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public void Atualizar(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado)
        {
            return _dbContext.Set<TEntity>().Where(predicado).AsEnumerable();
        }

        public TEntity ObterId(int Id)
        {
            return _dbContext.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _dbContext.Set<TEntity>().AsEnumerable();
        }

        public void Remover(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
