using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kutatas_core.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }

        public string Description { get; set; }

        public int Count { get; set; }

        public byte[] Image { get; set; }

        public Food(int id, string name, int price, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }
        public Food()
        {}
    }
}
