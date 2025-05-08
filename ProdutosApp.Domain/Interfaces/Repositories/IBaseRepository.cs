using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface para repositório genérico
    /// 
    public interface IBaseRepository<TEntity, TKey>
        where TEntity : class
    {
        Task AddAsync(TEntity obg);
        Task UpdateAsync(TEntity obg);
        Task DeleteAsync(TEntity obj);

        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey id);
    }
}
