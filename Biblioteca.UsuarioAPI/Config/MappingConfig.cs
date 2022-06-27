
using AutoMapper;
using Biblioteca.UsuarioAPI.Data.ValueObjects;
using Biblioteca.UsuarioAPI.Model;

namespace Biblioteca.UsuarioAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<UsuarioVO, Usuario>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
