using System;
using System.Collections.Generic;

namespace KLDFishStall.Model.Models
{
    public partial class FishAttributes
    {
        public long Id { get; set; }
        public string OtherNames { get; set; }
        public string Description { get; set; }
        public double? NetWeight { get; set; }
        public double? GrossWeight { get; set; }
        public string Units { get; set; }

        public Fish Fish { get; set; }
    }
}
