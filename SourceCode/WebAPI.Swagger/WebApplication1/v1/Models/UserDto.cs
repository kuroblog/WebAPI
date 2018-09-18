using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.v1.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// name
        /// </summary>
        [Required, StringLength(255, MinimumLength = 2)]
        public string name { get; set; }
    }
}