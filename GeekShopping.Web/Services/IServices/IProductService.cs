using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> FindAllProducts(string token); //setando 
        Task<ProductViewModel> FindProductById(long id, string token);//setando 

        Task<ProductViewModel> CreateProduct( ProductViewModel model, string token);//setando 

        Task<ProductViewModel> UpdateProduct( ProductViewModel model, string token);//setando 

        Task<bool> DeleteProductById(long id, string token);//setando 


    }
}
