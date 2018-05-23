using System.Collections.Generic;

namespace SuhMapi.Core.Api.Services
{
    public interface ISimpleService<TResource>
    {
         TResource GetById(string id);
         IEnumerable<TResource> GetAll(string id);
         void Create(TResource resource);
         void Delete(TResource resource);
    }
}