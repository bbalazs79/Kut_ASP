using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kutatas_core.Models
{
    public class Employee
    {
        [MinLength(3)]
        [MaxLength(255)]
        [Required]
        public string FirstName { get; set; }

        [MinLength(3)]
        [MaxLength(255)]
        [Required]
        public string LastName { get; set; }
        
        [Key]
        [MinLength(7)]
        [MaxLength(255)]
        [Required]
        public string Email { get; set; }

        [MinLength(8)]
        [MaxLength(255)]
        [Required]
        public string Password { get; set; }
    }
}
