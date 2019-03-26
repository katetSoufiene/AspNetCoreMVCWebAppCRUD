using AspNetCoreMVCWebAppCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMVCWebAppCRUD.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
