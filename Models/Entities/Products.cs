using System.ComponentModel.DataAnnotations;

namespace technova_ecommerce_shop.Models.Entities
{
    public class Products
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Range(1, 10000)]
        public decimal Price { get; set; }

        [Required, StringLength(300)]
        public string Description { get; set; }
    }
}
