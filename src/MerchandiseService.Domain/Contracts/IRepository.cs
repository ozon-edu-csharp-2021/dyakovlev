using System.Threading;
using System.Threading.Tasks;

namespace MerchandiseService.Domain.Services
{
    public interface IRepository<T>
    {
        IUnitOfWork UnitOfWork { get; }
        Task Add(T entity, CancellationToken ct);
        Task Update(T entity, CancellationToken ct);
        Task<T> GetById(long id);
    }
}