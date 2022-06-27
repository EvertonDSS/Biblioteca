using Biblioteca.LivroAPI.Data.ValueObjects;

namespace Biblioteca.LivroAPI.Repository
{
    public interface ILivroRepository
    {
        Task<IEnumerable<LivroVO>> FindAll(); //Task que tem como retorno um enumerador do tipo LivroVO na função FindAll
        Task<LivroVO> FindById(long id); //Task que tem como retorno um LivroVO e tem como entrada um id tipo long
        Task<LivroVO> Create(LivroVO vo); //Task que tem como entrada e saida um LivroVO
        Task<LivroVO> Update(LivroVO vo); //Task que tem como entrada e saida um LivroVO 
        Task<bool> Delete(long id); //Task que retorna um bool(true ou false) com uma entrada do id do tipo long
    }
}
