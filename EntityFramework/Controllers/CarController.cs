using Microsoft.AspNetCore.Mvc;
using EntityFramework.Models;

namespace EntityFramework.Controllers
{
    public class CarController : Controller
    {
        private List<Car> cars;
        public CarController()
        {
            cars = new()
            {
                new () {Id = 1, Name ="Car1", ModelId = 1},
                new () {Id = 2, Name ="Car2", ModelId = 2},
                new () {Id = 3, Name ="Car3", ModelId = 3},
                new () {Id = 4, Name ="Car4", ModelId = 4},
                new () {Id = 5, Name ="Car5", ModelId = 5},
                new () {Id = 6, Name ="Car6", ModelId = 6}
            };
        }
        public IActionResult Index(int? modelId)
        {
            if (modelId == null)
            {
                return View(cars);
            }
            if (cars.Exists(x => x.ModelId == modelId))
            {
                return View(cars.Find(x => x.ModelId == modelId));
            }
            return NotFound();
        }
    }
}
