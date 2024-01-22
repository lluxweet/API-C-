using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class RazreshenieController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.razreshenie.ToList();
            return Ok(list);
        }

        [HttpGet("{idRazreshenie}")]
        public IActionResult GetById(int idRazreshenie)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.razreshenie.FirstOrDefault(x => x.idRazreshenie == idRazreshenie);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(RazreshenieEntity razreshenieEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.razreshenie.Add(razreshenieEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(RazreshenieEntity razreshenieEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.razreshenie.Update(razreshenieEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idRazreshenie}")]
        public IActionResult Delete(int idRazreshenie)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.razreshenie.FirstOrDefault(x => x.idRazreshenie == idRazreshenie);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.razreshenie.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
