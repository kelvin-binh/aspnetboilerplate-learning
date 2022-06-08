using Abp.Application.Services;
using Abp.Application.Services.Dto;
using eSchool.UseCases.Branches.Dto;
using System;

namespace eSchool.UseCases.Branches
{
    public interface IBranchAppService : IAsyncCrudAppService<BranchDto, Guid, PagedAndSortedResultRequestDto, CreateBranchDto, UpdateBranchDto>
    {
    }
}