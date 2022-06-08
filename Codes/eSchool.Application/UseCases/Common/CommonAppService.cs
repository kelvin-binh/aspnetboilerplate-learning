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
    public class CommonAppService : eSchoolAppServiceBase, ICommonAppService
    {
        private IRepository<Course, Guid> repository;

        public CommonAppService(IRepository<Course, Guid> repository)
        {
            this.repository = repository;
        }

    }

}
