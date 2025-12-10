using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Range(1, 100000)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public string Category { get; set; }

        public string Shelf { get; set; }

        [Range(0, 1000)]
        public int Count { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

    }
}
