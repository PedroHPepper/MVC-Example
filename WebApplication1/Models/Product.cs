using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Need product's name")]
        public string Name { get; set; }
        [Range(1, 1000, ErrorMessage ="Value out of range")]
        public int Quantity { get; set; }
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
