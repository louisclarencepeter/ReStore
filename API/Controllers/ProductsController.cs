using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext Context;

        public ProductsController(StoreContext context)
        {
            this.Context = context;
        }

        [HttpGet]
        public ActionResult<List<ProductsController>> GetProducts()
        {
            var products = Context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Entities.Product> GetProduct(int id)
        {
            return Ok(Context.Products.Find(id));
        }
    }

}