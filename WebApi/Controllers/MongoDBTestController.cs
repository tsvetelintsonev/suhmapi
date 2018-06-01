using Microsoft.AspNetCore.Mvc;
using SuhMapi.Core.Api.Services;
using SuhMapi.Core.Api.Services.Models;

namespace SuhMapi.WebApi.Controllers 
{
    
    [Route("mongo-test")]
    public class MongoDBTestController 
    {

        private IStartupsService _startupsService;

        public MongoDBTestController(IStartupsService startupsService) 
        {
            _startupsService = startupsService;
        }

        public string Index() {
            _startupsService.Create(new StartupProfileModel{CompanyName = "test company name"});
            return "Helooooooo";
        }

    }
}