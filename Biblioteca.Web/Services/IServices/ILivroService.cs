using Biblioteca.Web.Models;

namespace Biblioteca.Web.Services.IServices
{
    public interface ILivroService 
    {
        Task<IEnumerable<LivroModel>> FindAllLivros();
        Task<LivroModel> FindLivroById(int id);
        Task<LivroModel> CreateLivro(LivroModel model);
        Task<LivroModel> UpdateLivro(LivroModel model);
        Task<bool> DeleteLivroById(int id);
    }
}
