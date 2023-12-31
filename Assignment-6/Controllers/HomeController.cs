using Assignment06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment06.Controllers
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
            return View();
        }
        public IActionResult ProductIndex()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    ProductName = "Mobile",
                    Price = 300000000
                },
                new Product
                {
                    ProductName = "Laptop",
                    Price = 550000000
                },
                new Product
                {
                    ProductName = "Tablet",
                    Price = 155000000
                }
            };

            return View(products);
        }

        public IActionResult OrderIndex()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    ProductName = "Mobile",
                    Price = 300000000
                },
                new Product
                {
                    ProductName = "Laptop",
                    Price = 550000000
                },
                new Product
                {
                    ProductName = "Tablet",
                    Price = 155000000
                }
            };

            Order order = new Order();
            order.Products = products;
            order.Total = products.Sum(p => p.Price);
            return View(order);
        }

    }
}
