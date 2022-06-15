
using AutoMapper;
using Biblioteca.LivroAPI.Data.ValueObjects;
using Biblioteca.LivroAPI.Model;

namespace Biblioteca.LivroAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<LivroVO, Livro>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
