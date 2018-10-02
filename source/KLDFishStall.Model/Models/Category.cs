using System;
using System.Collections.Generic;

namespace KLDFishStall.Model.Models
{
    public partial class Category
    {
        public Category()
        {
            FishCategory = new HashSet<FishCategory>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<FishCategory> FishCategory { get; set; }
    }
}
