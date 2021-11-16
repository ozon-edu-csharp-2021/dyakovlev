using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchandiseService.Infrastructure.Commands;

namespace MerchandiseService.Infrastructure.Handlers
{
    public class EmployeeMerchHistoryRequestHandler : RequestHandler<EmployeeMerchHistoryRequest, EmployeeMerchHistoryResponse>
    {
        protected override EmployeeMerchHistoryResponse Handle(EmployeeMerchHistoryRequest request)
        {
            return new EmployeeMerchHistoryResponse
            {
                MerchPacks = request.Employee.MerchPacks
            };
        }
    }
}