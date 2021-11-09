using System.Threading;
using System.Threading.Tasks;
using MerchandiseService.Domain.AggregationModels.MerchPack;

namespace MerchandiseService.Domain.Services
{
    public interface IMerchPackBundler
    {
        Task<bool> CanBundle(MerchPack merchPack, CancellationToken ct);
        Task ReserveMerchPackItems(MerchPack merchPack, CancellationToken ct);
    }
}