using AutoMapper;
using Biblioteca.UsuarioAPI.Data.ValueObjects;
using Biblioteca.UsuarioAPI.Model;
using Biblioteca.UsuarioAPI.Model.Context;

namespace Biblioteca.UsuarioAPI.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly MySqlContext _context; //Instancia o contexto do BD
        private IMapper _mapper; //Instancia o mapper

        public UsuarioRepository(MySqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UsuarioVO> AddUsuario(UsuarioVO vo)
        {
            Usuario usuario = _mapper.Map<Usuario>(vo);
            _context.Usuario.Add(usuario);
            await _context.SaveChangesAsync();
            return _mapper.Map<UsuarioVO>(usuario);
        }

        public async Task<UsuarioVO> GetUsuario(long id)
        {
            Usuario usuario = await _context.Usuario.FindAsync(id);
            return _mapper.Map<UsuarioVO>(usuario);
        }
    }
}
