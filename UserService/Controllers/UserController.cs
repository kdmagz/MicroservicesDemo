using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Model;

namespace UserService.Controllers
{
  
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRespository _repository;

        public UserController(IUserRespository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _repository.GetAllUsers();
            return Ok(data);
        }

        [HttpGet]
        [Route("api/[controller]/{Id}")]
        public IActionResult GetUserByID(int Id)
        {
            var data = _repository.GetUserById(Id);
            if(data==null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddUser([FromBody] User user)
        {
            var users = _repository.AddUser(user);
            return Created(HttpContext.Request.Scheme + "://" + 
                HttpContext.Request.Host + "/" + HttpContext.Request.Method + "/" + user.Id, users);

        }
    }
}
