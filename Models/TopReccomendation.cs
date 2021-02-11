using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_4.Models
{
    public class TopReccomendation
    {
        public TopReccomendation(int rank)
        {
            Rank = rank;
        }

        //Here I would like it noted that in the videos we do read only via a round about way with the contructor and passing peramitors to it. You can just stright up make an attibute "readonly," 
        //but then you can change it at all..... contructor or no. So I just stuck with the vidos
        [Required]
        public int Rank;
        [Required]
        public string Restaurant_Name { get; set; }
        public string? Favorite_Dish { get; set; }
        [Required]
        public string Address { get; set; }
        [Url]
        public string? Website { get; set; }
        [Phone]
        public string? Phone { get; set; }

        public static TopReccomendation[] GetTopReccomendations()
        {
            TopReccomendation r1 = new TopReccomendation(1)
            {
                Restaurant_Name = "Texas Roadhouse",
                Favorite_Dish = "Rolls",
                Address = "1265 S State St, Orem, UT 84097",
                Website = "https://www.texasroadhouse.com",
                Phone = "(801) 226-2742"
            };

            TopReccomendation r2 = new TopReccomendation(2)
            {
                Restaurant_Name = "Don Joaquin Street Tacos",
                Favorite_Dish = "Tacos al pastor",
                Address = "150 W 1230 N St, Provo, UT 84604",
                Website = "https://stdonjoaquin.com",
                Phone = "(801) 400-2894"
            };

            TopReccomendation r3 = new TopReccomendation(3)
            {
                Restaurant_Name = "Taco Bell",
                Favorite_Dish = "Baja Blast",
                Address = "433 900 E, Provo, UT 84606",
                Website = "https://locations.tacobell.com",
                Phone = "(801) 343-3594"
            };

            TopReccomendation r4 = new TopReccomendation(4)
            {
                Restaurant_Name = "McDank",
                Favorite_Dish = "Nuggets",
                Address = "1225 S University Ave, Provo, UT 84601",
                Website = "https://www.mcdonalds.com",
                Phone = "(801) 373-0370"
            };

            TopReccomendation r5 = new TopReccomendation(5)
            {
                Restaurant_Name = "Little Caesars Pizza",
                Favorite_Dish = "Hot 'N Ready",
                Address = "434 900 E, Provo, UT 84606",
                Website = "https://littlecaesars.com",
                Phone = "(801) 374-2315"
            };

            return new TopReccomendation[] {r1, r2, r3, r4, r5};
        }
    }
}
