using System;
using System.Collections.Generic;

namespace KLDFishStall.Model.Models
{
    public partial class FishAttributes
    {
        public long Id { get; set; }
        public string OtherNames { get; set; }
        public string Description { get; set; }
        public string NetWeight { get; set; }
        public string GrossWeight { get; set; }

        public Fish Fish { get; set; }
    }
}
