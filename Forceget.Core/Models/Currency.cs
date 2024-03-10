namespace Forceget.Core.Models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
