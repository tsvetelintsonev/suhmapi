using System;
using Core.Api.Repositories.Models;

namespace SuhMapi.Core.Api.Repositories.Models
{
    public class StartupProfile
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string WhatDoYouDo { get; set; }
        public Country Country { get; set; }
        public Region Region { get; set; }
        public string Address { get; set; }
        public string WebsiteUrl { get; set; }
        public int NumberOfEmployees { get; set; }
        public int YearOfEstablishment { get; set; }
    }
}