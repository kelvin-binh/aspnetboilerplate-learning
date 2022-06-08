using Abp.Application.Services;
using Abp.Application.Services.Dto;
using eSchool.UseCases.Teachers.Dto;
using System;

namespace eSchool.UseCases.Teachers
{
    public interface ITeacherAppService : IAsyncCrudAppService<TeacherDto, Guid, PagedAndSortedResultRequestDto, CreateTeacherDto, UpdateTeacherDto>
    {
    }
}