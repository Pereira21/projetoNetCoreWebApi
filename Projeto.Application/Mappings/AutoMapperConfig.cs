using AutoMapper;

namespace Projeto.Application.Mappings
{
    public class AutoMapperConfig
    {
        public static void Register()
        {
            Mapper.Initialize(
                cfg => 
                {
                    cfg.AddProfile<EntityToViewModel>();
                    cfg.AddProfile<ViewModelToEntity>();
                });
        }
    }
}
