using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses(bool trackChanges);
        Course GetCourse(Guid courseId, bool trackChanges);
        void CreateCourse(Course subject);
        void DeleteCourse(Course subject);
    }
}
