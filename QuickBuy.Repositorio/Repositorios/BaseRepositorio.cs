using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly QuickBuyDbContext QuickBuyDbContext;
        public BaseRepositorio(QuickBuyDbContext context)
        {
            QuickBuyDbContext = context;
        }
        public void Adicionar(TEntity entity)
        {
            QuickBuyDbContext.Set<TEntity>().Add(entity);
            QuickBuyDbContext.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            QuickBuyDbContext.Set<TEntity>().Update(entity);
            QuickBuyDbContext.SaveChanges();
        }

        public void Dispose()
        {
            QuickBuyDbContext.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return QuickBuyDbContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickBuyDbContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            QuickBuyDbContext.Set<TEntity>().Remove(entity);
            QuickBuyDbContext.SaveChanges();
        }
    }
}
