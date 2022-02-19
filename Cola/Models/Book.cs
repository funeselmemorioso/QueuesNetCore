using System.ComponentModel.DataAnnotations;

namespace Cola.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }       
    }
}
