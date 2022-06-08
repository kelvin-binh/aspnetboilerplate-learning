using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using eSchool.Entities;
using eSchool.UseCases.Students.Dto;
using System;

namespace eSchool.UseCases.Students
{
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, Guid, PagedAndSortedResultRequestDto, CreateStudentDto, UpdateStudentDto>, IStudentAppService
    {
        public StudentAppService(IRepository<Student, Guid> repository)
            : base(repository)
        {
        }
    }
}
