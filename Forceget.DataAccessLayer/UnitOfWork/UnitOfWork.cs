using Forceget.Core.IntRepository;
using Forceget.Core.IntUnitOfWork;
using Forceget.DataAccessLayer.Repository;

namespace Forceget.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ForcegetDBContext _context;
        private OfferRepository _offerRepository;

        public UnitOfWork(ForcegetDBContext context)
        {
            _context = context;
        }

        public IOfferRepository Offer => _offerRepository ?? new OfferRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Task CommitAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
