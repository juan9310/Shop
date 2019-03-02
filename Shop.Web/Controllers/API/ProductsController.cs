
namespace Shop.Web.Controllers.API
{
    using Data;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[Controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]


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
            return Ok(this.productsRepository.GetAllWithUsers());
        }
    }
}
