using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class StatusoplataController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.statusoplata.ToList();
            return Ok(list);
        }

        [HttpGet("{idStatus}")]
        public IActionResult GetById(int idStatus)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.statusoplata.FirstOrDefault(x => x.idStatus == idStatus);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(StatusoplataEntity statusoplataEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.statusoplata.Add(statusoplataEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(StatusoplataEntity statusoplataEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.statusoplata.Update(statusoplataEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idStatus}")]
        public IActionResult Delete(int idStatus)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.statusoplata.FirstOrDefault(x => x.idStatus == idStatus);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.statusoplata.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
