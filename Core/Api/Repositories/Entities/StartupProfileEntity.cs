using System;
using SuhMapi.Core.Api.Repositories.Entities;

namespace SuhMapi.Core.Api.Repositories.Entities
{
    public class StartupProfileEntity
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string WhatDoYouDo { get; set; }
        public CountryEntity Country { get; set; }
        public TownEntity Town { get; set; }
        public string Address { get; set; }
        public string WebsiteUrl { get; set; }
        public int NumberOfEmployees { get; set; }
        public int YearOfEstablishment { get; set; }
    }
}