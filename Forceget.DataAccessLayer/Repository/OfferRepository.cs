using Forceget.Core.IntRepository;
using Forceget.Core.Models;
using Forceget.Core.Models.DTOs;
using Forceget.Core.Models.ResponseModels;
using Microsoft.EntityFrameworkCore;

namespace Forceget.DataAccessLayer.Repository
{
    public class OfferRepository: Repository<Offer>, IOfferRepository
    {
        public ForcegetDBContext forcegetDBContext
        {
            get => _context as ForcegetDBContext;
        }
        public OfferRepository(ForcegetDBContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<OfferResponseModel>> GetAllOffersAsync()
        {
            var offers = await forcegetDBContext.Offers.Include(x => x.City).ThenInclude(city => city.Country).Include(x => x.Currency).Include(x => x.PackageType).ToListAsync();
            var response = new List<OfferResponseModel>();

            foreach (var offer in offers)
            {
                var offerDTO = new OfferResponseModel
                {
                    Id = offer.Id,
                    Mode = offer.Mode,
                    MovementType = offer.MovementType,
                    Incoterm = offer.Incoterm,
                    Unit1WithQuantity = $"{offer.Unit1Quantity} {offer.Unit1}",
                    Unit2WithQuantity = $"{offer.Unit2Quantity} {offer.Unit2}",
                    City = offer.City.Name,
                    Country = offer.City.Country.Name,
                    Currency = offer.Currency.ShortName,
                    PackageType = offer.PackageType.Name
                };
                response.Add(offerDTO);
            }

            return response;
        }

        public async Task<ParametersResponseModel> GetParametersAsync()
        {
            var response = new ParametersResponseModel();
            var cityResponse = new List<CityDTO>();
            var currencyReponse = new List<CurrencyDTO>();
            var packageTypeResponse = new List<PackageTypeDTO>();
            var cities = await forcegetDBContext.Cities.Include(city => city.Country).ToListAsync();
            var currencies = await forcegetDBContext.Currencies.ToListAsync();
            var packageTypes = await forcegetDBContext.PackageTypes.ToListAsync();
            foreach (var city in cities)
            {
                cityResponse.Add(new CityDTO
                {
                    Id = city.Id,
                    Name = city.Name,
                    Country = new CountryDTO
                    {
                        Id = city.Country.Id,
                        Name = city.Country.Name
                    }
                });
            }
            response.Cities = cityResponse;
            foreach (var currency in currencies)
            {
                currencyReponse.Add(new CurrencyDTO
                {
                    Id = currency.Id,
                    Name = currency.Name,
                    ShortName = currency.ShortName
                });
            }
            response.Currencies = currencyReponse;
            foreach (var packageType in packageTypes)
            {
                packageTypeResponse.Add(new PackageTypeDTO
                {
                    Id = packageType.Id,
                    Name = packageType.Name
                });
            }
            response.PackageTypes = packageTypeResponse;

            return response;

        }
    }
}
