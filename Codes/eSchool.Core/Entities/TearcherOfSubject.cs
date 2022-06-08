using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eSchool.Entities
{
    [Table("TearcherOfSubject")]
    public class TearcherOfSubject : Entity<Guid>
    {
        public TearcherOfSubject()
        {
        }

        public Guid TearcherId { get; set; }

        public Guid SubjectId { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
