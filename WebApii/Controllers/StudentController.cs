using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace WebApii.Controllers
{
    [Route("[controller]")]
    
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                value: _studentService.GetAll()
                );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                value: _studentService.GetAll()
                );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Student Model)
        {
            return Ok(
                value: _studentService.Add(Model)
                );
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Student Model)
        {
            return Ok(
                value: _studentService.Add(Model)
                );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
              value: _studentService.Delete(id)
              );
        }
    }
}
