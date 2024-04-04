using Eshop.Application.Bases;
using MediatR;

namespace Eshop.Application.Features.Orders.Queries.GetOrder
{
    public class GetOrderQueryRequest : IRequest<ResponseDto<IList<GetOrderQueryResponse>>>
    {
        public GetOrderQueryRequest()
        {
            
        }
    }
}
