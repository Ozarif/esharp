using Domain.Abstractions;
using Domain.Shared;

namespace Domain.Orders
{
    public class LineItem : Entity<Guid>
    {
        private LineItem() { }
        internal LineItem(Guid id, Guid orderId, Guid productId,Money price): base(id)
        {
            OrderId = orderId;
            ProductId = productId;
            Price = price;
        }
     //   public Guid Id { get; private set;}
        public Guid OrderId { get; private set;}
        public Guid ProductId { get; private set;}
        public Money Price { get; private set;} 
    }
       
}