using System.Collections.Generic;

namespace MerchandiseService.HttpModels
{
    public class EmployeeMerchHistoryResponse
    {
        public IEnumerable<MerchPack> MerchPacks { get; set; }
    }
}