using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeService.Model;

namespace EmployeeService.Controllers
{

    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var data = _repository.GetAllEmployee();
            return Ok(data);
        }

        [HttpGet]
        [Route("api/[controller]/{Id}")]
        public IActionResult Get(int Id)
        {
            var data = _repository.GetEmployeeById(Id);
            if (data == null)
                return NotFound();

            return Ok(data);
        }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post([FromBody]Employee employee)
        {
            var data = _repository.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + "/" + HttpContext.Request.Method + "/" + employee.Id, data);
        }
    }
}
