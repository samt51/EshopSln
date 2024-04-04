using Eshop.Application.Bases;
using Eshop.Application.Interfaces.AutoMapper;
using Eshop.Application.Interfaces.UnitOfWorks;
using MediatR;

namespace Eshop.Application.Features.Orders.Commands.CreateOrder
{
    internal class CreateOrderCommandHandler : BaseHandler, IRequestHandler<CreateOrderCommandRequest, ResponseDto<CreateOrderCommandResponse>>
    {
        public CreateOrderCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public Task<ResponseDto<CreateOrderCommandResponse>> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
