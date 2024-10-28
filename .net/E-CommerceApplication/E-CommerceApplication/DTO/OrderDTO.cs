using System.ComponentModel.DataAnnotations;

namespace E_CommerceApplication.DTO
{
    public class OrderDTO
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public List<OrderItemDetailsDTO> Items { get; set; }
    }
}
