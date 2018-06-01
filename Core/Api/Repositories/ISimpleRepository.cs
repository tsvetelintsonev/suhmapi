using System;
using System.Collections.Generic;

namespace SuhMapi.Core.Api.Repositories
{
    public interface ISimpleRepository<TEntity>
    {
        TEntity GetById(Guid id);
         TEntity GetById(string id);
         IEnumerable<TEntity> GetAll(string id);
         void Create(TEntity entity);
         void Delete(TEntity entity);
    }
}