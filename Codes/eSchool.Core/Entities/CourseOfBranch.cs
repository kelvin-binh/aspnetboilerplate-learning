using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eSchool.Entities
{
    [Table("CourseOfBranch")]
    public class CourseOfBranch : Entity<Guid>
    {
        public CourseOfBranch()
        {
        }

        public Guid BranchId { get; set; }

        public Guid CourseId { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Course Course { get; set; }
    }
}
