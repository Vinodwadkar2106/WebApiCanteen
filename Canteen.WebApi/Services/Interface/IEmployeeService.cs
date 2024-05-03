using Canteen.WebApi.Messages.v1;

namespace Canteen.WebApi.Services.Interface
{
    public interface IEmployeeService
    {
      public Task<AddEmployeeReply> AddEmployee(AddEmployee employee);
    }
}
