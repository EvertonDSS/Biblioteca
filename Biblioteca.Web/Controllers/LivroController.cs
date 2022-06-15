using Biblioteca.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Web.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroService _livroService;

        public IActionResult Index()
        {
            return View();
        }
    }
}
