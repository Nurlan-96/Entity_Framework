using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public class Brand:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        List<Model> models;
    }
}
