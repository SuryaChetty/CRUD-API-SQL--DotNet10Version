using CRUD_Operations.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Operations.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;
        public UserController(UserContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            var user = _context.Users.ToList();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var users = _context.Users.Find(id);
            if(users == null)
            {
                return BadRequest("UserID Not Found");
            }
            return Ok(users);
        }
        [HttpPost]
        public IActionResult Create(UserInfo obj)
        {

            if(obj == null)
            {
                return NotFound("User Not FOund");
            }
            _context.Users.Add(obj);
            _context.SaveChanges();
            return Ok(obj);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id , UserInfo obj)
        {
            var existinguser = _context.Users.Find(id);
            if (existinguser == null)
            {
                return NotFound("User Not Found");
            }
            existinguser.FirstName = obj.FirstName;
            existinguser.LastName = obj.LastName;
            existinguser.Email = obj.Email;
            existinguser.Password = obj.Password;
            _context.SaveChanges();
            return Ok(existinguser);

        }
        [HttpDelete]
        public IActionResult  Delete(int id)
        {
            var user = _context.Users.Find(id);
            if(user == null)
            {
                return NotFound("User Not Found");
            }
            _context.Remove(user);
            _context.SaveChanges();
            return Ok(user);


        }
     

        

    }
}
