using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using eSchool.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace eSchool.UseCases.Teachers.Dto
{
    [AutoMapTo(typeof(Teacher))]
    public class CreateTeacherDto
    {
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

        public int Sex { get; set; }
    }
}