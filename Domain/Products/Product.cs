using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Abstractions;
using Domain.Shared;

namespace Domain.Products
{
    public class Product : Entity<Guid>
    {
        public Product(Guid id) : base(id)
        {            
        }

        public string Name { get; private set;} = string.Empty;
        public Money Price { get; private set;} 
        public Sku Sku { get; private set;}        
    }
}