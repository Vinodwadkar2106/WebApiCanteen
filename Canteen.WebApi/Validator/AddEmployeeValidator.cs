using Canteen.WebApi.Messages.v1;
using Canteen.WebApi.Services.Interface;
using Canteen.WebApi.Validator.Interface;
using Canteen.WebApi.Validator.Messages;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace Canteen.WebApi.Validator
{
    public class AddEmployeeValidator : AbstractValidator<AddEmployee>//, Interface.IValidator<AddEmployee>
    {
        public AddEmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotNull().WithMessage(CommonValues.employeeNameError);
            RuleFor(x => x.EmailId).EmailAddress();
            RuleFor(x => x.EmployeeCode).NotNull().WithMessage("Employee Code should not be blank");
            RuleFor(x => x.DeptId).NotNull().WithMessage("Employee Dept Id should not be blank");
        }

        //public Task<ValidationResult> Interface.IValidator<AddEmployee>.validateAsync();
       
    }
}
