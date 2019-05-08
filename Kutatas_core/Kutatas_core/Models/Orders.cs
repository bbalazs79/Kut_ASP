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
        
        public int OrderedId { get; set; }

        public int OrderFoodCount { get; set; }

        public int OrderedFoodId { get; set; }

        public string OrdererFirstName { get; set; }

        public string OrdererLastName { get; set; }

        public string OrdererPhoneNumber { get; set; }

        public string OrdererAddress { get; set; }

        public string OrdererCity { get; set; }

        public int AllPrice { get; set; }
        public bool Performed { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PerformedDate { get; set; }
    }
}
