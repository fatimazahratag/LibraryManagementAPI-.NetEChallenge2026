using System.ComponentModel.DataAnnotations;

namespace LibraryManagementAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required, MinLength(2)]
        public string Title { get; set; }

        [Required, MinLength(2)]
        public string Author { get; set; }

        [Required]
        public string ISBN { get; set; }

        public int CopiesAvailable { get; set; }

        [Range(0.01, 1000)]
        public double Price { get; set; }

        [Required]
        public int PublicationYear { get; set; }  
    }
}
