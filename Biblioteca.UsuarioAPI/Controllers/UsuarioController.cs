using Biblioteca.UsuarioAPI.Data.ValueObjects;
using Biblioteca.UsuarioAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.UsuarioAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _repository;


        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioVO>> FindById(long id)
        {
            var usuario = await _repository.GetUsuario(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioVO>> AddUser([FromBody] UsuarioVO vo)
        {
            if (vo == null) return BadRequest();
            var usuario = await _repository.AddUsuario(vo);
            return Ok(usuario);
        }

    }
}
