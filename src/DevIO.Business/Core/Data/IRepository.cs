using DevIO.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Core.Data
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Adicionar(TEntity entity);
        Task<Entity> ObterPorId(Guid id);
        Task<List<Entity>> ObterTodos();
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);
        Task<IEnumerable<Entity>> Buscar(Expression<Func<Entity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
