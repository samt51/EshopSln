using Eshop.Application.Bases;
using MediatR;

namespace Eshop.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<ResponseDto<CreateOrderCommandResponse>>
    {
    }
}
