using Forceget.Core.Models;
using Forceget.Core.Models.ResponseModels;

namespace Forceget.Core.IntService
{
    public interface IOfferService:IService<Offer>
    {
        Task<IEnumerable<OfferResponseModel>> GetAllOffersAsync();
        Task<ParametersResponseModel> GetParametersAsync();
    }
}
