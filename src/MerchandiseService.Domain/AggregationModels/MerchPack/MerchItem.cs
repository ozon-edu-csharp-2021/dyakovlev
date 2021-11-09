using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.MerchPack
{
    public class MerchItem : Entity
    {
        public MerchItem(MerchItemType itemType)
        {
            ItemType = itemType;
        }

        public MerchItemType ItemType { get; }
    }
}