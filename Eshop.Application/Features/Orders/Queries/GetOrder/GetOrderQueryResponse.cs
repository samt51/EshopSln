using Eshop.Application.Dtos.OrderItemDto.Response;

namespace Eshop.Application.Features.Orders.Queries.GetOrder
{
    public class GetOrderQueryResponse
    {
        public string OrderStateEnum { get; set; }
        public IList<OrderItemResponseDto> orderItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
