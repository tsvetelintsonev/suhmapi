using System.Collections.Generic;
using MongoDB.Driver;
using SuhMapi.Core.Api.Repositories.Models;

namespace SuhMapi.Core.Api.Repositories.Mongo.Startups 
{

    public interface IStartupsRepository : ISimpleRepository<StartupProfile>
    {
        
    }

}