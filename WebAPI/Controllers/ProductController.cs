using LinqToDB;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.product.ToList();
            return Ok(list);
        }

        [HttpGet("{idProduct}")]
        public IActionResult GetById(int idProduct)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.product.FirstOrDefault(x => x.idProduct == idProduct);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(ProductEntity productEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.product.Add(productEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(ProductEntity productEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.product.Update(productEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idProduct}")]
        public IActionResult Delete(int idProduct)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.product.FirstOrDefault(x => x.idProduct == idProduct);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.product.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
