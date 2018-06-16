using System;

namespace SuhMapi.Core.Api.Repositories.Models
{
    public class Country
    {
        public Guid Id { get; set; }
        public string IsoCode { get; set; }
        public string Name { get; set; }
    }
}