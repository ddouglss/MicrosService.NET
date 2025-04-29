using AutoMapper;
using GeekShopping.CartAPI.Model.Entity;

namespace GeekShopping.CarrtAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                //config.CreateMap<ProductVo, Product>();
               // config.CreateMap<Product, ProductVo>();
            });
            return mappingConfig;
        }

    }
}
