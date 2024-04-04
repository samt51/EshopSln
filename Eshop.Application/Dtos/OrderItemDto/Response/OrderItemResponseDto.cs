using Eshop.Application.Dtos.ProductDto.Response;
using Eshop.Domain.Entites;
using Eshop.Domain.Enums;

namespace Eshop.Application.Dtos.OrderItemDto.Response
{
    public class OrderItemResponseDto
    {
        public int Id { get; set; }
        public ProductResponseDto Product { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public OrderStateEnum OrderStateEnum { get; set; }
    }
}
