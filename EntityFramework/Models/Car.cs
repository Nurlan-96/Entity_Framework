using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public class Car:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public int ModelId { get; set; }

        Model model { get; set; }
    }
}
