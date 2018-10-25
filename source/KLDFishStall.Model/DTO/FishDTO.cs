using KLDFishStall.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KLDFishStall.Model.DTO
{
    public class FishDTO : Fish, IDataTransferObject<Fish>
    {
        public FishDTO() { }

        public FishDTO(Fish item, IUnitOfWork unitOfWork = null)
        {
            FishCategory = item.FishCategory;
            FishImage = item.FishImage;
            FkIdFishAttributes = item.FkIdFishAttributes;
            FkIdFishAttributesNavigation = item.FkIdFishAttributesNavigation;
            Id = item.Id;
            MarketPrice = item.MarketPrice;
            Name = item.Name;
            OrderItem = item.OrderItem;
            OurPrice = item.OurPrice;

            GetInnerDetails(unitOfWork);
        }

        public FishAttributesDTO FishAttributes { get; set; }

        public void GetInnerDetails(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null) return;

            FishAttributes = new FishAttributesDTO(unitOfWork.FishAttributes.Get(x => x.Id == FkIdFishAttributes));
        }

        public Fish Map()
        {
            return new Fish()
            {
                Id = Id,
                FkIdFishAttributes = FkIdFishAttributes,
                MarketPrice = MarketPrice,
                OurPrice = OurPrice,
                Name = Name,
                FkIdFishAttributesNavigation = FkIdFishAttributesNavigation
            };
        }
    }
}
