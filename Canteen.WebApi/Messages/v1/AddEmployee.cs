using Canteen.WebApi.Messages.v1.Models;

namespace Canteen.WebApi.Messages.v1
{
    [Serializable]
    public class AddEmployee : BaseModel
    {
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public int DeptId { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public int StatusId { get; set; }
        public string CompanyCode { get; set; }
    }
}
