using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eSchool.Entities
{
    [Table("Subject")]
    public class Subject : Entity<Guid>
    {
        public Subject()
        {
        }

        [Required]
        [StringLength(250)]
        public string Code { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public virtual ICollection<TearcherOfSubject> TearcherOfSubjects { get; set; }

        public virtual ICollection<SubjectOfCourse> SubjectOfCourses { get; set; }
    }
}
