using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class TypeoplataController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.typeoplata.ToList();
            return Ok(list);
        }

        [HttpGet("{idTypeOplata}")]
        public IActionResult GetById(int idTypeOplata)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.typeoplata.FirstOrDefault(x => x.idTypeOplata == idTypeOplata);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(TypeoplataEntity typeoplataEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.typeoplata.Add(typeoplataEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(TypeoplataEntity typeoplataEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.typeoplata.Update(typeoplataEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idTypeOplata}")]
        public IActionResult Delete(int idTypeOplata)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.typeoplata.FirstOrDefault(x => x.idTypeOplata == idTypeOplata);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.typeoplata.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
