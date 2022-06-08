using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eSchool.Entities
{
    [Table("BranchOfTeacher")]
    public class BranchOfTeacher : Entity<Guid>
    {
        public BranchOfTeacher()
        {
        }
        
        public Guid BranchId { get; set; }

        public Guid TeacherId { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
