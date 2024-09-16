using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Abstractions;
using Domain.Customers;
using Domain.Products;

namespace Domain.Orders
{
    public class Order : Entity<Guid>
    {
        private readonly HashSet<LineItem> _lineItems = new();

        private Order(){}
        public Guid CustomerId { get; private set; }
        public IReadOnlyCollection<LineItem> LineItems => _lineItems.ToList();
        public OrderStatus Status { get; private set; }

        public static Order Create(Customer customer)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                CustomerId = customer.Id,
                Status = OrderStatus.Pending              
            };

            return order;
        }
        public void Add(Product product)
        {
            var lineItem = new LineItem(Guid.NewGuid(), Id, product.Id,product.Price) ;
            _lineItems.Add(lineItem);
        }
    }       
}