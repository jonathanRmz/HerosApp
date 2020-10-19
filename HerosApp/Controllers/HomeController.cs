using HerosApp.Data;
using HerosApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace HerosApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Get the list of heros
        /// </summary>
        /// <returns></returns>
        public IActionResult GetList()
        {
            var list = _context.Heros.Include("RatingsHistorical").ToList();

            list.All(x => 
            {
                x.Rating = x.RatingsHistorical.Select(a => a.Rating).Average();
                return true;
            });

            return View(list.OrderByDescending(x => x.Rating));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
