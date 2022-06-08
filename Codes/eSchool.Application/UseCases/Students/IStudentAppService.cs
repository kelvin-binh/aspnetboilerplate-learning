using Abp.Application.Services;
using Abp.Application.Services.Dto;
using eSchool.UseCases.Students.Dto;
using System;

namespace eSchool.UseCases.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, Guid, PagedAndSortedResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {
    }
}
