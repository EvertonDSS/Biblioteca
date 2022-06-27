using Biblioteca.Web.Models;
using Biblioteca.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Biblioteca.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILivroService _livroService;

        public HomeController(ILogger<HomeController> logger,
            ILivroService livroService)
        {
            _logger = logger;
            _livroService = livroService;
        }

        public async Task<IActionResult> Index()
        {
            var livros = await _livroService.FindAllLivros();
            return View(livros);
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