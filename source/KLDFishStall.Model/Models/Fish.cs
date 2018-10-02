using System;
using System.Collections.Generic;

namespace KLDFishStall.Model.Models
{
    public partial class Fish
    {
        public Fish()
        {
            FishCategory = new HashSet<FishCategory>();
            FishImage = new HashSet<FishImage>();
            OrderItem = new HashSet<OrderItem>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public double? MarketPrice { get; set; }
        public double OurPrice { get; set; }
        public long FkIdFishAttributes { get; set; }

        public FishAttributes FkIdFishAttributesNavigation { get; set; }
        public ICollection<FishCategory> FishCategory { get; set; }
        public ICollection<FishImage> FishImage { get; set; }
        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
