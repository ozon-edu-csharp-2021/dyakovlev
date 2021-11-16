using MerchandiseService.Domain.AggregationModels.Employee;
using MerchandiseService.Domain.AggregationModels.MerchPack;

namespace MerchandiseService.Domain.Services
{
    public interface IMerchPackEmployeesQueue
    {
        void Enqueue(MerchPack merchPack, Employee employee);
        void DequeueEmployee(MerchPack merchPack);
    }
}