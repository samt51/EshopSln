using Eshop.Application.Dtos.CategoryDto.Response;

namespace Eshop.Application.Dtos.ProductDto.Response
{
    public class ProductResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CategoryResponseDto Categoria { get; set; }
    }
}
