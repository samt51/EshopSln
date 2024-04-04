using Eshop.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var product = new Product(1, "Kısa Kol T-shirt", "Pamuk desenli", 2000, 1);
            var product1 = new Product(2, "SweatShirt", "Pamuk desenli", 3000, 1);

            builder.HasData(product, product1);
        }
    }
}
