using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_4.Models
{
    public class USPM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Restaurant_Name { get; set; }
        public string? Favorite_Dish { get; set; }
        [Phone]
        public string? Phone { get; set; }
    }
}
