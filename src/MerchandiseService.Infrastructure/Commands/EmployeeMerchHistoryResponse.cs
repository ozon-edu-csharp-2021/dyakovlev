using System.Collections.Generic;
using MerchandiseService.Domain.AggregationModels.MerchPack;

namespace MerchandiseService.Infrastructure.Commands
{
    public class EmployeeMerchHistoryResponse
    {
        public IEnumerable<MerchPack> MerchPacks { get; init; }
    }
}