using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sambalpuri.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
