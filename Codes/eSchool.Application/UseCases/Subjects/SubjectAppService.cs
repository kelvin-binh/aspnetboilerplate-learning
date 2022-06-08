using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using CmsCore.Subjects.Dto;
using eSchool.Entities;
using System;

namespace eSchool.UseCases.Subjects
{
    public class SubjectAppService : AsyncCrudAppService<Subject, SubjectDto, Guid, PagedAndSortedResultRequestDto, CreateSubjectDto, UpdateSubjectDto>, ISubjectAppService
    {
        public SubjectAppService(IRepository<Subject, Guid> repository)
            : base(repository)
        {
        }

    }
}
