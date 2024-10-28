using System.ComponentModel.DataAnnotations;

namespace ModelBinding_Day5.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
