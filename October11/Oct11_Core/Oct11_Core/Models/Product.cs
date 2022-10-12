using System.ComponentModel.DataAnnotations;

namespace Oct11_Core.Models
{
    public class Product
    {
        [Required()]
        public int ProductId { get; set; }
        [MaxLength(20, ErrorMessage = "Name cannot be greater than 10 characters")]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 character")]
        public string ProductName { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ManufacturedDate { get; set; }
    }
}
