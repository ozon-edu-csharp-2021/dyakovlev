using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchandiseService.Domain.AggregationModels.Employee;
using MerchandiseService.Domain.AggregationModels.MerchPack;
using MerchandiseService.Domain.Events;
using MerchandiseService.Domain.Services;

namespace MerchandiseService.Infrastructure.Handlers
{
    public class EmployeeCanAcceptMerchPackEventHandler : INotificationHandler<EmployeeCanAcceptMerchPackEvent>
    {
        private readonly IRepository<Employee> _employeesRepo;

        public EmployeeCanAcceptMerchPackEventHandler(IRepository<Employee> employeesRepo)
        {
            _employeesRepo = employeesRepo;
        }
        
        public async Task Handle(EmployeeCanAcceptMerchPackEvent notification, CancellationToken cancellationToken)
        {
            notification.Employee.AcceptMerchPack(notification.MerchPack);
            await _employeesRepo.Add(notification.Employee, cancellationToken);
            await _employeesRepo.UnitOfWork.SaveChanges(cancellationToken);
        }
    }
}