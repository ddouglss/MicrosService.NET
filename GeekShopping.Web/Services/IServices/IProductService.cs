using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts(string token); //setando 
        Task<ProductModel> FindProductById(long id, string token);//setando 

        Task<ProductModel> CreateProduct( ProductModel model, string token);//setando 

        Task<ProductModel> UpdateProduct( ProductModel model, string token);//setando 

        Task<bool> DeleteProductById(long id, string token);//setando 


    }
}
