using System.Collections.Generic;
using Mapster;
using SuhMapi.Core.Api.Repositories.Entities;
using SuhMapi.Core.Api.Repositories.Mongo.Startups;
using SuhMapi.Core.Api.Services.Models;

namespace SuhMapi.Core.Api.Services 
{
    public class StartupsService : IStartupsService
    {
        private IStartupsRepository _startupsRepository;
        public StartupsService(IStartupsRepository startupsRepository) {
            _startupsRepository = startupsRepository;
        }

        public void Create(StartupProfileModel model)
        {
            _startupsRepository.Create(model.Adapt<StartupProfileEntity>());
        }

        public void Delete(StartupProfileModel model)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<StartupProfileModel> GetAll(string id)
        {
            throw new System.NotImplementedException();
        }

        public StartupProfileModel GetById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}