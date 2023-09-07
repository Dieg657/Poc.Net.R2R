using Poc.Net.R2R.Domain.Models;

namespace Poc.Net.R2R.Repository.Queries
{
    internal static class EmployeeQueries
    {
        public const string QueryAll = "SELECT * FROM Employees";
        public const string InsertEmployee = $@"INSERT INTO Employees (Role, Company, Location, Remote, Link, Salary, CreatedAt)
                                                VALUES (@{nameof(EmployeeDto.Role)}, 
                                                        @{nameof(EmployeeDto.Company)}, 
                                                        @{nameof(EmployeeDto.Location)}, 
                                                        @{nameof(EmployeeDto.Remote)}, 
                                                        @{nameof(EmployeeDto.Link)}, 
                                                        @{nameof(EmployeeDto.Salary)}, 
                                                        CURRENT_TIMESTAMP)";
    }
}
