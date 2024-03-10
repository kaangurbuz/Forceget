namespace Forceget.Core.Models.ResponseModels
{
    public class OfferResponseModel
    {
        public int Id { get; set; }
        public string Mode { get; set; }
        public string MovementType { get; set; }
        public string Incoterm { get; set; }
        public string Unit1WithQuantity { get; set; }
        public string Unit2WithQuantity { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Currency { get; set; }
        public string PackageType { get; set; }
    }
}
