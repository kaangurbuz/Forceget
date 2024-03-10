using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forceget.Core.Models
{
    public class Offer
    {
        public int Id { get; set; }
        public string Mode { get; set; }
        public string MovementType { get; set; }
        public string Incoterm { get; set; }
        public string Unit1 { get; set; }
        public int Unit1Quantity { get; set; }
        public string Unit2 { get; set; }
        public int Unit2Quantity { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public int PackageTypeId { get; set; }
        public virtual PackageType PackageType { get; set; }
    }
}
