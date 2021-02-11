using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(
              new Course
              {
                  Id = Constants.CourseFrontEndDev,
                  Name = "Front-end Developer",
                  Description = "front-end Javascript and css",
                  NumerOfLessons = 850,
                  StartDate = new DateTime(2021, 4, 1)
              },
              new Course
              {
                  Id = Constants.CourseNetDeveloper,
                  Name = "DotNet Developer",
                  Description = "Backend .Net Developer in C#",
                  NumerOfLessons = 985,
                  StartDate = new DateTime(2021, 10, 1)
              });
        }
    }
}
