using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using eSchool.Authorization.Roles;
using eSchool.Authorization.Users;
using eSchool.MultiTenancy;
using eSchool.Entities;

namespace eSchool.EntityFrameworkCore
{
    public class eSchoolDbContext : AbpZeroDbContext<Tenant, Role, User, eSchoolDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchOfTeacher> BranchOfTeachers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseOfBranch> CourseOfBranches { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentOfCourse> StudentOfCourses { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectOfCourse> SubjectOfCourses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TearcherOfSubject> TearcherOfSubjects { get; set; }

        public eSchoolDbContext(DbContextOptions<eSchoolDbContext> options)
            : base(options)
        {
        }
    }
}
