using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class PredprinimatelController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.predprinimatel.ToList();
            return Ok(list);
        }

        [HttpGet("{idPredprinimatel}")]
        public IActionResult GetById(int idPredprinimatel)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.predprinimatel.FirstOrDefault(x => x.idPredprinimatel == idPredprinimatel);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(PredprinimatelEntity predprinimatelEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.predprinimatel.Add(predprinimatelEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(PredprinimatelEntity predprinimatelEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.predprinimatel.Update(predprinimatelEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idPredprinimatel}")]
        public IActionResult Delete(int idPredprinimatel)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.predprinimatel.FirstOrDefault(x => x.idPredprinimatel == idPredprinimatel);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.predprinimatel.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
