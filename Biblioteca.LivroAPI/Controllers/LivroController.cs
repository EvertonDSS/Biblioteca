using Biblioteca.LivroAPI.Data.ValueObjects;
using Biblioteca.LivroAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.LivroAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LivroController : Controller
    {
        private ILivroRepository _repository;

        public LivroController(ILivroRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet] //Metodo HTTP utilizado
        public async Task<ActionResult<IEnumerable<LivroVO>>> FindAll()
        {
            var livros = await _repository.FindAll(); //Cria uma variavel que contem a instancia repository e utiliza a função FindAll
            return Ok(livros); //A função findall retorna o status Ok e o resultado da busca na anterior
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LivroVO>> FindById(long id)
        {
            var livro = await _repository.FindById(id);
            if(livro == null) return NotFound();
            return Ok(livro);
        }

        [HttpPost]
        public async Task<ActionResult<LivroVO>> Create([FromBody] LivroVO vo)
        {
            if (vo == null) return BadRequest(); //Se VO for null retorna erro de requisição
            var livro = await _repository.Create(vo); //Variavel que recebe a instancia de repository e utiliza a função de criar um novo LivroVO
            return Ok(livro); //Retorna status Ok e retorna o livro criado na linha anterior
        }
        [HttpPut]
        public async Task<ActionResult<LivroVO>> Update([FromBody] LivroVO vo)
        {
            if (vo == null) return BadRequest();
            var livro = await _repository.Update(vo);
            return Ok(livro);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}
