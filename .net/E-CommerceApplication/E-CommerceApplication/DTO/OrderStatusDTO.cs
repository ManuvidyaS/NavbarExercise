using System.ComponentModel.DataAnnotations;

namespace E_CommerceApplication.DTO
{
    
        public class OrderStatusDTO
        {
            [Required]
            public int OrderId { get; set; }
            [Required]
            public string Status { get; set; }
        }
    
}
