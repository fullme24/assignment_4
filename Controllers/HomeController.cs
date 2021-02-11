/*
 * Name: True
 * The following is the brain of this operation. It helps to direct the data to the right places and to make sure it is correct
 */

using assignment_4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> TopRec = new List<string>();

            foreach(TopReccomendation tr in TopReccomendation.GetTopReccomendations())
            {
                //Here, in the videos, Prof. Hilton used the "??" to set a default. However, I just felt that in this case an if
                //statement feels better. Same end result
                if (tr.Favorite_Dish == null)
                {
                    tr.Favorite_Dish = "........ you cant pick just one thing! It's all tasty!";
                }

                if (tr.Website == null)
                {
                    tr.Website = "Coming Soon! Thus, no website means the link will not work!";
                }

                if (tr.Phone == null)
                {
                    tr.Phone = "Coming Soon";
                }

                TopRec.Add($"<strong>{tr.Restaurant_Name}</strong> is the #<strong>{tr.Rank}</strong> place to go for food! Its best item is {tr.Favorite_Dish}.<br /> Here is some more information:<br />Phone: {tr.Phone}.<br />Address: {tr.Address}.<br /><a href=\"{tr.Website}\" target=\"_blank\">Website: {tr.Website}</a>");
            }

            return View(TopRec);
        }

        [HttpGet]
        public IActionResult USP()
        {
            return View();
        }

        [HttpPost]
        public IActionResult USP(USPM US)
        {

            if (US.Name == null)
            {
                US.Name = "Unknown";
            }

            if (US.Restaurant_Name == null)
            {

                return View();
            }

            if ( US.Favorite_Dish == null)
            {

                US.Favorite_Dish = "........ you cant pick just one thing! It's all tasty!";
            }

            if (US.Phone == null)
            {
                US.Phone = "Coming Soon";
            }

            USM.AddUS(US);

            return View("US", USM.User_Suggestions);
        }

        public IActionResult US()
        {
            return View(USM.User_Suggestions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
