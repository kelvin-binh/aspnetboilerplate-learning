using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using eSchool.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace CmsCore.Subjects.Dto
{
    [AutoMap(typeof(Subject))]
    public class SubjectDto : EntityDto<Guid>
    {
        [Required]
        [StringLength(250)]
        public string Code { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}
