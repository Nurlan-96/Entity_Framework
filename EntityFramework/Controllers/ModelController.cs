using Microsoft.AspNetCore.Mvc;
using EntityFramework.Models;


namespace EntityFramework.Controllers
{
    public class ModelController : Controller
    {
        private List<Model> models;
        public ModelController()
        {
            models = new()
            {
                new () {Id = 1, Name ="S-Class", BrandId=1 },
                new () {Id = 2, Name ="GLA", BrandId = 1},
                new () {Id = 3, Name ="Malibu", BrandId = 2},
                new () {Id = 4, Name ="Camaro", BrandId = 2},
                new () {Id = 5, Name ="M3", BrandId = 3},
                new () {Id = 6, Name ="X5", BrandId = 3}
            };
        }
        public IActionResult Index(int? modelId)
        {
            if (modelId == null)
            {
                return View(models);
            }
            if (models.Exists(x => x.Id == modelId))
            {
                var data = models.FirstOrDefault(x => x.Id == modelId) 
                    ?? throw new Exception("Not found.");
                List<Model> modelList = new()
                {
                    data
                };
                return View(modelList);
            }
            return NotFound();
        }
    }
}
