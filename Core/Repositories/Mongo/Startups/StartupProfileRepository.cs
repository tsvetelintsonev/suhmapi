using System.Collections.Generic;
using MongoDB.Driver;
using SuhMapi.Core.Api.Repositories.Models;
using SuhMapi.Core.Api.Repositories.Mongo;
using SuhMapi.Core.Api.Repositories.Mongo.Startups;

namespace SuhMapi.Core.Repositories.Mongo.Startups 
{

    public class StartupsRepository : SimpleMongoRepository<StartupProfile>, IStartupsRepository
    {
        public StartupsRepository(IMongoDatabase database) : base(database)
        {
        }

        protected override string CollectionName => "StartupProfiles";

    }

}