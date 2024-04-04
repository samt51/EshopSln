using Eshop.Domain.Common;

namespace Eshop.Domain.Entites
{
    public class Product : BaseEntity
    {
        public Product(int id, string name, string description, decimal price, int categoryId)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.CategoryId = categoryId;
        }
        public Product()
        {

        }
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public int CategoryId { get; }
        public Category Categoria { get; set; }
    }
}
