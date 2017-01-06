namespace Kong.Master.Presentation.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Application.Services.Interfaces;

    public class HomeController : Controller
    {
        private readonly IAdminServices adminServices;

        public HomeController(IAdminServices adminServices)
        {
            this.adminServices = adminServices;
        }

        public async Task<IActionResult> Index()
        {
            var settings = await this.adminServices.GetServerOptionsAsync().ConfigureAwait(false);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
