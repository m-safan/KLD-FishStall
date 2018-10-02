using System;
using System.Collections.Generic;

namespace KLDFishStall.Model.Models
{
    public partial class FishCategory
    {
        public long Id { get; set; }
        public long FkIdFish { get; set; }
        public long FkIdCategory { get; set; }

        public Category FkIdCategoryNavigation { get; set; }
        public Fish FkIdFishNavigation { get; set; }
    }
}
