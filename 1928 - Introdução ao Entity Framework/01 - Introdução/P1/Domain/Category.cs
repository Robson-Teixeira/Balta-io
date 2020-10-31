using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P1.Domain
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Title { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}