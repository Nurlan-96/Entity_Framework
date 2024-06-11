using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    public class BrandController : Controller
    {
        private List<Brand> brands;
        public BrandController()
        {
            brands = new()
            {
                new () {Id = 1, Name ="Mercedes" },
                new () {Id = 2, Name ="Chevrolet"},
                new () {Id = 3, Name ="BMW"}
            };
        }
        public IActionResult Index(int? brandId)
        {
            if (brandId == null)
            {
                return View(brands);
            }
            if (brands.Exists(x => x.Id == brandId))
            {
                var data = brands.FirstOrDefault(x => x.Id == brandId) 
                    ?? throw new Exception("Not found.");
                List<Brand> brandList = new()
                {
                    data
                };
                return View(brandList);
            }
            return NotFound();
        }
    }
}
