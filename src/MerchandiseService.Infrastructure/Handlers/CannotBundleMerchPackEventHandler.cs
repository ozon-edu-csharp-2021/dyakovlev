using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchandiseService.Domain.Events;
using MerchandiseService.Domain.Services;

namespace MerchandiseService.Infrastructure.Handlers
{
    public class CannotBundleMerchPackEventHandler : NotificationHandler<CannotBundleMerchPackEvent>
    {
        private IMerchPackEmployeesQueue _employeesQueue;

        public CannotBundleMerchPackEventHandler(IMerchPackEmployeesQueue employeesQueue)
        {
            _employeesQueue = employeesQueue;
        }
        
        protected override void Handle(CannotBundleMerchPackEvent notification)
        {
            _employeesQueue.Enqueue(notification.MerchPack, notification.Employee);
        }
    }
}