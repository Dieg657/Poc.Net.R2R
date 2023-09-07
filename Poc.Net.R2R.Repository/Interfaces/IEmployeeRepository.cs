using Poc.Net.R2R.Domain.Entities;
using Poc.Net.R2R.Domain.Models;

namespace Poc.Net.R2R.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();
        Task Insert(EmployeeDto model);
    }
}
