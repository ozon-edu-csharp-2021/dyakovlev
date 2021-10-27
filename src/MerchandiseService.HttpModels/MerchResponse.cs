using System.Collections.Generic;

namespace MerchandiseService.HttpModels
{
    public class MerchResponse
    {
        public IEnumerable<MerchItem> MerchItems { get; set; }
    }
}