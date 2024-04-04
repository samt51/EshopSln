using Eshop.Application.Bases;
using Eshop.Application.Dtos.OrderItemDto.Response;
using Eshop.Application.Interfaces.AutoMapper;
using Eshop.Application.Interfaces.UnitOfWorks;
using Eshop.Domain.Entites;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Application.Features.Orders.Queries.GetOrder
{
    public class GetOrderQueryHandler : BaseHandler, IRequestHandler<GetOrderQueryRequest, ResponseDto<IList<GetOrderQueryResponse>>>
    {
        public GetOrderQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetOrderQueryResponse>>> Handle(GetOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var orders = await unitOfWork.GetReadRepository<Order>().GetAllAsync(x => x.IsDeleted!, y => y.Include(x => x.orderItems));

            mapper.Map<IList<OrderItemResponseDto>, IList<OrderItem>>(orders.Select(x => x.orderItems).ToList());

            var orderMapping = mapper.Map<GetOrderQueryResponse, Order>(orders);


            return new ResponseDto<IList<GetOrderQueryResponse>>().Success(orderMapping);

        }
    }
}
