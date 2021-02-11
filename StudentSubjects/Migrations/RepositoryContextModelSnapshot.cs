﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace StudentSubjects.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CourseId")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("NumerOfLessons")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00a18bcf-607e-4084-a49d-cd524769dbc9"),
                            Description = "front-end Javascript and css",
                            Name = "Front-end Developer",
                            NumerOfLessons = 850L,
                            StartDate = new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("3cc1e5c0-838d-4912-bc3d-f770eb669e1a"),
                            Description = "Backend .Net Developer in C#",
                            Name = "DotNet Developer",
                            NumerOfLessons = 985L,
                            StartDate = new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entities.Models.CourseSubject", b =>
                {
                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CourseId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("CourseSubject");

                    b.HasData(
                        new
                        {
                            CourseId = new Guid("00a18bcf-607e-4084-a49d-cd524769dbc9"),
                            SubjectId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a")
                        },
                        new
                        {
                            CourseId = new Guid("00a18bcf-607e-4084-a49d-cd524769dbc9"),
                            SubjectId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811")
                        },
                        new
                        {
                            CourseId = new Guid("3cc1e5c0-838d-4912-bc3d-f770eb669e1a"),
                            SubjectId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a")
                        },
                        new
                        {
                            CourseId = new Guid("3cc1e5c0-838d-4912-bc3d-f770eb669e1a"),
                            SubjectId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                        });
                });

            modelBuilder.Entity("Entities.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("StudentId")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            BirthDate = new DateTime(1947, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jos",
                            LastName = "De Klos"
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            BirthDate = new DateTime(1927, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Joke",
                            LastName = "De Klos"
                        },
                        new
                        {
                            Id = new Guid("a821b747-5a72-47f7-be34-c61f123eb44d"),
                            BirthDate = new DateTime(2001, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jan",
                            LastName = "Jansens"
                        });
                });

            modelBuilder.Entity("Entities.Models.StudentSubject", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubject");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            SubjectId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                        },
                        new
                        {
                            StudentId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            SubjectId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a")
                        },
                        new
                        {
                            StudentId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            SubjectId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                        },
                        new
                        {
                            StudentId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            SubjectId = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811")
                        });
                });

            modelBuilder.Entity("Entities.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SubjectId")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Subject");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                            Description = "Csharp programming language",
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                            Description = "Sql Server for beginners",
                            Name = "Database"
                        },
                        new
                        {
                            Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                            Description = "Web applications in ASP.NET Core",
                            Name = "Web apps"
                        });
                });

            modelBuilder.Entity("Entities.Models.CourseSubject", b =>
                {
                    b.HasOne("Entities.Models.Course", "Course")
                        .WithMany("CourseSubjects")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Subject", "Subject")
                        .WithMany("CourseSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Entities.Models.StudentSubject", b =>
                {
                    b.HasOne("Entities.Models.Student", "Student")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Subject", "Subject")
                        .WithMany("StudentSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("Entities.Models.Course", b =>
                {
                    b.Navigation("CourseSubjects");
                });

            modelBuilder.Entity("Entities.Models.Student", b =>
                {
                    b.Navigation("StudentSubjects");
                });

            modelBuilder.Entity("Entities.Models.Subject", b =>
                {
                    b.Navigation("CourseSubjects");

                    b.Navigation("StudentSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
