using System.ComponentModel.DataAnnotations;

namespace E_CommerceApplication.DTO
{
    public class OrderItemDetailsDTO
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
