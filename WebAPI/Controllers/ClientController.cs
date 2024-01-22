using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class ClientController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.client.ToList();
            return Ok(list);
        }

        [HttpGet("{idClient}")]
        public IActionResult GetById(int idClient)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.client.FirstOrDefault(x => x.idClient == idClient);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(ClientEntity clientEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.client.Add(clientEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(ClientEntity clientEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.client.Update(clientEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idClient}")]
        public IActionResult Delete(int idClient)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.client.FirstOrDefault(x => x.idClient == idClient);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.client.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

    }
}

