using System.ComponentModel.DataAnnotations;

namespace ADKE.Data.Models
{
    public class Category :BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string Name_EN { get; set; }
        public string Name_AR { get; set; }
     }
}
