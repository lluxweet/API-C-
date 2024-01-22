using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class UserController : ControllerBase
    {     
        [HttpGet()]

        public IActionResult GetAll()
        {        
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.user.ToList();
            return Ok(list);
        }

        [HttpGet("{idUser}")]
        public IActionResult GetById(int idUser) 
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.user.FirstOrDefault(x => x.idUser == idUser);
            return Ok(list);
        }

        [HttpPost()]
        public IActionResult Create(UserEntity taskEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.user.Add(taskEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpPut()]
        public IActionResult Update(UserEntity taskEntity)
        {
            using ApplicationContext _context = new ApplicationContext();
            var list = _context.user.Update(taskEntity).Entity;
            _context.SaveChanges();
            return Ok(list);
        }

        [HttpDelete("{idUser}")]
        public IActionResult Delete(int idUser) 
        {
            using ApplicationContext _context = new ApplicationContext();
            var item = _context.user.FirstOrDefault(x => x.idUser == idUser);
            if (item == null)
            {
                return NotFound();
            }
            var list = _context.user.Remove(item).Entity;
            _context.SaveChanges();
            return Ok(list);
        }
       
    }
}
