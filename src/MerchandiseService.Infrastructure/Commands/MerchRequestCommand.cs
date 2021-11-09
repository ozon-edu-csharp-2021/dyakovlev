using MediatR;
using MerchandiseService.Domain.AggregationModels.Employee;
using MerchandiseService.Domain.AggregationModels.MerchPack;

namespace MerchandiseService.Infrastructure.Commands
{
    public class MerchRequestCommand : IRequest
    {
        public MerchPack RequestedPack { get; init; }
        public Employee Employee { get; init; }
    }
}