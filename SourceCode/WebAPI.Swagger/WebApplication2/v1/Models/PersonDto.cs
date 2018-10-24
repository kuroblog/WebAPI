
namespace WebApplication2.v1.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// person
    /// </summary>
    public class PersonDto
    {
        /// <summary>
        /// name
        /// </summary>
        [Required, StringLength(255, MinimumLength = 3)]
        public string name { get; set; }

        /// <summary>
        /// age
        /// </summary>
        public int? age { get; set; }
    }

    /// <summary>
    /// person entity
    /// </summary>
    public class PersonEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [Required, StringLength(255, MinimumLength = 3)]
        public string Name { get; set; }

        /// <summary>
        /// age
        /// </summary>
        public int? Age { get; set; }
    }
}