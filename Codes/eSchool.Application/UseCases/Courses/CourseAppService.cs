using Abp.Authorization;

namespace eSchool.UseCases.Courses
{
    [AbpAuthorize]
    public class CourseAppService : eSchoolAppServiceBase, ICourseAppService
    {
    }
}
