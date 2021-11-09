using MerchandiseService.Domain.AggregationModels.MerchPack;

namespace MerchandiseService.Infrastructure.Commands
{
    public class ReserveMerchPackItemsCommand
    {
        public MerchPack PackToReserve { get; init; }
    }
}