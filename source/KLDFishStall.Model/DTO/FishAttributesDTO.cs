using KLDFishStall.Model.Models;

namespace KLDFishStall.Model.DTO
{
    public class FishAttributesDTO : FishAttributes, IDataTransferObject<FishAttributes>
    {
        public FishAttributesDTO() { }

        public FishAttributesDTO(FishAttributes item, IUnitOfWork unitOfWork = null)
        {
            Description = item.Description;
            GrossWeight = item.GrossWeight;
            Id = item.Id;
            NetWeight = item.NetWeight;
            OtherNames = item.OtherNames;

            GetInnerDetails(unitOfWork);
        }

        public void GetInnerDetails(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null) return;
        }

        public FishAttributes Map()
        {
            return new FishAttributes()
            {
                Description = Description,
                GrossWeight = GrossWeight,
                Id = Id,
                NetWeight = NetWeight,
                OtherNames = OtherNames
            };
        }
    }
}