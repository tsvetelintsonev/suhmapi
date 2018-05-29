using System.Collections.Generic;
using MongoDB.Driver;
using SuhMapi.Core.Api.Repositories.Entities;

namespace SuhMapi.Core.Api.Repositories.Mongo.Startups 
{

    public class StartupsRepository : SimpleMongoRepository<StartupProfileEntity>, IStartupsRepository
    {
        public StartupsRepository(string databaseName, MongoClient mongoClient) : base(databaseName, mongoClient)
        {
        }

        protected override string CollectionName => "StartupProfiles";
    }

}