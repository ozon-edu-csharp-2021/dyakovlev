using MerchandiseService.Domain.Models;

namespace MerchandiseService.Domain.AggregationModels.MerchPack
{
    public class MerchPack : Entity
    {
        public MerchPackType MerchPackType { get; }

        public MerchPack(MerchPackType merchPackType)
        {
            MerchPackType = merchPackType;
        }
    }
}