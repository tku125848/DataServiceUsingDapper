using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.DataService;
using WebApplication2.DbContexts;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly TpContext _context;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration, TpContext context)
        {
            _logger = logger;
            _configuration = configuration;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ISO3166DataServiceDP ds = new ISO3166DataServiceDP(_configuration);
            List<ISO3166> list = new List<ISO3166>();
            try
            {
                string[] keys = { };
                list = await ds.GetListAsync(keys);
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            return Ok(list);
        }

        public async Task<IActionResult> IndexC()
        {
            ISO3166DataServiceEF ds = new ISO3166DataServiceEF(_context);
            List<ISO3166> list = new List<ISO3166>();
            try
            {
                string[] keys = { };
                list = await ds.GetListAsync(keys);
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
