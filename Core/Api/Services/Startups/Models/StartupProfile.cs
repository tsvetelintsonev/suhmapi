using SuhMapi.Core.Api.Services.Countries.Models;

namespace SuhMapi.Core.Api.Services.Startups.Models
{
    public class StartupProfile
    {
        public string CompanyName { get; set; }
        public string WhatDoYouDo { get; set; }
        public Country Country { get; set; }
        public Town Town { get; set; }
        public string Address { get; set; }
        public string WebsiteUrl { get; set; }
        public int NumberOfEmployees { get; set; }
        public int YearOfEstablishment { get; set; }
    }
}