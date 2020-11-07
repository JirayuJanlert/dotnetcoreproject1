using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using authproject.Models;
using Microsoft.AspNetCore.Authorization;
using authproject.Data;
using Microsoft.EntityFrameworkCore;

namespace authproject.Controllers
{
    [Authorize]

    // [Authorize(Roles = "user,admin")]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ProductDbContext Context { get; }
        public HomeController(ProductDbContext context, ILogger<HomeController> logger)
        {
            this.Context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Products()
        {
            List<Product> products = await Context.ProductsTb.ToListAsync();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Page1()
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
;