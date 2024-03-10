using Forceget.Core.Models.DTOs;
using System.Collections;

namespace Forceget.Core.Models.ResponseModels
{
    public class ParametersResponseModel
    {
        public IEnumerable<CityDTO> Cities { get; set; }
        public IEnumerable<CurrencyDTO> Currencies { get; set; }
        public IEnumerable<PackageTypeDTO> PackageTypes { get; set; }
    }
}
