using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.DataService;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {

            ISO3166DataService ds = new ISO3166DataService(_configuration);
            List<ISO3166> list = new List<ISO3166>();
            try
            {
                string[] keys = {};
                list = await ds.GetModelsAsync(keys);
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            return Ok(list);
        }

        public IActionResult Privacy()
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
