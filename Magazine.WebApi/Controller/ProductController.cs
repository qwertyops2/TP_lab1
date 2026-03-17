using Magazine.Core.Models;
using Magazine.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Magazine.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // POST: api/product
        [HttpPost]
        public IActionResult add([FromBody] Product product)
        {
            try
            {
                var result = _productService.add(product);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/product/{id}
        [HttpDelete("{id}")]
        public IActionResult remove(Guid id)
        {
            try
            {
                var result = _productService.remove(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // PUT: api/product
        [HttpPut]
        public IActionResult edit([FromBody] Product product)
        {
            try
            {
                var result = _productService.edit(product);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/product/{id}
        [HttpGet("{id}")]
        public IActionResult search(Guid id)
        {
            try
            {
                var result = _productService.search(id);

                if (result == null)
                    return NotFound($"Продукт с Id = {id} не найден");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}