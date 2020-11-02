using System.Threading;
using System.Threading.Tasks;

namespace Tienda.Soporte.SharedKernel.Core
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}