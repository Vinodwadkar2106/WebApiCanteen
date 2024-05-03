using Canteen.WebApi.Messages.v1;
using System.ComponentModel.DataAnnotations;

namespace Canteen.WebApi.Validator.Interface
{
    public interface IValidator<T>  
    {
        public Task<ValidationResult> validateAsync();
    }
}
