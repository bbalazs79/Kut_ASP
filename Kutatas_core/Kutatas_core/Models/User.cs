using System;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kutatas_core.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [MinLength(3)]
        [MaxLength(255)]
        [Required]
        public string UserName { get; set; }
        
        [MinLength(8)]
        [MaxLength(255)]
        [Required]
        public string Password { get; set; }
    }
}
