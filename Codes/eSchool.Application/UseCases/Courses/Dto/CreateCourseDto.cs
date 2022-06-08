using Abp.AutoMapper;
using eSchool.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace eSchool.UseCases.Courses.Dto
{
    [AutoMapTo(typeof(Course))]
    public class CreateCourseDto
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
