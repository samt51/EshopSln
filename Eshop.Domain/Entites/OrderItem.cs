using Eshop.Domain.Common;
using Eshop.Domain.Enums;

namespace Eshop.Domain.Entites
{
    public class OrderItem : BaseEntity
    {
        public OrderItem(int id, int productId, int orderId, int quantity, decimal price, OrderStateEnum orderStateEnum)
        {
            this.Id = id;
            this.ProductId = productId;
            this.OrderId = orderId;
            this.Quantity = quantity;
            this.Price = price;
            this.OrderStateEnum = orderStateEnum;
        }
        public int ProductId { get; }
        public Product Product { get; }
        public int OrderId { get; }
        public Order Order { get; }
        public int Quantity { get; }
        public decimal Price { get; }
        public OrderStateEnum OrderStateEnum { get; }
    }
}
