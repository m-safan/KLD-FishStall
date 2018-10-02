using System;
using System.Collections.Generic;

namespace KLDFishStall.Model.Models
{
    public partial class OrderItem
    {
        public long Id { get; set; }
        public long FkIdOrder { get; set; }
        public long FkIdFish { get; set; }
        public double Quantity { get; set; }
        public double? MarketPrice { get; set; }
        public double OurPrice { get; set; }
        public double Total { get; set; }

        public Fish FkIdFishNavigation { get; set; }
        public Order FkIdOrderNavigation { get; set; }
    }
}
