using System;
using System.Collections.Generic;
using MerchandiseService.Domain.AggregationModels.Employee;
using MerchandiseService.Domain.AggregationModels.MerchPack;
using Xunit;

namespace MerchandiseService.Domain.Tests
{
    public class EmployeeEntityTest
    {
        [Fact]
        public void AcceptMerchPack_ShouldAddMerchPack_WhenEmployeeHasNotMerchPack()
        {
            var employee = new Employee(new HashSet<MerchPack>());
            var newMerchPack = new MerchPack(MerchPackType.StarterPack);

            employee.AcceptMerchPack(newMerchPack);
            
            Assert.True(employee.HasMerchPack(newMerchPack));
        }
        
        [Fact]
        public void AcceptMerchPack_ShouldThrowException_WhenEmployeeHasMerchPack()
        {
            var employee = new Employee(new HashSet<MerchPack>
            {
                new(MerchPackType.StarterPack)
            });
            var newMerchPack = new MerchPack(MerchPackType.StarterPack);

            Assert.Throws<EmployeeAlreadyHasMerchException>(() => employee.AcceptMerchPack(newMerchPack));
        }
    }
}