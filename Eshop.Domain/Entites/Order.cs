using Eshop.Domain.Common;
using Eshop.Domain.Enums;

namespace Eshop.Domain.Entites
{
    public class Order : BaseEntity
    {
        public Order(int id,OrderStateEnum orderStateEnum)
        {
            this.Id = id;
            this.OrderStateEnum = orderStateEnum;
        }
        public OrderStateEnum OrderStateEnum { get; }
        public IList<OrderItem> orderItems { get; }
    }
}
