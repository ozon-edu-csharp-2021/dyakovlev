using System.Collections.Generic;
using MerchandiseService.Domain.AggregationModels.Employee;
using MerchandiseService.Domain.AggregationModels.MerchPack;

namespace MerchandiseService.Domain.Services
{
    public class MerchPackEmployeesQueue : IMerchPackEmployeesQueue
    {
        private Dictionary<MerchPack, Queue<Employee>> _employeesQueue = new();
        
        public void Enqueue(MerchPack merchPack, Employee employee)
        {
            if (!_employeesQueue.ContainsKey(merchPack))
            {
                _employeesQueue[merchPack] = new Queue<Employee>();
            }
            _employeesQueue[merchPack].Enqueue(employee);
        }

        public void DequeueEmployee(MerchPack merchPack)
        {
            var employee = _employeesQueue[merchPack].Dequeue();
            employee.AcceptMerchPack(merchPack);
        }
    }
}