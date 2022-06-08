using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eSchool.Entities
{
    [Table("Course")]
    public class Course : Entity<Guid>
    {
        public Course()
        {
        }

        [Required]
        [StringLength(250)]
        public string Code { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public Guid? TeacherId { get; set; }

        public virtual ICollection<CourseOfBranch> CourseOfBranches { get; set; }

        public virtual ICollection<StudentOfCourse> StudentOfCourses { get; set; }

        public virtual ICollection<SubjectOfCourse> SubjectOfCourses { get; set; }
    }
}
