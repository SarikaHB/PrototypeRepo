using InstituteManagement.Domain.Logics;
using Microsoft.AspNetCore.Mvc;
using System;

namespace InstituteManagement.Api.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private IStudentServices _studentServices;

        public StudentApiController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAll()
        {
            try
            {
                var students = _studentServices.GetStudents();
                return Ok(students);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
       
        [HttpGet]
        [Route("get-byId")]
        public IActionResult GetById(int id)
        {
            try
            {
                var student = _studentServices.GetStudentById(id);
                return Ok(student);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}