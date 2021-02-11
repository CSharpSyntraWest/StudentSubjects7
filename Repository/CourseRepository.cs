using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {

        public CourseRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {
            
        }

        public void CreateCourse(Course course)
        {
            Create(course);
        }

        public void DeleteCourse(Course course)
        {
            Delete(course);
        }

        public IEnumerable<Course> GetAllCourses(bool trackChanges)
        {
            return FindAll(trackChanges).OrderBy(s => s.Name).ToList();
        }

        public Course GetCourse(Guid courseId, bool trackChanges)
        {
            return FindByCondition(s => s.Id.Equals(courseId), trackChanges).SingleOrDefault();
        }
    }
}