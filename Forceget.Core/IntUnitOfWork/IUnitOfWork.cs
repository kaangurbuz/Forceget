using Forceget.Core.IntRepository;

namespace Forceget.Core.IntUnitOfWork
{
    public interface IUnitOfWork
    {
        IOfferRepository Offer { get; }
        Task CommitAsync();
        void Commit();
    }
}
