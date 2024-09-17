using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public abstract class AggregateRoot<T> : Entity<T>
    {
        private readonly List<IDomainEvent> _domainEvents = new();
        protected AggregateRoot(T Id) : base(Id)
        {       
        }
        protected AggregateRoot()
        {           
        }

        public IReadOnlyList<IDomainEvent> GetDomainEvents()
        {
            return _domainEvents.ToList();
        }

        public void ClearDomainEvents()
        {   
            _domainEvents.Clear();
        }

        protected void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}