using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using LinqToDB;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class ProdajaController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.prodaja.ToList();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.prodaja.FirstOrDefault(x => x.id == id);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(ProdajaEntity prodaja)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.prodaja.Add(prodaja).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(ProdajaEntity prodaja)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.prodaja.Update(prodaja).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.prodaja.FirstOrDefault(x => x.id == id);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.prodaja.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
