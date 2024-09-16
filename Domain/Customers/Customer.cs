using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Abstractions;

namespace Domain.Customers
{
    public class Customer : Entity<Guid>
    {
        public Customer( Guid id) : base(id)
        {            
        }

        public string Email { get; private set;} = string.Empty;
        public string Name { get; private set;} = string.Empty;
    }
}