using System.Collections.Generic;
using MerchandiseService.Domain.AggregationModels.MerchPack;
using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.Employee
{
    public class Employee : Entity
    {
        public IReadOnlyCollection<MerchPack.MerchPack> MerchPacks => _merchPacks;
        private HashSet<MerchPack.MerchPack> _merchPacks = new();

        public Employee(HashSet<MerchPack.MerchPack> merchPacks)
        {
            _merchPacks = merchPacks;
        }
        
        public bool HasMerchPack(MerchPack.MerchPack merchPack)
        {
            return _merchPacks.Contains(merchPack);
        }

        public void AcceptMerchPack(MerchPack.MerchPack merchPack)
        {
            if (HasMerchPack(merchPack))
            {
                throw new EmployeeAlreadyHasMerchException();
            }
            _merchPacks.Add(merchPack);
        }
    }
}