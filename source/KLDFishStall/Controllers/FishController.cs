using KLDFishStall.Attributues;
using KLDFishStall.Model.DTO;
using KLDFishStall.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace KLDFishStall.Controllers
{
    [ExceptionHandler]
    public class FishController : Controller
    {
        private IFishService _fishService;

        public FishController(IFishService fishService)
        {
            _fishService = fishService;
        }

        [HttpPost]
        public FishDTO AddFish([FromBody]FishDTO fish)
        {
            return _fishService.AddFish(fish);
        }
    }
}
