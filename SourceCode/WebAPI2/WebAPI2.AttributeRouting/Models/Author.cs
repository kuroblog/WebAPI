
namespace WebAPI2.AttributeRouting.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}