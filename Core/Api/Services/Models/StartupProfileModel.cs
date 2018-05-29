using System;
using SuhMapi.Core.Api.Services.Models;

namespace SuhMapi.Core.Api.Services.Models
{
    public class StartupProfileModel
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string WhatDoYouDo { get; set; }
        public CountryModel Country { get; set; }
        public TownModel Town { get; set; }
        public string Address { get; set; }
        public string WebsiteUrl { get; set; }
        public int NumberOfEmployees { get; set; }
        public int YearOfEstablishment { get; set; }
    }
}