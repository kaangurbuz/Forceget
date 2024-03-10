using AutoMapper;
using Forceget.API.DTOs;
using Forceget.Core.IntService;
using Forceget.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forceget.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private IOfferService _offerService;
        private IMapper _mapper;

        public OfferController(IOfferService offerService,IMapper mapper)
        {
            _offerService = offerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOffers()
        {
            var offers = await _offerService.GetAllOffersAsync();
            return Ok(offers);
        }

        [HttpGet("parameters")]
        public async Task<IActionResult> GetParatemers()
        {
            var parameters = await _offerService.GetParametersAsync();
            return Ok(parameters);
        }

        [HttpPost]
        public async Task<IActionResult> AddOffer(OfferCreateDTO offerCreateDTO)
        {
            var newOffer = await _offerService.AddAsync(_mapper.Map<Offer>(offerCreateDTO));
            return Created(string.Empty, offerCreateDTO);
        }
    }
}
