using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Webshop.Data;
using Webshop.Models;

namespace ASPNetCore_Modeldata_Webshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebshopContext _webshopContext;

        public HomeController(ILogger<HomeController> logger, WebshopContext webshopContext)
        {
            _logger = logger;
            _webshopContext = webshopContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Producten(Categorie? categorie)
        {
            if (categorie == null)
            {
                return View();
            }

            var productenFiltered = _webshopContext.Products.Where(p => p.Categorie == categorie)
                                                            .OrderBy(p => p.Naam);

            ProductenViewModel viewModel = new()
            {
                Categorie = categorie.Value,
                Producten = await productenFiltered.ToListAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Bestelling(ProductenViewModel productenViewModel)
        {
            var bestelling = new List<Product>();
            var besteldeProducten = productenViewModel.Producten.Where(p => p.Aantal > 0);
            decimal totaal = 0;

            // lijst van bestelde producten uit db halen
            foreach (var product in besteldeProducten)
            {
                Product? temp = await _webshopContext.Products.FindAsync(product.Id);
                if (temp == null)
                {
                    return BadRequest("Product list contains invalid product id(s).");
                }
                temp.Aantal = product.Aantal;
                bestelling.Add(temp);
                totaal += temp.Aantal * temp.Prijs;
            }

            // geen producten besteld, terugsturen naar de productenpagina
            if (!bestelling.Any())
            {
                return RedirectToAction(nameof(Producten), new { categorie = productenViewModel.Categorie });
            }

            ViewBag.Totaal = totaal;
            return View(bestelling);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Bestel(IEnumerable<Product> producten)
        {
            var bestelling = new List<Product>();
            foreach (var product in producten)
            {
                Product? temp = await _webshopContext.Products.FindAsync(product.Id);
                if (temp == null)
                {
                    return BadRequest("Product list contains invalid product id(s).");
                }
                temp.Aantal = product.Aantal;
                bestelling.Add(temp);
            }
            await MailHelper.SendMail("order@nerdcore.be", "Bestelling", string.Join(Environment.NewLine, bestelling), "wim.hambrouck@ehb.be");
            return View();
        }

        public IActionResult Openingsuren()
        {
            ViewBag.Open = IsWinkelOpen();

            return View();
        }

        private static bool IsWinkelOpen()
        {
            DateTime nu = DateTime.Now;
            bool open = false;

            if (nu.DayOfWeek != DayOfWeek.Sunday)
            {
                if (nu.DayOfWeek != DayOfWeek.Saturday)
                {
                    if (nu.Hour >= 8 && nu.Hour < 20)
                    {
                        open = true;
                    }
                }
                else if (nu.Hour >= 10 && nu.Hour < 22)
                {
                    open = true;
                }
            }
            return open;
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(string? email, string? naam, string? inhoud)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(naam) || string.IsNullOrWhiteSpace(inhoud))
            {
                ViewBag.Error = "Gelieve alle veldjes in te vullen!";
            }
            else
            {
                MailHelper.SendMail(email, naam, inhoud, "wim.hambrouck@ehb.be");
                ViewBag.Message = "Bericht verzonden!";
            }

            return View();
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