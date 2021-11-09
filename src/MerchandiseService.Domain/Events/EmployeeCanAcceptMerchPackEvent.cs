using MediatR;
using MerchandiseService.Domain.AggregationModels.Employee;
using MerchandiseService.Domain.AggregationModels.MerchPack;

namespace MerchandiseService.Domain.Events
{
    public class EmployeeCanAcceptMerchPackEvent : INotification
    {
        public MerchPack MerchPack { get; init; }
        public Employee Employee { get; init; }
    }
}