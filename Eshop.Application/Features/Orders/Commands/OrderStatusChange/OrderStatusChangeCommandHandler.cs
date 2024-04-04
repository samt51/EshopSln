using Eshop.Application.Bases;
using Eshop.Application.Interfaces.AutoMapper;
using Eshop.Application.Interfaces.UnitOfWorks;
using Eshop.Domain.Entites;
using MediatR;

namespace Eshop.Application.Features.Orders.Commands.OrderStatusChange
{
    public class OrderStatusChangeCommandHandler : BaseHandler, IRequestHandler<OrderStatusChangeCommandRequest, ResponseDto<OrderStatusChangeCommandResponse>>
    {
        public OrderStatusChangeCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<OrderStatusChangeCommandResponse>> Handle(OrderStatusChangeCommandRequest request, CancellationToken cancellationToken)
        {
            var orderItem = await unitOfWork.GetReadRepository<OrderItem>().GetAsync(x => x.Id == request.OrderItemId && x.OrderId == request.OrderId && x.IsDeleted!);

            if (orderItem is null)
            {
                return new ResponseDto<OrderStatusChangeCommandResponse>().Fail(null, "Böyle bir siparişiniz bulunamamktadır", 400);
            }

            orderItem.OrderStateEnum = request.OrderStateEnum;

            var changeStatus = await unitOfWork.GetWriteRepository<OrderItem>().AddAsync(orderItem);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new ResponseDto<OrderStatusChangeCommandResponse>().Success();
            }
            return new ResponseDto<OrderStatusChangeCommandResponse>().Fail(null, "Bir Hata Oluştu", 400);
        }
    }
}
