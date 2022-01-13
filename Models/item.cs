using System;

namespace Catalog.Models
{

    public record Item
    {
        public Guid Id{get; init;}

        public string name{ get; init;}
        public string Name { get; internal set; }
        public decimal Price {get; init;}

        public DateTimeOffset CreateDate{get; init;}
    }
}