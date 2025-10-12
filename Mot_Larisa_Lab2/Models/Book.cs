using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Mot_Larisa_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }

        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
