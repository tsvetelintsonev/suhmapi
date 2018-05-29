using System.Collections.Generic;
using SuhMapi.Core.Api.Services.Models;

namespace SuhMapi.Core.Api.Services
{
    public interface IStartupsService
    {
         StartupProfileModel GetById(string id);
         IEnumerable<StartupProfileModel> GetAll(string id);
         void Create(StartupProfileModel resource);
         void Delete(StartupProfileModel resource);
    }
}