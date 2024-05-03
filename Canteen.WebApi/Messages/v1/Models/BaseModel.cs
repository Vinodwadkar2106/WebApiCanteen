namespace Canteen.WebApi.Messages.v1.Models
{
    [Serializable]
    public class BaseModel
    {
        public string LastUpatedBy { get; set; }
        public DateTime LastUpatedDateTime { get; set; }
    }
}
