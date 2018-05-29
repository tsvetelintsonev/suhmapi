using System.Collections.Generic;
using MongoDB.Driver;
using SuhMapi.Core.Api.Repositories.Entities;

namespace SuhMapi.Core.Api.Repositories.Mongo.Startups 
{

    public interface IStartupsRepository : ISimpleRepository<StartupProfileEntity>
    {
        
    }

}