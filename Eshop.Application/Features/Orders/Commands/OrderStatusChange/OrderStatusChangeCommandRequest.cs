using Eshop.Application.Bases;
using Eshop.Domain.Enums;
using MediatR;

namespace Eshop.Application.Features.Orders.Commands.OrderStatusChange
{
    public class OrderStatusChangeCommandRequest : IRequest<ResponseDto<OrderStatusChangeCommandResponse>>
    {
        public int OrderId { get; }
        public int OrderItemId { get; }
        public OrderStateEnum OrderStateEnum { get; }
        public OrderStatusChangeCommandRequest(int orderId, int orderItemId, OrderStateEnum orderStateEnum)
        {
            this.OrderId = orderId;
            this.OrderItemId = orderItemId;
            this.OrderStateEnum = orderStateEnum;
        }
    }
}
