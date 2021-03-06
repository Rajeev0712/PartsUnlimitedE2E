﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//This is for testing azure .22/12/2020 - 9.01 AM changes do again...succes..trying to chagne from github
namespace PartsUnlimited.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}
