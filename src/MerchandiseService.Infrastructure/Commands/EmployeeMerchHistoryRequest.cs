using MediatR;
using MerchandiseService.Domain.AggregationModels.Employee;
using MerchandiseService.Domain.AggregationModels.MerchPack;

namespace MerchandiseService.Infrastructure.Commands
{
    public class EmployeeMerchHistoryRequest : IRequest<EmployeeMerchHistoryResponse>
    {
        public Employee Employee { get; init; }
    }
}