using eSchool.Controllers;
using eSchool.UseCases.Branches;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eSchool.Web.Controllers
{
    public class TestController : eSchoolControllerBase
    {
        private readonly IBranchAppService _branchAppService;

        public TestController(IBranchAppService branchAppService)
        {
            _branchAppService = branchAppService;
        }
        public async Task<IActionResult> Index()
        {
            await _branchAppService.GetAllAsync(new Abp.Application.Services.Dto.PagedAndSortedResultRequestDto());
            return View();
        }
    }
}
