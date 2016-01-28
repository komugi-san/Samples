using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.EntityModels;

namespace WebApplication1.Models.Repositories
{

    public class WebApplication1DbContext : DbContext
    {

        public WebApplication1DbContext(DbContextOptions<WebApplication1DbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<DepartmentEntityModel> Departments { get; set; }

        public virtual DbSet<EmployeeEntityModel> Employees { get; set; }

        public virtual DbSet<ExpenseEntityModel> Expenses { get; set; }

        public virtual DbSet<JobTitleEntityModel> JobTitles { get; set; }

        public virtual DbSet<PeriodEntityModel> Periods { get; set; }

    }

}
