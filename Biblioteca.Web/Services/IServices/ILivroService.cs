using Biblioteca.Web.Models;

namespace Biblioteca.Web.Services.IServices
{
    public interface ILivroService 
    {
        Task<IEnumerable<LivroModel>> FindAllLivros();
        Task<LivroModel> LivroCreate(LivroModel model);
    }
}
