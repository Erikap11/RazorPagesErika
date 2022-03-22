using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RazorPagesErika.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }  = string.Empty;

        [Display(Name = "Date Published")]
        [DataType(DataType.Date)]
        public DateTime DatePublished { get; set; }
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
