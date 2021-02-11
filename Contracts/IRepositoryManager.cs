using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IStudentRepository Student { get; }
        ISubjectRepository Subject { get; }
        ICourseRepository Course { get; }
        IStudentSubjectRepository StudentSubject { get; }
        ICourseSubjectRepository CourseSubject { get; }
        void Save();
    }
}
