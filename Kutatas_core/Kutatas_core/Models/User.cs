using System;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kutatas_core.Models
{
    public class User
    {      
        [MinLength(3)]
        [MaxLength(255)]
        [Required]
        public string FirstName { get; set; }

        [MinLength(3)]
        [MaxLength(255)]
        [Required]
        public string LastName { get; set; }

        [MinLength(11)]
        [MaxLength(11)]
        [Required]
        public string PhoneNumber { get; set; }
        
        [Key]
        [MinLength(7)]
        [MaxLength(255)]
        [Required]
        public string Email { get; set; }
        
        [MinLength(8)]
        [MaxLength(255)]
        [Required]
        public string Password { get; set; }
        
        [Required]
        public string City { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
