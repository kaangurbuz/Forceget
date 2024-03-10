namespace Forceget.Core.Models
{
    public class PackageType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
