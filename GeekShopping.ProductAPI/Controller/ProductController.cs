using GeekShopping.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Repository;
using GeekShopping.ProductAPI.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controller
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVo>>> FindAll()
        {
            var products = await _repository.FindAll();
            return Ok(products);
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<ProductVo>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product == null) return NotFound("Produto não encontrado!");
            return Ok(product);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<ProductVo>> CreateProduct(ProductVo prod)
        {
            if (prod == null) return BadRequest("Dados inválidos");
            var product = await _repository.Create(prod);

            return Ok(product);
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<ProductVo>> UpdateProduct(ProductVo prodPut)
        {
            if (prodPut == null) return BadRequest("Dados inválidos");
            var productUp = await _repository.Update(prodPut);

            return Ok(productUp);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = Role.Admin)]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return NotFound("Erro ao deletar Produto!");

            if (status == true) return Ok($"Produto número {id} deletado com sucesso!");

            return Ok(status);
        }
    }
}