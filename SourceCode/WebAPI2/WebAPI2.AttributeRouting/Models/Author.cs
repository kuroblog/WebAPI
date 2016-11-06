
namespace WebAPI2.AttributeRouting.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}