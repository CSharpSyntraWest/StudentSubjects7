using Entities.Configurations;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API om mappings te definiëren tussen de model classes en de Database-tabellen
            modelBuilder.Entity<Student>().Property(s => s.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Subject>().Property(s => s.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<StudentSubject>().HasKey(sc => new { sc.StudentId, sc.SubjectId });//samengestelde PK in tabel StudentSubject

            modelBuilder.Entity<StudentSubject>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(sc => sc.StudentSubjects)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<StudentSubject>()
                .HasOne<Subject>(sc => sc.Subject)
                .WithMany(sc => sc.StudentSubjects)
                .HasForeignKey(sc => sc.SubjectId);


            modelBuilder.Entity<Course>().Property(s => s.Id).HasDefaultValueSql("NEWID()");


            modelBuilder.Entity<CourseSubject>().HasKey(sc => new { sc.CourseId, sc.SubjectId });//samengestelde PK in tabel CourseSubject

            modelBuilder.Entity<CourseSubject>()
                .HasOne<Course>(sc => sc.Course)
                .WithMany(sc => sc.CourseSubjects)
                .HasForeignKey(sc => sc.CourseId);

            modelBuilder.Entity<CourseSubject>()
                .HasOne<Subject>(sc => sc.Subject)
                .WithMany(sc => sc.CourseSubjects)
                .HasForeignKey(sc => sc.SubjectId);

            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new StudentSubjectConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new CourseSubjectConfiguration());
        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<StudentSubject> StudentSubject { get; set; }

        public DbSet<Course> Course { get; set; }
        public DbSet<CourseSubject> CourseSubject { get; set; }

    }
}
