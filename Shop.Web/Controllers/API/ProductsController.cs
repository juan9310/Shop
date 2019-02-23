
namespace Shop.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using Shop.Web.Data;

    [Route("api/[Controller]")]

    public class ProductsController : Controller
    {
        private readonly IProductRepository productsRepository;

        public ProductsController(IProductRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.productsRepository.GetAll());
        }
    }
}
