using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace SuhMapi.Core.Api.Repositories.Mongo 
{

    public abstract class SimpleMongoRepository<TDocument>: ISimpleRepository<TDocument> 
    {
        private IMongoDatabase _database;
        public IMongoDatabase Database { get => _database; private set{} }
        protected abstract string CollectionName { get; }

        public SimpleMongoRepository(IMongoDatabase database) {
            _database = database;
        }

        public void Create(TDocument entity)
        {
            _database.GetCollection<TDocument>(CollectionName).InsertOne(entity);
        }

        public void Delete(TDocument entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TDocument> GetAll(string id)
        {
            throw new System.NotImplementedException();
        }

        public TDocument GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public TDocument GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }

}