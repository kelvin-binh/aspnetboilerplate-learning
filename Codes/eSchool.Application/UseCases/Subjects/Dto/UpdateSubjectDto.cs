using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using eSchool.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace CmsCore.Subjects.Dto
{
    [AutoMapFrom(typeof(Subject))]
    public class UpdateSubjectDto : EntityDto<Guid>
    {
        [Required]
        [StringLength(250)]
        public string Code { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}
