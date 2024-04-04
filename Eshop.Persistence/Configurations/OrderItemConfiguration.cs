using Eshop.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Persistence.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            var orderItem = new OrderItem(1, 1, 1, 2, 2000, Domain.Enums.OrderStateEnum.Pending);

            var orderItem2 = new OrderItem(1, 2, 2, 5, 15000, Domain.Enums.OrderStateEnum.Approved);

            builder.HasData(orderItem, orderItem2);
        }
    }
}
