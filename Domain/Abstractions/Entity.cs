using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public abstract class Entity<T>
    {
     protected Entity(T id)
    {
        Id = id;
    }

    protected Entity()
    {
    }

    public T Id { get; init; }
        
    }
}