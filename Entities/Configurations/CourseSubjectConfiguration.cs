using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configurations
{
    public class CourseSubjectConfiguration : IEntityTypeConfiguration<CourseSubject>
    {
        public void Configure(EntityTypeBuilder<CourseSubject> builder)
        {
            builder.HasData(
                new CourseSubject
                {
                    CourseId = Constants.CourseFrontEndDev,
                    SubjectId = Constants.SubjectDatabase
                },

                new CourseSubject
                {
                    CourseId = Constants.CourseFrontEndDev,
                    SubjectId = Constants.SubjectWebapps
                },
                new CourseSubject
                {
                    CourseId = Constants.CourseNetDeveloper,
                    SubjectId = Constants.SubjectDatabase
                },

                new CourseSubject
                {
                    CourseId = Constants.CourseNetDeveloper,
                    SubjectId = Constants.SubjectCsharp
                }
                );
        }
    }
}
