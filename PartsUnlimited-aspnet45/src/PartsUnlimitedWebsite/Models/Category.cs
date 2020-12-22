using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//This is for testing azure ...22/12/2020 - 8.55 AM changes
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