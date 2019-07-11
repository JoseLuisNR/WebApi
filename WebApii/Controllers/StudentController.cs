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
        ///<summary>
        /// Obtiene los valores de API
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                value: _studentService.GetAll()
                );
        }
        ///<summary>
        /// Obtiene los valores de api por ID
        /// </summary>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                value: _studentService.GetAll()
                );
        }
        ///<summary>
        /// POST api/values
        /// </summary>
        [HttpPost]
        public IActionResult Post([FromBody] Student Model)
        {
            return Ok(
                value: _studentService.Add(Model)
                );
        }
        ///<summary>
        /// PUT api/values/5
        /// </summary>
        [HttpPut]
        public IActionResult Put([FromBody] Student Model)
        {
            return Ok(
                value: _studentService.Add(Model)
                );
        }
        ///<summary>
        /// Borra valores de api por ID
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
              value: _studentService.Delete(id)
              );
        }
    }
}
