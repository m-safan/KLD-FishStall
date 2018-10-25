using KLDFishStall.Model;
using KLDFishStall.Model.DTO;
using KLDFishStall.Service.Contracts;
using System;
using System.Linq;

namespace KLDFishStall.Service
{
    public class FishService : IFishService
    {
        private IUnitOfWork _unitOfWork;

        public FishService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public FishDTO AddFish(FishDTO fish)
        {
            if (_unitOfWork.Fish.GetAllQueryable().Any(x => x.Name.Equals(fish.Name, StringComparison.InvariantCultureIgnoreCase)))
                throw new Exception($"Fish with name: {fish.Name} already exists");

            fish.FkIdFishAttributesNavigation = fish.FishAttributes.Map();
            var fishToReturn = _unitOfWork.Fish.Insert(fish.Map());

            _unitOfWork.Commit();

            return new FishDTO(fishToReturn, _unitOfWork);
        }
    }
}
