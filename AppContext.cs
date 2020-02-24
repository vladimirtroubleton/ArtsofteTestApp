using ArtsofteTestApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtsofteTestApp
{
    public class AppContext : DbContext
    {
        public DbSet<StaffModel> Staffs { get; set; }
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<ProgrammingLanguageModel> ProgrammingLanguages { get; set; }

        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
