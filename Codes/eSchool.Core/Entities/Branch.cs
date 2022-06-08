using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eSchool.Entities
{
    [Table("Branch")]
    public class Branch : Entity<Guid>
    {
        public Branch()
        {
        }

        [Required]
        [StringLength(250)]
        public string Code { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }
        
        [StringLength(250)]
        public string Email { get; set; }

        public virtual ICollection<BranchOfTeacher> BranchOfTeachers { get; set; }

        public virtual ICollection<CourseOfBranch> CourseOfBranches { get; set; }
    }
}
