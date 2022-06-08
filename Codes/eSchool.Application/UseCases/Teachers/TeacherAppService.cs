using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using eSchool.Entities;
using eSchool.UseCases.Teachers.Dto;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eSchool.UseCases.Teachers
{
    [AbpAuthorize]
    public class TeacherAppService : AsyncCrudAppService<Teacher, TeacherDto, Guid, PagedAndSortedResultRequestDto, CreateTeacherDto, UpdateTeacherDto>, ITeacherAppService
    {
        public TeacherAppService(IRepository<Teacher, Guid> repository)
            : base(repository)
        {
        }

        public override async Task<TeacherDto> CreateAsync(CreateTeacherDto input)
        {
            CheckCreatePermission();

            var entity = MapToEntity(input);

            await Repository.InsertAsync(entity);

            await CurrentUnitOfWork.SaveChangesAsync();

            return MapToEntityDto(entity);
        }
        public override async Task DeleteAsync(EntityDto<Guid> input)
        {
            CheckDeletePermission();

            var news = await Repository.GetAsync(input.Id);

            await Repository.DeleteAsync(news);

            CurrentUnitOfWork.SaveChanges();
        }
        public override async Task<TeacherDto> UpdateAsync(UpdateTeacherDto input)
        {
            CheckUpdatePermission();

            var entity = await GetEntityByIdAsync(input.Id);

            await CurrentUnitOfWork.SaveChangesAsync();

            return MapToEntityDto(entity);
        }
    }
}
