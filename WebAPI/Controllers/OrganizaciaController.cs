using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class OrganizaciaController : ControllerBase
    {
        [HttpGet()]

        public IActionResult GetAll()
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.organizacia.ToList();
            return Ok(list);
        }

        [HttpGet("{idOrganizacia}")]
        public IActionResult GetById(int idOrganizacia)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.organizacia.FirstOrDefault(x => x.idOrganizacia == idOrganizacia);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(OrganizaciaEntity organizaciaEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.organizacia.Add(organizaciaEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(OrganizaciaEntity organizaciaEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.organizacia.Update(organizaciaEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idOrganizacia}")]
        public IActionResult Delete(int idOrganizacia)
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.organizacia.FirstOrDefault(x => x.idOrganizacia == idOrganizacia);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.organizacia.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
    }
}
