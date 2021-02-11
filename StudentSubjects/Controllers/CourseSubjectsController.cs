using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSubjects.Controllers
{
    [Route("api/coursesubjects")]
    [ApiController]
    public class CourseSubjectsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public CourseSubjectsController(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet] // GET /api/coursesubjects
        public IActionResult GetCourseSubjects()
        {
            var courseSubjects = _repository.CourseSubject.GetAllCourseSubjects(false);
            return Ok(courseSubjects);
        }

    }
}
