using Poc.Net.R2R.Application.Interfaces.Services;
using Poc.Net.R2R.Domain.Entities;
using Poc.Net.R2R.Domain.Models;
using Poc.Net.R2R.Repository.Interfaces;

namespace Poc.Net.R2R.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        public readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Employee>> GetAll() 
            => await _repository.GetAll();

        public async Task Insert(EmployeeDto model) 
            => await _repository.Insert(model);
    }
}
