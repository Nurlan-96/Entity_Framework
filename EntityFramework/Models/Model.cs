using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public class Model:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public int BrandId { get; set; }
        Brand Brand { get; set; }
        List<Car> Cars { get; set; }
    }
}
