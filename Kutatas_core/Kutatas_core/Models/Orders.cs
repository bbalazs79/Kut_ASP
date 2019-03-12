using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kutatas_core.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Food OrderedFood { get; set; }
        
        public int AllPrice { get; set; }
    }
}
