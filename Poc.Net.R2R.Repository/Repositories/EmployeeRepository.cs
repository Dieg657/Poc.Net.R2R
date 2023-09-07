using Dapper;
using Npgsql;
using Poc.Net.R2R.Domain.Entities;
using Poc.Net.R2R.Domain.Models;
using Poc.Net.R2R.Repository.Interfaces;
using Poc.Net.R2R.Repository.Queries;

namespace Poc.Net.R2R.Repository.Repositories
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        private readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            using var connection = new NpgsqlConnection(_connectionString);
            return await connection.QueryAsync<Employee>(EmployeeQueries.QueryAll) ?? new List<Employee>();
        }

        public async Task Insert(EmployeeDto model)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            await connection.ExecuteAsync(EmployeeQueries.InsertEmployee, model);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
