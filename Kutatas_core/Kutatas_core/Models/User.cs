using System;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kutatas_core.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column("UserName")]
        public string UserName { get; set; }
        //[Column("Password")]
        public string Password { get; set; }
    }
}
