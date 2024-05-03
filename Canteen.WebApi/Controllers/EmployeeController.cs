using Canteen.WebApi.Messages.v1;
using Canteen.WebApi.Services.Interface;
using Canteen.WebApi.Validator.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Canteen.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;
        private readonly IValidator<AddEmployee> _validatior;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeService employeeService, IValidator<AddEmployee> validator)
        {
            _logger = logger;
            this._employeeService = employeeService;
            _validatior = validator;
        }

        [HttpPost]
        public async Task<ActionResult<AddEmployeeReply>> CreateEmployee(AddEmployee employee)
        {
            try
            {
                if (employee == null)
                    return BadRequest();

                var validationResult = await _validatior.validateAsync();

                if (validationResult.ErrorMessage != null)
                {
                    
                }
                var createdEmployee = await _employeeService.AddEmployee(employee);

                return CreatedAtAction(nameof(AddEmployee),
                    new { id = createdEmployee.ErrorMessage }, createdEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

    }
}
