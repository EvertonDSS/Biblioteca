using Biblioteca.Web.Models;
using Biblioteca.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Web.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService ?? throw new ArgumentNullException(nameof(livroService));
        }

        public async Task<ActionResult> LivroIndex()
        {
            var livros = await _livroService.FindAllLivros();
            return View(livros);
        }

        public async Task<IActionResult> LivroCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LivroCreate(LivroModel model)
        {
            if(ModelState.IsValid)
            {
                var response = await _livroService.CreateLivro(model);
                if (response != null) return RedirectToAction(nameof(LivroIndex));
            }
            return View(model);
        }
        
        public async Task<IActionResult> LivroUpdate(int id)
        {
            var model = await _livroService.FindLivroById(id);
            if(model != null) return View(model);
            return NotFound();
        }
        
        [HttpPut]
        public async Task<IActionResult> LivroUpdate(LivroModel model)
        {
            if(ModelState.IsValid)
            {
                var response = await _livroService.UpdateLivro(model);
                if (response != null) return RedirectToAction(nameof(LivroIndex));
            }
            return View(model);
        }
        
        public async Task<IActionResult> LivroDelete(int id)
        {
           var model = await _livroService.FindLivroById(id);
           if(model != null) return View(model);
           return NotFound();
        }
        
        [HttpDelete]
        public async Task<IActionResult> LivroDelete(LivroModel model)
        {
            var response = await _livroService.DeleteLivroById(model.Id);
            if (response) return RedirectToAction(nameof(LivroIndex));
            return View(model);
        }

    }

}
