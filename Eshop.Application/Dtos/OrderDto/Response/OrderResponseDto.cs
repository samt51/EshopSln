using Eshop.Application.Dtos.OrderItemDto.Response;

namespace Eshop.Application.Dtos.OrderDto.Response
{
    public class OrderResponseDto
    {
        public string OrderStateEnum { get; set; }
        public IList<OrderItemResponseDto> orderItems { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
