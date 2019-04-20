using System;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Kutatas_core.Models
{
    public class User : IdentityUser
    {          
        [MinLength(3)]
        [MaxLength(255)]
        [Required]
        public string FirstName { get; set; }

        [MinLength(3)]
        [MaxLength(255)]
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string City { get; set; }

        [Required]
        public string Address { get; set; }      
    }
}
