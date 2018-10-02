using System;
using System.Collections.Generic;

namespace KLDFishStall.Model.Models
{
    public partial class FishImage
    {
        public long Id { get; set; }
        public long FkIdFish { get; set; }
        public string FilePath { get; set; }
        public bool IsPrimary { get; set; }
        public string Description { get; set; }

        public Fish FkIdFishNavigation { get; set; }
    }
}
