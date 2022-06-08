using Abp.AutoMapper;
using eSchool.Entities;
using System.ComponentModel.DataAnnotations;

namespace CmsCore.Subjects.Dto
{
    [AutoMapTo(typeof(Subject))]
    public class CreateSubjectDto
    {
        [Required]
        [StringLength(250)]
        public string Code { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}
