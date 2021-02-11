using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CourseSubjectRepository : RepositoryBase<CourseSubject> ,ICourseSubjectRepository
    {
        
        public CourseSubjectRepository(RepositoryContext repositoryContext):base(repositoryContext)
        {
          
        }

        public void CreateCourseSubject(CourseSubject courseSubject)
        {
            Create(courseSubject);
        }

        public void DeleteCourseSubject(CourseSubject courseSubject)
        {
            Delete(courseSubject);
        }

        public IEnumerable<CourseSubject> GetAllCourseSubjects(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public IEnumerable<CourseSubject> GetCoursesBySubjectId(Guid subjectId, bool trackChanges)
        {
            return FindByCondition(s => s.SubjectId.Equals(subjectId), trackChanges).ToList();
        }

        public CourseSubject GetCourseSubject(CourseSubject courseSubject, bool trackChanges)
        {
            return FindByCondition(s => s.SubjectId.Equals(courseSubject.SubjectId) 
            && s.CourseId.Equals(courseSubject.CourseId), trackChanges).SingleOrDefault();
        }

        public IEnumerable<CourseSubject> GetSubjectsByCourseId(Guid courseId, bool trackChanges)
        {
            return FindByCondition(s => s.CourseId.Equals(courseId), trackChanges);
        }
    }
}