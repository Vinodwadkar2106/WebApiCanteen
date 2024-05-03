using Canteen.WebApi.Controllers;
using Canteen.WebApi.Messages.v1;
using Canteen.WebApi.Services.Interface;

namespace Canteen.WebApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ILogger<EmployeeService> _logger;
        public EmployeeService(ILogger<EmployeeService> logger) 
        {
            _logger = logger;
        }
        public Task<AddEmployeeReply> AddEmployee(AddEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}
