using Eshop.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Persistence.Configurations
{

    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            var order = new Order(1, Domain.Enums.OrderStateEnum.Pending);
            var order2 = new Order(2, Domain.Enums.OrderStateEnum.Approved);

            builder.HasData(order, order2);
        }
    }
}
