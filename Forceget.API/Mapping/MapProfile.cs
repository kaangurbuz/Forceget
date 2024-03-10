using AutoMapper;
using Forceget.API.DTOs;
using Forceget.Core.Models;

namespace Forceget.API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Offer, OfferCreateDTO>();
            CreateMap<OfferCreateDTO, Offer>();            
        }
    }
}
