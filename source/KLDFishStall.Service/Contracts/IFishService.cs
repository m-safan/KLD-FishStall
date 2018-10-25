using KLDFishStall.Model.DTO;

namespace KLDFishStall.Service.Contracts
{
    public interface IFishService
    {
        FishDTO AddFish(FishDTO fish);
    }
}
