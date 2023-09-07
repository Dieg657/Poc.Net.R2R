using Poc.Net.R2R.Domain.Models;

namespace Poc.Net.R2R.Domain.Entities
{
    public class Employee : EmployeeDto
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeleteAt { get; set; }
    }
}
