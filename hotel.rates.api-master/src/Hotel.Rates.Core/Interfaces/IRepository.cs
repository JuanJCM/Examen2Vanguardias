using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Hotel.Rates.Core.Interfaces
{
    public interface IRepository<TEntity, TKey>
    {
        TEntity GetbyId(TKey key);

        IReadOnlyList<TEntity> GetAll();
    }
}
