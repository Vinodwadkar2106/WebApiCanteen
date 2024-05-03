namespace Canteen.WebApi.Messages.v1.Models
{
    [Serializable]
    public class BaseReply
    {
        public  List<Error> ErrorMessage { get; set; }
    }
}
