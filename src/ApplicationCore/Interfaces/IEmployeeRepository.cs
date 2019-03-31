using ApplicationCore.Entities;
using System.Linq;

namespace ApplicationCore.Interfaces
{
    public interface IEmployeeRepository : IAsyncRepository<Employee>
    {
        
    }
}
