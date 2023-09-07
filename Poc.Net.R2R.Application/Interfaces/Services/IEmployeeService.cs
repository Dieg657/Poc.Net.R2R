using Poc.Net.R2R.Domain.Entities;
using Poc.Net.R2R.Domain.Models;

namespace Poc.Net.R2R.Application.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task Insert(EmployeeDto model);
    }
}
