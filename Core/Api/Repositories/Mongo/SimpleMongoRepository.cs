using System.Collections.Generic;
using MongoDB.Driver;

namespace SuhMapi.Core.Api.Repositories.Mongo 
{

    public abstract class SimpleMongoRepository<TEntity>: ISimpleRepository<TEntity> 
    {
         private MongoClient _mongoClient;
         private string _databaseName {set; get;}
         private IMongoDatabase _database;
         private IMongoDatabase Database => _database ?? CreateMongoDatabase();
         private IMongoCollection<TEntity> _collection;
         protected IMongoCollection<TEntity> Collection => _collection ?? CreateMongoCollection();
         protected abstract string CollectionName {get;}

        public SimpleMongoRepository(string databaseName, MongoClient mongoClient) {
            _databaseName = databaseName;
            _mongoClient = mongoClient;
        }

        public void Create(TEntity entity)
        {
            Collection.InsertOne(entity);
        }

        public void Delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll(string id)
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        private IMongoDatabase CreateMongoDatabase() {
            if(_database == null)
                _database = _mongoClient.GetDatabase(_databaseName);
            return _database;
        }

        private IMongoCollection<TEntity> CreateMongoCollection() {
            if(_collection == null)
                _collection = Database.GetCollection<TEntity>(CollectionName);
            return _collection;
        }
    }

}