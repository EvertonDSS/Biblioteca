using AutoMapper;
using Biblioteca.LivroAPI.Data.ValueObjects;
using Biblioteca.LivroAPI.Model;
using Biblioteca.LivroAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.LivroAPI.Repository
{
    public class LivroRepository : ILivroRepository
    {
        private readonly MySqlContext _context; //Instancia o contexto do BD
        private IMapper _mapper; //Instancia o mapper

        public LivroRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LivroVO>> FindAll()
        {
            List<Livro> livros = await _context.Livros.ToListAsync();
            return _mapper.Map<List<LivroVO>>(livros);
        }
        
        public async Task<LivroVO> FindById(long id)
        {
            Livro livro = await _context.Livros.FindAsync(id);
            return _mapper.Map<LivroVO>(livro);

        }

        public async Task<LivroVO> Create(LivroVO vo) //Criar um novo livro
        {
            Livro livro = _mapper.Map<Livro>(vo); //Mapear o livro do tipo livro(id, titulo, autor, etc...)
            _context.Livros.Add(livro); //Adicionar livro ao contexto
            await _context.SaveChangesAsync(); //Salvar as mudanças
            return _mapper.Map<LivroVO>(livro); //Retornar o resultado do mapeamento
        }     

        public async Task<LivroVO> Update(LivroVO vo) //Criar um novo livro
        {
            Livro livro = _mapper.Map<Livro>(vo); //Mapear o livro do tipo livro(id, titulo, autor, etc...)
            _context.Livros.Update(livro); //Adicionar livro ao contexto
            await _context.SaveChangesAsync(); //Salvar as mudanças
            return _mapper.Map<LivroVO>(livro); //Retornar o resultado do mapeamento
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Livro livro = await _context.Livros.FindAsync(id);
                if (livro == null) return false;
                _context.Livros.Remove(livro);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
