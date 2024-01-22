using LinqToDB;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class StatusController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.status.ToList();
            return Ok(list);
        }

        [HttpGet("{idstatus}")]
        public IActionResult GetById(int idstatus)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.status.FirstOrDefault(x => x.idstatus == idstatus);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(StatusEntity statusEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.status.Add(statusEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(StatusEntity statusEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.status.Update(statusEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idstatus}")]
        public IActionResult Delete(int idstatus)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.status.FirstOrDefault(x => x.idstatus == idstatus);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.status.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
