using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface ICourseSubjectRepository
    {
        IEnumerable<CourseSubject> GetAllCourseSubjects(bool trackChanges);
        void CreateCourseSubject(CourseSubject courseSubject);
        void DeleteCourseSubject(CourseSubject courseSubject);
        IEnumerable<CourseSubject> GetSubjectsByCourseId(Guid courseId, bool trackChanges);
        IEnumerable<CourseSubject> GetCoursesBySubjectId(Guid subjectId, bool trackChanges);
        CourseSubject GetCourseSubject(CourseSubject courseSubject, bool trackChanges);
    }
}