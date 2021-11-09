using System.Threading;
using System.Threading.Tasks;

namespace MerchandiseService.Domain.Services
{
    public interface IUnitOfWork
    {
        Task SaveChanges(CancellationToken ct);
    }
}