using Forceget.Core.Models;
using Forceget.Core.Models.ResponseModels;

namespace Forceget.Core.IntRepository
{
    public interface IOfferRepository : IRepository<Offer>
    {
        Task<IEnumerable<OfferResponseModel>> GetAllOffersAsync();
        Task<ParametersResponseModel> GetParametersAsync();
    }
}
