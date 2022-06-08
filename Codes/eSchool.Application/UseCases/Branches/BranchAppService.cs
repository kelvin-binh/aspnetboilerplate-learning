using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using eSchool.UseCases.Branches.Dto;
using eSchool.Entities;
using System;
using System.Threading.Tasks;
using System.Linq;
using Abp.Linq.Extensions;

namespace eSchool.UseCases.Branches
{
    [AbpAuthorize]
    public class BranchAppService : AsyncCrudAppService<Branch, BranchDto, Guid, PagedAndSortedResultRequestDto, CreateBranchDto, UpdateBranchDto>, 
        IBranchAppService
    {

        public BranchAppService(IRepository<Branch, Guid> repository)
            : base(repository)
        {
        }

        protected override IQueryable<Branch> CreateFilteredQuery(PagedAndSortedResultRequestDto input)
        {
            var query = Repository.GetAll()
                .WhereIf(!string.IsNullOrEmpty(input.Sorting), x => x.Name.ToLower().Contains(input.Sorting.ToLower()));
            return query;
        }

        public override async Task<BranchDto> CreateAsync(CreateBranchDto input)
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
        public override async Task<BranchDto> UpdateAsync(UpdateBranchDto input)
        {
            CheckUpdatePermission();

            var entity = await GetEntityByIdAsync(input.Id);

            await CurrentUnitOfWork.SaveChangesAsync();

            return MapToEntityDto(entity);
        }
    }

}
