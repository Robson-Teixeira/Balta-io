using System.ComponentModel.DataAnnotations;

namespace P1.Domain
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Title { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}