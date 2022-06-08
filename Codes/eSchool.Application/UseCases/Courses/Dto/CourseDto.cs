
using Abp.AutoMapper;
using Abp.Domain.Entities;
using eSchool.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace eSchool.UseCases.Courses.Dto
{
    [AutoMapFrom(typeof(Course))]
    public class CourseDto : Entity<Guid>
    {
        [Required]
        [StringLength(250)]
        public string Code { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public Guid? TeacherId { get; set; }
    }
}
