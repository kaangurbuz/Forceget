using Forceget.Core.IntRepository;
using Forceget.Core.IntService;
using Forceget.Core.IntUnitOfWork;
using Forceget.Core.Models;
using Forceget.Core.Models.ResponseModels;

namespace Forceget.Services.Services
{
    public class OfferService : Service<Offer>, IOfferService
    {
        private readonly IRepository<Offer> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public OfferService(IUnitOfWork unitOfWork, IRepository<Offer> repository) : base(unitOfWork, repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<IEnumerable<OfferResponseModel>> GetAllOffersAsync()
        {
            return await _unitOfWork.Offer.GetAllOffersAsync();
        }

        public async Task<ParametersResponseModel> GetParametersAsync()
        {
            return await _unitOfWork.Offer.GetParametersAsync();
        }
    }
}
