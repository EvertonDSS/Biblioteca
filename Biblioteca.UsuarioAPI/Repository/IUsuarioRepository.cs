using Biblioteca.UsuarioAPI.Data.ValueObjects;

namespace Biblioteca.UsuarioAPI.Repository
{
    public interface IUsuarioRepository
    {
        Task<UsuarioVO> GetUsuario(long id);
        Task<UsuarioVO> AddUsuario(UsuarioVO vo);
    }
}
