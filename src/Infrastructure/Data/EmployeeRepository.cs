using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;

namespace AspNetCoreMVCWebAppCRUD.Infrastructure.Data
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeContext employeeContext):base(employeeContext)
        {

        }
    }
}
