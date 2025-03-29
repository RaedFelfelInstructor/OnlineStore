using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using System.Diagnostics;

namespace OnlineStore.Controllers
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
            var cards = new List<HomeCard>
            {
                new HomeCard
                {
                    Title = "New Arrivals",
                    Description = "Check out our latest products.",
                    ActionName = "Products",
                    ControllerName = "Home",
                    ButtonText = "View Products"
                },
                new HomeCard
                {
                    Title = "Special Offers",
                    Description = "Explore our current deals and discounts.",
                    ActionName = "Offers",
                    ControllerName = "Home",
                    ButtonText = "View Offers"
                },
                new HomeCard
                {
                    Title = "Categories",
                    Description = "Browse products by categories",
                    ActionName = "Categories",
                    ControllerName = "Home",
                    ButtonText = "View Categories"
                },
                new HomeCard
                {
                    Title = "Customer Reviews",
                    Description = "See what our customers are saying.",
                    ActionName = "Reviews",
                    ControllerName = "Home",
                    ButtonText = "Read Reviews"
                }
            };
            return View(cards);
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult Categories()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
