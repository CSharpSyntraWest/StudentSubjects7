using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Course
    {
        [Column("CourseId")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(60)]
        public string Description { get; set; }
        [DataType("date")]
        public DateTime StartDate { get; set; }
       
        public uint NumerOfLessons { get; set; }

        public ICollection<CourseSubject> CourseSubjects { get; set; }

    }
}
