using System.Collections.Generic;

namespace MerchandiseService.HttpModels
{
    public class MerchPack
    {
        public IEnumerable<MerchItem> MerchItems { get; set; }
    }
}