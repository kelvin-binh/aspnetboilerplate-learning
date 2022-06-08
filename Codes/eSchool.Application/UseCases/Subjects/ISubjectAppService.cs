using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CmsCore.Subjects.Dto;
using System;

namespace eSchool.UseCases.Subjects
{
    public interface ISubjectAppService : IAsyncCrudAppService<SubjectDto, Guid, PagedAndSortedResultRequestDto, CreateSubjectDto, UpdateSubjectDto>
    {
    }
}
