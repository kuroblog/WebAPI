
namespace WebApp.CallWebService.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TestRequestDto
    {
        [Required]
        public string code { get; set; }

        public dynamic data { get; set; }
    }
}
