﻿using System;
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
        public string FoodName { get; set; }
        [Required]
        public int Price { get; set; }

        public byte[] Image { get; set; }
    }
}