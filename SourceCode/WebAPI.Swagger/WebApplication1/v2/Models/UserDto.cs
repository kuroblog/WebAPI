using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.v2.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserDto : v1.Models.UserDto
    {
        /// <summary>
        /// sex
        /// </summary>
        public string sex { get; set; }
    }
}