using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "{1} is required")]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }
        public string  Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public String Description { get; set; }
    }
}