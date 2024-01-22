using LinqToDB;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class CategoriaController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.categoria.ToList();
            return Ok(list);
        }

        [HttpGet("{idCategoria}")]
        public IActionResult GetById(int idCategoria)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.categoria.FirstOrDefault(x => x.idCategoria == idCategoria);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(CategoriaEntity categoriaEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.categoria.Add(categoriaEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(CategoriaEntity categoriaEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.categoria.Update(categoriaEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idCategoria}")]
        public IActionResult Delete(int idCategoria)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.categoria.FirstOrDefault(x => x.idCategoria == idCategoria);
            if (item == null)
            {
                return NotFound(); 
            }
            var list = _context.categoria.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
