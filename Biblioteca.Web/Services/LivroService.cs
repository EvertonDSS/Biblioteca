using Biblioteca.Web.Models;
using Biblioteca.Web.Services.IServices;
using Biblioteca.Web.Utils;

namespace Biblioteca.Web.Services
{
    public class LivroService : ILivroService
    {
        private readonly HttpClient _client;
        public const string BasePath = "api/v1/livro";

        public LivroService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }


        public async Task<IEnumerable<LivroModel>> FindAllLivros()
        {
            var response = await _client.GetAsync(BasePath);
            return await response.ReadContentAs<List<LivroModel>>();
        }
 
        public async Task<LivroModel> FindLivroById(int id)
        {
            var response = await _client.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<LivroModel>();
        }
        
        public async Task<LivroModel> CreateLivro(LivroModel model)
        {
            var response = await _client.PostAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<LivroModel>();
            }
            else throw new Exception("Algo errado ao chamar API");

        }

        public async Task<LivroModel> UpdateLivro(LivroModel model)
        {
            var response = await _client.PutAsJson(BasePath, model);
            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<LivroModel>();
            }
            else throw new Exception("Algo errado ao chamar API");

        }
        
        public async Task<bool> DeleteLivroById(int id)
        {
            var response = await _client.DeleteAsync($"{BasePath}/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<bool>();
            }
            else throw new Exception("Algo errado ao chamar API");

        }
    }
}
