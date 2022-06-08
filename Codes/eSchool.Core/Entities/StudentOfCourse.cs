using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eSchool.Entities
{
    [Table("StudentOfCourse")]
    public class StudentOfCourse : Entity<Guid>
    {
        public StudentOfCourse()
        {
        }

        public Guid StudentId { get; set; }

        public Guid CourseId { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }
    }
}
