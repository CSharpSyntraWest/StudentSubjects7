using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSubjects.Controllers
{
    [Route("api/courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public CoursesController(IRepositoryManager repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult GetCourses()           
        {
            var courses = _repository.Course.GetAllCourses(false);//query is sneller wanneer trackchanges af staat
            return Ok(courses); //status OK = code 200       
        }
        [HttpGet("{id}")]
        public IActionResult GetCourse(Guid id)
        {
            var course = _repository.Course.GetCourse(id, false);
            if (course == null)
            {
                return NotFound(); //HTTP Response met status code 404 -- not found 
            }
            return Ok(course); //HTTP Response met status code 200 --OK
        }
    }
}
