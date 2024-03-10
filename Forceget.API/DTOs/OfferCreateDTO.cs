namespace Forceget.API.DTOs
{
    public class OfferCreateDTO
    {
        public string Mode { get; set; }
        public string MovementType { get; set; }
        public string Incoterm { get; set; }
        public string Unit1 { get; set; }
        public int Unit1Quantity { get; set; }
        public string Unit2 { get; set; }
        public int Unit2Quantity { get; set; }
        public int CityId { get; set; }
        public int CurrencyId { get; set; }
        public int PackageTypeId { get; set; }
    }
}
