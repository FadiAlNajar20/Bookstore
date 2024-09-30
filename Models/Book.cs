using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        [Range(0, 1000)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
    }
}
